<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialReceiving
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtInvtyCode = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DELELTEITEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtMRSNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPORef = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtReceived = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDelivered = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkboxLessVat = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(583, 589)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 39)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(472, 589)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 39)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1011, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 34)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(651, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "UNIT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "INVENTORY CODE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(425, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "SERIAL/MODEL/BRAND"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(194, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "MATERIAL DESCRIPTION"
        '
        'txtUnit
        '
        Me.txtUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(617, 250)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(116, 20)
        Me.txtUnit.TabIndex = 11
        '
        'txtInvtyCode
        '
        Me.txtInvtyCode.Enabled = False
        Me.txtInvtyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvtyCode.Location = New System.Drawing.Point(13, 250)
        Me.txtInvtyCode.Name = "txtInvtyCode"
        Me.txtInvtyCode.Size = New System.Drawing.Size(126, 20)
        Me.txtInvtyCode.TabIndex = 7
        '
        'txtSerial
        '
        Me.txtSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(400, 250)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(201, 20)
        Me.txtSerial.TabIndex = 9
        '
        'txtItemDesc
        '
        Me.txtItemDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(142, 250)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(251, 20)
        Me.txtItemDesc.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 295)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column5, Me.Column3, Me.Column6, Me.Column9, Me.Column4, Me.Column7})
        Me.dgw.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw.GridColor = System.Drawing.Color.LightGray
        Me.dgw.Location = New System.Drawing.Point(3, 16)
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersVisible = False
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(1127, 276)
        Me.dgw.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "INVENTORY CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "MATERIAL DESCRIPTION"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "SERIAL/MODEL/BRAND"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "UNIT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column6
        '
        DataGridViewCellStyle3.Format = "c"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column6.HeaderText = "UNIT PRICE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column9
        '
        DataGridViewCellStyle4.Format = "c"
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column9.HeaderText = "LESS VAT"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column7
        '
        DataGridViewCellStyle5.Format = "c"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column7.HeaderText = "AMOUNT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 130
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DELELTEITEMToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 26)
        '
        'DELELTEITEMToolStripMenuItem
        '
        Me.DELELTEITEMToolStripMenuItem.Name = "DELELTEITEMToolStripMenuItem"
        Me.DELELTEITEMToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DELELTEITEMToolStripMenuItem.Text = "DELETE ITEM"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1011, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 34)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "FIND"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(733, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "DATE :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(718, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "MRS NO :"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(797, 89)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpDate.TabIndex = 1
        '
        'txtMRSNo
        '
        Me.txtMRSNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMRSNo.Enabled = False
        Me.txtMRSNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRSNo.Location = New System.Drawing.Point(797, 66)
        Me.txtMRSNo.Name = "txtMRSNo"
        Me.txtMRSNo.Size = New System.Drawing.Size(145, 20)
        Me.txtMRSNo.TabIndex = 85
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(236, 114)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(387, 20)
        Me.txtAddress.TabIndex = 84
        '
        'txtSuppName
        '
        Me.txtSuppName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSuppName.Enabled = False
        Me.txtSuppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppName.Location = New System.Drawing.Point(236, 91)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(387, 20)
        Me.txtSuppName.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "SUPPLIER'S NAME :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(141, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "ADDRESS :"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(236, 138)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(387, 48)
        Me.txtRemarks.TabIndex = 5
        Me.txtRemarks.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "REMARKS :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "PO REF NO :"
        '
        'txtPORef
        '
        Me.txtPORef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPORef.Enabled = False
        Me.txtPORef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPORef.Location = New System.Drawing.Point(236, 68)
        Me.txtPORef.Name = "txtPORef"
        Me.txtPORef.Size = New System.Drawing.Size(238, 20)
        Me.txtPORef.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(674, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "DR / CI / SI NO :"
        '
        'txtDR
        '
        Me.txtDR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDR.Location = New System.Drawing.Point(797, 111)
        Me.txtDR.Name = "txtDR"
        Me.txtDR.Size = New System.Drawing.Size(266, 20)
        Me.txtDR.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MATERIAL'S RECEIVING"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(771, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "UNIT PRICE"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(754, 250)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(117, 20)
        Me.txtUnitPrice.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(899, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "QUANTITY"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(895, 250)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(80, 20)
        Me.txtQuantity.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(876, 254)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "X"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(739, 253)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 13)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "₱"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(771, 589)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(304, 15)
        Me.lblTotal.TabIndex = 101
        Me.lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ 0.00"
        '
        'txtReceived
        '
        Me.txtReceived.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceived.Location = New System.Drawing.Point(797, 135)
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.Size = New System.Drawing.Size(266, 20)
        Me.txtReceived.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(685, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "RECEIVED BY :"
        '
        'txtDelivered
        '
        Me.txtDelivered.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDelivered.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelivered.Location = New System.Drawing.Point(797, 159)
        Me.txtDelivered.Name = "txtDelivered"
        Me.txtDelivered.Size = New System.Drawing.Size(266, 20)
        Me.txtDelivered.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(678, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 13)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = "DELIVERED BY :"
        '
        'chkboxLessVat
        '
        Me.chkboxLessVat.AutoSize = True
        Me.chkboxLessVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkboxLessVat.Location = New System.Drawing.Point(39, 203)
        Me.chkboxLessVat.Name = "chkboxLessVat"
        Me.chkboxLessVat.Size = New System.Drawing.Size(197, 17)
        Me.chkboxLessVat.TabIndex = 6
        Me.chkboxLessVat.Text = "THIS PRICE'S IS LESS VAT ?"
        Me.chkboxLessVat.UseVisualStyleBackColor = True
        '
        'frmMaterialReceiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 673)
        Me.Controls.Add(Me.chkboxLessVat)
        Me.Controls.Add(Me.txtDelivered)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtDR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPORef)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtMRSNo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSuppName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtInvtyCode)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMaterialReceiving"
        Me.Text = "frmMaterialReceiving"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtInvtyCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMRSNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSuppName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPORef As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DELELTEITEMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtReceived As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDelivered As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents chkboxLessVat As System.Windows.Forms.CheckBox
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
