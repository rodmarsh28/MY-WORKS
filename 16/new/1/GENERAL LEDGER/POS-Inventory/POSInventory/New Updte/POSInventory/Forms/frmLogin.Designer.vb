﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form
    Dim a As watermark
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtPassword = New POSInventory.watermark()
        Me.txtUsername = New POSInventory.watermark()
        Me.btnCLose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(68, 170)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(80, 25)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(171, 169)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 26)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(39, 104)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(226, 26)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.WatermarkColor = System.Drawing.Color.Gray
        Me.txtPassword.WatermarkText = ""
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(39, 48)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(226, 26)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.WatermarkColor = System.Drawing.Color.Gray
        Me.txtUsername.WatermarkText = ""
        '
        'btnCLose
        '
        Me.btnCLose.BackColor = System.Drawing.Color.Transparent
        Me.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLose.Location = New System.Drawing.Point(278, 1)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(26, 17)
        Me.btnCLose.TabIndex = 4
        Me.btnCLose.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(306, 209)
        Me.Controls.Add(Me.btnCLose)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As watermark
    Friend WithEvents txtPassword As watermark
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCLose As System.Windows.Forms.Button
End Class
