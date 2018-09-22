Public Class frmViewRFC

    Sub showPendingRFC()
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
                .CommandText = "SELECT DATE,RFCNO,SECTION,DEPARTMENT,PAYEE,AMOUNT from tblRFC where status = 'WAITING FOR APPROVED' "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(0), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2) & " - " & OleDBDR.Item(3)
                    dgw.Item(3, c).Value = OleDBDR.Item(4)
                    dgw.Item(4, c).Value = OleDBDR.Item(5)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub updateRFCStatus()
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
                .CommandText = "update tblRFC SET STATUS= 'APPROVED' where RFCNO ='" & dgw.CurrentRow.Cells(1).Value & "'"
                .ExecuteNonQuery()
            End With
            MsgBox("REQUEST FOR CASH APPROVED !", MsgBoxStyle.Information, "SUCCESS")
            showPendingRFC()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmViewRFC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showPendingRFC()
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

   
    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        dgw.ContextMenuStrip = ContextMenuStrip2
    End Sub

    Private Sub APPROVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APPROVEToolStripMenuItem.Click
        If MsgBox("ARE YOU SURE YOU WANT TO ADD ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            updateRFCStatus()

        End If
    End Sub
End Class