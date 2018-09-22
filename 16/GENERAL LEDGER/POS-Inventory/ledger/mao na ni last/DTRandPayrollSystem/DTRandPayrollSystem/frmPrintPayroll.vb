Public Class frmPrintPayroll

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable

        With dt
            .Columns.Add("Name")
            .Columns.Add("Basic Pay")
            .Columns.Add("RegularHolidays")
            .Columns.Add("NonWorkingHolidays")
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


        End With
        For Each dr As DataGridViewRow In Me.dgw.Rows

            dt.Rows.Add(dr.Cells("Column1").Value, dr.Cells("Column2").Value, dr.Cells("Column3").Value, dr.Cells("Column4").Value, dr.Cells("Column5").Value, _
                        dr.Cells("Column8").Value, dr.Cells("Column6").Value, dr.Cells("Column7").Value, dr.Cells("Column9").Value, dr.Cells("Column10").Value, dr.Cells("Column11").Value _
                        , dr.Cells("Column12").Value, dr.Cells("Column13").Value, dr.Cells("Column14").Value)
        Next

        '
        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New CrystalReport1
        rptDoc.SetDataSource(dt)
        '
        frmReport.CrystalReportViewer1.ReportSource = rptDoc
        frmReport.ShowDialog()


    End Sub

    Private Sub frmPrintPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class