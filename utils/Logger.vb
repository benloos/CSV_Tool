Imports System.IO

Public Class Logger
    Dim logFile As String = "csvtool_logs.txt"

    'Logs auslesen
    Public Function readLogs()
        Return String.Join(Environment.NewLine, File.ReadAllLines(logFile).TakeLast(30))
    End Function

    'Log in die Datei schreiben
    Public Sub Log(type As String, message As String)
        Dim time As DateTime = DateTime.Now
        File.AppendAllText(logFile, time & " | " & type & " | " & message & Environment.NewLine)
    End Sub
End Class
