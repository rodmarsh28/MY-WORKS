<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANAGEACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTERACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANAGECHARTOFACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMREPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SYSTEMSETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLNAME = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBLPOS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTToolStripMenuItem, Me.SYSTEMREPORTSToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.ABOUTToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1252, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACCOUNTToolStripMenuItem
        '
        Me.ACCOUNTToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.ACCOUNTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANAGEACCOUNTToolStripMenuItem, Me.REGISTERACCOUNTToolStripMenuItem, Me.MANAGECHARTOFACCOUNTSToolStripMenuItem})
        Me.ACCOUNTToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ACCOUNTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.ACCOUNTToolStripMenuItem.Name = "ACCOUNTToolStripMenuItem"
        Me.ACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.ACCOUNTToolStripMenuItem.Text = "ACCOUNT"
        '
        'MANAGEACCOUNTToolStripMenuItem
        '
        Me.MANAGEACCOUNTToolStripMenuItem.Name = "MANAGEACCOUNTToolStripMenuItem"
        Me.MANAGEACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.MANAGEACCOUNTToolStripMenuItem.Text = "MANAGE ACCOUNTS"
        '
        'REGISTERACCOUNTToolStripMenuItem
        '
        Me.REGISTERACCOUNTToolStripMenuItem.Name = "REGISTERACCOUNTToolStripMenuItem"
        Me.REGISTERACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.REGISTERACCOUNTToolStripMenuItem.Text = "REGISTER ACCOUNTS"
        '
        'MANAGECHARTOFACCOUNTSToolStripMenuItem
        '
        Me.MANAGECHARTOFACCOUNTSToolStripMenuItem.Name = "MANAGECHARTOFACCOUNTSToolStripMenuItem"
        Me.MANAGECHARTOFACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(320, 26)
        Me.MANAGECHARTOFACCOUNTSToolStripMenuItem.Text = "MANAGE CHART OF ACCOUNTS"
        '
        'SYSTEMREPORTSToolStripMenuItem
        '
        Me.SYSTEMREPORTSToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.SYSTEMREPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTSToolStripMenuItem, Me.LOGSToolStripMenuItem})
        Me.SYSTEMREPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SYSTEMREPORTSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SYSTEMREPORTSToolStripMenuItem.Name = "SYSTEMREPORTSToolStripMenuItem"
        Me.SYSTEMREPORTSToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.SYSTEMREPORTSToolStripMenuItem.Text = "SYSTEM"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'LOGSToolStripMenuItem
        '
        Me.LOGSToolStripMenuItem.Name = "LOGSToolStripMenuItem"
        Me.LOGSToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.LOGSToolStripMenuItem.Text = "LOGS"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SYSTEMSETTINGSToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ABOUTToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.ABOUTToolStripMenuItem.Text = "OPTIONS"
        '
        'SYSTEMSETTINGSToolStripMenuItem
        '
        Me.SYSTEMSETTINGSToolStripMenuItem.Name = "SYSTEMSETTINGSToolStripMenuItem"
        Me.SYSTEMSETTINGSToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.SYSTEMSETTINGSToolStripMenuItem.Text = "SYSTEM SETTINGS"
        '
        'ABOUTToolStripMenuItem1
        '
        Me.ABOUTToolStripMenuItem1.BackColor = System.Drawing.Color.Gray
        Me.ABOUTToolStripMenuItem1.Name = "ABOUTToolStripMenuItem1"
        Me.ABOUTToolStripMenuItem1.Size = New System.Drawing.Size(76, 25)
        Me.ABOUTToolStripMenuItem1.Text = "ABOUT"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LBLID, Me.ToolStripStatusLabel3, Me.LBLNAME, Me.ToolStripStatusLabel5, Me.LBLPOS})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1252, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "USER ID :"
        '
        'LBLID
        '
        Me.LBLID.ForeColor = System.Drawing.Color.White
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(18, 17)
        Me.LBLID.Text = "ID"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel3.Text = "NAME :"
        '
        'LBLNAME
        '
        Me.LBLNAME.ForeColor = System.Drawing.Color.White
        Me.LBLNAME.Name = "LBLNAME"
        Me.LBLNAME.Size = New System.Drawing.Size(41, 17)
        Me.LBLNAME.Text = "NAME"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel5.Text = "POSITION :"
        '
        'LBLPOS
        '
        Me.LBLPOS.ForeColor = System.Drawing.Color.White
        Me.LBLPOS.Name = "LBLPOS"
        Me.LBLPOS.Size = New System.Drawing.Size(60, 17)
        Me.LBLPOS.Text = "POSITION"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 638)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(41, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SIGN OUT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(26, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EDIT ACCOUNT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(183, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1069, 88)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GENERAL LEDGER SYSTEM"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Accounting System"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(609, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Inventory System"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(972, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Payroll System"
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Location = New System.Drawing.Point(226, 253)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(298, 287)
        Me.MetroButton1.TabIndex = 9
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton2.BackgroundImage = CType(resources.GetObject("MetroButton2.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton2.Location = New System.Drawing.Point(578, 253)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(298, 287)
        Me.MetroButton2.TabIndex = 10
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton3.BackgroundImage = CType(resources.GetObject("MetroButton3.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton3.Location = New System.Drawing.Point(922, 253)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(298, 287)
        Me.MetroButton3.TabIndex = 11
        Me.MetroButton3.UseSelectable = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 682)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MANAGEACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTERACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYSTEMREPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SYSTEMSETTINGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLID As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLNAME As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LBLPOS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MANAGECHARTOFACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
