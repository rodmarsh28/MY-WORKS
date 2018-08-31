Public Class frmPayroll
    Public field As String
    Public rate As Double
    Public empid As String
    Public premDed As String
    Public sssNo As Boolean
    Public phNo As Boolean
    Public piNo As Boolean
    Dim regularWorkedDays As Double
    Dim regularHolidays As Double
    Dim nonWorkingHolidays As Double
    Dim leavePay As Double
    Dim overtime As Double
    Dim grossPay As Double
    Dim late As Double
    Dim sss As Double
    Dim sssER As Double
    Dim pagibig As Double
    Dim pagibigER As Double
    Dim philhealth As Double
    Dim philhealthER As Double
    Dim sssloan As Double
    Dim pagibigloan As Double
    Dim philhealthloan As Double
    Dim cashAdvance As Double
    Dim totalDeduction As Double
    Dim netPay As Double
    Dim basicpay As Double
    Dim absentinamount As Double
    Dim regularholiday As Double
    Dim nonworkingholiday As Double
    Dim leavepaycash As Double
    Dim overtimecash As Double
    Dim latecash As Double
    Dim lastnetpay As Double
    Dim id As String
    Dim absent As Double
    Dim stats As Boolean

    Dim totalEmployees As Integer = 0
    Dim totalOT As Double = 0.0
    Dim totalGrossPay As Double = 0.0
    Dim totalDeductions As Double = 0.0
    Dim totalNetpay As Double = 0.0

    Dim xempid As String
    Dim xabsent As String
    Dim xregHol As String
    Dim xnonRegHol As String
    Dim xlp As String
    Dim xot As String
    Dim xlate As String
    Dim xbp As String
    Dim xam As String
    Dim xrhp As String
    Dim xnwhp As String
    Dim xlpc As String
    Dim xotp As String
    Dim xlateded As String
    Dim xca As String
    Dim xtax As String
    Dim xsssprem As String
    Dim xpiprem As String
    Dim xphprem As String
    Dim xsssER As String
    Dim xpiER As String
    Dim xphER As String
    Dim xsssloan As String
    Dim xpiloan As String
    Dim xledgerBalance As String
    Dim xgp As String
    Dim xdeductions As String
    Dim xnp As String




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    
    Sub clear()
        txtregularWorkedDays.Text = "0"
        txtRegularHolidays.Text = "0"
        txtNonWorkingHolidays.Text = "0"
        txtLeavepay.Text = "0"
        txtOvertime.Text = "0"
        lblGrossPay.Text = "0.00"

        txtSSS.Text = "0.00"
        txtPagibig.Text = "0.00"
        txtPhilhealth.Text = "0.00"
        sssER = "0.00"
        pagibigER = "0.00"
        philhealthER = "0.00"
        txtSSSLoan.Text = "0.00"
        txtPagibigLoah.Text = "0.00"
        txtLedgerBalance.Text = "0.00"
        txtCA.Text = "0.00"
        lbldeductions.Text = "0.00"
        lblNetPay.Text = "0.00"
    End Sub
    Sub clearForm()
        dgw.Rows.Clear()
        txtemID.Text = ""
        txtName.Text = ""
        txtPos.Text = ""
        txtPayMethod.Text = ""
        txtDR.Text = ""
        dtrDH.Value = Now
        dtrFrom.Value = Now
        dtrTo.Value = Now
        lblTotEmp.Text = "0"
        lblTotOT.Text = "0.00"
        lblGrossPay.Text = "0.00"
        lblTotDed.Text = "0.00"
        lblTotNet.Text = "0.00"
    End Sub
    Sub printPayroll()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            Dim c As Integer
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT dbo.tblPayroll.payrollID,dbo.tblPayroll.dateFrom,dbo.tblPayroll.dateTo,dbo.tblEmployee.empid,dbo.tblEmployee.lastname," & _
                                "dbo.tblEmployee.firstname,dbo.tblEmployee.middlename,dbo.tblPayrollofEmployees.absent,dbo.tblPayrollofEmployees.regHolidays," & _
                                "dbo.tblPayrollofEmployees.NonWorkHolidays,dbo.tblPayrollofEmployees.leavePay,dbo.tblPayrollofEmployees.overtimeHRS," & _
                                "dbo.tblPayrollofEmployees.lateUTMins,dbo.tblPayrollofEmployees.basicPay,dbo.tblPayrollofEmployees.regHolidayPay," & _
                                "dbo.tblPayrollofEmployees.nonWorkHolidayPay,dbo.tblPayrollofEmployees.leavePayCash,dbo.tblPayrollofEmployees.overtimePay," & _
                                "dbo.tblPayrollofEmployees.lateUndertimeDed,dbo.tblPayrollofEmployees.sssPrems,dbo.tblPayrollofEmployees.piPrems,dbo.tblPayrollofEmployees.phPrems," & _
                                "dbo.tblPayrollofEmployees.sssLoans,dbo.tblPayrollofEmployees.piLoans,dbo.tblPayrollofEmployees.phLoans,dbo.tblPayrollofEmployees.cashAdvance," & _
                                "dbo.tblPayrollofEmployees.grossPay,dbo.tblPayrollofEmployees.Deduction,dbo.tblPayrollofEmployees.Netpay,dbo.tblPayroll.totalDeduction," & _
                                "dbo.tblPayroll.totalGrossPay,dbo.tblPayroll.totalNetpay FROM dbo.tblPayroll INNER JOIN dbo.tblPayrollofEmployees ON dbo.tblPayroll.payrollID = " & _
                                "dbo.tblPayrollofEmployees.payrollID INNER JOIN dbo.tblEmployee ON dbo.tblEmployee.empid = dbo.tblPayrollofEmployees.empID " & _
                                " where dbo.tblPayroll.payrollID = '" & lblPRID.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("payrollID")
                .Columns.Add("DATERANGE")
                .Columns.Add("Name")
                .Columns.Add("Worked Days")
                .Columns.Add("Holidays")
                .Columns.Add("NonWorkingHolidays")
                .Columns.Add("leavepay")
                .Columns.Add("overtime(HRS)")
                .Columns.Add("lateundertime(min)")
                .Columns.Add("Basic Pay")
                .Columns.Add("RegularHolidayCash")
                .Columns.Add("NonWorkingHolidaysCash")
                .Columns.Add("Leave Pay")
                .Columns.Add("Overtime / Restday Report")
                .Columns.Add("Gross Pay")
                .Columns.Add("Late / Undertime")
                .Columns.Add("SSS Premiums")
                .Columns.Add("Pagibig Premiums")
                .Columns.Add("Philhealth Premiums")
                .Columns.Add("SSS Loans")
                .Columns.Add("Pagibig Loans")
                .Columns.Add("Philhealth Loans")
                .Columns.Add("Cash Advance")
                .Columns.Add("Total Deduction")
                .Columns.Add("Net Pay")
                .Columns.Add("DATE")
                .Columns.Add("totalAllDed")
                .Columns.Add("totalAllGross")
                .Columns.Add("totalallNet")
                .Columns.Add("PreparedBy")

            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MMMM") & " " & Format(OleDBDR.Item(1), "dd") & " - " + Format(OleDBDR.Item(2), "dd") & " " & Format(OleDBDR.Item(2), "yyyy"),
                                OleDBDR.Item(4) & ", " & OleDBDR.Item(5) & " " & OleDBDR.Item(6), OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9),
                                OleDBDR.Item(10), Format(OleDBDR.Item(11), "0.0"), Format(OleDBDR.Item(12), "0.0"), Format(OleDBDR.Item(13), "0.00"), Format(OleDBDR.Item(14), "0.00"),
                                Format(OleDBDR.Item(15), "0.00"), Format(OleDBDR.Item(16), "0.00"), Format(OleDBDR.Item(17), "0.00"), Format(OleDBDR.Item(18), "0.00"),
                                Format(OleDBDR.Item(19), "0.00"), Format(OleDBDR.Item(20), "0.00"), Format(OleDBDR.Item(21), "0.00"), Format(OleDBDR.Item(22), "0.00"),
                                Format(OleDBDR.Item(23), "0.00"), Format(OleDBDR.Item(24), "0.00"), Format(OleDBDR.Item(25), "0.00"), Format(OleDBDR.Item(26), "0.00"),
                                Format(OleDBDR.Item(27), "0.00"), Format(OleDBDR.Item(28), "0.00"), Format(Now, "MM/dd/yyyy"), Format(OleDBDR.Item(29), "0.00"),
                                Format(OleDBDR.Item(30), "0.00"), Format(OleDBDR.Item(31), "0.00"), frmMain.lblUsername.Text)
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New GFLS_Payroll
            rptDoc.SetDataSource(dt)
            frmReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmReportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub generatePayrollID()
        Dim StrID As String
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblPayroll order by PAYROLLID DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 6, Len(OleDBDR(0)))
                lblPRID.Text = "PR-" & Format(Val(StrID) + 1, "00000")
            Else
                lblPRID.Text = "PR-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub frmPayroll_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ForeColorChanged

    End Sub

    Private Sub frmPayroll_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear()
        clearForm()
    End Sub

    Private Sub frmPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
        frmEmployeeName.searchExisting()
        frmEmployeeName.showEmployee()
        generatePayrollID()
        If databaseMode = "Utility" Then
            txtSSSLoan.Enabled = False
            txtPagibigLoah.Enabled = False
        Else
            If frmDateGenerator.isLastDay = True Then
                txtSSSLoan.Enabled = False
                txtPagibigLoah.Enabled = False

            Else
                txtSSSLoan.Enabled = True
                txtPagibigLoah.Enabled = True

            End If
        End If
        lblTotEmp.Text = dgw.RowCount
        totalOT = 0.0
        totalGrossPay = 0.0
        totalDeductions = 0.0
        totalNetpay = 0.0

        lblTotOT.Text = Format(totalOT, "N")
        lblTotGP.Text = Format(totalGrossPay, "N")
        lblTotDed.Text = Format(totalDeductions, "N")
        lblTotNet.Text = Format(totalNetpay, "N")
    End Sub


    Sub selectLastNetpay()
        Dim dtr1 As Date = Format(DateAdd("d", -15, dtrFrom.Value), "MM/dd/yyyy")

        'MsgBox(dtr1)
        'MsgBox(dtr2)
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT dbo.tblPayrollofEmployees.grossPay FROM dbo.tblPayrollofEmployees INNER JOIN dbo.tblPayroll ON dbo.tblPayroll.payrollID = dbo.tblPayrollofEmployees.payrollID" & _
                                " where dbo.tblPayroll.datefrom = '" & dtr1 & "' and dbo.tblPayrollofEmployees.EMPID  = '" & txtemID.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    lastnetpay = OleDBDR.Item(0)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()

        End Try
    End Sub

    Sub deductions()
        convertZero()
        Dim Year As DateTime = dtrFrom.Value
        Dim month As DateTime = dtrFrom.Value
        Dim years As Integer = Year.Year
        Dim months As Integer = month.Month
        Dim days As Integer = System.DateTime.DaysInMonth(years, months)

        regularWorkedDays = txtregularWorkedDays.Text
        regularHolidays = txtRegularHolidays.Text
        nonWorkingHolidays = txtNonWorkingHolidays.Text
        leavePay = txtLeavepay.Text
        overtime = txtOvertime.Text
        absent = 0
        late = 0
        If txtPayMethod.Text = "Daily" Then
            Dim totalabsent As Integer
            basicpay = txtDR.Text * regularWorkedDays
            totalabsent = regularWorkedDays - DateDiff(DateInterval.Day, dtrTo.Value, dtrFrom.Value)
            absentinamount = txtDR.Text * totalabsent
            latecash = (txtDR.Text / 8 / 60) * late
            regularholiday = txtDR.Text * regularHolidays
            nonworkingholiday = txtDR.Text * 0.3 * nonWorkingHolidays
            leavepaycash = txtDR.Text * leavePay
            If field = "Stay In" Then

                overtimecash = txtDR.Text * overtime
            Else
                overtimecash = (txtDR.Text / 8) * overtime
            End If
        Else

            basicpay = (txtDR.Text / 2)
            absentinamount = txtDR.Text / 26 / 8 * regularWorkedDays
            latecash = (txtDR.Text / 26 / 8 / 60) * late
            regularholiday = (txtDR.Text / 26) * regularHolidays
            nonworkingholiday = (txtDR.Text / 26) * 0.3 * nonWorkingHolidays
            leavepaycash = (txtDR.Text / 26) * leavePay
            If field = "Stay In" Then

                overtimecash = (txtDR.Text / 26) * overtime
            Else
                overtimecash = (txtDR.Text / 26 / 8) * overtime
            End If
        End If

        Dim totgross As Double
        totgross = basicpay + regularholiday + nonworkingholiday + leavepaycash + overtimecash - absentinamount
        lblGrossPay.Text = Format(totgross, "0.00")
        grossPay = lblGrossPay.Text


        'Dim daydate As DateTime = dtrTo.Value
        If frmDateGenerator.isLastDay = True Then
            selectLastNetpay()

        End If

        If premDed = "Yes" Then

            If frmDateGenerator.isLastDay = True Then
                grossPay = grossPay + lastnetpay
                If phNo = True Then
                    'If grossPay <= 10000 Then
                    '    txtPhilhealth.Text = "137.50"
                    'ElseIf grossPay <= 39999 Then
                    '    txtPhilhealth.Text = Format(grossPay * 0.0275 / 2, "0.00")

                    'Else
                    '    txtPhilhealth.Text = "550.00"
                    'End If
                    If grossPay <= 8999.99 Then
                        txtPhilhealth.Text = "100"
                    ElseIf grossPay <= 9999.99 Then
                        txtPhilhealth.Text = "112.50"
                    ElseIf grossPay <= 10999.99 Then
                        txtPhilhealth.Text = "125"
                    ElseIf grossPay <= 11999.99 Then
                        txtPhilhealth.Text = "137.50"
                    ElseIf grossPay <= 12999.99 Then
                        txtPhilhealth.Text = "150"
                    ElseIf grossPay <= 13999.99 Then
                        txtPhilhealth.Text = "162.50"
                    ElseIf grossPay <= 14999.99 Then
                        txtPhilhealth.Text = "175"
                    ElseIf grossPay <= 15999.99 Then
                        txtPhilhealth.Text = "187.50"
                    ElseIf grossPay <= 16999.99 Then
                        txtPhilhealth.Text = "200"
                    ElseIf grossPay <= 17999.99 Then
                        txtPhilhealth.Text = "212.50"
                    ElseIf grossPay <= 18999.99 Then
                        txtPhilhealth.Text = "225"
                    ElseIf grossPay <= 19999.99 Then
                        txtPhilhealth.Text = "237.50"
                    ElseIf grossPay <= 20999.99 Then
                        txtPhilhealth.Text = "250"
                    ElseIf grossPay <= 21999.99 Then
                        txtPhilhealth.Text = "262.50"
                    ElseIf grossPay <= 22999.99 Then
                        txtPhilhealth.Text = "275"
                    ElseIf grossPay <= 23999.99 Then
                        txtPhilhealth.Text = "287.50"
                    ElseIf grossPay <= 24999.99 Then
                        txtPhilhealth.Text = "300"
                    ElseIf grossPay <= 25999.99 Then
                        txtPhilhealth.Text = "312.50"
                    ElseIf grossPay <= 26999.99 Then
                        txtPhilhealth.Text = "325"
                    ElseIf grossPay <= 27999.99 Then
                        txtPhilhealth.Text = "337.50"
                    ElseIf grossPay <= 28999.99 Then
                        txtPhilhealth.Text = "350"
                    ElseIf grossPay <= 29999.99 Then
                        txtPhilhealth.Text = "362.50"
                    ElseIf grossPay <= 30999.99 Then
                        txtPhilhealth.Text = "375"
                    ElseIf grossPay <= 31999.99 Then
                        txtPhilhealth.Text = "387.50"
                    ElseIf grossPay <= 32999.99 Then
                        txtPhilhealth.Text = "400"
                    ElseIf grossPay <= 33999.99 Then
                        txtPhilhealth.Text = "412.50"
                    ElseIf grossPay <= 34999.99 Then
                        txtPhilhealth.Text = "425"
                    Else
                        txtPhilhealth.Text = "437.50"
                    End If
                Else
                    txtPhilhealth.Text = "0.00"
                End If
                    philhealthER = txtPhilhealth.Text
                    If sssNo = True Then
                        If grossPay <= 1249.99 Then
                            txtSSS.Text = 36.3
                            sssER = 83.7
                        ElseIf grossPay <= 1749.99 Then
                            txtSSS.Text = 54.5
                            sssER = 120.5
                        ElseIf grossPay <= 2249.99 Then
                            txtSSS.Text = 72.7
                            sssER = 157.3
                        ElseIf grossPay <= 2749.99 Then
                            txtSSS.Text = 90.8
                            sssER = 194.2
                        ElseIf grossPay <= 3249.99 Then
                            txtSSS.Text = 109
                            sssER = 231
                        ElseIf grossPay <= 3749.99 Then
                            txtSSS.Text = 127.2
                            sssER = 267.8
                        ElseIf grossPay <= 4249.99 Then
                            txtSSS.Text = 145.3
                            sssER = 304.7
                        ElseIf grossPay <= 4749.99 Then
                            txtSSS.Text = 163.5
                            sssER = 341.5
                        ElseIf grossPay <= 5249.99 Then
                            txtSSS.Text = 181.7
                            sssER = 378.3
                        ElseIf grossPay <= 5749.99 Then
                            txtSSS.Text = 199.8
                            sssER = 415.2
                        ElseIf grossPay <= 6249.99 Then
                            txtSSS.Text = 218
                            sssER = 452
                        ElseIf grossPay <= 6749.99 Then
                            txtSSS.Text = 236.2
                            sssER = 488.8
                        ElseIf grossPay <= 7249.99 Then
                            txtSSS.Text = 254.3
                            sssER = 525.7
                        ElseIf grossPay <= 7749.99 Then
                            txtSSS.Text = 272.5
                            sssER = 562.5
                        ElseIf grossPay <= 8249.99 Then
                            txtSSS.Text = 290.7
                            sssER = 599.3
                        ElseIf grossPay <= 8749.99 Then
                            txtSSS.Text = 308.8
                            sssER = 636.2
                        ElseIf grossPay <= 9249.99 Then
                            txtSSS.Text = 327
                            sssER = 673
                        ElseIf grossPay <= 9749.99 Then
                            txtSSS.Text = 345.2
                            sssER = 709.8
                        ElseIf grossPay <= 10249.99 Then
                            txtSSS.Text = 363.3
                            sssER = 746.7
                        ElseIf grossPay <= 10749.99 Then
                            txtSSS.Text = 381.5
                            sssER = 783.5
                        ElseIf grossPay <= 11249.99 Then
                            txtSSS.Text = 399.7
                            sssER = 820.3
                        ElseIf grossPay <= 11749.99 Then
                            txtSSS.Text = 417.8
                            sssER = 857.2
                        ElseIf grossPay <= 12249.99 Then
                            txtSSS.Text = 436
                            sssER = 894
                        ElseIf grossPay <= 12749.99 Then
                            txtSSS.Text = 454.2
                            sssER = 930.8
                        ElseIf grossPay <= 13249.99 Then
                            txtSSS.Text = 472.3
                            sssER = 967.7
                        ElseIf grossPay <= 13749.99 Then
                            txtSSS.Text = 490.5
                            sssER = 1004.5
                        ElseIf grossPay <= 14249.99 Then
                            txtSSS.Text = 508.7
                            sssER = 1041.3
                        ElseIf grossPay <= 14749.99 Then
                            txtSSS.Text = 526.8
                            sssER = 1078.2
                        ElseIf grossPay <= 15249.99 Then
                            txtSSS.Text = 545
                            sssER = 1135
                        ElseIf grossPay <= 15749.99 Then
                            txtSSS.Text = 563.2
                            sssER = 1171.8
                        ElseIf grossPay <= 16249.99 Or grossPay >= 16249.99 Then
                            txtSSS.Text = 581.3
                            sssER = 1208.7
                        End If
                    Else
                        txtSSS.Text = "0.00"
                        sssER = 0.0
                    End If
                    If piNo = True Then
                        If grossPay <= 1500 Then
                            txtPagibig.Text = Format(grossPay * 0.02, "0.00")
                            pagibigER = Format(grossPay * 0.01, "0.00")
                        Else
                            txtPagibig.Text = Format(grossPay * 0.02, "0.00")
                            pagibigER = Format(grossPay * 0.02, "0.00")
                        End If
                    Else
                        txtPagibig.Text = "0.00"
                        pagibigER = 0.0
                    End If
                    grossPay = grossPay - lastnetpay
                Else
                    txtSSS.Text = "0.00"
                    txtPagibig.Text = "0.00"
                    txtPhilhealth.Text = "0.00"


                End If
        Else
            txtSSS.Text = "0.00"
            txtPagibig.Text = "0.00"
            txtPhilhealth.Text = "0.00"
        End If

        late = 0
        sss = txtSSS.Text
        pagibig = txtPagibig.Text
        philhealth = txtPhilhealth.Text
        sssloan = txtSSSLoan.Text
        pagibigloan = txtPagibigLoah.Text
        philhealthloan = txtPagibigLoah.Text
        cashAdvance = txtCA.Text
        Dim totded As Double
        totded = sss + pagibig + philhealth + sssloan + pagibigloan + philhealthloan + cashAdvance + txtLedgerBalance.Text
        lbldeductions.Text = Format(totded, "0.00")

        totalDeduction = lbldeductions.Text
        netPay = grossPay - totalDeduction
        lblNetPay.Text = netPay



    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Sub getsunday()
        Dim DateStart As Date = Format(dtrFrom.Value, "Short Date")
        Dim EndDate As Date = Format(dtrTo.Value, "Short Date")
        Dim sun As Integer = 0
        For d As Double = DateStart.ToOADate To EndDate.ToOADate
            If Date.FromOADate(d).DayOfWeek = DayOfWeek.Sunday Then
                sun += 1
            End If
        Next
        MsgBox(sun)
    End Sub
    Sub convertZero()



        If txtregularWorkedDays.Text = "" Then
            txtregularWorkedDays.Text = "0"
        End If
        If txtRegularHolidays.Text = "" Then
            txtRegularHolidays.Text = "0"
        End If
        If txtNonWorkingHolidays.Text = "" Then
            txtNonWorkingHolidays.Text = "0"
        End If
        If txtLeavepay.Text = "" Then
            txtLeavepay.Text = "0"
        End If
        If txtOvertime.Text = "" Then
            txtOvertime.Text = "0"

        End If
      

        If txtCA.Text = "" Then
            txtCA.Text = "0"
        End If
    End Sub

    
    Sub selectExist()
        'Dim dtr1 As Date = Format(dtrFrom.Value, "MM/dd/yyyy")
        'Dim dtr2 As Date = Format(dtrFrom.Value, "MM/dd/yyyy")
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT dbo.tblPayrollofEmployees.Netpay FROM dbo.tblPayrollofEmployees INNER JOIN dbo.tblPayroll ON dbo.tblPayroll.payrollID = dbo.tblPayrollofEmployees.payrollID" & _
                                " where '" & Format(dtrFrom.Value, "MM/dd/yyyy") & "' between dbo.tblPayroll.DATEFROM and dbo.tblPayroll.DATETO" & _
                                 " or '" & Format(dtrTo.Value, "MM/dd/yyyy") & "' between dbo.tblPayroll.DATEFROM and dbo.tblPayroll.DATETO"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                MsgBox("you already save payroll on this date range", MsgBoxStyle.Critical, "sorry")
            Else
                save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Sub save()
        
            If MsgBox("Save Payroll?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                
                Try
                    If conn.State = ConnectionState.Open Then
                        OleDBC.Dispose()
                        conn.Close()
                    End If
                    If conn.State <> ConnectionState.Open Then
                        ConnectDatabase()
                End If
                ''"','" & dtrFrom.Value.ToString("MM/dd/yyyy") & _
                '"','" & dtrTo.Value.ToString("MM/dd/yyyy") & _
                With OleDBC
                    .Connection = conn
                    .CommandText = " INSERT INTO tblPayroll VALUES ('" & lblPRID.Text & _
                            "','" & Now.ToString("MM/dd/yyyy") &
                            "','" & dtrFrom.Value.ToString("MM/dd/yyyy") & _
                            "','" & dtrTo.Value.ToString("MM/dd/yyyy") & _
                            "','" & lblTotEmp.Text & _
                            "','" & lblTotOT.Text & _
                            "','" & lblTotGP.Text & _
                            "','" & lblTotDed.Text & _
                            "','" & lblTotNet.Text & _
                            "','" & frmMain.lblUsername.Text & _
                            "','" & "Payroll Generated:" & Today.ToString("MM/dd/yyyy") & "')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                MsgBox("Payroll Created Success", MsgBoxStyle.Information, "Success")
                dgw.Rows.Clear()
                Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

    End Sub
    Sub dgwItemProcess()
        
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            xempid = dgw.Item(0, col).Value
            xabsent = dgw.Item(2, col).Value
            xregHol = dgw.Item(3, col).Value
            xnonRegHol = dgw.Item(4, col).Value
            xlp = dgw.Item(5, col).Value
            xot = dgw.Item(6, col).Value
            xlate = dgw.Item(7, col).Value
            xbp = dgw.Item(8, col).Value
            xam = dgw.Item(9, col).Value
            xrhp = dgw.Item(10, col).Value
            xnwhp = dgw.Item(11, col).Value
            xlpc = dgw.Item(12, col).Value
            xotp = dgw.Item(13, col).Value
            xlateded = dgw.Item(14, col).Value
            xca = dgw.Item(15, col).Value
            xtax = dgw.Item(16, col).Value
            xsssprem = dgw.Item(17, col).Value
            xpiprem = dgw.Item(18, col).Value
            xphprem = dgw.Item(19, col).Value
            xsssloan = dgw.Item(20, col).Value
            xpiloan = dgw.Item(21, col).Value
            xledgerBalance = dgw.Item(22, col).Value
            xgp = dgw.Item(23, col).Value
            xdeductions = dgw.Item(24, col).Value
            xnp = dgw.Item(25, col).Value
            xsssER = dgw.Item(26, col).Value
            xpiER = dgw.Item(27, col).Value
            xphER = dgw.Item(28, col).Value
            saveEmployeesPayroll()
            If frmDateGenerator.isLastDay = True Then
                saveEmployERContribution()
            End If
            col = col + 1

        End While
    End Sub
    Sub saveEmployeesPayroll()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "insert into tblPayrollofEmployees VALUES('" & lblPRID.Text & _
                    "','" & xempid & _
                    "','" & xabsent & _
                    "','" & xregHol & _
                    "','" & xnonRegHol & _
                    "','" & xlp & _
                    "','" & xot & _
                    "','" & xlate & _
                    "','" & xbp & _
                    "','" & xam & _
                    "','" & xrhp & _
                    "','" & xnwhp & _
                    "','" & xlpc & _
                    "','" & xotp & _
                    "','" & xlateded & _
                    "','" & xca & _
                    "','" & xtax & _
                    "','" & xsssprem & _
                    "','" & xpiprem & _
                    "','" & xphprem & _
                    "','" & xsssloan & _
                    "','" & xpiloan & _
                    "','" & xledgerBalance & _
                    "','" & xgp & _
                    "','" & xdeductions & _
                    "','" & xnp & "')"
                .ExecuteNonQuery()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub saveEmployERContribution()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "DECLARE @id int " & _
                    "select @id = (SELECT max(empPayrollTransNo)) " & _
                    "from tblPayrollofEmployees " & _
                    "INSERT into tblBenefitsPaymentSum values('" & lblPRID.Text & "',@id,'" & xsssER & _
                    "','" & xpiER & _
                    "','" & xphER & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Dim xempid As String
    'Dim xabsent As String
    'Dim xregHol As String
    'Dim xnonRegHol As String
    'Dim xlp As String
    'Dim xot As String
    'Dim xlate As String
    'Dim xbp As String
    'Dim xrhp As String
    'Dim xnwhp As String
    'Dim xlpc As String
    'Dim xotp As String
    'Dim xlateded As String
    'Dim xca As String
    'Dim xtax As String
    'Dim xsssprem As String
    'Dim xpiprem As String
    'Dim xphprem As String
    'Dim xsssloan As String
    'Dim xpiloan As String
    'Dim xphloan As String
    'Dim xgp As String
    'Dim xdeductions As String
    'Dim xnp As String
    Sub addtoDGV()
        Dim r As Integer = dgw.Rows.Count
        dgw.Rows.Add()
        dgw.Item(0, r).Value = txtemID.Text
        dgw.Item(1, r).Value = txtName.Text
        dgw.Item(2, r).Value = txtregularWorkedDays.Text
        dgw.Item(3, r).Value = txtRegularHolidays.Text
        dgw.Item(4, r).Value = txtNonWorkingHolidays.Text
        dgw.Item(5, r).Value = txtLeavepay.Text
        dgw.Item(6, r).Value = txtOvertime.Text
        dgw.Item(8, r).Value = Format(basicpay, "0.00")
        dgw.Item(9, r).Value = Format(absentinamount, "0.00")
        dgw.Item(10, r).Value = Format(regularholiday, "0.00")
        dgw.Item(11, r).Value = Format(nonworkingholiday, "0.00")
        dgw.Item(12, r).Value = Format(leavepaycash, "0.00")
        dgw.Item(13, r).Value = Format(overtimecash, "0.00")
        dgw.Item(14, r).Value = Format(latecash, "0.00")
        dgw.Item(15, r).Value = txtCA.Text
        dgw.Item(16, r).Value = "0.00"
        dgw.Item(17, r).Value = txtSSS.Text
        dgw.Item(18, r).Value = txtPagibig.Text
        dgw.Item(19, r).Value = txtPhilhealth.Text
        dgw.Item(20, r).Value = txtSSSLoan.Text
        dgw.Item(21, r).Value = txtPagibigLoah.Text
        dgw.Item(22, r).Value = txtLedgerBalance.Text
        dgw.Item(23, r).Value = lblGrossPay.Text
        dgw.Item(24, r).Value = lbldeductions.Text
        dgw.Item(25, r).Value = lblNetPay.Text
        dgw.Item(26, r).Value = sssER
        dgw.Item(27, r).Value = pagibigER
        dgw.Item(28, r).Value = philhealthER
        dgw.ClearSelection()

        lblTotEmp.Text = dgw.RowCount
        totalOT = totalOT + overtimecash
        totalGrossPay = totalGrossPay + lblGrossPay.Text
        totalDeductions = totalDeductions + lbldeductions.Text
        totalNetpay = totalNetpay + lblNetPay.Text

        lblTotOT.Text = Format(totalOT, "N")
        lblTotGP.Text = Format(totalGrossPay, "N")
        lblTotDed.Text = Format(totalDeductions, "N")
        lblTotNet.Text = Format(totalNetpay, "N")

    End Sub
    


 

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtemID.Text <> "" Then
           
            deductions()
            stats = True
        Else
            MsgBox("please select employee first", MsgBoxStyle.Information, "sorry")
        End If
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If dgw.Rows.Count <> 0 Then
            save()
        Else
            MsgBox("You Dont have calculated Payroll of Employees", MsgBoxStyle.Critical, "error")
        End If
        'selectExist()

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmEmployeeName.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If stats = True Then
            addtoDGV()
            clear()
            txtemID.Text = ""
            txtName.Text = ""
            txtPos.Text = ""
            txtPayMethod.Text = ""
            txtDR.Text = ""
            dtrDH.Value = Now
            stats = False
            For Each row As DataGridViewRow In frmEmployeeName.dgw.SelectedRows
                frmEmployeeName.dgw.Rows.Remove(row)
            Next
        Else
            MsgBox("Please Calculate before Add", MsgBoxStyle.Critical, "error")
        End If
    End Sub

 
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            lblTotEmp.Text = dgw.RowCount - 1
            totalOT = totalOT - dgw.CurrentRow.Cells(13).Value
            totalGrossPay = totalGrossPay - dgw.CurrentRow.Cells(23).Value
            totalDeductions = totalDeductions - dgw.CurrentRow.Cells(24).Value
            totalNetpay = totalNetpay - dgw.CurrentRow.Cells(25).Value

            lblTotOT.Text = Format(totalOT, "N")
            lblTotGP.Text = Format(totalGrossPay, "N")
            lblTotDed.Text = Format(totalDeductions, "N")
            lblTotNet.Text = Format(totalNetpay, "N")
            Dim r As Integer = frmEmployeeName.dgw.Rows.Count
            frmEmployeeName.dgw.Rows.Add()
            frmEmployeeName.dgw.Item(0, r).Value = dgw.CurrentRow.Cells(0).Value
            frmEmployeeName.dgw.Item(1, r).Value = dgw.CurrentRow.Cells(1).Value
            dgw.Rows.Remove(row)
            dgw.ClearSelection()
        Next
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                dgw.ContextMenuStrip = ContextMenuStrip1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip1.Closing
        dgw.ContextMenuStrip = ContextMenuStrip2
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotNet.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class