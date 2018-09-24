Imports System.Data.OleDb
Imports System.Object
Imports System.IO
Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT userid,user,password,userType from tblUser where user = '" & txtuser.Text & "' and password ='" & txtpass.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    MsgBox("ACCESS GRANTED!", MsgBoxStyle.OkOnly, "WELCOME")
                    userid = OleDBDR.Item(0)
                    frmMain.lblat.Text = OleDBDR.Item(3)
                    frmMain.Show()
                    frmMain.Enabled = True
                    Me.Close()
                    frmMain.DataGridView1.Visible = True



                End If
            Else
                MsgBox("Your Username/Password is Wrong !", MsgBoxStyle.Critical, "ERROR")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class