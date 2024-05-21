Imports System.IO

Public Class Form1
    ''' <summary>
    ''' Struktur:
    '''     GUI:
    '''         TAB CSV
    '''         Datei laden mit csv
    '''         CSV Viewer
    '''         Spaltenauswahl (dropdown + inputfeld) 1 oder mehr
    '''         Wenn ausgewählt, Datei wählen mit XLSX und CSV ändern
    '''         CSV speichern
    '''         Pop Up zur Bestätigung
    '''         
    '''         TAB Logs
    '''         Logs Viewer
    '''             CSV öffnen
    '''             CSV überschreiben
    '''             CSV speichern
    '''             Fehler
    '''             
    ''' Dim variable As type
    ''' variable = value
    ''' String & String -> concat
    ''' String & vbNewLine & String -> \n
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog() With {.Filter = "CSV File|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(",")
                Next
            End If
        End Using
    End Sub
End Class
