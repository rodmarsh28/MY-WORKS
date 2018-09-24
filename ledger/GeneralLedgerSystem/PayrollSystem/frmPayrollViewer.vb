Public Class frmPayrollViewer

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmEmployeeLisst.mode = "1"
        frmEmployeeLisst.Show()
    End Sub
    Sub showEmployeesPayroll()
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
                .CommandText = "select * from tblPayroll where empID = '" & txtemID.Text & "' order by DATETO desc"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = Format(OleDBDR.Item(2), "MM/dd/yyyy") & " - " & Format(OleDBDR.Item(3), "MM/dd/yyyy")
                    dgw.Item(2, c).Value = OleDBDR.Item(10)
                    dgw.Item(3, c).Value = OleDBDR.Item(11)
                    c = c + 1
                End While
            Else
                MsgBox("This Employee not have generated payroll", MsgBoxStyle.Critical, "Sorry")
            End If
            dgw.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PrintPayslip()
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
                .CommandText = "SELECT dbo.tblEmployee.EMPID,dbo.tblPayroll.DATEFROM,dbo.tblPayroll.DATETO,dbo.tblEmployee.NAME,dbo.tblEmployee.[POSITION],dbo.tblEmployee.RATE,dbo.tblEmployee.DATEHIRED,dbo.tblPayroll.REGWORKDAYS," & _
                    "dbo.tblPayroll.SPECHOLIDAYS,dbo.tblPayroll.NONWORKHOLIDAYS,dbo.tblPayroll.OVERTIME,dbo.tblPayroll.LATEUNDERTIME,dbo.tblPayrollCash.REGWORKCASH,dbo.tblPayrollCash.OVERTIMECASH," & _
                    "dbo.tblPayrollCash.SPECHOLIDAYCASH,dbo.tblPayrollCash.NONWORKHOLIDAYCASH,dbo.tblPayrollDeductions.LATEUNDERTIMECASH,dbo.tblPayrollDeductions.SSS,dbo.tblPayrollDeductions.PAGIBIG," & _
                    "dbo.tblPayrollDeductions.PHILHEALTH,dbo.tblPayrollDeductions.WHOLDINGTAX,dbo.tblPayrollDeductions.CASHADVANCE,dbo.tblPayroll.TOTALDEDUCTIONS,dbo.tblPayroll.GROSSPAY,dbo.tblPayroll.NETPAY " & _
                    "FROM dbo.tblEmployee ,dbo.tblPayroll ,dbo.tblPayrollCash ,dbo.tblPayrollDeductions where dbo.tblPayroll.payrollID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("EMPID")
                .Columns.Add("DATEPERIOD")
                .Columns.Add("NAME")
                .Columns.Add("POSITION")
                .Columns.Add("RATE")
                .Columns.Add("DATEHIRED")
                .Columns.Add("REGWORKDAYS")
                .Columns.Add("SPECHOLIDAYS")
                .Columns.Add("NONWORKHOLIDAYS")
                .Columns.Add("OVERTIME")
                .Columns.Add("LATEUNDERTIME")
                .Columns.Add("REGWORKCASH")
                .Columns.Add("OVERTIMECASH")
                .Columns.Add("SPECHOLIDAYCASH")
                .Columns.Add("NONWORKHOLIDAYCASH")
                .Columns.Add("LATEUNDERTIMECASH")
                .Columns.Add("SSS")
                .Columns.Add("PAGIBIG")
                .Columns.Add("PHILHEALTH")
                .Columns.Add("WHOLDINGTAX")
                .Columns.Add("CASHADVANCE")
                .Columns.Add("TOTALDEDUCTIONS")
                .Columns.Add("GROSSPAY")
                .Columns.Add("NETPAY")
                .Columns.Add("DATEISSUED")

            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MMMM") & " " & Format(OleDBDR.Item(1), "dd") & " - " + Format(OleDBDR.Item(2), "dd") & " " & Format(OleDBDR.Item(2), "yyyy"),
                                OleDBDR.Item(3), OleDBDR.Item(4), Format(OleDBDR.Item(5), "0.00"), Format(OleDBDR.Item(6), "MM/dd/yyyy"), OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9),
                                OleDBDR.Item(10), OleDBDR.Item(11), Format(OleDBDR.Item(12), "0.00"), Format(OleDBDR.Item(13), "0.00"), Format(OleDBDR.Item(14), "0.00"),
                                Format(OleDBDR.Item(15), "0.00"), Format(OleDBDR.Item(16), "0.00"), Format(OleDBDR.Item(17), "0.00"), Format(OleDBDR.Item(18), "0.00"),
                                 Format(OleDBDR.Item(19), "0.00"), Format(OleDBDR.Item(20), "0.00"), Format(OleDBDR.Item(21), "0.00"), Format(OleDBDR.Item(22), "0.00"),
                                  Format(OleDBDR.Item(23), "0.00"), Format(OleDBDR.Item(24), "0.00"), Format(Now, "MM/dd/yyyy"))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New payslip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtemID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemID.TextChanged
        
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

    Private Sub PrintPayslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPayslipToolStripMenuItem.Click
        PrintPayslip()
    End Sub
End Class