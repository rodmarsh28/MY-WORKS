﻿Public Class frmPayroll
    Public field As String
    Public rate As Double
    Public EmployeeID As String
    Public premDed As String
    Public sssNo As Boolean
    Public phNo As Boolean
    Public piNo As Boolean
    Dim regularWorkedDays As Double
    Dim absent As Double
    Dim regularHolidays As Double
    Dim nonWorkingHolidays As Double
    Dim restDayReport As Double
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
    Dim restDayReportAmount As Double
    Dim leavepaycash As Double
    Dim overtimecash As Double
    Dim latecash As Double
    Dim lastnetpay As Double
    Dim id As String
    Dim stats As Boolean

    Public totalEmployees As Integer = 0
    Public totalOT As Double = 0.0
    Public totalGrossPay As Double = 0.0
    Public totalDeductions As Double = 0.0
    Public totalNetpay As Double = 0.0

    Dim xEmployeeID As String
    Dim xtotWorkDays As String
    Dim xabsent As String
    Dim xregHol As String
    Dim xnonRegHol As String
    Dim xlp As String
    Dim xot As String
    Dim xrdr As String
    Dim xlate As String
    Dim xbp As String
    Dim xrhd As String
    Dim xnwhd As String
    Dim xrhp As String
    Dim xnwhp As String
    Dim xlpc As String
    Dim xotp As String
    Dim xrdrpay As String
    Dim xlateded As String
    Dim xca As String
    Dim xtax As String
    Dim xsssprem As String
    Dim xsssER As String
    Dim xpiprem As String
    Dim xpiER As String
    Dim xphprem As String
    Dim xphER As String
    Dim xsssloan As String
    Dim xpiloan As String
    Dim xledgerBalance As String
    Dim xgp As String
    Dim xdeductions As String
    Dim xnp As String
    Dim rtx As Double
    Dim sunday As Integer
    Public rhdays As Integer
    Public nwhdays As Integer

    Sub clear()
        txtregularWorkedDays.Text = "0"
        txtRegularHolidays.Text = "0"
        txtNonWorkingHolidays.Text = "0"
        txtLeavepay.Text = "0"
        txtOvertime.Text = "0"
        txtRDR.Text = "0"
        lblGrossPay.Text = "0.00"
        txtrhd.Text = 0
        txtnwhd.Text = 0

        txtLate.Text = "0"
        txtSSS.Text = "0.00"
        sssER = 0.0
        txtPagibig.Text = "0.00"
        pagibigER = 0.0
        txtPhilhealth.Text = "0.00"
        philhealthER = 0.0
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

    Private Sub frmPayroll_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmPayroll_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        clear()
        clearForm()
    End Sub


    Private Sub frmPayroll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
        If e.Alt AndAlso e.KeyCode = Keys.A Then
            Button2.PerformClick()
        End If

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
                                " where dbo.tblPayroll.datefrom = '" & dtr1 & "' and dbo.tblPayrollofEmployees.EmployeeID  = '" & txtemID.Text & "'"
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
    Sub countsunday()
        sunday = 0
        Dim totalday As Integer = dtrTo.Value.Day - dtrFrom.Value.Day
        Dim i As Integer = 0
        Dim dates As DateTime = dtrFrom.Value
        While i <= totalday
            i = i + 1
            If dates.DayOfWeek = DayOfWeek.Sunday Then
                sunday = sunday + 1
            End If
            dates = DateAdd(DateInterval.Day, 1, dates)
        End While

    End Sub

    Sub deductions()
        convertZero()
        Dim Year As DateTime = dtrFrom.Value
        Dim month As DateTime = dtrFrom.Value
        Dim years As Integer = Year.Year
        Dim months As Integer = month.Month
        Dim days As Integer = System.DateTime.DaysInMonth(years, months)
        Dim fdate As DateTime = dtrTo.Value
        Dim sdate As DateTime = dtrFrom.Value
        'Dim CountSundays As Integer = (1 + dtrTo.Value.Subtract(dtrFrom.Value).Days + (6 + CInt(dtrFrom.Value.DayOfWeek)) Mod 7) / 7
        Dim totgross As Double
        Dim rhtodays As Double
        Dim nwhtodays As Double
        If txtRegularHolidays.Text <> "0" Then
            rhtodays = txtRegularHolidays.Text / 8
            If rhtodays <= 1 Then
                rhtodays = 1
            ElseIf rhtodays <= 2 Then
                rhtodays = 2
            ElseIf rhtodays <= 3 Then
                rhtodays = 3
            ElseIf rhtodays <= 4 Then
                rhtodays = 4
            ElseIf rhtodays <= 5 Then
                rhtodays = 5
            End If
        End If
        If txtNonWorkingHolidays.Text <> "0" Then
            nwhtodays = txtNonWorkingHolidays.Text / 8
            If nwhtodays <= 1 Then
                nwhtodays = 1
            ElseIf nwhtodays <= 2 Then
                nwhtodays = 2
            ElseIf nwhtodays <= 3 Then
                nwhtodays = 3
            ElseIf nwhtodays <= 4 Then
                nwhtodays = 4
            ElseIf nwhtodays <= 5 Then
                nwhtodays = 5
            End If
        End If
        If txtPayMethod.Text = "Daily" Then
          
            regularWorkedDays = txtregularWorkedDays.Text
            absent = DateDiff(DateInterval.Day, dtrFrom.Value, dtrTo.Value) + 1 - txtregularWorkedDays.Text - sunday - txtrhd.Text - txtnwhd.Text
            If absent < 0 Then
                absent = 0
            End If
        ElseIf txtPayMethod.Text = "Monthly" Then
            regularWorkedDays = DateDiff(DateInterval.Day, dtrFrom.Value, dtrTo.Value) - txtregularWorkedDays.Text + 1 - sunday - txtrhd.Text - txtnwhd.Text
            absent = txtregularWorkedDays.Text
            If regularWorkedDays < 0 Then
                regularWorkedDays = 0
            End If
        ElseIf txtPayMethod.Text = "Weekly" Then
            regularWorkedDays = txtregularWorkedDays.Text
            absent = 7 - txtregularWorkedDays.Text
        End If

        late = txtLate.Text
        regularHolidays = txtRegularHolidays.Text
        nonWorkingHolidays = txtNonWorkingHolidays.Text
        leavePay = txtLeavepay.Text
        overtime = txtOvertime.Text
        restDayReport = txtRDR.Text
        late = txtLate.Text
        If txtPayMethod.Text = "Daily" Then
            basicpay = txtDR.Text * regularWorkedDays
            latecash = (txtDR.Text / 8 / 60) * late
            regularholiday = txtDR.Text / 8 * regularHolidays + (txtDR.Text * rhdays)
            nonworkingholiday = txtDR.Text / 8 * 0.3 * nonWorkingHolidays + (txtDR.Text / 8 * nonWorkingHolidays)
            leavepaycash = leavePay
            overtimecash = txtDR.Text / 8 * overtime
            restDayReportAmount = txtDR.Text / 8 * 1.3 * restDayReport
            totgross = basicpay + regularholiday + nonworkingholiday + leavepaycash + overtimecash + restDayReportAmount - latecash
        ElseIf txtPayMethod.Text = "Monthly" Then
            basicpay = txtDR.Text / 2
            absentinamount = txtDR.Text / 313 * 12 * absent
            latecash = (txtDR.Text / 26 / 8 / 60) * late
            regularholiday = txtDR.Text / 313 * 12 / 8 * txtRegularHolidays.Text + (txtDR.Text / 313 * 12 * rhdays)
            nonworkingholiday = txtDR.Text / 313 * 12 / 8 * 0.3 * txtNonWorkingHolidays.Text + (txtDR.Text / 313 * 12 * nwhdays)
            leavepaycash = leavePay
            overtimecash = txtDR.Text / 313 * 12 / 8 * overtime
            restDayReportAmount = txtDR.Text / 313 * 12 / 8 * 1.3 * restDayReport
            totgross = basicpay + txtDR.Text / 313 * 12 / 8 * txtRegularHolidays.Text + txtDR.Text / 313 * 12 / 8 * 0.3 * txtNonWorkingHolidays.Text + leavepaycash + overtimecash + restDayReportAmount - latecash - absentinamount
        End If
        lblGrossPay.Text = Format(totgross, "0.00")
        grossPay = lblGrossPay.Text
        Dim daydate As DateTime = dtrTo.Value
        If frmDateGenerator.isLastDay = True Then
            selectLastNetpay()

        End If
        If premDed = "Yes" Then

            If frmDateGenerator.isLastDay = True Then
                If txtPayMethod.Text = "Monthly" Then
                    rtx = txtDR.Text
                ElseIf txtPayMethod.Text = "Daily" Then
                    rtx = txtDR.Text * 26
                End If
                grossPay = grossPay

                If phNo = True Then
                    If rtx <= 10000 Then
                        txtPhilhealth.Text = "137.50"
                    ElseIf rtx <= 39999 Then
                        txtPhilhealth.Text = Format(rtx * 0.0275 / 2, "0.00")

                    Else
                        txtPhilhealth.Text = "550.00"
                    End If
                Else
                    txtPhilhealth.Text = "0.00"
                End If
                philhealthER = txtPhilhealth.Text
                If sssNo = True Then
                    If rtx <= 1249.99 Then
                        txtSSS.Text = 36.3
                        sssER = 83.7
                    ElseIf rtx <= 1749.99 Then
                        txtSSS.Text = 54.5
                        sssER = 120.5
                    ElseIf rtx <= 2249.99 Then
                        txtSSS.Text = 72.7
                        sssER = 157.3
                    ElseIf rtx <= 2749.99 Then
                        txtSSS.Text = 90.8
                        sssER = 194.2
                    ElseIf rtx <= 3249.99 Then
                        txtSSS.Text = 109
                        sssER = 231
                    ElseIf rtx <= 3749.99 Then
                        txtSSS.Text = 127.2
                        sssER = 267.8
                    ElseIf rtx <= 4249.99 Then
                        txtSSS.Text = 145.3
                        sssER = 304.7
                    ElseIf rtx <= 4749.99 Then
                        txtSSS.Text = 163.5
                        sssER = 341.5
                    ElseIf rtx <= 5249.99 Then
                        txtSSS.Text = 181.7
                        sssER = 378.3
                    ElseIf rtx <= 5749.99 Then
                        txtSSS.Text = 199.8
                        sssER = 415.2
                    ElseIf rtx <= 6249.99 Then
                        txtSSS.Text = 218
                        sssER = 452
                    ElseIf rtx <= 6749.99 Then
                        txtSSS.Text = 236.2
                        sssER = 488.8
                    ElseIf rtx <= 7249.99 Then
                        txtSSS.Text = 254.3
                        sssER = 525.7
                    ElseIf rtx <= 7749.99 Then
                        txtSSS.Text = 272.5
                        sssER = 562.5
                    ElseIf rtx <= 8249.99 Then
                        txtSSS.Text = 290.7
                        sssER = 599.3
                    ElseIf rtx <= 8749.99 Then
                        txtSSS.Text = 308.8
                        sssER = 636.2
                    ElseIf rtx <= 9249.99 Then
                        txtSSS.Text = 327
                        sssER = 673
                    ElseIf rtx <= 9749.99 Then
                        txtSSS.Text = 345.2
                        sssER = 709.8
                    ElseIf rtx <= 10249.99 Then
                        txtSSS.Text = 363.3
                        sssER = 746.7
                    ElseIf rtx <= 10749.99 Then
                        txtSSS.Text = 381.5
                        sssER = 783.5
                    ElseIf rtx <= 11249.99 Then
                        txtSSS.Text = 399.7
                        sssER = 820.3
                    ElseIf rtx <= 11749.99 Then
                        txtSSS.Text = 417.8
                        sssER = 857.2
                    ElseIf rtx <= 12249.99 Then
                        txtSSS.Text = 436
                        sssER = 894
                    ElseIf rtx <= 12749.99 Then
                        txtSSS.Text = 454.2
                        sssER = 930.8
                    ElseIf rtx <= 13249.99 Then
                        txtSSS.Text = 472.3
                        sssER = 967.7
                    ElseIf rtx <= 13749.99 Then
                        txtSSS.Text = 490.5
                        sssER = 1004.5
                    ElseIf rtx <= 14249.99 Then
                        txtSSS.Text = 508.7
                        sssER = 1041.3
                    ElseIf rtx <= 14749.99 Then
                        txtSSS.Text = 526.8
                        sssER = 1078.2
                    ElseIf rtx <= 15249.99 Then
                        txtSSS.Text = 545
                        sssER = 1135
                    ElseIf rtx <= 15749.99 Then
                        txtSSS.Text = 563.2
                        sssER = 1171.8
                    ElseIf rtx <= 16249.99 Or rtx >= 16249.99 Then
                        txtSSS.Text = 581.3
                        sssER = 1208.7
                    End If
                Else
                    txtSSS.Text = "0.00"
                    sssER = 0.0
                End If
                If piNo = True Then

                    txtPagibig.Text = 100.0
                    pagibigER = 100.0

                    txtPagibig.Text = 100.0
                    pagibigER = 100.0

                Else
                    txtPagibig.Text = "0.00"
                    pagibigER = 0.0
                End If
                grossPay = grossPay
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
        If txtRDR.Text = "" Then
            txtRDR.Text = "0"
        End If
        If txtLate.Text = "" Then
            txtLate.Text = "0"
        End If

        If txtRDR.Text = "" Then
            txtRDR.Text = "0"

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
                            "','" & payrollType & "')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                MsgBox("Payroll Created Success", MsgBoxStyle.Information, "Success")
                dgw.Rows.Clear()
                clear()
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
            xEmployeeID = dgw.Item(0, col).Value
            xtotWorkDays = dgw.Item(2, col).Value
            xabsent = dgw.Item(3, col).Value
            xrhd = dgw.Item(4, col).Value
            xnwhd = dgw.Item(5, col).Value
            xregHol = dgw.Item(6, col).Value
            xnonRegHol = dgw.Item(7, col).Value
            xlp = dgw.Item(8, col).Value
            xot = dgw.Item(9, col).Value
            xrdr = dgw.Item(10, col).Value
            xlate = dgw.Item(11, col).Value
            xbp = dgw.Item(12, col).Value
            xrhp = dgw.Item(13, col).Value
            xnwhp = dgw.Item(14, col).Value
            xlpc = dgw.Item(15, col).Value
            xotp = dgw.Item(16, col).Value
            xrdrpay = dgw.Item(17, col).Value
            xlateded = dgw.Item(18, col).Value
            xca = dgw.Item(19, col).Value
            xtax = dgw.Item(20, col).Value
            xsssprem = dgw.Item(21, col).Value
            xpiprem = dgw.Item(22, col).Value
            xphprem = dgw.Item(23, col).Value
            xsssloan = dgw.Item(24, col).Value
            xpiloan = dgw.Item(25, col).Value
            xledgerBalance = dgw.Item(26, col).Value
            xgp = dgw.Item(27, col).Value
            xdeductions = dgw.Item(28, col).Value
            xnp = dgw.Item(29, col).Value
            xsssER = dgw.Item(30, col).Value
            xpiER = dgw.Item(31, col).Value
            xphER = dgw.Item(32, col).Value
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
                    "','" & xEmployeeID & _
                    "','" & xtotWorkDays & _
                    "','" & xabsent & _
                    "','" & xrhd & _
                    "','" & xnwhd & _
                    "','" & xregHol & _
                    "','" & xnonRegHol & _
                    "','" & xlp & _
                    "','" & xot & _
                    "','" & xrdr & _
                    "','" & xlate & _
                    "','" & xbp & _
                    "','" & xrhp & _
                    "','" & xnwhp & _
                    "','" & xlpc & _
                    "','" & xotp & _
                    "','" & xrdrpay & _
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
    Sub deleteExtPayroll()
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
                .CommandText = "delete tblPayroll where payrollID ='" & lblPRID.Text & "' " & _
                             "delete tblPayrollofEmployees where payrollID ='" & lblPRID.Text & "' "
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub addtoDGV()
        Dim r As Integer = dgw.Rows.Count
        dgw.Rows.Add()
        dgw.Item(0, r).Value = txtemID.Text
        dgw.Item(1, r).Value = txtName.Text
        dgw.Item(2, r).Value = regularWorkedDays
        dgw.Item(3, r).Value = absent
        dgw.Item(4, r).Value = rhdays
        dgw.Item(5, r).Value = nwhdays
        dgw.Item(6, r).Value = txtRegularHolidays.Text
        dgw.Item(7, r).Value = txtNonWorkingHolidays.Text
        dgw.Item(8, r).Value = txtLeavepay.Text
        dgw.Item(9, r).Value = txtOvertime.Text
        dgw.Item(10, r).Value = txtRDR.Text
        dgw.Item(11, r).Value = txtLate.Text
        dgw.Item(12, r).Value = Format(basicpay, "0.00")
        dgw.Item(13, r).Value = Format(regularholiday, "0.00")
        dgw.Item(14, r).Value = Format(nonworkingholiday, "0.00")
        dgw.Item(15, r).Value = Format(leavepaycash, "0.00")
        dgw.Item(16, r).Value = Format(overtimecash, "0.00")
        dgw.Item(17, r).Value = Format(restDayReportAmount, "0.00")
        dgw.Item(18, r).Value = Format(latecash, "0.00")
        dgw.Item(19, r).Value = txtCA.Text
        dgw.Item(20, r).Value = "0.00"
        dgw.Item(21, r).Value = txtSSS.Text
        dgw.Item(22, r).Value = txtPagibig.Text
        dgw.Item(23, r).Value = txtPhilhealth.Text
        dgw.Item(24, r).Value = txtSSSLoan.Text
        dgw.Item(25, r).Value = txtPagibigLoah.Text
        dgw.Item(26, r).Value = txtLedgerBalance.Text
        dgw.Item(27, r).Value = lblGrossPay.Text
        dgw.Item(28, r).Value = lbldeductions.Text
        dgw.Item(29, r).Value = lblNetPay.Text
        dgw.Item(30, r).Value = sssER
        dgw.Item(31, r).Value = pagibigER
        dgw.Item(32, r).Value = philhealthER
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



    Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                dgw.ContextMenuStrip = ContextMenuStrip1
            End If
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtemID.Text <> "" Then

            deductions()
            stats = True
        Else
            MsgBox("please select employee first", MsgBoxStyle.Information, "sorry")
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmEmployeeName.ShowDialog()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If dgw.Rows.Count <> 0 Then
            If payrollMode = "Add" Then
                save()
            ElseIf payrollMode = "Update" Then
                deleteExtPayroll()
                save()
                frmAllPayrollHistory.ShowAllPayrollHistory()
            End If


        Else
            MsgBox("You Dont have calculated Payroll of Employees", MsgBoxStyle.Critical, "error")
        End If
            'selectExist()
    End Sub

    Private Sub btnClose_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub frmPayroll_FormClosing1(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dgw.Rows.Clear()
        clear()
    End Sub

    Private Sub frmPayroll_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If payrollMode = "Update" Then
        ElseIf payrollMode = "Add" Then
            clear()
            Button1.Focus()
            frmEmployeeName.searchExisting()
            frmEmployeeName.showEmployee()
            generatePayrollID()
            If frmDateGenerator.isLastDay = True Then
                txtSSSLoan.Enabled = False
                txtPagibigLoah.Enabled = False
            ElseIf payrollType = "Labor" Then
                txtSSSLoan.Enabled = False
                txtPagibigLoah.Enabled = False
            Else
                txtSSSLoan.Enabled = True
                txtPagibigLoah.Enabled = True

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
        End If
       
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            lblTotEmp.Text = dgw.RowCount - 1
            totalOT = totalOT - dgw.CurrentRow.Cells(16).Value
            totalGrossPay = totalGrossPay - dgw.CurrentRow.Cells(28).Value
            totalDeductions = totalDeductions - dgw.CurrentRow.Cells(26).Value
            totalNetpay = totalNetpay - dgw.CurrentRow.Cells(27).Value

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        rhdays = 0
        Try
            Dim rhd As String = InputBox("How many Regular Holidays Counted ?")
            If rhd = "" Then
                rhd = "0"
            End If
            rhdays = rhd
            txtrhd.Text = rhdays
        Catch ex As Exception
            MsgBox("Invalid Input", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        nwhdays = 0
        Try
            Dim nwhd As String = InputBox("How many Non Working Holidays Counted ?")
            If nwhd = "" Then
                nwhd = "0"
            End If
            nwhdays = nwhd
            txtnwhd.Text = nwhdays
        Catch ex As Exception
            MsgBox("Invalid Input", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Private Sub txtRegularHolidays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegularHolidays.TextChanged
        Dim rhtodays As Double
        Try
            If txtRegularHolidays.Text <> "0" Then
                rhtodays = txtRegularHolidays.Text / 8
                If rhtodays <= 1 Then
                    rhtodays = 1
                ElseIf rhtodays <= 2 Then
                    rhtodays = 2
                ElseIf rhtodays <= 3 Then
                    rhtodays = 3
                ElseIf rhtodays <= 4 Then
                    rhtodays = 4
                ElseIf rhtodays <= 5 Then
                    rhtodays = 5
                End If
                rhdays = rhtodays

            Else
                rhtodays = 0
            End If
            txtrhd.Text = rhtodays
        Catch ex As Exception
        End Try
    End Sub

 

   

    Private Sub txtNonWorkingHolidays_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNonWorkingHolidays.TextChanged
        Dim nwhtodays As Double
        Try
            If txtNonWorkingHolidays.Text <> "0" Then
                nwhtodays = txtNonWorkingHolidays.Text / 8
                If nwhtodays <= 1 Then
                    nwhtodays = 1
                ElseIf nwhtodays <= 2 Then
                    nwhtodays = 2
                ElseIf nwhtodays <= 3 Then
                    nwhtodays = 3
                ElseIf nwhtodays <= 4 Then
                    nwhtodays = 4
                ElseIf nwhtodays <= 5 Then
                    nwhtodays = 5
                End If
                nwhdays = nwhtodays

            Else
                nwhtodays = 0
            End If
            txtnwhd.Text = nwhtodays
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtregularWorkedDays_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtregularWorkedDays.MouseDown
        txtregularWorkedDays.SelectAll()
    End Sub
    Private Sub txtRegularHolidays_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRegularHolidays.MouseDown
        txtRegularHolidays.SelectAll()
    End Sub
    Private Sub txtNonWorkingHolidays_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtNonWorkingHolidays.MouseDown
        txtNonWorkingHolidays.SelectAll()
    End Sub

    Private Sub txtLeavepay_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLeavepay.MouseDown
        txtLeavepay.SelectAll()
    End Sub

    Private Sub txtOvertime_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOvertime.MouseDown
        txtOvertime.SelectAll()
    End Sub

    Private Sub txtRDR_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRDR.MouseDown
        txtRDR.SelectAll()
    End Sub

    Private Sub txtLate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLate.MouseDown
        txtLate.SelectAll()
    End Sub

    Private Sub txtSSSLoan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSSSLoan.MouseDown
        txtSSSLoan.SelectAll()
    End Sub

    Private Sub txtPagibigLoah_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPagibigLoah.MouseDown
        txtPagibigLoah.SelectAll()
    End Sub

    Private Sub txtLedgerBalance_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLedgerBalance.MouseDown
        txtLedgerBalance.SelectAll()
    End Sub

    Private Sub txtCA_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCA.MouseDown
        txtCA.SelectAll()
    End Sub

   
End Class