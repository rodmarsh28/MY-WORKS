<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddMaterials
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInvtyCode = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaterialDesc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADD MATERIALS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INVENTORY CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "MATERIAL DESCRIPTION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "UNIT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "STOCKS"
        '
        'txtInvtyCode
        '
        Me.txtInvtyCode.Enabled = False
        Me.txtInvtyCode.Location = New System.Drawing.Point(217, 76)
        Me.txtInvtyCode.Name = "txtInvtyCode"
        Me.txtInvtyCode.Size = New System.Drawing.Size(136, 20)
        Me.txtInvtyCode.TabIndex = 7
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(217, 162)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(136, 20)
        Me.txtUnit.TabIndex = 4
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(217, 212)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(136, 20)
        Me.txtStocks.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(303, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(217, 135)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(363, 20)
        Me.txtSerial.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SERIAL/MODEL/BRAND/TYPE"
        '
        'txtUPrice
        '
        Me.txtUPrice.Location = New System.Drawing.Point(217, 187)
        Me.txtUPrice.Name = "txtUPrice"
        Me.txtUPrice.Size = New System.Drawing.Size(136, 20)
        Me.txtUPrice.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "UNIT PRICE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(196, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "₱"
        '
        'txtMaterialDesc
        '
        Me.txtMaterialDesc.Location = New System.Drawing.Point(217, 110)
        Me.txtMaterialDesc.Name = "txtMaterialDesc"
        Me.txtMaterialDesc.Size = New System.Drawing.Size(363, 20)
        Me.txtMaterialDesc.TabIndex = 1
        '
        'frmaddMaterials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 312)
        Me.Controls.Add(Me.txtMaterialDesc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtInvtyCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmaddMaterials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Materials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInvtyCode As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtStocks As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMaterialDesc As System.Windows.Forms.TextBox
End Class
