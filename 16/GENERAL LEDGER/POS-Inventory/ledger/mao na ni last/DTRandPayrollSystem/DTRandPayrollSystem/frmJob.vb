Public Class frmJob

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbDatabase.Text = "" Then
            MsgBox("Please Select Database First", MsgBoxStyle.Critical, "Sorry")
        Else
            frmLogin.Show()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmbDatabase.Text = "" Then
            MsgBox("Please Select Database First", MsgBoxStyle.Critical, "Sorry")
        Else
            frmDTRvb.Show()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class