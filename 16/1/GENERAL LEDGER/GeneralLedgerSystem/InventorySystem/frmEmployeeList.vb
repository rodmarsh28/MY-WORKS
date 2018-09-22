Public Class frmEmployeeList
    Sub showRequestor()
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
                .CommandText = "SELECT Distinct RECEIVEDBY,DEPARTMENT from tblMISDESC order by RECEIVEDBY asc "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub searchRequestor()
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
                .CommandText = "SELECT Distinct RECEIVEDBY,DEPARTMENT from tblMISDESC where RECEIVEDBY like '%" & TextBox1.Text & "%' or DEPARTMENT like '%" & TextBox1.Text & "%' order by RECEIVEDBY asc "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    c = c + 1
                End While
                dgw.ClearSelection()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEmployeeList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showRequestor()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        searchRequestor()
    End Sub



    Private Sub dgw_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellDoubleClick
        frmTransactionReportForMember.txtName.Text = dgw.CurrentRow.Cells(0).Value
        Me.Dispose()
    End Sub

 

End Class