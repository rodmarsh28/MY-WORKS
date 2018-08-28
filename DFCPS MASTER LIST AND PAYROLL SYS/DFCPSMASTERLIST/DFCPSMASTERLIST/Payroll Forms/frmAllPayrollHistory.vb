﻿Public Class frmAllPayrollHistory
    Dim payrollMaxID As String
    Sub deletePayroll()
        If MsgBox("Delete Payroll?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "delete tblPayroll where payrollID ='" & dgw.CurrentRow.Cells(0).Value & "' " & _
                                    "delete tblBenefitsPaymentSum where payrollID ='" & dgw.CurrentRow.Cells(0).Value & "' " & _
                                    "delete tblPayrollofEmployees where payrollID ='" & dgw.CurrentRow.Cells(0).Value & "' "
                    .ExecuteNonQuery()
                End With
                MsgBox("Delete Success", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub ShowAllPayrollHistory()
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
                .CommandText = "select * from tblPayroll order by dateTo desc"

            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = Format(OleDBDR.Item(2), "MM/dd/yyyy") & " - " & Format(OleDBDR.Item(3), "MM/dd/yyyy")
                    dgw.Item(2, c).Value = Format(OleDBDR.Item(6), "N")
                    dgw.Item(3, c).Value = Format(OleDBDR.Item(7), "N")
                    dgw.Item(4, c).Value = Format(OleDBDR.Item(8), "N")
                    dgw.Item(5, c).Value = OleDBDR.Item(9)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub findPayroll()
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
                .CommandText = "select * from tblPayroll where dateFrom >= '" & dtpFrom.Value.ToString("MM/dd/yyyy") & "' and dateTo <= '" & _
                                dtpTo.Value.ToString("MM/dd/yyyy") & "' order by dateTo desc"

            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = Format(OleDBDR.Item(2), "MM/dd/yyyy") & " - " & Format(OleDBDR.Item(3), "MM/dd/yyyy")
                    dgw.Item(2, c).Value = Format(OleDBDR.Item(6), "N")
                    dgw.Item(3, c).Value = Format(OleDBDR.Item(7), "N")
                    dgw.Item(4, c).Value = Format(OleDBDR.Item(8), "N")
                    dgw.Item(5, c).Value = OleDBDR.Item(9)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPayroll()
        frmLoading.Show()
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
                .CommandText = "SELECT payrollID,tblEmployeesInfo.employeeID,lastname,firstname,middlename,totalWorkedDays,absent,regHolidays,NonWorkHolidays,leavePay,overtimeHRS," & _
                    "restdayReportHRS,lateUTMins,basicPay,regHolidayPay,nonWorkHolidayPay,leavePayCash,overtimePay,restdayReportAmount,lateUndertimeDed," & _
                    "cashAdvance,wHoldingTax,sssPrems,piPrems,phPrems,sssLoans,piLoans,ledgerBalance,Deduction,grossPay,Netpay FROM tblPayrollofEmployees " & _
                    "INNER JOIN tblEmployeesInfo ON tblPayrollofEmployees.employeeID = tblEmployeesInfo.employeeID" & _
                                " where payrollID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("datarange")
                .Columns.Add("date")
                .Columns.Add("payrollID")
                .Columns.Add("empID")
                .Columns.Add("name")
                .Columns.Add("twd")
                .Columns.Add("absent")
                .Columns.Add("rh")
                .Columns.Add("nwh")
                .Columns.Add("lp")
                .Columns.Add("ot")
                .Columns.Add("rdr")
                .Columns.Add("late")
                .Columns.Add("bp")
                .Columns.Add("rhp")
                .Columns.Add("nwhp")
                .Columns.Add("lpc")
                .Columns.Add("otp")
                .Columns.Add("rdrp")
                .Columns.Add("latep")
                .Columns.Add("ca")
                .Columns.Add("tax")
                .Columns.Add("sss")
                .Columns.Add("pi")
                .Columns.Add("ph")
                .Columns.Add("sssl")
                .Columns.Add("pil")
                .Columns.Add("lb")
                .Columns.Add("ded")
                .Columns.Add("gp")
                .Columns.Add("netpay")
                .Columns.Add("preparedby")
                

            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(dgw.CurrentRow.Cells(1).Value,
                                Format(Now, "MM/dd/yyyy"),
                                OleDBDR.Item(0),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2) & ", " & OleDBDR.Item(3) & " " & OleDBDR.Item(4),
                                Format(OleDBDR.Item(5), "N"),
                                Format(OleDBDR.Item(6), "N"),
                                Format(OleDBDR.Item(7), "N"),
                                Format(OleDBDR.Item(8), "N"),
                                Format(OleDBDR.Item(9), "N"),
                                Format(OleDBDR.Item(10), "N"),
                                Format(OleDBDR.Item(11), "N"),
                                Format(OleDBDR.Item(12), "N"),
                                Format(OleDBDR.Item(13), "N"),
                                Format(OleDBDR.Item(14), "N"),
                                Format(OleDBDR.Item(15), "N"),
                                Format(OleDBDR.Item(16), "N"),
                                Format(OleDBDR.Item(17), "N"),
                                Format(OleDBDR.Item(18), "N"),
                                Format(OleDBDR.Item(19), "N"),
                                Format(OleDBDR.Item(20), "N"),
                                Format(OleDBDR.Item(21), "N"),
                                Format(OleDBDR.Item(22), "N"),
                                Format(OleDBDR.Item(23), "N"),
                                Format(OleDBDR.Item(24), "N"),
                                Format(OleDBDR.Item(25), "N"),
                                Format(OleDBDR.Item(26), "N"),
                                Format(OleDBDR.Item(27), "N"),
                                Format(OleDBDR.Item(28), "N"),
                                Format(OleDBDR.Item(29), "N"),
                                Format(OleDBDR.Item(30), "N"),
                                frmMain.lblUsername.Text)
                    
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New Payroll
            rptDoc.SetDataSource(dt)
            frmReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoading.Close()
            frmReportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPayslip()
        frmLoading.Show()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            Dim c As Integer

            With OleDBC
                .Connection = conn
                .CommandText = "SELECT payrollID,tblEmployeesInfo.employeeID,lastname,firstname,middlename,position,rate,dateHired,totalWorkedDays,absent,regHolidays,NonWorkHolidays,leavePay,overtimeHRS," & _
                    "restdayReportHRS,lateUTMins,basicPay,regHolidayPay,nonWorkHolidayPay,leavePayCash,overtimePay,restdayReportAmount,lateUndertimeDed," & _
                    "cashAdvance,wHoldingTax,sssPrems,piPrems,phPrems,sssLoans,piLoans,ledgerBalance,Deduction,grossPay,Netpay FROM tblPayrollofEmployees " & _
                    "INNER JOIN tblEmployeesInfo ON tblPayrollofEmployees.employeeID = tblEmployeesInfo.employeeID" & _
                                " where payrollID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
                OleDBDR = OleDBC.ExecuteReader
                Dim dt As New DataTable
                With dt
                .Columns.Add("datarange")
                .Columns.Add("date")
                .Columns.Add("payrollID")
                .Columns.Add("empID")
                .Columns.Add("name")
                .Columns.Add("pos")
                .Columns.Add("rate")
                .Columns.Add("dateHired")
                .Columns.Add("twd")
                .Columns.Add("absent")
                .Columns.Add("rh")
                .Columns.Add("nwh")
                .Columns.Add("lp")
                .Columns.Add("ot")
                .Columns.Add("rdr")
                .Columns.Add("late")
                .Columns.Add("bp")
                .Columns.Add("rhp")
                .Columns.Add("nwhp")
                .Columns.Add("lpc")
                .Columns.Add("otp")
                .Columns.Add("rdrp")
                .Columns.Add("latep")
                .Columns.Add("ca")
                .Columns.Add("tax")
                .Columns.Add("sss")
                .Columns.Add("pi")
                .Columns.Add("ph")
                .Columns.Add("sssl")
                .Columns.Add("pil")
                .Columns.Add("lb")
                .Columns.Add("ded")
                .Columns.Add("gp")
                .Columns.Add("netpay")
                .Columns.Add("preparedby")


                End With

                If OleDBDR.HasRows Then
                    While OleDBDR.Read
                        c = 0
                        While c < 2
                        dt.Rows.Add(dgw.CurrentRow.Cells(1).Value,
                            Format(Now, "MM/dd/yyyy"),
                                OleDBDR.Item(0),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2) & ", " & OleDBDR.Item(3) & " " & OleDBDR.Item(4),
                                OleDBDR.Item(5),
                                OleDBDR.Item(6),
                                Format(OleDBDR.Item(7), "MM/dd/yyyy"),
                                Format(OleDBDR.Item(8), "N"),
                                Format(OleDBDR.Item(9), "N"),
                                Format(OleDBDR.Item(10), "N"),
                                Format(OleDBDR.Item(11), "N"),
                                Format(OleDBDR.Item(12), "N"),
                                Format(OleDBDR.Item(13), "N"),
                                Format(OleDBDR.Item(14), "N"),
                                Format(OleDBDR.Item(15), "N"),
                                Format(OleDBDR.Item(16), "N"),
                                Format(OleDBDR.Item(17), "N"),
                                Format(OleDBDR.Item(18), "N"),
                                Format(OleDBDR.Item(19), "N"),
                                Format(OleDBDR.Item(20), "N"),
                                Format(OleDBDR.Item(21), "N"),
                                Format(OleDBDR.Item(22), "N"),
                                Format(OleDBDR.Item(23), "N"),
                                Format(OleDBDR.Item(24), "N"),
                                Format(OleDBDR.Item(25), "N"),
                                Format(OleDBDR.Item(26), "N"),
                                Format(OleDBDR.Item(27), "N"),
                                Format(OleDBDR.Item(28), "N"),
                                Format(OleDBDR.Item(29), "N"),
                                Format(OleDBDR.Item(30), "N"),
                                Format(OleDBDR.Item(31), "N"),
                                Format(OleDBDR.Item(32), "N"),
                                Format(OleDBDR.Item(33), "N"),
                                frmMain.lblUsername.Text)
                            c = c + 1
                        End While
                    End While
                End If
                Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptDoc = New Payslip
                rptDoc.SetDataSource(dt)
                frmReportViewer.CrystalReportViewer1.ReportSource = rptDoc
                frmLoading.Close()
                frmReportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmAllPayrollHistory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            dgw.ClearSelection()
        End If
    End Sub
    Private Sub ContextMenuStrip1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip1.Closing
        dgw.ContextMenuStrip = ContextMenuStrip2
    End Sub
    Private Sub PrintPayrollToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPayrollToolStripMenuItem.Click
        printPayroll()
    End Sub

    Private Sub PrintPayslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPayslipToolStripMenuItem.Click
        printPayslip()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        findPayroll()
    End Sub
    Private Sub CancelPayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelPayrollToolStripMenuItem.Click
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
                .CommandText = "select max(payrollID) from tblPayroll"

            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    payrollMaxID = OleDBDR.Item(0)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If payrollMaxID = dgw.CurrentRow.Cells(0).Value Then
            deletePayroll()
            ShowAllPayrollHistory()
        Else
            MsgBox("you cannot delete this payroll", MsgBoxStyle.Critical, "error")
        End If
    End Sub
    Private Sub frmAllPayrollHistory_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowAllPayrollHistory()
    End Sub


    Private Sub dgw_CellMouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                dgw.ContextMenuStrip = ContextMenuStrip1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class