Public Class frmAddVehicle
    Sub addVehicle()

        If MsgBox("ARE YOU SURE YOU WANT TO ADD ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Try
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                    .CommandText = "INSERT INTO tblvehicle VALUES('" & txtPlateNo.Text & _
                        "','" & txtVModel.Text & _
                        "','" & txtDriver.Text & "')"
                    .ExecuteNonQuery()
                End With
                MsgBox("Vehicle Added", MsgBoxStyle.Information, "SUCCESS")
                txtPlateNo.Text = ""
                txtVModel.Text = ""
                txtDriver.Text = ""
                txtPlateNo.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
  

    Private Sub frmAddVehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        addVehicle()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class