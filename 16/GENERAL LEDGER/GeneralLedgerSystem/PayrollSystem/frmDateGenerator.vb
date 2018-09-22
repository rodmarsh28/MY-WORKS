Public Class frmDateGenerator

    Private Sub frmDateGenerator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
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
                .CommandText = "SELECT dbo.tblPayroll.DATEFROM,dbo.tblPayroll.DATETO,dbo.tblEmployee.NAME,dbo.tblPayroll.REGWORKDAYS,dbo.tblPayroll.SPECHOLIDAYS,dbo.tblPayroll.NONWORKHOLIDAYS," & _
                                "dbo.tblPayroll.LEAVEPAY,dbo.tblPayroll.OVERTIME,dbo.tblPayroll.LATEUNDERTIME,dbo.tblPayrollCash.REGWORKCASH," & _
                                "dbo.tblPayrollCash.SPECHOLIDAYCASH,dbo.tblPayrollCash.NONWORKHOLIDAYCASH,dbo.tblPayroll.LEAVEPAY,dbo.tblPayrollCash.OVERTIMECASH,dbo.tblPayroll.GROSSPAY," & _
                                "dbo.tblPayrollDeductions.LATEUNDERTIMECASH,dbo.tblPayrollDeductions.SSS,dbo.tblPayrollDeductions.PAGIBIG,dbo.tblPayrollDeductions.PHILHEALTH," & _
                                "dbo.tblPayrollDeductions.CASHADVANCE,dbo.tblPayroll.TOTALDEDUCTIONS,dbo.tblPayroll.NETPAY,dbo.tblPayroll.DATEGENERATE FROM dbo.tblEmployee " & _
                                "INNER JOIN dbo.tblPayroll ON dbo.tblPayroll.EMPID = dbo.tblEmployee.EMPID ,dbo.tblPayrollCash ,dbo.tblPayrollDeductions" & _
                                "where dbo.tblPayroll.DATEFROM = '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and dbo.tblPayroll.DATETO = '" & Format(dtpTo.Value, "MM/dd/yyyy") & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("DATERANGE")
                .Columns.Add("Name")
                .Columns.Add("Worked Days")
                .Columns.Add("Holidays")
                .Columns.Add("NonWorkingHolidays")
                .Columns.Add("leavepay")
                .Columns.Add("overtime(hrs)")
                .Columns.Add("lateundertime(min)")
                .Columns.Add("Basic Pay")
                .Columns.Add("RegularHolidayCash")
                .Columns.Add("NonWorkingHolidaysCash")
                .Columns.Add("Leave Pay")
                .Columns.Add("Overtime / Restday Report")
                .Columns.Add("Gross Pay") '14
                .Columns.Add("Late / Undertime")
                .Columns.Add("SSS Premiums")
                .Columns.Add("Pagibig Premiums")
                .Columns.Add("Philhealth Premiums")
                .Columns.Add("Cash Advance")
                .Columns.Add("Total Deduction") '20
                .Columns.Add("Net Pay") '21
                .Columns.Add("DATE")
                .Columns.Add("totalAllDed")
                .Columns.Add("totalAllGross")
                .Columns.Add("totalAllNet")
            End With

            Dim totAllGross As Double = 0.0
            Dim totAllDed As Double = 0.0
            Dim totAllNet As Double = 0.0

            If OleDBDR.HasRows Then
                While OleDBDR.Read

                    totAllGross = totAllGross + OleDBDR.Item(14)
                    totAllDed = totAllDed + OleDBDR.Item(20)
                    totAllNet = totAllNet + OleDBDR.Item(21)

                    dt.Rows.Add(Format(OleDBDR.Item(0), "MMMM") & " " & Format(OleDBDR.Item(0), "dd") & " - " + Format(OleDBDR.Item(1), "dd") & " " & Format(OleDBDR.Item(1), "yyyy"),
                                OleDBDR.Item(2), OleDBDR.Item(3).ToString("0.00"), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6), OleDBDR.Item(7), OleDBDR.Item(8).ToString("0.0"),
                                OleDBDR.Item(9).ToString("0.0"), OleDBDR.Item(10).ToString("0.00"), OleDBDR.Item(11).ToString("0.00"), OleDBDR.Item(12).ToString("0.00"),
                                OleDBDR.Item(13).ToString("0.00"), OleDBDR.Item(14).ToString("0.00"), OleDBDR.Item(15).ToString("0.00"), OleDBDR.Item(16).ToString("0.00"),
                                OleDBDR.Item(17).ToString("0.00"), OleDBDR.Item(18).ToString("0.00"), OleDBDR.Item(19).ToString("0.00"), OleDBDR.Item(20).ToString("0.00"),
                                OleDBDR.Item(21).ToString("0.00"), Format(OleDBDR.Item(22), "MM/dd/yyyy"), totAllGross, totAllDed, totAllNet)
                End While
            Else
                MsgBox("NO PAYROLL GENERATED IN THIS DATE RANGE", MsgBoxStyle.Critical, "SORRY")
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New payroll
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class