<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRGI
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAssetCost = New System.Windows.Forms.TextBox()
        Me.txtSalvageValue = New System.Windows.Forms.TextBox()
        Me.cmbUsefulLife = New System.Windows.Forms.ComboBox()
        Me.rchDDB = New System.Windows.Forms.RichTextBox()
        Me.rchSYD = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcDeprValues = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asset Cost:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Salvage Value:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Useful Life:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Location = New System.Drawing.Point(126, 31)
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.Size = New System.Drawing.Size(121, 20)
        Me.txtAssetCost.TabIndex = 2
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Location = New System.Drawing.Point(126, 67)
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.Size = New System.Drawing.Size(121, 20)
        Me.txtSalvageValue.TabIndex = 2
        '
        'cmbUsefulLife
        '
        Me.cmbUsefulLife.FormattingEnabled = True
        Me.cmbUsefulLife.Location = New System.Drawing.Point(126, 104)
        Me.cmbUsefulLife.Name = "cmbUsefulLife"
        Me.cmbUsefulLife.Size = New System.Drawing.Size(121, 21)
        Me.cmbUsefulLife.TabIndex = 3
        '
        'rchDDB
        '
        Me.rchDDB.Location = New System.Drawing.Point(288, 112)
        Me.rchDDB.Name = "rchDDB"
        Me.rchDDB.Size = New System.Drawing.Size(144, 136)
        Me.rchDDB.TabIndex = 4
        Me.rchDDB.Text = ""
        '
        'rchSYD
        '
        Me.rchSYD.Location = New System.Drawing.Point(472, 112)
        Me.rchSYD.Name = "rchSYD"
        Me.rchSYD.Size = New System.Drawing.Size(144, 136)
        Me.rchSYD.TabIndex = 4
        Me.rchSYD.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Double-Declining Balances:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sum-of-Years-Digits:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalcDeprValues
        '
        Me.btnCalcDeprValues.Location = New System.Drawing.Point(39, 151)
        Me.btnCalcDeprValues.Name = "btnCalcDeprValues"
        Me.btnCalcDeprValues.Size = New System.Drawing.Size(91, 96)
        Me.btnCalcDeprValues.TabIndex = 5
        Me.btnCalcDeprValues.Text = "Display Depr. Schedules"
        Me.btnCalcDeprValues.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 151)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 96)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Depreciation Schedules"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmRGI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 273)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcDeprValues)
        Me.Controls.Add(Me.rchSYD)
        Me.Controls.Add(Me.rchDDB)
        Me.Controls.Add(Me.cmbUsefulLife)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRGI"
        Me.Text = "RGI Annual Asset Depreciation APP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAssetCost As TextBox
    Friend WithEvents txtSalvageValue As TextBox
    Friend WithEvents cmbUsefulLife As ComboBox
    Friend WithEvents rchDDB As RichTextBox
    Friend WithEvents rchSYD As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalcDeprValues As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label6 As Label
End Class
