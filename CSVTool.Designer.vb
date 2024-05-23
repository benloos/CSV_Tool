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
        dgvCSV = New DataGridView()
        btnReplaceData = New Button()
        btnOpenLogs = New Button()
        CType(dgvCSV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnImportCSV
        ' 
        btnImportCSV.Location = New Point(12, 12)
        btnImportCSV.Name = "btnImportCSV"
        btnImportCSV.Size = New Size(90, 23)
        btnImportCSV.TabIndex = 0
        btnImportCSV.Text = "Import CSV"
        btnImportCSV.UseVisualStyleBackColor = True
        ' 
        ' lbColumns
        ' 
        lbColumns.FormattingEnabled = True
        lbColumns.ItemHeight = 15
        lbColumns.Location = New Point(633, 41)
        lbColumns.Name = "lbColumns"
        lbColumns.Size = New Size(155, 109)
        lbColumns.TabIndex = 2
        ' 
        ' dgvCSV
        ' 
        dgvCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCSV.Location = New Point(12, 41)
        dgvCSV.Name = "dgvCSV"
        dgvCSV.Size = New Size(615, 397)
        dgvCSV.TabIndex = 3
        ' 
        ' btnReplaceData
        ' 
        btnReplaceData.Location = New Point(633, 156)
        btnReplaceData.Name = "btnReplaceData"
        btnReplaceData.Size = New Size(90, 23)
        btnReplaceData.TabIndex = 4
        btnReplaceData.Text = "Replace Data"
        btnReplaceData.UseVisualStyleBackColor = True
        ' 
        ' btnOpenLogs
        ' 
        btnOpenLogs.Location = New Point(633, 415)
        btnOpenLogs.Name = "btnOpenLogs"
        btnOpenLogs.Size = New Size(90, 23)
        btnOpenLogs.TabIndex = 5
        btnOpenLogs.Text = "Open Logs"
        btnOpenLogs.UseVisualStyleBackColor = True
        ' 
        ' CSVTool
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnOpenLogs)
        Controls.Add(btnReplaceData)
        Controls.Add(dgvCSV)
        Controls.Add(lbColumns)
        Controls.Add(btnImportCSV)
        Name = "CSVTool"
        Text = "CSV Tool"
        CType(dgvCSV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnImportCSV As Button
    Friend WithEvents lbColumns As ListBox
    Friend WithEvents dgvCSV As DataGridView
    Friend WithEvents btnReplaceData As Button
    Friend WithEvents btnOpenLogs As Button

End Class
