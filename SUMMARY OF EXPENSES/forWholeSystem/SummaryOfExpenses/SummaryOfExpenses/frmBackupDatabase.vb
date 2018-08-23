Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlBackup

Public Class frmBackupDatabase

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description = "Select Folder to Save Backup"
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtDir.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.backupDir = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub frmBackupDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDir.Text = My.Settings.backupDir
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim conn = New MySqlConnection("Server=localhost;Database=dfcexpsum;Uid=root;")
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = conn
            conn.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(txtDir.Text & "\" & Format(Now, "MM-dd-yyyy") & ".sql")
            conn.Close()
            MsgBox("Backup Completed", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("failed to connect offline database", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class