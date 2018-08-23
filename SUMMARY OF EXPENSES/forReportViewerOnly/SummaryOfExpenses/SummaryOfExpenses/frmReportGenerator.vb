Public Class frmReportGenerator
    Sub lastupdate()
        Try
            strConnString = "Server=db4free.net;Port=3306;Database=dfcexpsum;Uid=dfcship;Pwd=greatmarsh;old guids=true;connection timeout=100;"
            conn.ConnectionString = strConnString
            conn.Open()
            Dim lu As Date
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT value FROM tblsystemsettings where settingsName = 'LastUpdate'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    lu = Date.ParseExact(OleDBDR.Item(0), "MM/dd/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    lblLU.Text = "Last Update : " & Format(lu, "MMMM") & " " & Format(lu, "dd") & ", " & Format(lu, "yyyy")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub selectType()
        Try
           OleDBDR.Dispose()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT DISTINCT expenseType FROM tblsummaryexpenses where vid = '" & PlateList.dgw.CurrentRow.Cells(0).Value & "'"

            End With
            OleDBDR = OleDBC.ExecuteReader
            cmbType.Items.Clear()
            cmbType.Items.Add("All")
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    cmbType.Items.Add(OleDBDR.Item(0))
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reportQuery()
        Try
           OleDBDR.Dispose()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT tblsummaryexpenses.date,tblvehicle.plateNo,tblvehicle.vehicleModel,tblsummaryexpenses.expenseType," & _
                    "tblsummaryexpenses.qty,tblsummaryexpenses.unit,tblsummaryexpenses.unitPrice,tblsummaryexpenses.totalPrice,tblsummaryexpenses.yearUsed " & _
                    "FROM tblsummaryexpenses INNER JOIN tblvehicle ON tblsummaryexpenses.vID = tblvehicle.vID " & _
                    "where plateNo = '" & txtPlate.Text & "' and expenseType = '" & cmbType.Text & "' and date between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & _
                    "' and '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("date")
                .Columns.Add("plateNo")
                .Columns.Add("vehicleModel")
                .Columns.Add("expenseType")
                .Columns.Add("noofYearsUsed")
                .Columns.Add("qty")
                .Columns.Add("unitPrice")
                .Columns.Add("totalPrice")
                .Columns.Add("datePeriod")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(Format(OleDBDR.Item(0), "MM/dd/yyyy"),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2),
                                OleDBDR.Item(3),
                                OleDBDR.Item(8),
                                OleDBDR.Item(4) & " " & OleDBDR.Item(5),
                                Format(OleDBDR.Item(6), "N"),
                                Format(OleDBDR.Item(7), "N"),
                                dtpFrom.Text & "-" & dtpTo.Text)
                End While
            Else
                dt.Rows.Add("",
                              txtPlate.Text,
                              PlateList.dgw.CurrentRow.Cells(2).Value,
                              cmbType.Text,
                              "",
                              "",
                              "",
                              "",
                              dtpFrom.Text & "-" & dtpTo.Text)
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New SummaryReport
            rptDoc.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rptDoc
            frmLoading.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reportQueryForFuel()
        Try
            OleDBDR.Dispose()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT tblsummaryexpenses.date,tblvehicle.plateNo,tblvehicle.vehicleModel,tblsummaryexpenses.expenseType," & _
                    "tblsummaryexpenses.prevOdometer,tblsummaryexpenses.currentOdometer,tblsummaryexpenses.kml,tblsummaryexpenses.qty," & _
                    "tblsummaryexpenses.unit,tblsummaryexpenses.unitPrice,tblsummaryexpenses.totalPrice FROM tblsummaryexpenses INNER JOIN " & _
                    "tblvehicle ON tblsummaryexpenses.vID = tblvehicle.vID " & _
                    "where plateNo = '" & txtPlate.Text & "' and expenseType = '" & cmbType.Text & "' and date between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & _
                    "' and '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("date")
                .Columns.Add("plateNo")
                .Columns.Add("vehicleModel")
                .Columns.Add("expenseType")
                .Columns.Add("prevOdometer")
                .Columns.Add("currentOdometer")
                .Columns.Add("KML")
                .Columns.Add("qty")
                .Columns.Add("unitPrice")
                .Columns.Add("totalPrice")
                .Columns.Add("datePeriod")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(Format(OleDBDR.Item(0), "MM/dd/yyyy"),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2),
                                OleDBDR.Item(3),
                                OleDBDR.Item(4),
                                OleDBDR.Item(5),
                                Format(OleDBDR.Item(6), "N"),
                                OleDBDR.Item(7) & " " & OleDBDR.Item(8),
                                Format(OleDBDR.Item(9), "N"),
                                Format(OleDBDR.Item(10), "N"),
                                dtpFrom.Text & "-" & dtpTo.Text)
                End While
            Else
                dt.Rows.Add("",
                              txtPlate.Text,
                              PlateList.dgw.CurrentRow.Cells(2).Value,
                              cmbType.Text,
                              "",
                              "",
                              "",
                              "",
                              "",
                              "",
                              dtpFrom.Text & "-" & dtpTo.Text)
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New SummaryReportforFuel
            rptDoc.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rptDoc
            frmLoading.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reportQueryPerUnit()
        Try
           OleDBDR.Dispose()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT tblsummaryexpenses.date,tblvehicle.plateNo,tblvehicle.vehicleModel,tblsummaryexpenses.expenseType," & _
                    "tblsummaryexpenses.prevOdometer,tblsummaryexpenses.currentOdometer,tblsummaryexpenses.kml,tblsummaryexpenses.qty," & _
                    "tblsummaryexpenses.unit,tblsummaryexpenses.unitPrice,tblsummaryexpenses.totalPrice,tblsummaryexpenses.yearUsed FROM tblsummaryexpenses INNER JOIN " & _
                    "tblvehicle ON tblsummaryexpenses.vID = tblvehicle.vID " & _
                    "where plateNo = '" & txtPlate.Text & "' and date between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & _
                    "' and '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("date")
                .Columns.Add("plateNo")
                .Columns.Add("vehicleModel")
                .Columns.Add("expenseType")
                .Columns.Add("prevOdometer")
                .Columns.Add("currentOdometer")
                .Columns.Add("KML")
                .Columns.Add("qty")
                .Columns.Add("unitPrice")
                .Columns.Add("totalPrice")
                .Columns.Add("datePeriod")
                .Columns.Add("yearUsed")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(Format(OleDBDR.Item(0), "MM/dd/yyyy"),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2),
                                OleDBDR.Item(3),
                                OleDBDR.Item(4),
                                OleDBDR.Item(5),
                                Format(OleDBDR.Item(6), "N"),
                                OleDBDR.Item(7) & " " & OleDBDR.Item(8),
                                Format(OleDBDR.Item(9), "N"),
                                Format(OleDBDR.Item(10), "N"),
                                dtpFrom.Text & "-" & dtpTo.Text,
                                OleDBDR.Item(11))
                End While
            Else
                dt.Rows.Add("",
                              txtPlate.Text,
                              PlateList.dgw.CurrentRow.Cells(2).Value,
                              "",
                              "",
                              "",
                              "",
                              "",
                              "",
                              "",
                              dtpFrom.Text & "-" & dtpTo.Text)
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New SummaryReportPerUnit
            rptDoc.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rptDoc
            frmLoading.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub reportQuerySalaries()
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
                .CommandText = "SELECT tblsummaryexpenses.date,tblvehicle.plateNo,tblvehicle.vehicleModel,tblsummaryexpenses.expenseType," & _
                    "tblsummaryexpenses.qty,tblsummaryexpenses.unit,tblsummaryexpenses.unitPrice,tblsummaryexpenses.totalPrice,tblsummaryexpenses.yearUsed,tblsummaryexpenses.remarks " & _
                    "FROM tblsummaryexpenses INNER JOIN tblvehicle ON tblsummaryexpenses.vID = tblvehicle.vID " & _
                    "where plateNo = '" & txtPlate.Text & "' and expenseType = '" & cmbType.Text & "' and date between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & _
                    "' and '" & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("date")
                .Columns.Add("plateNo")
                .Columns.Add("vehicleModel")
                .Columns.Add("expenseType")
                .Columns.Add("noofYearsUsed")
                .Columns.Add("qty")
                .Columns.Add("unitPrice")
                .Columns.Add("totalPrice")
                .Columns.Add("datePeriod")
                .Columns.Add("remarks")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(Format(OleDBDR.Item(0), "MM/dd/yyyy"),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2),
                                OleDBDR.Item(3),
                                OleDBDR.Item(8),
                                OleDBDR.Item(4) & " " & OleDBDR.Item(5),
                                Format(OleDBDR.Item(6), "N"),
                                Format(OleDBDR.Item(7), "N"),
                                dtpFrom.Text & "-" & dtpTo.Text,
                                Format(OleDBDR.Item(9)))
                End While
            Else
                dt.Rows.Add("",
                              txtPlate.Text,
                              PlateList.dgw.CurrentRow.Cells(2).Value,
                              cmbType.Text,
                              "",
                              "",
                              "",
                              "",
                              dtpFrom.Text & "-" & dtpTo.Text,
                              "")
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New SummaryReportforSalariesWages
            rptDoc.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rptDoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        PlateList.ShowDialog()

    End Sub
  

    Private Sub frmReportGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.Text = "All"
        lastupdate()
        Timer1.Start()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        If cmbType.Text = "" Or txtPlate.Text = "" Then
            MsgBox("please select record first", MsgBoxStyle.Critical, "error")
        Else
            frmLoading.Show()
            If cmbType.Text = "Fuel" Then
                reportQueryForFuel()
            ElseIf cmbType.Text = "All" Then
                reportQueryPerUnit()
            ElseIf cmbType.Text = "Salaries & Wages" Then
                reportQuerySalaries()
            Else
                reportQuery()

            End If
            frmLoading.Close()
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmExpensesHistory.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmVehicleMasterList.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CheckForInternetConnection()
    End Sub
End Class