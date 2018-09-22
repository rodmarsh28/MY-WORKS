<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayroll))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbldeductions = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCA = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPhilhealthLoan = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPagibigLoah = New System.Windows.Forms.TextBox()
        Me.txtSSSLoan = New System.Windows.Forms.TextBox()
        Me.txtPhilhealth = New System.Windows.Forms.TextBox()
        Me.txtPagibig = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.txtlate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtOvertime = New System.Windows.Forms.TextBox()
        Me.txtLeavepay = New System.Windows.Forms.TextBox()
        Me.txtNonWorkingHolidays = New System.Windows.Forms.TextBox()
        Me.txtRegularHolidays = New System.Windows.Forms.TextBox()
        Me.txtregularWorkedDays = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRW = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPayMethod = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDR = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtemID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtrDH = New System.Windows.Forms.DateTimePicker()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dtrTo = New System.Windows.Forms.DateTimePicker()
        Me.dtrFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 605)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Location = New System.Drawing.Point(27, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 75)
        Me.Panel2.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(219, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(304, 35)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Manual Payroll"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(406, 549)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 30)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(287, 549)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 30)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.lbldeductions)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtCA)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtPhilhealthLoan)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtPagibigLoah)
        Me.GroupBox2.Controls.Add(Me.txtSSSLoan)
        Me.GroupBox2.Controls.Add(Me.txtPhilhealth)
        Me.GroupBox2.Controls.Add(Me.txtPagibig)
        Me.GroupBox2.Controls.Add(Me.txtSSS)
        Me.GroupBox2.Controls.Add(Me.txtlate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 257)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deductions"
        '
        'lbldeductions
        '
        Me.lbldeductions.AutoSize = True
        Me.lbldeductions.Location = New System.Drawing.Point(205, 231)
        Me.lbldeductions.Name = "lbldeductions"
        Me.lbldeductions.Size = New System.Drawing.Size(58, 13)
        Me.lbldeductions.TabIndex = 26
        Me.lbldeductions.Text = "                 "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(47, 234)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Total Deductions"
        '
        'txtCA
        '
        Me.txtCA.Location = New System.Drawing.Point(198, 203)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(100, 20)
        Me.txtCA.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(37, 206)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Cash Advance"
        '
        'txtPhilhealthLoan
        '
        Me.txtPhilhealthLoan.Enabled = False
        Me.txtPhilhealthLoan.Location = New System.Drawing.Point(198, 177)
        Me.txtPhilhealthLoan.Name = "txtPhilhealthLoan"
        Me.txtPhilhealthLoan.Size = New System.Drawing.Size(100, 20)
        Me.txtPhilhealthLoan.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(37, 180)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Philhealth Loan"
        '
        'txtPagibigLoah
        '
        Me.txtPagibigLoah.Enabled = False
        Me.txtPagibigLoah.Location = New System.Drawing.Point(198, 151)
        Me.txtPagibigLoah.Name = "txtPagibigLoah"
        Me.txtPagibigLoah.Size = New System.Drawing.Size(100, 20)
        Me.txtPagibigLoah.TabIndex = 20
        '
        'txtSSSLoan
        '
        Me.txtSSSLoan.Enabled = False
        Me.txtSSSLoan.Location = New System.Drawing.Point(198, 125)
        Me.txtSSSLoan.Name = "txtSSSLoan"
        Me.txtSSSLoan.Size = New System.Drawing.Size(100, 20)
        Me.txtSSSLoan.TabIndex = 19
        '
        'txtPhilhealth
        '
        Me.txtPhilhealth.Enabled = False
        Me.txtPhilhealth.Location = New System.Drawing.Point(198, 99)
        Me.txtPhilhealth.Name = "txtPhilhealth"
        Me.txtPhilhealth.Size = New System.Drawing.Size(100, 20)
        Me.txtPhilhealth.TabIndex = 18
        '
        'txtPagibig
        '
        Me.txtPagibig.Enabled = False
        Me.txtPagibig.Location = New System.Drawing.Point(198, 73)
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.Size = New System.Drawing.Size(100, 20)
        Me.txtPagibig.TabIndex = 17
        '
        'txtSSS
        '
        Me.txtSSS.Enabled = False
        Me.txtSSS.Location = New System.Drawing.Point(198, 47)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(100, 20)
        Me.txtSSS.TabIndex = 16
        '
        'txtlate
        '
        Me.txtlate.Location = New System.Drawing.Point(198, 18)
        Me.txtlate.Name = "txtlate"
        Me.txtlate.Size = New System.Drawing.Size(100, 20)
        Me.txtlate.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Pag-ibig Loan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "SSS Loan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(37, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Pag-ibig Premiums"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "PhilHealth Premiums"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "SSS Premiums"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Late / Undertime ( mins )"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.lblGrossPay)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtOvertime)
        Me.GroupBox1.Controls.Add(Me.txtLeavepay)
        Me.GroupBox1.Controls.Add(Me.txtNonWorkingHolidays)
        Me.GroupBox1.Controls.Add(Me.txtRegularHolidays)
        Me.GroupBox1.Controls.Add(Me.txtregularWorkedDays)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblRW)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 257)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Addjustment"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(253, 164)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(55, 13)
        Me.lblGrossPay.TabIndex = 28
        Me.lblGrossPay.Text = "                "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(39, 164)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Gross Pay"
        '
        'txtOvertime
        '
        Me.txtOvertime.Location = New System.Drawing.Point(229, 122)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Size = New System.Drawing.Size(100, 20)
        Me.txtOvertime.TabIndex = 20
        '
        'txtLeavepay
        '
        Me.txtLeavepay.Location = New System.Drawing.Point(229, 96)
        Me.txtLeavepay.Name = "txtLeavepay"
        Me.txtLeavepay.Size = New System.Drawing.Size(100, 20)
        Me.txtLeavepay.TabIndex = 19
        '
        'txtNonWorkingHolidays
        '
        Me.txtNonWorkingHolidays.Location = New System.Drawing.Point(229, 70)
        Me.txtNonWorkingHolidays.Name = "txtNonWorkingHolidays"
        Me.txtNonWorkingHolidays.Size = New System.Drawing.Size(100, 20)
        Me.txtNonWorkingHolidays.TabIndex = 18
        '
        'txtRegularHolidays
        '
        Me.txtRegularHolidays.Location = New System.Drawing.Point(229, 44)
        Me.txtRegularHolidays.Name = "txtRegularHolidays"
        Me.txtRegularHolidays.Size = New System.Drawing.Size(100, 20)
        Me.txtRegularHolidays.TabIndex = 16
        '
        'txtregularWorkedDays
        '
        Me.txtregularWorkedDays.Location = New System.Drawing.Point(229, 18)
        Me.txtregularWorkedDays.Name = "txtregularWorkedDays"
        Me.txtregularWorkedDays.Size = New System.Drawing.Size(100, 20)
        Me.txtregularWorkedDays.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Overtime ( hrs ) / Restday Report"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Leave with Pay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Special / Non Working Holidays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Regular Holidays"
        '
        'lblRW
        '
        Me.lblRW.AutoSize = True
        Me.lblRW.Location = New System.Drawing.Point(26, 25)
        Me.lblRW.Name = "lblRW"
        Me.lblRW.Size = New System.Drawing.Size(112, 13)
        Me.lblRW.TabIndex = 9
        Me.lblRW.Text = "Regular Worked Days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(46, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Position :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(46, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.txtPayMethod)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtDR)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.txtemID)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtrDH)
        Me.Panel3.Controls.Add(Me.txtPos)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.dtrTo)
        Me.Panel3.Controls.Add(Me.dtrFrom)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.lblNetPay)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Location = New System.Drawing.Point(27, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(742, 495)
        Me.Panel3.TabIndex = 17
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(659, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 12)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "DD/MM/YYYY"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(563, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 12)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "DD/MM/YYYY"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(113, 150)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 12)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "DD/MM/YYYY"
        '
        'txtPayMethod
        '
        Me.txtPayMethod.Enabled = False
        Me.txtPayMethod.Location = New System.Drawing.Point(105, 99)
        Me.txtPayMethod.Name = "txtPayMethod"
        Me.txtPayMethod.Size = New System.Drawing.Size(80, 20)
        Me.txtPayMethod.TabIndex = 44
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.Location = New System.Drawing.Point(19, 102)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 13)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Pay Method :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDR
        '
        Me.txtDR.Enabled = False
        Me.txtDR.Location = New System.Drawing.Point(235, 99)
        Me.txtDR.Name = "txtDR"
        Me.txtDR.Size = New System.Drawing.Size(80, 20)
        Me.txtDR.TabIndex = 41
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.SteelBlue
        Me.Label20.Location = New System.Drawing.Point(193, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Rate :"
        '
        'txtemID
        '
        Me.txtemID.Enabled = False
        Me.txtemID.Location = New System.Drawing.Point(105, 12)
        Me.txtemID.Name = "txtemID"
        Me.txtemID.Size = New System.Drawing.Size(114, 20)
        Me.txtemID.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Employee ID:"
        '
        'dtrDH
        '
        Me.dtrDH.Enabled = False
        Me.dtrDH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtrDH.Location = New System.Drawing.Point(105, 127)
        Me.dtrDH.Name = "dtrDH"
        Me.dtrDH.Size = New System.Drawing.Size(80, 20)
        Me.dtrDH.TabIndex = 39
        '
        'txtPos
        '
        Me.txtPos.Enabled = False
        Me.txtPos.Location = New System.Drawing.Point(105, 71)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(210, 20)
        Me.txtPos.TabIndex = 38
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(105, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(210, 20)
        Me.txtName.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(19, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date Hired :"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(225, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 20)
        Me.Button5.TabIndex = 18
        Me.Button5.UseVisualStyleBackColor = False
        '
        'dtrTo
        '
        Me.dtrTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtrTo.Location = New System.Drawing.Point(652, 8)
        Me.dtrTo.Name = "dtrTo"
        Me.dtrTo.Size = New System.Drawing.Size(80, 20)
        Me.dtrTo.TabIndex = 36
        '
        'dtrFrom
        '
        Me.dtrFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtrFrom.Location = New System.Drawing.Point(555, 8)
        Me.dtrFrom.Name = "dtrFrom"
        Me.dtrFrom.Size = New System.Drawing.Size(80, 20)
        Me.dtrFrom.TabIndex = 35
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(637, 11)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "-"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(511, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Date:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(597, 56)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(94, 24)
        Me.lblNetPay.TabIndex = 30
        Me.lblNetPay.Text = "              "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(503, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 24)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Net Pay"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(820, 629)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayroll"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCA As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPhilhealthLoan As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPagibigLoah As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSLoan As System.Windows.Forms.TextBox
    Friend WithEvents txtPhilhealth As System.Windows.Forms.TextBox
    Friend WithEvents txtPagibig As System.Windows.Forms.TextBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtlate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOvertime As System.Windows.Forms.TextBox
    Friend WithEvents txtLeavepay As System.Windows.Forms.TextBox
    Friend WithEvents txtNonWorkingHolidays As System.Windows.Forms.TextBox
    Friend WithEvents txtRegularHolidays As System.Windows.Forms.TextBox
    Friend WithEvents txtregularWorkedDays As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRW As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lbldeductions As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtrDH As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPos As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents dtrTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtrFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtemID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDR As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPayMethod As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
