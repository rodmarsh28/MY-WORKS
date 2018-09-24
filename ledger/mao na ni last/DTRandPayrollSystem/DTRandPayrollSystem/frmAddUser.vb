Imports System.Data.OleDb

Public Class frmAddUser
    Dim username As String
    Dim userids As String
    Dim updates As Boolean
    Sub selectuser()
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT user FROM tblUSER WHERE user ='" & txtuser.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    MsgBox("THE USERNAME YOU ENTER IS ALREADY TAKEN", MsgBoxStyle.Critical, "SORRY")
                End If
            Else
                OleDBC.Dispose()
                conn.Close()
                save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try


    End Sub
    Sub updateUser()
        Try
            If MsgBox("Save Changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                If txtpass.Text = txtrepass.Text Then
                    ConnectDatabase()
                    With OleDBC
                        .Connection = conn
                        .CommandText = "UPDATE [tblUSER] set [user]='" & txtuser.Text & _
                        "', [password] = '" & txtpass.Text & "', [userType]='" & txttype.Text & "' where userID = " & userids & ""
                        .ExecuteNonQuery()
                    End With
                    MsgBox("UPDATE SUCCESS !", MsgBoxStyle.OkOnly, "SUCCESS")
                    clear()

                    updates = False

                Else
                    MsgBox("Your Password Missmatch", MsgBoxStyle.Critical, "Sorry")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
            showUsers()
            dgw.Enabled = True

        End Try
    End Sub
    Sub showUsers()
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT user from tblUSER "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub editinput()
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblUSER where user= '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    userids = OleDBDR.Item(0)
                    txtuser.Text = OleDBDR.Item(1)
                    txttype.Text = OleDBDR.Item(3)
                    dgw.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub


    Sub save()
        Try
            If MsgBox("Save User?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                If txtpass.Text = txtrepass.Text Then
                    ConnectDatabase()
                    With OleDBC
                        .Connection = conn
                        .CommandText = " INSERT INTO [tblUSER]([user],[password],[userType]) VALUES ('" & txtuser.Text & _
                                "','" & txtpass.Text & _
                                "','" & txttype.Text & "')"
                        .ExecuteNonQuery()
                    End With
                    MsgBox("REGISTRATION SUCCESS !", MsgBoxStyle.OkOnly, "SUCCESS")
                    clear()
                Else
                    MsgBox("Your Password Missmatch", MsgBoxStyle.Critical, "Sorry")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
            dgw.Enabled = True
            showUsers()
        End Try

    End Sub


    Private Sub cmbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        selectuser()
    End Sub

    Private Sub frmAddUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showUsers()
    End Sub
    Sub clear()
        txtuser.Text = ""
        txtpass.Text = ""
        txtrepass.Text = ""
        txttype.Text = ""

    End Sub

    Private Sub cmbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        If updates = True Then
            If MessageBox.Show(" Are you sure you want to Cancel", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                dgw.Enabled = True
                clear()
                dgw.ClearSelection()
                updates = False
            End If

        Else
            Me.Close()
        End If

    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick
        'If e.RowIndex < 0 Then Exit Sub
        'username = dgw.Item(0, e.RowIndex).Value
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        editinput()
        updates = True

    End Sub

    Private Sub cmbAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdd.Click
        If txtuser.Text = "" Or txtpass.Text = "" Or txttype.Text = "" Then
            MsgBox("Field cannot be empty", MsgBoxStyle.Critical, "Error")
        Else
            If updates = True Then
                updateUser()
            Else
                save()
            End If
        End If

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MsgBox("Are You Sure You Want To Delete ?", MsgBoxStyle.OkCancel, "Are You Sure ?") = MsgBoxResult.Ok Then
            Try
                ConnectDatabase()
                With OleDBC
                    .Connection = conn
                    .CommandText = "DELETE FROM tblUSER where user='" & dgw.CurrentRow.Cells(0).Value & "'"
                    .ExecuteNonQuery()
                End With
                MsgBox("USER DELETED!", MsgBoxStyle.Information, "SUCCESS")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                OleDBC.Dispose()
                conn.Close()
            End Try
            showUsers()
        End If

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class