<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class msgboxx
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(32, 83)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(89, 23)
        Me.btnName.TabIndex = 0
        Me.btnName.Text = "&DEBIT"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnCredit
        '
        Me.btnCredit.Location = New System.Drawing.Point(140, 83)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(90, 23)
        Me.btnCredit.TabIndex = 1
        Me.btnCredit.Text = "&CREDIT"
        Me.btnCredit.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(46, 35)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(170, 20)
        Me.txtAmount.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AMOUNT"
        '
        'msgboxx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 129)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnCredit)
        Me.Controls.Add(Me.btnName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "msgboxx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLEASE INPUT AMOUNT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents btnCredit As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
