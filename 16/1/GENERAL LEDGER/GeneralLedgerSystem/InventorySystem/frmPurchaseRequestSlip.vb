Public Class frmPurchaseRequestSlip
    Public rows As Integer = 0
    Dim materialDesc As String
    Dim Serial As String
    Dim invntyCode As String
    Dim unit As String
    Dim quantity As String
    Dim stockOnHand As String

    Sub clear()
        txtMaterialDesc.Text = ""
        txtSerial.Text = ""
        txtUnit.Text = ""
        txtQuantity.Text = ""
    End Sub
    Sub selectPrsNo()
        Dim StrID As String
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
                .CommandText = "SELECT * from tblPRSDESC order by PRSNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtPrsNo.Text = "PRS-" & Format(Val(StrID) + 1, "00000")
            Else
                txtPrsNo.Text = "PRS-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub addtoDGW()
        dgw.ClearSelection()
        dgw.Rows.Add()
        dgw.Item(0, rows).Value = "-"
        dgw.Item(1, rows).Value = txtMaterialDesc.Text
        dgw.Item(2, rows).Value = txtSerial.Text
        dgw.Item(3, rows).Value = txtUnit.Text
        dgw.Item(4, rows).Value = txtQuantity.Text
        dgw.Item(5, rows).Value = "0"
        rows = dgw.RowCount
        clear()
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO CREATE AND SAVE PURCHASE REQUEST SLIP ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "INSERT INTO tblPRSDESC VALUES('" & txtPrsNo.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txRemarks.Text & _
                        "','" & txtPreparedBy.Text & _
                        "','" & txtApprovedBy.Text & "','PENDING FOR PO')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                printPRS()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE PURCHASE REQUEST HAS BEEN CREATED!", MsgBoxStyle.Information, "SUCCESS")
                frmViewIssuedReq.Refresh()
                Me.Close()
            End Try
        End If
    End Sub
    Sub dgwItemProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            invntyCode = dgw.Item(0, col).Value
            materialDesc = dgw.Item(1, col).Value
            Serial = dgw.Item(2, col).Value
            unit = dgw.Item(3, col).Value
            quantity = dgw.Item(4, col).Value
            stockOnHand = dgw.Item(5, col).Value

            saveItem()

            col = col + 1
        End While

    End Sub
    Sub saveItem()
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
                .CommandText = "INSERT INTO tblPRSITEM VALUES('" & txtPrsNo.Text & _
                    "','" & invntyCode & _
                    "','" & materialDesc & _
                    "','" & Serial & _
                    "','" & unit & _
                    "','" & quantity & _
                    "','" & stockOnHand & "')"

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPRS()
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
                .CommandText = "SELECT dbo.tblPRSDESC.PRSNO,dbo.tblPRSDESC.[DATE],dbo.tblPRSDESC.REMARKS,dbo.tblPRSDESC.PREPAREDBY,dbo.tblPRSDESC.APPROVEDBY," & _
                    "dbo.tblPRSDESC.REQSTATUS,dbo.tblPRSITEM.ITEMDESC,dbo.tblPRSITEM.SERIAL,dbo.tblPRSITEM.INVTYCODE,dbo.tblPRSITEM.UNIT,dbo.tblPRSITEM.QTY,dbo.tblPRSITEM.STOCKSONHAND" & _
                    " FROM dbo.tblPRSDESC INNER JOIN dbo.tblPRSITEM ON dbo.tblPRSDESC.PRSNO = dbo.tblPRSITEM.PRSNO WHERE dbo.tblPRSDESC.PRSNO = '" & txtPrsNo.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("PRSNO")
                .Columns.Add("DATE")
                .Columns.Add("REMARKS")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("REQSTATUS")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("MODEL")
                .Columns.Add("INVTYCODE")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
                .Columns.Add("STOCKSONHAND")
            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New purchaseRequestSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPurchaseRequestSlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        selectPrsNo()
        frmFindMaterials.showAllMaterials()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmFindMaterials.mode = "prs"
        frmFindMaterials.dgw.Columns(5).HeaderCell.Value = "STOCKS ON HAND"
        frmFindMaterials.dgw.Columns(5).DefaultCellStyle.Format = ""
        frmFindMaterials.ShowDialog()
        dgw.ClearSelection()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtMaterialDesc.Text = "" Or txtSerial.Text = "" Or txtUnit.Text = "" Or txtQuantity.Text = "" Then
        Else
            addtoDGW()
        End If
        dgw.ClearSelection()
    End Sub

    Private Sub DELETEITEMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEITEMToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            dgw.Rows.Remove(row)
            rows = rows - 1
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        save()
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class