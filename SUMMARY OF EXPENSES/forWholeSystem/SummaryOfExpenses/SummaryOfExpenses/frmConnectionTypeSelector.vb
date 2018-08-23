Public Class frmConnectionTypeSelector

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.connectionType = ComboBox1.Text
        MsgBox("Done ", MsgBoxStyle.Information, "")
        Me.Close()
    End Sub

    Private Sub frmConnectionTypeSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = My.Settings.connectionType
    End Sub
End Class