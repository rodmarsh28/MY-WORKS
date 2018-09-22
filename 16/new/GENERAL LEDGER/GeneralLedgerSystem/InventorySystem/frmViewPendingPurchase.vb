Public Class frmViewPendingPurchase
    Dim ifPOTaxExcempted As Boolean
    Public Sub refreshDGV()
        showPRS()
        showPO()
        showPOnotReceived()

    End Sub
    Private Sub cmbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmViewPendingPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbShowby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShowby.SelectedIndexChanged
        If cmbShowby.Text = "PENDING PURCHASE REQUEST" Then
            showPRS()
            dgw.Columns(1).HeaderCell.Value = "PRS NO."

        ElseIf cmbShowby.Text = "WAITING FOR CASH/CHECK ISSUANCE" Then
            showPO()
            dgw.Columns(1).HeaderCell.Value = "PO NO."

        ElseIf cmbShowby.Text = "WAITING FOR RECEIVING ITEMS / MATERIALS" Then
            showPOnotReceived()
            dgw.Columns(1).HeaderCell.Value = "PO NO."

        End If
    End Sub

    Sub showPRS()
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
                .CommandText = "select * from tblPRSDESC where REQSTATUS = 'PENDING FOR PO'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(3)
                    dgw.Item(3, c).Value = OleDBDR.Item(5)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblCount.Text = dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub showPO()
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
                .CommandText = "select * from tblPODESC where POSTATUS = 'WAITING FOR CASH/CHECK ISSUANCE'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(10)
                    dgw.Item(3, c).Value = OleDBDR.Item(13)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblCount.Text = dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub showPOnotReceived()
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
                .CommandText = "select * from tblPODESC where POSTATUS = 'WAITING FOR ITEMS RECEIVED'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(10)
                    dgw.Item(3, c).Value = OleDBDR.Item(13)
                    dgw.Item(4, c).Value = OleDBDR.Item(3)
                    dgw.Item(5, c).Value = OleDBDR.Item(4)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblCount.Text = dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub viewPOforCashIssuance()
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
                .CommandText = "SELECT dbo.tblPODESC.PONO,dbo.tblPODESC.[DATE],dbo.tblPODESC.PRSREF,dbo.tblPODESC.SUPPLIERNAME,dbo.tblPODESC.ADDRESS," & _
                    "dbo.tblPODESC.CONTACTPERSON,dbo.tblPODESC.CONTACTNO,dbo.tblPODESC.PAYMENTTERM,dbo.tblPODESC.TOTALAMOUNT,dbo.tblPODESC.REMARKS," & _
                    "dbo.tblPODESC.PREPAREDBY,dbo.tblPODESC.RECOMMENDEDBY,dbo.tblPODESC.APPROVEDBY,dbo.tblPODESC.POSTATUS,dbo.tblPOITEM.ITEMDESC," & _
                    "dbo.tblPOITEM.SERIAL,dbo.tblPOITEM.UNIT,dbo.tblPOITEM.UPRICE,dbo.tblPOITEM.LESSVAT,dbo.tblPOITEM.QTY,dbo.tblPOITEM.AMOUNT FROM dbo.tblPODESC " & _
                    "INNER JOIN dbo.tblPOITEM ON dbo.tblPODESC.PONO = dbo.tblPOITEM.PONO WHERE dbo.tblPODESC.PONO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("PONO")
                .Columns.Add("DATE")
                .Columns.Add("PRSREF")
                .Columns.Add("SUPPLIERNAME")
                .Columns.Add("ADDRESS")
                .Columns.Add("CONTACTPERSON")
                .Columns.Add("CONTACTNO")
                .Columns.Add("PAYMENTTERM")
                .Columns.Add("TOTALAMOUNT")
                .Columns.Add("REMARKS")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("RECOMMENDEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("POSTATUS")
                .Columns.Add("ITEMDESC")
                .Columns.Add("SERIAL")
                .Columns.Add("UNIT")
                .Columns.Add("UPRICE")
                .Columns.Add("LESSVAT")
                .Columns.Add("QUANTITY")
                .Columns.Add("AMOUNT")
            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), Convert.ToDecimal(OleDBDR.Item(8)).ToString("c"), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14),
                                  OleDBDR.Item(15), OleDBDR.Item(16), Convert.ToDecimal(OleDBDR.Item(17)).ToString("c"), Convert.ToDecimal(OleDBDR.Item(18)).ToString("c"), OleDBDR.Item(19),
                                  Convert.ToDecimal(OleDBDR.Item(20)).ToString("c"))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New purchaseOrderSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub VIEWPRS()
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
                    " FROM dbo.tblPRSDESC INNER JOIN dbo.tblPRSITEM ON dbo.tblPRSDESC.PRSNO = dbo.tblPRSITEM.PRSNO WHERE dbo.tblPRSDESC.PRSNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
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
    Sub updateIssuedPO()
        If MsgBox("ARE YOU SURE ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "update tblPODESC SET POSTATUS= 'WAITING FOR ITEMS RECEIVED' where PONO ='" & dgw.CurrentRow.Cells(1).Value & "'"
                    .ExecuteNonQuery()
                End With
                MsgBox("P.O. STATUS UPDATED", MsgBoxStyle.Information, "SUCCESS")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CREATEPOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREATEPOToolStripMenuItem.Click
        frmPurchaseOrder.selectPONo()
        frmPurchaseOrder.mode = "CREATE"
        frmPurchaseOrder.Button3.Text = "SAVE"
        frmPurchaseOrder.txtPreparedBy.Text = MainForm.LBLNAME.Text
        frmPurchaseOrder.Show()
        frmPurchaseOrder.txtPRSRef.Text = dgw.CurrentRow.Cells(1).Value
    End Sub

    Private Sub VIEWToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWToolStripMenuItem1.Click
        viewPOforCashIssuance()
    End Sub

    Private Sub CASHCHECKISSUEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CASHCHECKISSUEDToolStripMenuItem.Click
        updateIssuedPO()
        showPO()
    End Sub

    Private Sub RECEIVEANDADDMRSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIVEANDADDMRSToolStripMenuItem.Click
        frmMaterialReceiving.txtPORef.Text = dgw.CurrentRow.Cells(1).Value
        frmMaterialReceiving.txtSuppName.Text = dgw.CurrentRow.Cells(4).Value
        frmMaterialReceiving.txtAddress.Text = dgw.CurrentRow.Cells(5).Value
        frmMaterialReceiving.Show()
    End Sub

    Private Sub VIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWToolStripMenuItem.Click
        VIEWPRS()

    End Sub



    Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                If cmbShowby.Text = "PENDING PURCHASE REQUEST" Then
                    dgw.ContextMenuStrip = ContextMenuStrip1
                ElseIf cmbShowby.Text = "WAITING FOR CASH/CHECK ISSUANCE" Then
                    dgw.ContextMenuStrip = ContextMenuStrip2
                ElseIf cmbShowby.Text = "WAITING FOR RECEIVING ITEMS / MATERIALS" Then
                    dgw.ContextMenuStrip = ContextMenuStrip3
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip1.Closed
        dgw.ContextMenuStrip = ContextMenuStrip4
    End Sub

    Private Sub ContextMenuStrip2_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip2.Closed
        dgw.ContextMenuStrip = ContextMenuStrip4
    End Sub

    Private Sub ContextMenuStrip3_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip3.Closed
        dgw.ContextMenuStrip = ContextMenuStrip4
    End Sub

    Private Sub VIEWPOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWPOToolStripMenuItem.Click
        viewPOforCashIssuance()
    End Sub

    Private Sub CANCELPURCHASEREQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELPURCHASEREQUESTToolStripMenuItem.Click
        If MsgBox("ARE YOU SURE YOU CANCEL THIS PURCHASE REQUEST ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "DELETE FROM tblPRSDESC where PRSNO='" & dgw.CurrentRow.Cells(1).Value & "'; " & _
                                    "DELETE FROM tblPRSITEM where PRSNO='" & dgw.CurrentRow.Cells(1).Value & "'"
                    .ExecuteNonQuery()
                End With
                MsgBox("THIS PURCHASE REQUEST HAS CANCELLED", MsgBoxStyle.Information, "DONE")
                showPRS()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("PLEASE BE SURE TO PERFORM THIS ACTION", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub EDITPOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITPOToolStripMenuItem.Click
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
                .CommandText = "select * from tblPODESC where PONO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader

            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmPurchaseOrder.txtPONo.Text = OleDBDR.Item(0)
                    frmPurchaseOrder.dtpDate.Value = OleDBDR.Item(1)
                    frmPurchaseOrder.txtPRSRef.Text = OleDBDR.Item(2)
                    frmPurchaseOrder.txtSuppName.Text = OleDBDR.Item(3)
                    frmPurchaseOrder.txtAddress.Text = OleDBDR.Item(4)
                    frmPurchaseOrder.txtContactPerson.Text = OleDBDR.Item(5)
                    frmPurchaseOrder.txtContactNo.Text = OleDBDR.Item(6)
                    frmPurchaseOrder.txtPayTerm.Text = OleDBDR.Item(7)
                    frmPurchaseOrder.totalAmount = OleDBDR.Item(8)
                    frmPurchaseOrder.lblTotal.Text = "TOTAL FOR THIS PURCHASE ORDER :  ₱ " & frmPurchaseOrder.totalAmount.ToString("n2")
                    frmPurchaseOrder.txtRemakrs.Text = OleDBDR.Item(9)
                    frmPurchaseOrder.txtPreparedBy.Text = OleDBDR.Item(10)
                    frmPurchaseOrder.txtRecommendedBy.Text = OleDBDR.Item(11)
                    frmPurchaseOrder.txtApprovedBy.Text = OleDBDR.Item(12)
                    'If OleDBDR.Item(14) = "YES" Then
                    '    ifPOTaxExcempted = True
                    'ElseIf OleDBDR.Item(14) = "NO" Then
                    '    ifPOTaxExcempted = False
                    'End If
                End If
            End If
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
        
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblPOITEM where PONO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            frmPurchaseOrder.dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    frmPurchaseOrder.dgw.Rows.Add()
                    frmPurchaseOrder.dgw.Item(0, c).Value = OleDBDR.Item(2)
                    frmPurchaseOrder.dgw.Item(1, c).Value = OleDBDR.Item(3)
                    frmPurchaseOrder.dgw.Item(2, c).Value = OleDBDR.Item(9)
                    frmPurchaseOrder.dgw.Item(3, c).Value = OleDBDR.Item(4)
                    frmPurchaseOrder.dgw.Item(4, c).Value = OleDBDR.Item(5)
                    frmPurchaseOrder.dgw.Item(5, c).Value = OleDBDR.Item(8)
                    frmPurchaseOrder.dgw.Item(6, c).Value = OleDBDR.Item(6)
                    frmPurchaseOrder.dgw.Item(7, c).Value = OleDBDR.Item(7)
                    c = c + 1
                    frmPurchaseOrder.rows = frmPurchaseOrder.dgw.RowCount
                End While
                frmPurchaseOrder.dgw.ClearSelection()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmPurchaseOrder.mode = "EDIT"
        frmPurchaseOrder.Button3.Text = "SAVE"
        frmPurchaseOrder.ShowDialog()

    End Sub

End Class