Public Class frmPayrollViewer

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmEmpName.Show()
    End Sub
    Sub showpayrollInfo()
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblPayrollInfo where employeeID = '" & frmEmpName.empid & "' order by dateTo desc"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = Format(OleDBDR.Item(2), "Short Date")
                    dgw.Item(2, c).Value = Format(OleDBDR.Item(3), "Short Date")
                    dgw.Item(3, c).Value = OleDBDR.Item(9)
                    dgw.Item(4, c).Value = OleDBDR.Item(18)
                    dgw.Item(5, c).Value = OleDBDR.Item(19)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        delete()
        showpayrollInfo()
    End Sub
    Sub delete()
        If MsgBox("Are You Sure You Want To Delete ?", MsgBoxStyle.OkCancel, "Are You Sure ?") = MsgBoxResult.Ok Then
            Try
                ConnectDatabase()
                With OleDBC
                    .Connection = conn
                    .CommandText = "DELETE FROM tblPayrollInfo where payrollID=" & dgw.CurrentRow.Cells(0).Value & ""
                    .ExecuteNonQuery()
                End With
                OleDBC.Dispose()
                conn.Close()
                ConnectDatabase()
                With OleDBC
                    .Connection = conn
                    .CommandText = "DELETE FROM tblPayrollCash where payrollID=" & dgw.CurrentRow.Cells(0).Value & ""
                    .ExecuteNonQuery()
                End With
                MsgBox("Payroll Record Deleted", MsgBoxStyle.Information, "SUCCESS")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                OleDBC.Dispose()
                conn.Close()
            End Try

        End If

    End Sub

    Private Sub GeneratePayslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePayslipToolStripMenuItem.Click
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
              
                .CommandText = "SELECT tblEmployees.*,tblPayrollInfo.*,tblPayrollCash.* FROM (tblEmployees INNER JOIN tblPayrollInfo ON tblEmployees.employeeID = tblPayrollInfo.employeeID) INNER JOIN " & _
                    "tblPayrollCash ON tblPayrollInfo.payrollID = tblPayrollCash.payrollID where tblPayrollInfo.payrollID = " & dgw.CurrentRow.Cells(0).Value & ""
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
                If OleDBDR.Read Then
                    dt.Rows.Add(OleDBDR.Item(1) + ", " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + ".", OleDBDR.Item(9), OleDBDR.Item(12), OleDBDR.Item(10), OleDBDR.Item(26), OleDBDR.Item(49), OleDBDR.Item(46), OleDBDR.Item(47), _
                                  OleDBDR.Item(31), OleDBDR.Item(50), OleDBDR.Item(34), OleDBDR.Item(35), OleDBDR.Item(36), OleDBDR.Item(39), OleDBDR.Item(40), OleDBDR.Item(41), _
                                  Format(OleDBDR.Item(24), "Short Date"), Format(OleDBDR.Item(25), "Short Date"), OleDBDR.Item(45))

                    Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                    rptDoc = New paySlipPerson
                    rptDoc.SetDataSource(dt)

                    frmReport.CrystalReportViewer1.ReportSource = rptDoc
                    frmReport.ShowDialog()
                End If
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

    Private Sub frmPayrollViewer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class