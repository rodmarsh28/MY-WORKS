Public Class frmViewEmployee
    Public Sub showEmployee()
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
                .CommandText = "select * from tblEmployee"
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
                    dgw.Item(4, c).Value = Format(OleDBDR.Item(4), "dd/MM/yyyy")
                    dgw.Item(5, c).Value = OleDBDR.Item(5)
                    dgw.Item(6, c).Value = OleDBDR.Item(6)

                    c = c + 1
                End While
            End If
            dgw.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddEmployee.cmbAdd.Text = "Add"
        frmAddEmployee.ShowDialog()
    End Sub

    Private Sub frmViewEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showEmployee()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        frmAddEmployee.cmbAdd.Text = "Update"
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            Dim c As Integer

            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployee where EMPID ='" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmAddEmployee.txtemID.Text = OleDBDR.Item(0)
                    frmAddEmployee.txtln.Text = OleDBDR.Item(1)
                    frmAddEmployee.txtAdd.Text = OleDBDR.Item(2)
                    frmAddEmployee.txtCN.Text = OleDBDR.Item(3)
                    frmAddEmployee.txtBD.Value = OleDBDR.Item(4)
                    frmAddEmployee.txtGender.Text = OleDBDR.Item(5)
                    frmAddEmployee.txtCS.Text = OleDBDR.Item(6)
                    frmAddEmployee.txtPos.Text = OleDBDR.Item(7)
                    frmAddEmployee.txtDR.Text = OleDBDR.Item(8)
                    frmAddEmployee.txtPM.Text = OleDBDR.Item(9)
                    frmAddEmployee.txtDH.Text = OleDBDR.Item(10)
                    frmAddEmployee.txtField.Text = OleDBDR.Item(11)
                    frmAddEmployee.cmbDedB.Text = OleDBDR.Item(12)
                    frmAddEmployee.txtSSSNo.Text = OleDBDR.Item(13)
                    frmAddEmployee.txtTinNo.Text = OleDBDR.Item(14)
                    frmAddEmployee.txtPINo.Text = OleDBDR.Item(15)
                    frmAddEmployee.txtPHNo.Text = OleDBDR.Item(16)
                    frmAddEmployee.txtStatus.Text = OleDBDR.Item(17)
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        frmAddEmployee.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class