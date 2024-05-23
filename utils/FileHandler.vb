Imports System.IO

Public Class FileHandler
    'Datei öffnen und als Liste von Strings zurückgeben
    'Gibt Empty String zurück wenn ein Fehler aufgetaucht ist
    Public Function readFile(Optional filter As String = "CSV File|*.csv")
        Using ofd As New OpenFileDialog() With {.Filter = filter}
            If ofd.ShowDialog() = DialogResult.OK Then
                Return File.ReadAllLines(ofd.FileName).ToList() 'Importierte Daten
            Else
                Return ""
            End If
        End Using
    End Function

    'Liste von Strings in einer Datei speichern
    Public Function saveFile(content As List(Of String), Optional filter As String = "CSV File|*.csv")
        Using sfd As New SaveFileDialog() With {.Filter = filter}
            If sfd.ShowDialog() = DialogResult.OK Then
                File.WriteAllLines(sfd.FileName, content)
                Return "Success"
            Else
                Return ""
            End If
        End Using
    End Function

End Class
