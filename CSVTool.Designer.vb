<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CSVTool
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnImportCSV = New Button()
        lbColumns = New ListBox()
        btnReplaceData = New Button()
        btnOpenLogs = New Button()
        lbMessages = New Label()
        lblColumns = New Label()
        lvCSV = New ListView()
        SuspendLayout()
        ' 
        ' btnImportCSV
        ' 
        btnImportCSV.Location = New Point(12, 12)
        btnImportCSV.Name = "btnImportCSV"
        btnImportCSV.Size = New Size(155, 35)
        btnImportCSV.TabIndex = 0
        btnImportCSV.Text = "Import CSV"
        btnImportCSV.UseVisualStyleBackColor = True
        ' 
        ' lbColumns
        ' 
        lbColumns.FormattingEnabled = True
        lbColumns.ItemHeight = 15
        lbColumns.Location = New Point(12, 90)
        lbColumns.Name = "lbColumns"
        lbColumns.Size = New Size(155, 109)
        lbColumns.TabIndex = 2
        ' 
        ' btnReplaceData
        ' 
        btnReplaceData.Location = New Point(12, 205)
        btnReplaceData.Name = "btnReplaceData"
        btnReplaceData.Size = New Size(155, 35)
        btnReplaceData.TabIndex = 4
        btnReplaceData.Text = "Replace Data"
        btnReplaceData.UseVisualStyleBackColor = True
        ' 
        ' btnOpenLogs
        ' 
        btnOpenLogs.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnOpenLogs.Location = New Point(12, 264)
        btnOpenLogs.Name = "btnOpenLogs"
        btnOpenLogs.Size = New Size(155, 35)
        btnOpenLogs.TabIndex = 5
        btnOpenLogs.Text = "Open Logs"
        btnOpenLogs.UseVisualStyleBackColor = True
        ' 
        ' lbMessages
        ' 
        lbMessages.AutoSize = True
        lbMessages.Location = New Point(633, 16)
        lbMessages.Name = "lbMessages"
        lbMessages.Size = New Size(0, 15)
        lbMessages.TabIndex = 6
        lbMessages.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblColumns
        ' 
        lblColumns.AutoSize = True
        lblColumns.Location = New Point(12, 72)
        lblColumns.Name = "lblColumns"
        lblColumns.Size = New Size(113, 15)
        lblColumns.TabIndex = 7
        lblColumns.Text = "Columns (choose 1)"
        ' 
        ' lvCSV
        ' 
        lvCSV.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvCSV.Location = New Point(173, 12)
        lvCSV.Name = "lvCSV"
        lvCSV.Size = New Size(399, 287)
        lvCSV.TabIndex = 8
        lvCSV.UseCompatibleStateImageBehavior = False
        ' 
        ' CSVTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 311)
        Controls.Add(lvCSV)
        Controls.Add(lblColumns)
        Controls.Add(lbMessages)
        Controls.Add(btnOpenLogs)
        Controls.Add(btnReplaceData)
        Controls.Add(lbColumns)
        Controls.Add(btnImportCSV)
        MinimumSize = New Size(600, 350)
        Name = "CSVTool"
        Text = "CSV Tool"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnImportCSV As Button
    Friend WithEvents lbColumns As ListBox
    Friend WithEvents btnReplaceData As Button
    Friend WithEvents btnOpenLogs As Button
    Friend WithEvents lbMessages As Label
    Friend WithEvents lblColumns As Label
    Friend WithEvents lvCSV As ListView

End Class
