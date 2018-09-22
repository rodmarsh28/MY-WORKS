<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddReqOfDept
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddReqOfDept))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELETEITEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.txtDeprt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaterialDesc = New System.Windows.Forms.TextBox()
        Me.txtDebitTo = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtJustification = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPREPAREDBY = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAPPROVEDBY = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBLMWSNO = New System.Windows.Forms.TextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MATERIAL'S WITHDRAWAL "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TO :"
        '
        'txtTo
        '
        Me.txtTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(151, 95)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(263, 20)
        Me.txtTo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(986, 314)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgw.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgw.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw.GridColor = System.Drawing.Color.LightGray
        Me.dgw.Location = New System.Drawing.Point(3, 16)
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(980, 295)
        Me.dgw.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "MWSITEMNO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "MATERIAL DESCRIPTION"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 420
        '
        'Column2
        '
        Me.Column2.HeaderText = "DEBIT TO (ACCOUNT)"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "UNIT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELETEITEMToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 26)
        '
        'DELETEITEMToolStripMenuItem
        '
        Me.DELETEITEMToolStripMenuItem.Name = "DELETEITEMToolStripMenuItem"
        Me.DELETEITEMToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DELETEITEMToolStripMenuItem.Text = "DELETE ITEM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "SECTION :"
        '
        'txtSection
        '
        Me.txtSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(151, 118)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(263, 20)
        Me.txtSection.TabIndex = 2
        '
        'txtDeprt
        '
        Me.txtDeprt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeprt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeprt.Location = New System.Drawing.Point(151, 140)
        Me.txtDeprt.Name = "txtDeprt"
        Me.txtDeprt.Size = New System.Drawing.Size(201, 20)
        Me.txtDeprt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DEPARTMENT :"
        '
        'txtMaterialDesc
        '
        Me.txtMaterialDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterialDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialDesc.Location = New System.Drawing.Point(16, 257)
        Me.txtMaterialDesc.Name = "txtMaterialDesc"
        Me.txtMaterialDesc.Size = New System.Drawing.Size(344, 20)
        Me.txtMaterialDesc.TabIndex = 8
        '
        'txtDebitTo
        '
        Me.txtDebitTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDebitTo.Enabled = False
        Me.txtDebitTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebitTo.Location = New System.Drawing.Point(399, 257)
        Me.txtDebitTo.Name = "txtDebitTo"
        Me.txtDebitTo.Size = New System.Drawing.Size(201, 20)
        Me.txtDebitTo.TabIndex = 9
        '
        'txtUnit
        '
        Me.txtUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(621, 257)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(116, 20)
        Me.txtUnit.TabIndex = 10
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(756, 257)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(116, 20)
        Me.txtQuantity.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MATERIAL DESCRIPTION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(432, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "DEBIT TO (ACCOUNT)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(657, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "UNIT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(770, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "QUANTITY"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(900, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(410, 604)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 39)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(514, 604)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 39)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(596, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "DATE :"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(649, 94)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(101, 20)
        Me.dtpDate.TabIndex = 4
        '
        'txtJustification
        '
        Me.txtJustification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJustification.Location = New System.Drawing.Point(151, 161)
        Me.txtJustification.Name = "txtJustification"
        Me.txtJustification.Size = New System.Drawing.Size(692, 54)
        Me.txtJustification.TabIndex = 7
        Me.txtJustification.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "JUSTIFICATION :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "MWS NO. :"
        '
        'txtPREPAREDBY
        '
        Me.txtPREPAREDBY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPREPAREDBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPREPAREDBY.Location = New System.Drawing.Point(649, 116)
        Me.txtPREPAREDBY.Name = "txtPREPAREDBY"
        Me.txtPREPAREDBY.Size = New System.Drawing.Size(194, 20)
        Me.txtPREPAREDBY.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(529, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = " REQUESTED BY :"
        '
        'txtAPPROVEDBY
        '
        Me.txtAPPROVEDBY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAPPROVEDBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPPROVEDBY.Location = New System.Drawing.Point(649, 138)
        Me.txtAPPROVEDBY.Name = "txtAPPROVEDBY"
        Me.txtAPPROVEDBY.Size = New System.Drawing.Size(194, 20)
        Me.txtAPPROVEDBY.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(542, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "APPROVED BY :"
        '
        'LBLMWSNO
        '
        Me.LBLMWSNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LBLMWSNO.Enabled = False
        Me.LBLMWSNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMWSNO.Location = New System.Drawing.Point(151, 72)
        Me.LBLMWSNO.Name = "LBLMWSNO"
        Me.LBLMWSNO.Size = New System.Drawing.Size(122, 20)
        Me.LBLMWSNO.TabIndex = 60
        '
        'MetroButton1
        '
        Me.MetroButton1.BackgroundImage = CType(resources.GetObject("MetroButton1.BackgroundImage"), System.Drawing.Image)
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroButton1.Location = New System.Drawing.Point(574, 229)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(27, 25)
        Me.MetroButton1.TabIndex = 61
        Me.MetroButton1.UseSelectable = True
        '
        'frmAddReqOfDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 653)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.LBLMWSNO)
        Me.Controls.Add(Me.txtAPPROVEDBY)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPREPAREDBY)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtJustification)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtDebitTo)
        Me.Controls.Add(Me.txtMaterialDesc)
        Me.Controls.Add(Me.txtDeprt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddReqOfDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REQUEST FORM"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents txtDeprt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaterialDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtDebitTo As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtJustification As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPREPAREDBY As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAPPROVEDBY As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DELETEITEMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBLMWSNO As System.Windows.Forms.TextBox
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
