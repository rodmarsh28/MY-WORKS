

Public Class frmReport

    Private Sub CrystalReportViewer1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CrystalReportViewer1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    'Sub selects()
    '    Try

    '        Dim c As Integer
    '        c = 0
    '        ConnectDatabase()
    '        With OleDBC
    '            .Connection = conn
    '            .CommandText = "SELECT  tblEmployees.*,tblPayrollInfo.*,tblPayrollCash.* FROM (tblEmployees INNER JOIN tblPayrollInfo ON tblEmployees.employeeID = tblPayrollInfo.employeeID) " & _
    '                "INNER JOIN tblPayrollCash ON tblPayrollInfo.payrollID = tblPayrollCash.payrollID where tblPayrollInfo.dateTo = #" & Format(DateTimePicker2.Value, "Short Date") & "#"
    '            .CommandText = "SELECT  tblEmployees.lastname,tblEmployees.firstname,tblEmployees.mi,tblPayrollCash.regularworkedCash," & _
    '                "tblPayrollCash.regularHolidaysCash,tblPayrollCash.nonWorkingHolidaysCash,tblPayrollCash.leavePayCash," & _
    '                "tblPayrollCash.overtimeCash,tblPayrollInfo.grossPay,tblPayrollCash.lateUndertimeCash,tblPayrollInfo.SSS," & _
    '                "tblPayrollInfo.pagibig,tblPayrollInfo.philhealth,tblPayrollInfo.cashAdvance,tblPayrollInfo.totalDeductions,tblPayrollInfo.netPay " & _
    '                "FROM (tblEmployees INNER JOIN tblPayrollInfo ON tblEmployees.employeeID = tblPayrollInfo.employeeID) " & _
    '                "INNER JOIN tblPayrollCash ON tblPayrollInfo.payrollID = tblPayrollCash.payrollID where tblPayrollInfo.dateTo = #" & Format(DateTimePicker2.Value, "Short Date") & "#"
    '        End With
    '        Dim da As OleDbDataAdapter = New OleDbDataAdapter(OleDBC.CommandText, OleDBC.Connection)
    '        Dim ds As DataSet = New DataSet
    '        OleDBDR = OleDBC.ExecuteReader
    '        frmPrintPayroll.dgw.Rows.Clear()
    '        If OleDBDR.HasRows Then
    '            While OleDBDR.Read

    '            End While
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class