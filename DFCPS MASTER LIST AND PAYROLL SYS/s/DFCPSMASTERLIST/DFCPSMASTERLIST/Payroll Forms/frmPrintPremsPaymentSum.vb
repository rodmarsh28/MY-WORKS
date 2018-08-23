Public Class frmPrintPremsPaymentSum

    Sub printPremsSum()
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
                .CommandText = "SELECT tblEmployeesInfo.employeeID,tblEmployeesInfo.lastname,tblEmployeesInfo.firstname," & _
                    "tblEmployeesInfo.middlename,tblPayrollofEmployees.sssPrems,tblPayrollofEmployees.piPrems,tblPayrollofEmployees.phPrems," & _
                    "tblBenefitsPaymentSum.erSSS,tblBenefitsPaymentSum.erPI,tblBenefitsPaymentSum.erPH FROM tblPayrollofEmployees INNER JOIN " & _
                    "tblEmployeesInfo ON tblPayrollofEmployees.employeeID = tblEmployeesInfo.employeeID INNER JOIN tblBenefitsPaymentSum ON " & _
                    "tblPayrollofEmployees.empPayrollTransNo = tblBenefitsPaymentSum.empPayrollTransNo " & _
                    "where tblPayrollofEmployees.payrollID = '" & dgw.CurrentRow.Cells(0).Value & "'"


            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("dateofprems")
                .Columns.Add("empid")
                .Columns.Add("name")
                .Columns.Add("sssee")
                .Columns.Add("piee")
                .Columns.Add("phee")
                .Columns.Add("ssser")
                .Columns.Add("pier")
                .Columns.Add("pher")
                .Columns.Add("preparedby")

            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(dgw.CurrentRow.Cells(1).Value,
                                OleDBDR.Item(0),
                                OleDBDR.Item(1) & ", " & OleDBDR.Item(2) & " " & OleDBDR.Item(3),
                                Format(OleDBDR.Item(4), "N"),
                                Format(OleDBDR.Item(5), "N"),
                                Format(OleDBDR.Item(6), "N"),
                                Format(OleDBDR.Item(7), "N"),
                                Format(OleDBDR.Item(8), "N"),
                                Format(OleDBDR.Item(9), "N"),
                                "Elvira Dela Serna")
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New premsSummary
            rptDoc.SetDataSource(dt)
            frmReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoading.Close()
            frmReportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Sub getMonth()
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
                .CommandText = "select payrollID,DATENAME(month, dateto), YEAR(dateTo) " & _
                                "from tblPayroll " & _
                                "where dateto like '%31%' or dateto like '%30%' or dateto like '%29%' or dateto like '%28%' or dateto like '%27%'"

            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1) & "  " & OleDBDR.Item(2)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPrintPremsPaymentSum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getMonth()
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub dgw_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDoubleClick
        MsgBox(dgw.CurrentRow.Cells(1).Value)
        printPremsSum()
    End Sub
End Class