Public Class frmDTRGenerator
    Public employeeID As String
    Public totalgross As Double
    Public totaldeduction As Double
    Public totalpay As Double
 
    Sub selectemployee()
        Dim c As Integer
        Dim datefrom As Date = Format(DateTimePicker1.Value, "Short Date")
        Dim dateto As Date = Format(DateTimePicker2.Value, "Short Date")
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblLogs where employeeID = '" & employeeID & "' and date between #" & datefrom & "# and #" & dateto & "#"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                c = 0
                frmPrintDTR.dgw.Rows.Clear()
                While OleDBDR.Read
                    frmPrintDTR.dgw.Rows.Add()
                    frmPrintDTR.dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "Short Date")
                    frmPrintDTR.dgw.Item(1, c).Value = Format(OleDBDR.Item(3), "Short Time")
                    frmPrintDTR.dgw.Item(2, c).Value = Format(OleDBDR.Item(4), "Short Time")
                    frmPrintDTR.dgw.Item(3, c).Value = Format(OleDBDR.Item(5), "Short Time")
                    frmPrintDTR.dgw.Item(4, c).Value = Format(OleDBDR.Item(6), "Short Time")
                    c = c + 1
                    frmPrintDTR.y += 17

                End While
                frmPrintDTR.dgw.Height += frmPrintDTR.y

                'Else

                '    MsgBox("wala", MsgBoxStyle.OkOnly)
                '    MsgBox(employeeID, MsgBoxStyle.OkOnly)
                '    MsgBox(DateTimePicker1.Value, MsgBoxStyle.OkOnly)
                '    MsgBox(DateTimePicker2.Value, MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()

        End Try
    End Sub
    Sub selectName()
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployees where employeeID = '" & employeeID & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmPrintDTR.lblname.Text = OleDBDR.Item(1) + ", " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + "."
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dateto As Date = Format(DateTimePicker2.Value, "Short Date")
        If frmMain.printPayroll = True Then
            allprintpayroll()
            
        ElseIf frmMain.printAllPayslips = True Then
            printallPayslip()

        Else
            selectName()
            selectemployee()
            frmPrintDTR.Show()
        End If

    End Sub
    Sub printallPayslip()
        Dim dateto As Date = Format(DateTimePicker2.Value, "Short Date")
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT tblEmployees.*,tblPayrollInfo.*,tblPayrollCash.* FROM (tblEmployees INNER JOIN tblPayrollInfo ON tblEmployees.employeeID = tblPayrollInfo.employeeID) INNER JOIN " & _
                    "tblPayrollCash ON tblPayrollInfo.payrollID = tblPayrollCash.payrollID where tblPayrollInfo.dateTo = #" & dateto & "#"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                Dim dt As New DataTable

                With dt
                    .Columns.Add("NAME")
                    .Columns.Add("POSITION")
                    .Columns.Add("DATE HIRED")
                    .Columns.Add("RATE")
                    .Columns.Add("WORKED DAYS")
                    .Columns.Add("OVERTIME")
                    .Columns.Add("REGULARHOLIDAY")
                    .Columns.Add("NONWORKINGHOLIDAY")
                    .Columns.Add("GROSS PAY")
                    .Columns.Add("LATE")
                    .Columns.Add("SSS")
                    .Columns.Add("PAGIBIG")
                    .Columns.Add("PHILHEALTH")
                    .Columns.Add("CASH ADVANCE")
                    .Columns.Add("TOTAL DEDUCTION")
                    .Columns.Add("NETPAY")
                    .Columns.Add("dateFrom")
                    .Columns.Add("dateTo")
                    .Columns.Add("regularWorked")
                End With

                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(1) + ", " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + ".", OleDBDR.Item(9), OleDBDR.Item(12), OleDBDR.Item(10), OleDBDR.Item(26), OleDBDR.Item(49), OleDBDR.Item(46), OleDBDR.Item(47), _
                                 OleDBDR.Item(31), OleDBDR.Item(50), OleDBDR.Item(34), OleDBDR.Item(35), OleDBDR.Item(36), OleDBDR.Item(39), OleDBDR.Item(40), OleDBDR.Item(41), _
                                 Format(OleDBDR.Item(24), "Short Date"), Format(OleDBDR.Item(25), "Short Date"), OleDBDR.Item(45))



                End While
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New paySlipPerson
                rptDoc.SetDataSource(dt)
                '
                frmReport.CrystalReportViewer1.ReportSource = rptDoc

                frmReport.ShowDialog()

            Else
                MsgBox("NO RECORDS FOUND", MsgBoxStyle.Critical, "SORRY")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmEmployee.showEmp()
        Me.Close()
    End Sub

    Private Sub frmDTRGenerator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDTRGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Sub allprintpayroll()
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT  tblEmployees.lastname,tblEmployees.firstname,tblEmployees.mi,tblPayrollInfo.regularWorkedDays,tblPayrollInfo.regularHolidays,tblPayrollInfo.nonWorkingHolidays," & _
                    "tblPayrollInfo.restday,tblPayrollCash.regularworkedCash," & _
                    "tblPayrollCash.regularHolidaysCash,tblPayrollCash.nonWorkingHolidaysCash,tblPayrollCash.leavePayCash," & _
                    "tblPayrollCash.overtimeCash,tblPayrollInfo.grossPay,tblPayrollCash.lateUndertimeCash,tblPayrollInfo.SSS," & _
                    "tblPayrollInfo.pagibig,tblPayrollInfo.philhealth,tblPayrollInfo.cashAdvance,tblPayrollInfo.totalDeductions,tblPayrollInfo.netPay " & _
                    "FROM (tblEmployees INNER JOIN tblPayrollInfo ON tblEmployees.employeeID = tblPayrollInfo.employeeID) " & _
                    "INNER JOIN tblPayrollCash ON tblPayrollInfo.payrollID = tblPayrollCash.payrollID where tblPayrollInfo.dateTo = #" & Format(DateTimePicker2.Value, "Short Date") & "#"
            End With
            OleDBDR = OleDBC.ExecuteReader
            frmPrintPayroll.dgw.Rows.Clear()
            totalgross = 0
            totaldeduction = 0
            totalpay = 0
           
            If OleDBDR.HasRows Then
                Dim dt As New DataTable

                With dt
                    .Columns.Add("Name")
                    .Columns.Add("Worked Days")
                    .Columns.Add("Holidays")
                    .Columns.Add("NonWorkingHolidays")
                    .Columns.Add("Restday")
                    .Columns.Add("Basic Pay")
                    .Columns.Add("RegularHolidays")
                    .Columns.Add("NonWorkingHolidaysCash")
                    .Columns.Add("Leave Pay")
                    .Columns.Add("Overtime / Restday Report")
                    .Columns.Add("Gross Pay")
                    .Columns.Add("Late / Undertime")
                    .Columns.Add("SSS Premiums")
                    .Columns.Add("Pagibig Premiums")
                    .Columns.Add("Philhealth Premiums")
                    .Columns.Add("Cash Advance")
                    .Columns.Add("Total Deduction")
                    .Columns.Add("Net Pay")
                    .Columns.Add("dateFrom")
                    .Columns.Add("dateTo")

                End With

                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0) + ", " + OleDBDR.Item(1) + " " + OleDBDR.Item(2) + ".", OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6), OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), _
                    OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14), OleDBDR.Item(15), OleDBDR.Item(16) _
                    , OleDBDR.Item(17), OleDBDR.Item(18), OleDBDR.Item(19), Format(DateTimePicker1.Value, "Short Date"), Format(DateTimePicker2.Value, "Short Date"))
                    c = c + 1
                End While
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New CrystalReport1
                rptDoc.SetDataSource(dt)
                '
                frmReport.CrystalReportViewer1.ReportSource = rptDoc
                frmReport.ShowDialog()
                Me.Close()
            Else
                MsgBox("NO RECORDS FOUND", MsgBoxStyle.Critical, "SORRY")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub
End Class