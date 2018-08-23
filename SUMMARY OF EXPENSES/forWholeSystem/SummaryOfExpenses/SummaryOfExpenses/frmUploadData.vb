Imports MySql.Data.MySqlClient
Public Class frmUploadData
    Public Sub lastUpdate()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectOfflineDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "UPDATE tblsystemsettings set value = '" & Format(Now, "MM/dd/yyyy") & "' where settingsName = 'LastUpdate'"
                .ExecuteNonQuery()
            End With
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblstatus.Text = "Uploading ... Please wait"
        dumpDB()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 10
    End Sub


End Class