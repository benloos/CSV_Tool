Imports System.Linq.Expressions
Imports System.Net

Public Class CSVTool
    ''' <summary>
    ''' Struktur:
    '''     GUI:
    '''         TAB CSV
    '''         - Datei laden mit csv
    '''         - CSV Viewer
    '''         - Spaltenauswahl (dropdown + inputfeld) 1 oder mehr
    '''         - Wenn ausgewählt, Datei wählen und CSV ändern
    '''         - CSV speichern
    '''         - Pop Up zur Bestätigung
    '''         
    '''         TAB Logs
    '''         - Logs Viewer
    '''             - CSV öffnen
    '''             - CSV überschreiben und speichern
    '''             - Fehler
    ''' </summary>
    ''' 
    Dim fh As FileHandler = New FileHandler()
    Dim log As Logger = New Logger()
    Dim originalFile As List(Of String()) = New List(Of String())

    Private Sub CSVTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvCSV.View = View.Details
        lvCSV.GridLines = True

        log.Log("Info", "CSV Tool geöffnet")
    End Sub

    Private Sub btnImportCSV_Click(sender As Object, e As EventArgs) Handles btnImportCSV.Click
        'Neue Liste erstellen
        originalFile = New List(Of String())

        'Inhalt auslesen und einzelne Daten speichern
        Dim content As List(Of String) = fh.readFile()
        If content IsNot "" Then
            For i As Integer = 0 To content.Count - 1
                originalFile.Add(content(i).Split(","))
            Next
            log.Log("Info", "CSV Datei erfolgreich geladen")
        Else
            log.Log("Error", "Fehler beim Laden der Datei")
        End If

        'ListBox und ListView leeren
        lbColumns.Items.Clear()
        lvCSV.Clear()

        'ListBox und ListView mit Titelzeile füllen
        For i As Integer = 0 To originalFile(0).Count - 1
            lbColumns.Items.Add(originalFile(0)(i))
            lvCSV.Columns.Add(originalFile(0)(i))
        Next

        'ListView füllen
        For i As Integer = 1 To originalFile.Count - 1
            Dim entry(originalFile(i).Count) As String
            For j As Integer = 0 To originalFile(i).Count - 1
                entry(j) = originalFile(i)(j)
            Next
            lvCSV.Items.Add(New ListViewItem(entry))
        Next
    End Sub

    Private Sub btnReplaceData_Click(sender As Object, e As EventArgs) Handles btnReplaceData.Click
        If lbColumns.Items.Count = 0 Then
            MsgBox("Bitte lade eine CSV Datei")
        ElseIf lbColumns.SelectedItems.Count = 0 Then
            MsgBox("Bitte wähle eine oder mehrere Spalten")
        Else
            'Inhalt auslesen und einzelne Daten speichern
            Dim changesFile As List(Of String) = fh.readFile()
            If changesFile IsNot "" Then
                log.Log("Info", "Änderungsdatei erfolgreich geladen")
            Else
                log.Log("Error", "Fehler beim auslesen der Änderungsdatei")
                Exit Sub
            End If

            'Anzahl Kolonnen speichern
            Dim columnCount = changesFile(0).Count(Function(x) x = ",") + 1

            'Bei einzelner Kolonne wird alles überschrieben
            If columnCount = 1 Then
                For i As Integer = 0 To changesFile.Count - 1
                    originalFile(i + 1)(lbColumns.SelectedIndex) = changesFile(i)
                Next
                'Bei zwei Kolonnen werden alle Zeilen chronologisch überschrieben wenn sie übereinanderstimmen
            ElseIf columnCount = 2 Then
                For i As Integer = 0 To changesFile.Count - 1
                    Dim changes As String() = changesFile(i).Split(",")
                    Dim line As String() = originalFile(i + 1)
                    If line(lbColumns.SelectedIndex) = changes(0) Then
                        line(lbColumns.SelectedIndex) = changes(1)
                    Else
                        log.Log("Error", "Zeile " & i & " stimmt nicht überein, Änderungen überprüfen")
                        MsgBox("Zeile " & i & " stimmt nicht überein, bitte Änderungen überprüfen")
                        Exit Sub
                    End If
                Next
                'Bei drei Kolonnen werden spezifische Zeilennummern überschrieben wenn sie übereinanderstimmen
            ElseIf columnCount = 3 Then
                For i As Integer = 0 To changesFile.Count - 1
                    Dim changes As String() = changesFile(i).Split(",")
                    Dim line As String() = originalFile(changes(0))
                    If line(lbColumns.SelectedIndex) = changes(1) Then
                        line(lbColumns.SelectedIndex) = changes(2)
                    Else
                        log.Log("Error", "Zeile " & changes(0) & " stimmt nicht überein, Änderungen überprüfen")
                        MsgBox("Zeile " & changes(0) & " stimmt nicht überein, bitte Änderungen überprüfen")
                        Exit Sub
                    End If
                Next
            Else
                log.Log("Error", "Inkompatible Änderungsdatei geladen")
                MsgBox("Datei nicht kompatibel")
                Exit Sub
            End If

            'Neue Daten speichern und formatieren
            Dim newFile As List(Of String) = New List(Of String)
            For i As Integer = 0 To originalFile.Count - 1
                newFile.Add(String.Join(",", originalFile(i)))
            Next
            Dim fileName As String = fh.saveFile(newFile)
            If fileName IsNot "" Then
                MsgBox(fileName & " wurde erfolgreich gespeichert")
                log.Log("Success", "Spalte " & lbColumns.SelectedItem & " wurde in der Datei " & fileName & " überschrieben")
            Else
                MsgBox("Fehler beim speichern")
                log.Log("Error", "Datei konnte nicht gespeichert werden")
            End If
        End If
    End Sub

    Private Sub btnOpenLogs_Click(sender As Object, e As EventArgs) Handles btnOpenLogs.Click
        MsgBox(log.readLogs())
    End Sub
End Class
