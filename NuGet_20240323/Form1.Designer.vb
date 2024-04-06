<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBoxInputCSVFileName = New TextBox()
        TextBoxOutputCSVFileName = New TextBox()
        ButtonCSVRead = New Button()
        ButtonCsvWrite = New Button()
        DataGridViewCsv = New DataGridView()
        OpenFileDialogCsv = New OpenFileDialog()
        SaveFileDialogCsv = New SaveFileDialog()
        ButtonCsvWrite2 = New Button()
        TextBoxOutputCSVFileName2 = New TextBox()
        CType(DataGridViewCsv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxInputCSVFileName
        ' 
        TextBoxInputCSVFileName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxInputCSVFileName.Location = New Point(12, 9)
        TextBoxInputCSVFileName.Name = "TextBoxInputCSVFileName"
        TextBoxInputCSVFileName.Size = New Size(612, 27)
        TextBoxInputCSVFileName.TabIndex = 0
        ' 
        ' TextBoxOutputCSVFileName
        ' 
        TextBoxOutputCSVFileName.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxOutputCSVFileName.Location = New Point(12, 424)
        TextBoxOutputCSVFileName.Name = "TextBoxOutputCSVFileName"
        TextBoxOutputCSVFileName.Size = New Size(612, 27)
        TextBoxOutputCSVFileName.TabIndex = 0
        ' 
        ' ButtonCSVRead
        ' 
        ButtonCSVRead.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ButtonCSVRead.Location = New Point(643, 6)
        ButtonCSVRead.Name = "ButtonCSVRead"
        ButtonCSVRead.Size = New Size(154, 33)
        ButtonCSVRead.TabIndex = 1
        ButtonCSVRead.Text = "CSV取得"
        ButtonCSVRead.UseVisualStyleBackColor = True
        ' 
        ' ButtonCsvWrite
        ' 
        ButtonCsvWrite.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCsvWrite.Location = New Point(630, 421)
        ButtonCsvWrite.Name = "ButtonCsvWrite"
        ButtonCsvWrite.Size = New Size(154, 32)
        ButtonCsvWrite.TabIndex = 1
        ButtonCsvWrite.Text = "CSV出力"
        ButtonCsvWrite.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewCsv
        ' 
        DataGridViewCsv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCsv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCsv.Location = New Point(12, 46)
        DataGridViewCsv.Name = "DataGridViewCsv"
        DataGridViewCsv.RowHeadersWidth = 51
        DataGridViewCsv.Size = New Size(785, 361)
        DataGridViewCsv.TabIndex = 2
        ' 
        ' OpenFileDialogCsv
        ' 
        OpenFileDialogCsv.FileName = "*.csv"
        OpenFileDialogCsv.InitialDirectory = ".\"
        ' 
        ' SaveFileDialogCsv
        ' 
        SaveFileDialogCsv.Filter = "CSVファイル|*.csv|すべてのファイル|*.*"
        SaveFileDialogCsv.InitialDirectory = ".\"
        ' 
        ' ButtonCsvWrite2
        ' 
        ButtonCsvWrite2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCsvWrite2.Location = New Point(630, 458)
        ButtonCsvWrite2.Name = "ButtonCsvWrite2"
        ButtonCsvWrite2.Size = New Size(154, 29)
        ButtonCsvWrite2.TabIndex = 3
        ButtonCsvWrite2.Text = "CSV出力2"
        ButtonCsvWrite2.UseVisualStyleBackColor = True
        ' 
        ' TextBoxOutputCSVFileName2
        ' 
        TextBoxOutputCSVFileName2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBoxOutputCSVFileName2.Location = New Point(12, 460)
        TextBoxOutputCSVFileName2.Name = "TextBoxOutputCSVFileName2"
        TextBoxOutputCSVFileName2.Size = New Size(612, 27)
        TextBoxOutputCSVFileName2.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 532)
        Controls.Add(TextBoxOutputCSVFileName2)
        Controls.Add(ButtonCsvWrite2)
        Controls.Add(DataGridViewCsv)
        Controls.Add(ButtonCsvWrite)
        Controls.Add(ButtonCSVRead)
        Controls.Add(TextBoxOutputCSVFileName)
        Controls.Add(TextBoxInputCSVFileName)
        Name = "Form1"
        Text = "CSVの読み書き"
        CType(DataGridViewCsv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxInputCSVFileName As TextBox
    Friend WithEvents TextBoxOutputCSVFileName As TextBox
    Friend WithEvents ButtonCSVRead As Button
    Friend WithEvents ButtonCsvWrite As Button
    Friend WithEvents DataGridViewCsv As DataGridView
    Friend WithEvents OpenFileDialogCsv As OpenFileDialog
    Friend WithEvents SaveFileDialogCsv As SaveFileDialog
    Friend WithEvents ButtonCsvWrite2 As Button
    Friend WithEvents TextBoxOutputCSVFileName2 As TextBox

End Class
