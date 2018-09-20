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
                .CommandText = "SELECT dbo.tblEmployeesInfo.employeeID,dbo.tblEmployeesInfo.lastname,dbo.tblEmployeesInfo.firstname,dbo.tblEmployeesInfo.middlename,dbo.tblEmployeesInfo.sssNo," & _
                    "dbo.tblEmployeesInfo.piNo,dbo.tblEmployeesInfo.phNo,dbo.tblPayrollofEmployees.sssPrems,dbo.tblBenefitsPaymentSum.erSSS,dbo.tblPayrollofEmployees.piPrems," & _
                    "dbo.tblBenefitsPaymentSum.erPI,dbo.tblPayrollofEmployees.phPrems,dbo.tblBenefitsPaymentSum.erPH FROM dbo.tblPayrollofEmployees INNER JOIN dbo.tblEmployeesInfo " & _
                    "ON dbo.tblPayrollofEmployees.employeeID = dbo.tblEmployeesInfo.employeeID INNER JOIN dbo.tblBenefitsPaymentSum ON dbo.tblPayrollofEmployees.empPayrollTransNo = " & _
                    "dbo.tblBenefitsPaymentSum.empPayrollTransNo " & _
                    "where tblPayrollofEmployees.payrollID = '" & dgw.CurrentRow.Cells(0).Value & "' and sssPrems <> 0 OR erSSS <> 0 OR piPrems <> 0 OR erPI <> 0 OR phPrems <> 0 OR erph <> 0"


            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("dateofprems")
                .Columns.Add("employeeID")
                .Columns.Add("name")
                .Columns.Add("sssNo")
                .Columns.Add("piNo")
                .Columns.Add("phNo")
                .Columns.Add("sssee")
                .Columns.Add("ssser")
                .Columns.Add("totalsss")
                .Columns.Add("piee")
                .Columns.Add("pier")
                .Columns.Add("totalpi")
                .Columns.Add("phee")
                .Columns.Add("pher")
                .Columns.Add("totalph")
                .Columns.Add("preparedby")

            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(UCase(dgw.CurrentRow.Cells(1).Value),
                                OleDBDR.Item(0),
                                OleDBDR.Item(1) & ", " & OleDBDR.Item(2) & " " & OleDBDR.Item(3),
                                OleDBDR.Item(4),
                                OleDBDR.Item(5),
                                OleDBDR.Item(6),
                                Format(OleDBDR.Item(7), "N"),
                                Format(OleDBDR.Item(8), "N"),
                                Format(OleDBDR.Item(7) + OleDBDR.Item(8), "N"),
                                Format(OleDBDR.Item(9), "N"),
                                Format(OleDBDR.Item(10), "N"),
                                Format(OleDBDR.Item(9) + OleDBDR.Item(10), "N"),
                                Format(OleDBDR.Item(11), "N"),
                                Format(OleDBDR.Item(12), "N"),
                                Format(OleDBDR.Item(11) + OleDBDR.Item(12), "N"),
                                frmMain.lblUsername.Text)
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New premsSummary
            rptDoc.SetDataSource(dt)
            'frmReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            'frmLoading.Close()
            'frmReportViewer.ShowDialog()
            rptDoc.PrintToPrinter(1, False, 0, 0)
            rptDoc.PrintOptions.PrinterName = printDialog.cmbPrinterList.Text
            printPremsSums()
            MsgBox("Report Successfully Printed !", MsgBoxStyle.Information)
            printDialog.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPremsSums()
        'frmLoading.Show()
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
                .CommandText = "SELECT dbo.tblEmployeesInfo.employeeID,dbo.tblEmployeesInfo.lastname,dbo.tblEmployeesInfo.firstname,dbo.tblEmployeesInfo.middlename,dbo.tblEmployeesInfo.rate," & _
                    "dbo.tblEmployeesInfo.payMethod,dbo.tblEmployeesInfo.sssNo,dbo.tblEmployeesInfo.piNo,dbo.tblEmployeesInfo.phNo,dbo.tblPayrollofEmployees.sssPrems," & _
                    "dbo.tblBenefitsPaymentSum.erSSS,dbo.tblPayrollofEmployees.piPrems,dbo.tblBenefitsPaymentSum.erPI,dbo.tblPayrollofEmployees.phPrems,dbo.tblBenefitsPaymentSum.erPH " & _
                    "FROM dbo.tblPayrollofEmployees INNER JOIN dbo.tblEmployeesInfo ON dbo.tblPayrollofEmployees.employeeID = dbo.tblEmployeesInfo.employeeID INNER JOIN dbo.tblBenefitsPaymentSum ON " & _
                    "dbo.tblPayrollofEmployees.empPayrollTransNo = dbo.tblBenefitsPaymentSum.empPayrollTransNo " & _
                    "where tblPayrollofEmployees.payrollID = '" & dgw.CurrentRow.Cells(0).Value & "' and sssPrems <> 0 OR erSSS <> 0 OR piPrems <> 0 OR erPI <> 0 OR phPrems <> 0 OR erph <> 0"


            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("dateofprems")
                .Columns.Add("employeeID")
                .Columns.Add("name")
                .Columns.Add("rate")
                .Columns.Add("sssNo")
                .Columns.Add("piNo")
                .Columns.Add("phNo")
                .Columns.Add("sssee")
                .Columns.Add("ssser")
                .Columns.Add("totalssswoec")
                .Columns.Add("ec")
                .Columns.Add("totalsss")
                .Columns.Add("piee")
                .Columns.Add("pier")
                .Columns.Add("totalpi")
                .Columns.Add("phee")
                .Columns.Add("pher")
                .Columns.Add("totalph")
                .Columns.Add("preparedby")

            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    Dim rate As Double
                    Dim ec As Double
                    If OleDBDR.Item(5) = "Daily" Then
                        rate = OleDBDR.Item(4) * 26
                    Else
                        rate = OleDBDR.Item(4)
                    End If
                    If rate <= 14750 Then
                        ec = 10.0
                    ElseIf rate > 14750 Then
                        ec = 30.0
                    End If
                    dt.Rows.Add(dgw.CurrentRow.Cells(1).Value,
                                OleDBDR.Item(0),
                                OleDBDR.Item(1) & ", " & OleDBDR.Item(2) & " " & OleDBDR.Item(3),
                                Format(rate, "N"),
                                OleDBDR.Item(6),
                                OleDBDR.Item(7),
                                OleDBDR.Item(8),
                                Format(OleDBDR.Item(9), "N"),
                                Format(OleDBDR.Item(10) - ec, "N"),
                                Format(OleDBDR.Item(9) + OleDBDR.Item(10) - ec, "N"),
                                Format(ec, "N"),
                                Format(OleDBDR.Item(9) + OleDBDR.Item(10), "N"),
                                Format(OleDBDR.Item(11), "N"),
                                Format(OleDBDR.Item(12), "N"),
                                Format(OleDBDR.Item(11) + OleDBDR.Item(12), "N"),
                                Format(OleDBDR.Item(13), "N"),
                                Format(OleDBDR.Item(14), "N"),
                                Format(OleDBDR.Item(13) + OleDBDR.Item(14), "N"),
                                frmMain.lblUsername.Text)
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New premsReport
            rptDoc.SetDataSource(dt)
            'frmReportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoading.Close()
            'frmReportViewer.ShowDialog()
            rptDoc.PrintToPrinter(1, False, 0, 0)
            rptDoc.PrintOptions.PrinterName = printDialog.cmbPrinterList.Text
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
                                "where dateto like '%31%' or dateto like '%30%' or dateto like '%29%' or dateto like '%28%' or dateto like '%27%' and remarks = 'Admin'"

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
        printDialog.ShowDialog()
    End Sub
End Class