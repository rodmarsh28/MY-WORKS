Public Class frmRequestForPaymentList
    Sub ShowRequestforPayment()
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
                .CommandText = "SELECT DATE,PONO,SUPPLIERNAME,TOTALAMOUNT from tblPODESC WHERE POSTATUS = 'WAITING FOR CASH/CHECK ISSUANCE'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRequestForPaymentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowRequestforPayment()
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

    Private Sub ContextMenuStrip1_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip1.Closed
        dgw.ContextMenuStrip = ContextMenuStrip2
    End Sub

   
    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        frmCheckVoucher.txtReqNo.Text = dgw.CurrentRow.Cells(1).Value
        frmCheckVoucher.txtPayee.Text = dgw.CurrentRow.Cells(2).Value
        frmCheckVoucher.txtPreparedBy.Text = MainForm.LBLNAME.Text
        frmCheckVoucher.selectCVNo()
        'frmCheckVoucher.selectPARTID()
        frmCheckVoucher.ShowDialog()
    End Sub
End Class