Public Class InputAccount
    Public mode As String
    'Private Sub InputAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        frmFindMaterials.debitTo = txtInput.Text
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub InputAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showAccountType()
    End Sub
    Sub showAccountType()
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
                .CommandText = "SELECT * from tblcoaType "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwType.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwType.Rows.Add()
                    dgwType.Item(0, c).Value = OleDBDR.Item(0)
                    dgwType.Item(1, c).Value = OleDBDR.Item(1)
                    c = c + 1
                End While
                dgwType.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showAccount()
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
                .CommandText = "SELECT * from tblCOA where TYPENO = '" & dgwType.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwAcc.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwAcc.Rows.Add()
                    dgwAcc.Item(0, c).Value = OleDBDR.Item(0)
                    dgwAcc.Item(1, c).Value = OleDBDR.Item(2)
                    c = c + 1
                End While
                dgwAcc.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgwType_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwType.CellMouseClick
        showAccount()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If mode = "FM" Then
            frmFindMaterials.debitTo = dgwAcc.CurrentRow.Cells(0).Value
            Me.Hide()
        ElseIf mode = "PO" Then
            frmPurchaseOrder.txtDebitTo.Text = dgwAcc.CurrentRow.Cells(0).Value
            Me.Close()
        ElseIf mode = "MWS" Then
            frmAddReqOfDept.txtDebitTo.Text = dgwAcc.CurrentRow.Cells(0).Value
            Me.Close()
        End If

    End Sub
End Class