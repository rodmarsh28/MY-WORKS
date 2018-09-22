<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckVoucher
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCVNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPayee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTIN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPreparedBy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCheckedBy = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApprovedBy = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblDebit = New System.Windows.Forms.Label()
        Me.lblTotAmount = New System.Windows.Forms.Label()
        Me.txtAmountinWords = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgw1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgw)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 160)
        Me.GroupBox1.TabIndex = 21
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
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw.GridColor = System.Drawing.Color.LightGray
        Me.dgw.Location = New System.Drawing.Point(3, 16)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersVisible = False
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(471, 141)
        Me.dgw.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "PARTICULARS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 340
        '
        'Column2
        '
        Me.Column2.HeaderText = "AMOUNT"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'txtCVNo
        '
        Me.txtCVNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCVNo.Enabled = False
        Me.txtCVNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVNo.Location = New System.Drawing.Point(140, 12)
        Me.txtCVNo.Name = "txtCVNo"
        Me.txtCVNo.Size = New System.Drawing.Size(125, 20)
        Me.txtCVNo.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "CV NO :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "DATE :"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(140, 57)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(97, 20)
        Me.dtpDate.TabIndex = 1
        '
        'txtPayee
        '
        Me.txtPayee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPayee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayee.Location = New System.Drawing.Point(203, 110)
        Me.txtPayee.Name = "txtPayee"
        Me.txtPayee.Size = New System.Drawing.Size(359, 20)
        Me.txtPayee.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "PAYEE :"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(203, 136)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(359, 20)
        Me.txtAddress.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "ADDRESS :"
        '
        'txtTIN
        '
        Me.txtTIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIN.Location = New System.Drawing.Point(140, 79)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(125, 20)
        Me.txtTIN.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "TIN NO :"
        '
        'txtBankName
        '
        Me.txtBankName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBankName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(203, 165)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(359, 20)
        Me.txtBankName.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "BANK NAME :"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNo.Location = New System.Drawing.Point(203, 191)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(359, 20)
        Me.txtCheckNo.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "CHECK NO :"
        '
        'txtPreparedBy
        '
        Me.txtPreparedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreparedBy.Enabled = False
        Me.txtPreparedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparedBy.Location = New System.Drawing.Point(203, 217)
        Me.txtPreparedBy.Name = "txtPreparedBy"
        Me.txtPreparedBy.Size = New System.Drawing.Size(359, 20)
        Me.txtPreparedBy.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "PREPARED BY :"
        '
        'txtCheckedBy
        '
        Me.txtCheckedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheckedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckedBy.Location = New System.Drawing.Point(203, 243)
        Me.txtCheckedBy.Name = "txtCheckedBy"
        Me.txtCheckedBy.Size = New System.Drawing.Size(359, 20)
        Me.txtCheckedBy.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "CHECKED BY :"
        '
        'txtApprovedBy
        '
        Me.txtApprovedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApprovedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApprovedBy.Location = New System.Drawing.Point(203, 269)
        Me.txtApprovedBy.Name = "txtApprovedBy"
        Me.txtApprovedBy.Size = New System.Drawing.Size(359, 20)
        Me.txtApprovedBy.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "APPROVED BY :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCredit)
        Me.GroupBox2.Controls.Add(Me.lblDebit)
        Me.GroupBox2.Controls.Add(Me.lblTotAmount)
        Me.GroupBox2.Controls.Add(Me.txtAmountinWords)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(586, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 175)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(109, 67)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(27, 12)
        Me.lblCredit.TabIndex = 109
        Me.lblCredit.Text = "0.00"
        '
        'lblDebit
        '
        Me.lblDebit.AutoSize = True
        Me.lblDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebit.Location = New System.Drawing.Point(109, 43)
        Me.lblDebit.Name = "lblDebit"
        Me.lblDebit.Size = New System.Drawing.Size(27, 12)
        Me.lblDebit.TabIndex = 108
        Me.lblDebit.Text = "0.00"
        '
        'lblTotAmount
        '
        Me.lblTotAmount.AutoSize = True
        Me.lblTotAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotAmount.Location = New System.Drawing.Point(109, 15)
        Me.lblTotAmount.Name = "lblTotAmount"
        Me.lblTotAmount.Size = New System.Drawing.Size(27, 12)
        Me.lblTotAmount.TabIndex = 107
        Me.lblTotAmount.Text = "0.00"
        '
        'txtAmountinWords
        '
        Me.txtAmountinWords.Location = New System.Drawing.Point(8, 106)
        Me.txtAmountinWords.Name = "txtAmountinWords"
        Me.txtAmountinWords.ReadOnly = True
        Me.txtAmountinWords.Size = New System.Drawing.Size(457, 63)
        Me.txtAmountinWords.TabIndex = 106
        Me.txtAmountinWords.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 12)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "AMOUNT IN WORDS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 12)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "TOTAL CREDIT :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 12)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "TOTAL DEBIT :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 12)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "TOTAL AMOUNT :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgw1)
        Me.GroupBox3.Location = New System.Drawing.Point(580, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 160)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'dgw1
        '
        Me.dgw1.AllowUserToAddRows = False
        Me.dgw1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue
        Me.dgw1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgw1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column3})
        Me.dgw1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgw1.GridColor = System.Drawing.Color.LightGray
        Me.dgw1.Location = New System.Drawing.Point(3, 16)
        Me.dgw1.MultiSelect = False
        Me.dgw1.Name = "dgw1"
        Me.dgw1.ReadOnly = True
        Me.dgw1.RowHeadersVisible = False
        Me.dgw1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw1.Size = New System.Drawing.Size(471, 141)
        Me.dgw1.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "ACCNO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ACCOUNTING ENTRY"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 245
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "DEBIT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "CREDIT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(453, 488)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 39)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(571, 488)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(112, 39)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(467, 309)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(980, 309)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(33, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "+"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtReqNo
        '
        Me.txtReqNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReqNo.Enabled = False
        Me.txtReqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqNo.Location = New System.Drawing.Point(140, 34)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(125, 20)
        Me.txtReqNo.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "REQUEST NO :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(506, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1019, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 23)
        Me.Button2.TabIndex = 112
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(435, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(267, 31)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "CHECK VOUCHER"
        '
        'frmCheckVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 555)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtReqNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtApprovedBy)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCheckedBy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPreparedBy)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBankName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTIN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPayee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCVNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCheckVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCheckVoucher"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgw1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents txtCVNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPayee As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTIN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPreparedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCheckedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtApprovedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgw1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblDebit As System.Windows.Forms.Label
    Friend WithEvents lblTotAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmountinWords As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
