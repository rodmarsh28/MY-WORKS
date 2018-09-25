Public Class dateReportViewer
    Sub showType()
        Try
            Dim c As Integer
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct Type from tblPOITEM order by Type asc "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                dgw.Rows.Add()
                dgw.Item(0, c).Value = "ALL"
                c = c + 1
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPOReport()

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
                If dgw.CurrentRow.Cells(0).Value = "ALL" Then
                    .CommandText = "SELECT type,itemdesc,unit,Sum(qty),Sum(amount) FROM dbo.tblPOITEM INNER JOIN dbo.tblPODESC ON dbo.tblPODESC.PONO = dbo.tblPOITEM.PONO " & _
                    "WHERE date BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "' " & _
                    " and POSTATUS <> 'WAITING FOR CASH/CHECK ISSUANCE' GROUP BY type,itemdesc,unit"
                Else
                    .CommandText = "SELECT type,itemdesc,unit,Sum(qty),Sum(amount) FROM dbo.tblPOITEM INNER JOIN dbo.tblPODESC ON dbo.tblPODESC.PONO = dbo.tblPOITEM.PONO " & _
                   "WHERE date BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "' " & _
                   " and POSTATUS <> 'WAITING FOR CASH/CHECK ISSUANCE' and Type like '%" & dgw.CurrentRow.Cells(0).Value & "%' GROUP BY type,itemdesc,unit"
                End If
               
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("TYPE")
                .Columns.Add("ITEMDESC")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
                .Columns.Add("TOTAL AMOUNT")
                .Columns.Add("FILTER")
                .Columns.Add("DATERANGE")
                .Columns.Add("PREPAREDBY")

            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0),
                                OleDBDR.Item(1),
                                OleDBDR.Item(2),
                                Format(OleDBDR.Item(3), "###,###"),
                                Format(OleDBDR.Item(4), "N"),
                                "ITEM / MATERIAL TYPE : " & dgw.CurrentRow.Cells(0).Value,
                                "Date Period    " & Format(dtpFrom.Value, "MM/dd/yyyy") & " - " & Format(dtpTo.Value, "MM/dd/yyyy"),
                                MainForm.LBLNAME.Text)
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New itemMaterialPurchasedReport
            rptDoc.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rptDoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dateReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFrom.Value = "01/01/2000"
        showType()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgw.SelectedRows.Count < 0 Then
            MsgBox("Please Select Type to Continue")
        Else
            printPOReport()
        End If
    End Sub
End Class