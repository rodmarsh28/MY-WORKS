Public Class frmBackupAndRestore

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description = "Select Folder to Save Backup"
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            dir.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.backupDirectory = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub frmBackupAndRestore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Button6.Enabled = True Then
                Button6.Enabled = False
            Else
                Button6.Enabled = True
            End If
        End If
    End Sub

    Private Sub frmBackupAndRestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dir.Text = My.Settings.backupDirectory
        Button6.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'frmLoading.ShowDialog()
        If dir.Text = "" Then
            MsgBox("Please select folder first", MsgBoxStyle.Critical, "error")
        Else
            Try
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectMasterDatabase()
                End If

                With OleDBC
                    .Connection = conn
                    .CommandText = "BACKUP DATABASE GFLSPAYROLLDB TO DISK = '" & dir.Text & "GFLS-" & Now.ToString("MM-dd-yyyy") & ".bak' " & _
                                    "BACKUP DATABASE ACPAYROLLDB TO DISK = '" & dir.Text & "AC-" & Now.ToString("MM-dd-yyyy") & ".bak' " & _
                                    "BACKUP DATABASE UTILITYDB TO DISK = '" & dir.Text & "UTILITY-" & Now.ToString("MM-dd-yyyy") & ".bak'"
                    .ExecuteNonQuery()
                End With
                'frmLoading.Close()
                MsgBox("Backup Success", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.FileName = "GFLS"
        OpenFileDialog1.InitialDirectory = dir.Text
        OpenFileDialog1.Filter = "Backup File|*.bak"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            gflsDIR.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.FileName = "AC"
        OpenFileDialog1.InitialDirectory = dir.Text
        OpenFileDialog1.Filter = "Backup File|*.bak"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            ACDir.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.FileName = "UTILITY"
        OpenFileDialog1.InitialDirectory = dir.Text
        OpenFileDialog1.Filter = "Backup File|*.bak"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            UTDIR.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Sub restoreGFLS()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectMasterDatabase()
            End If

            With OleDBC
                .Connection = conn
                .CommandText = "RESTORE DATABASE GFLSPAYROLLDB FROM DISK = '" & gflsDIR.Text & "' "
                                
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub restoreAC()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectMasterDatabase()
            End If

            With OleDBC
                .Connection = conn
                .CommandText = "RESTORE DATABASE ACPAYROLLDB FROM DISK = '" & ACDir.Text & "' "

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub restoreUT()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectMasterDatabase()
            End If

            With OleDBC
                .Connection = conn
                .CommandText = "RESTORE DATABASE UTILITYDB FROM DISK = '" & UTDIR.Text & "' "

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If gflsDIR.Text = "" And ACDir.Text = "" And UTDIR.Text = "" Then
            MsgBox("Please select backup file first", MsgBoxStyle.Critical, "error")
        Else
            If gflsDIR.Text <> "" Then
                restoreGFLS()
            End If
            If ACDir.Text <> "" Then
                restoreAC()
            End If
            If UTDIR.Text <> "" Then
                restoreUT()
            End If
            MsgBox("Restore Database Success", MsgBoxStyle.Information, "Success")
            gflsDIR.Text = ""
            ACDir.Text = ""
            UTDIR.Text = ""
        End If

    End Sub
End Class