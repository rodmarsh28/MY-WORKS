Public Class frmMode
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cmbMode.Text = "" Then
            Label2.Visible = True
        Else
            databaseMode = cmbMode.Text
            Me.Close()
        End If
    End Sub

    Private Sub frmMode_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Close()

    End Sub

    Private Sub frmMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
    End Sub
End Class