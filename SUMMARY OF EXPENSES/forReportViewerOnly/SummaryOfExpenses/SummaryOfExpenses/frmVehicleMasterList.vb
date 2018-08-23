Public Class frmVehicleMasterList
    Sub viewVehicle()
        Try
            OleDBDR.Dispose()
            Dim c As Integer
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM tblvehicle"

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
    Sub SearchVehicle()
        Try
            OleDBDR.Dispose()
            Dim c As Integer
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM tblvehicle where plateNo like '%" & txtSearch.Text & "%' or vehicleModel like '%" & txtSearch.Text & "%' or " & _
                    "nameOfDriver like '%" & txtSearch.Text & "%'"

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

    Private Sub frmVehicleMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewVehicle()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddExpenses.vid = dgw.CurrentRow.Cells(0).Value
        frmAddExpenses.txtPlateNo.Text = dgw.CurrentRow.Cells(1).Value
        frmAddExpenses.ShowDialog()
    End Sub


    'Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
    '    Try
    '        If e.Button = MouseButtons.Right Then
    '            dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
    '            dgw.ContextMenuStrip = ContextMenuStrip1
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub ContextMenuStrip1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs)
    '    dgw.ContextMenuStrip = ContextMenuStrip2
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SearchVehicle()
    End Sub
End Class