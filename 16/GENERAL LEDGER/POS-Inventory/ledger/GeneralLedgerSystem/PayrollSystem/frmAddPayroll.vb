Public Class frmAddPayroll
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
    Dim pagibig As Double
    Dim philhealth As Double
    Dim sssloan As Double
    Dim pagibigloan As Double
    Dim philhealthloan As Double
    Dim cashAdvance As Double
    Dim totalDeduction As Double
    Dim netPay As Double
    Dim basicpay As Double
    Dim regularholiday As Double
    Dim nonworkingholiday As Double
    Dim leavepaycash As Double
    Dim overtimecash As Double
    Dim latecash As Double
    Dim lastnetpay As Double
    Dim id As String
    Dim absent As Double


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
    Sub selectemployee()

    End Sub
    Sub clear()
        txtregularWorkedDays.Text = "0"
        txtRegularHolidays.Text = "0"
        txtNonWorkingHolidays.Text = "0"
        txtLeavepay.Text = "0"
        txtOvertime.Text = "0"
        lblGrossPay.Text = "0.00"
        txtlate.Text = "0"
        txtSSS.Text = "0.00"
        txtPagibig.Text = "0.00"
        txtPhilhealth.Text = "0.00"
        txtSSSLoan.Text = "0.00"
        txtPagibigLoah.Text = "0.00"
        txtPhilhealthLoan.Text = "0.00"
        txtCA.Text = "0"
        lbldeductions.Text = "0.00"
        lblNetPay.Text = "0.00"
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

    Private Sub frmAddPayroll_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear()
        txtemID.Text = ""
        txtName.Text = ""
        txtPos.Text = ""
        txtPayMethod.Text = ""
        txtDR.Text = ""
        dtrDH.Value = Now
        dtrFrom.Value = Now
        dtrTo.Value = Now
    End Sub

    Private Sub frmPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
        selectemployee()
        generatePayrollID()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmEmployeeLisst.mode = "2"
        frmEmployeeLisst.Show()
    End Sub
    Sub selectLastNetpay()
        Dim dtr1 As Date = DateAdd("d", -15, Format(dtrTo.Value, "Short Date"))
        Dim dtr2 As Date = DateAdd("d", -16, Format(dtrTo.Value, "Short Date"))
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
                .CommandText = "select * from tblPayroll where DATETO = '" & Format(dtr1, "MM/dd/yyyy") & "' or DATETO = '" & Format(dtr2, "MM/dd/yyyy") & "' and EMPID  = '" & empid & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    lastnetpay = OleDBDR.Item(11)
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
        absent = txtregularWorkedDays.Text
        late = txtlate.Text
        If txtPayMethod.Text = "Daily" Then
            basicpay = txtDR.Text * regularWorkedDays
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

            basicpay = (txtDR.Text / 2) - (txtDR.Text / 26 * regularWorkedDays)
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
        totgross = basicpay + regularholiday + nonworkingholiday + leavepaycash + overtimecash
        lblGrossPay.Text = Format(totgross, "0.00")
        grossPay = lblGrossPay.Text


        Dim daydate As DateTime = dtrTo.Value
        If premDed = "Yes" Then
            If daydate.Day = days Then
                If phNo = True Then
                    txtPhilhealth.Text = "100"
                Else
                    txtPhilhealth.Text = "0.00"
                End If

                grossPay = grossPay + lastnetpay
                If sssNo = True Then
                    If grossPay <= 1249.99 Then
                        txtSSS.Text = 36.3
                    ElseIf grossPay <= 1749.99 Then
                        txtSSS.Text = 54.5
                    ElseIf grossPay <= 2249.99 Then
                        txtSSS.Text = 72.7
                    ElseIf grossPay <= 2749.99 Then
                        txtSSS.Text = 90.8
                    ElseIf grossPay <= 3249.99 Then
                        txtSSS.Text = 109
                    ElseIf grossPay <= 3749.99 Then
                        txtSSS.Text = 127.2
                    ElseIf grossPay <= 4249.99 Then
                        txtSSS.Text = 145.3
                    ElseIf grossPay <= 4749.99 Then
                        txtSSS.Text = 163.5
                    ElseIf grossPay <= 5249.99 Then
                        txtSSS.Text = 181.7
                    ElseIf grossPay <= 5749.99 Then
                        txtSSS.Text = 199.8
                    ElseIf grossPay <= 6249.99 Then
                        txtSSS.Text = 218
                    ElseIf grossPay <= 6749.99 Then
                        txtSSS.Text = 236.2
                    ElseIf grossPay <= 7249.99 Then
                        txtSSS.Text = 254.3
                    ElseIf grossPay <= 7749.99 Then
                        txtSSS.Text = 272.5
                    ElseIf grossPay <= 8749.99 Then
                        txtSSS.Text = 308.8
                    ElseIf grossPay <= 9249.99 Then
                        txtSSS.Text = 327
                    ElseIf grossPay <= 9749.99 Then
                        txtSSS.Text = 345.2
                    ElseIf grossPay <= 10249.99 Then
                        txtSSS.Text = 363.3
                    ElseIf grossPay <= 10749.99 Then
                        txtSSS.Text = 381.5
                    ElseIf grossPay <= 11249.99 Then
                        txtSSS.Text = 399.7
                    ElseIf grossPay <= 11749.99 Then
                        txtSSS.Text = 417.8
                    ElseIf grossPay <= 12249.99 Then
                        txtSSS.Text = 436
                    ElseIf grossPay <= 12749.99 Then
                        txtSSS.Text = 454.2
                    ElseIf grossPay <= 13249.99 Then
                        txtSSS.Text = 472.3
                    ElseIf grossPay <= 13749.99 Then
                        txtSSS.Text = 490.5
                    ElseIf grossPay <= 14249.99 Then
                        txtSSS.Text = 508.7
                    ElseIf grossPay <= 14749.99 Then
                        txtSSS.Text = 526.8
                    ElseIf grossPay <= 15249.99 Then
                        txtSSS.Text = 545
                    ElseIf grossPay <= 15749.99 Then
                        txtSSS.Text = 563.2
                    ElseIf grossPay <= 16249.99 Then
                        txtSSS.Text = 581.3
                    End If
                Else
                    txtSSS.Text = "0.00"
                End If
                If piNo = True Then
                    If grossPay <= 8999.99 Then
                        txtPagibig.Text = 100
                    ElseIf grossPay <= 9999.99 Then
                        txtPagibig.Text = 112.5
                    ElseIf grossPay <= 10999.99 Then
                        txtPagibig.Text = 125
                    ElseIf grossPay <= 11999.99 Then
                        txtPagibig.Text = 137.5
                    ElseIf grossPay <= 12999.99 Then
                        txtPagibig.Text = 150
                    ElseIf grossPay <= 13999.99 Then
                        txtPagibig.Text = 162.5
                    ElseIf grossPay <= 14999.99 Then
                        txtPagibig.Text = 175
                    ElseIf grossPay <= 15999.99 Then
                        txtPagibig.Text = 187.5
                    ElseIf grossPay <= 16999.99 Then
                        txtPagibig.Text = 200
                    ElseIf grossPay <= 17999.99 Then
                        txtPagibig.Text = 212.5
                    ElseIf grossPay <= 18999.99 Then
                        txtPagibig.Text = 225
                    ElseIf grossPay <= 19999.99 Then
                        txtPagibig.Text = 237.5
                    ElseIf grossPay <= 20999.99 Then
                        txtPagibig.Text = 250
                    ElseIf grossPay <= 21999.99 Then
                        txtPagibig.Text = 262.5
                    ElseIf grossPay <= 22999.99 Then
                        txtPagibig.Text = 275
                    ElseIf grossPay <= 23999.99 Then
                        txtPagibig.Text = 287.5
                    ElseIf grossPay <= 24999.99 Then
                        txtPagibig.Text = 300
                    ElseIf grossPay <= 25999.99 Then
                        txtPagibig.Text = 312.5
                    ElseIf grossPay <= 26999.99 Then
                        txtPagibig.Text = 325
                    ElseIf grossPay <= 27999.99 Then
                        txtPagibig.Text = 337.5
                    ElseIf grossPay <= 28999.99 Then
                        txtPagibig.Text = 350
                    ElseIf grossPay <= 29999.99 Then
                        txtPagibig.Text = 362.5
                    ElseIf grossPay <= 30999.99 Then
                        txtPagibig.Text = 375
                    ElseIf grossPay <= 31999.99 Then
                        txtPagibig.Text = 387.5
                    ElseIf grossPay <= 32999.99 Then
                        txtPagibig.Text = 400
                    ElseIf grossPay <= 33999.99 Then
                        txtPagibig.Text = 412.5
                    ElseIf grossPay <= 34999.99 Then
                        txtPagibig.Text = 425
                    ElseIf grossPay <= 35000 Then
                        txtPagibig.Text = 437.5
                    End If
                Else
                    txtPagibig.Text = "0.00"
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

        late = txtlate.Text
        sss = txtSSS.Text
        pagibig = txtPagibig.Text
        philhealth = txtPhilhealth.Text
        sssloan = txtSSSLoan.Text
        pagibigloan = txtPagibigLoah.Text
        philhealthloan = txtPagibigLoah.Text
        cashAdvance = txtCA.Text
        Dim totded As Double
        totded = latecash + sss + pagibig + philhealth + sssloan + pagibigloan + philhealthloan + cashAdvance
        lbldeductions.Text = Format(totded, "0.00")

        totalDeduction = lbldeductions.Text
        netPay = grossPay - totalDeduction
        lblNetPay.Text = netPay



    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

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
        If txtlate.Text = "" Then
            txtlate.Text = "0"
        End If
        If txtCA.Text = "" Then
            txtCA.Text = "0"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtemID.Text <> "" Then
            selectLastNetpay()
            deductions()
        Else
            MsgBox("please select employee first", MsgBoxStyle.Information, "sorry")
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
                .CommandText = "select * from tblPayroll where '" & Format(dtrFrom.Value, "MM/dd/yyyy") & "' between DATEFROM and DATETO and EMPID  = '" & txtemID.Text & _
                    "' or '" & Format(dtrTo.Value, "MM/dd/yyyy") & "' between DATEFROM and DATETO and EMPID  = '" & txtemID.Text & "'"
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
        If txtemID.Text = "" Then
            MsgBox("Please select Employee first")
        Else
            If MsgBox("Save Payroll?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                Dim xfrom As DateTime = dtrFrom.Value
                Dim xto As DateTime = dtrTo.Value
                Dim regularwork As Integer
                Dim dayWork As Integer
                Dim restdays As Integer
                dayWork = xto.Day - xfrom.Day + 1
                If lblRW.Text = "Absent/Rest Days" Then
                    regularwork = dayWork - txtregularWorkedDays.Text
                    restdays = txtregularWorkedDays.Text

                Else
                    regularwork = txtregularWorkedDays.Text
                    restdays = 0
                End If
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
                        .CommandText = " INSERT INTO tblPayroll VALUES ('" & lblPRID.Text & _
                                "','" & txtemID.Text & _
                                "','" & dtrFrom.Value.ToString("MM/dd/yyyy") & _
                                "','" & dtrTo.Value.ToString("MM/dd/yyyy") & _
                                "','" & regularwork & _
                                "','" & txtRegularHolidays.Text & _
                                "','" & txtNonWorkingHolidays.Text & _
                                "','" & txtLeavepay.Text & _
                                "','" & txtOvertime.Text & _
                                "','" & txtlate.Text & _
                                "','" & lbldeductions.Text & _
                                "','" & lblGrossPay.Text & _
                                "','" & lblNetPay.Text & _
                                "','" & Now.ToString("MM/dd/yyyy") & "')"
                        .ExecuteNonQuery()
                    End With
                    saveCash()
                    saveDeduction()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Sub saveCash()
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
                .CommandText = "insert into tblPayrollCash VALUES('" & lblPRID.Text & _
                    "','" & Format(basicpay, "0.00") & _
                    "','" & Format(regularholiday, "0.00") & _
                    "','" & Format(nonworkingholiday, "0.00") & _
                    "','" & Format(leavepaycash, "0.00") & _
                    "','" & Format(overtimecash, "0.00") & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub saveDeduction()
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
                .CommandText = "insert into tblPayrollDeductions VALUES('" & lblPRID.Text & _
                    "','" & Format(latecash, "0.00") & _
                    "','" & txtSSS.Text & _
                    "','" & txtPagibig.Text & _
                    "','" & txtPhilhealth.Text & _
                    "','" & Format(0, "0.00") & _
                    "','" & Format(txtCA.Text, "0.00") & "')"
                .ExecuteNonQuery()
            End With
            MsgBox("PAYROLL GENERATED SUCCESSFULLY !", MsgBoxStyle.Information, "SUCCESS")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
  

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        selectExist()
    End Sub

End Class