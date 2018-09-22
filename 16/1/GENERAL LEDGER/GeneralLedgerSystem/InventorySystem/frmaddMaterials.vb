Public Class frmaddMaterials
    Sub clear()
        txtInvtyCode.Text = ""
        txtMaterialDesc.Text = ""
        txtSerial.Text = ""
        txtItemCategories.Text = ""
        txtUnit.Text = ""
        txtUPrice.Text = ""
        txtStocks.Text = ""
    End Sub
    Sub getInvtyCode()
        Dim StrID As String
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
                .CommandText = "SELECT * from tblINVENTORY order by INVTYCODE DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtInvtyCode.Text = "ITM-" & Format(Val(StrID) + 1, "00000")

            Else
                txtInvtyCode.Text = "ITM-00001"

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub save()
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
                    .CommandText = "INSERT INTO tblINVENTORY VALUES('" & txtInvtyCode.Text & _
                        "','" & txtMaterialDesc.Text & _
                        "','" & txtSerial.Text & _
                        "','" & txtItemCategories.Text & _
                        "','" & txtUnit.Text & _
                        "','" & txtUPrice.Text & _
                         "','" & txtUPrice.Text / 1.12 & _
                        "','" & txtStocks.Text & "')"
                    .ExecuteNonQuery()
                End With
                MsgBox("MATERIAL ADDED SUCCESSFULLY", MsgBoxStyle.Information, "SUCCESS")
                clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save()
        If MsgBox("YOU WANT TO ADD MATERIAL AGAIN ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "FORM") = MsgBoxResult.No Then
            Me.Dispose()
        Else
            getInvtyCode()
        End If
    End Sub

    Private Sub frmaddMaterials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getInvtyCode()
    End Sub

    Private Sub txtUPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUPrice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txtStocks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStocks.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class