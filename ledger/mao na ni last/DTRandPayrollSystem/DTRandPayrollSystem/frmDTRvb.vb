
Public Class frmDTRvb
    Public empid As String
    Dim time_IN As Date = Format(Date.Now, "Short Time")
    Dim time_Out As Date = Format(Date.Now, "Short Time")
    Dim dates As Date = Format(Date.Now, "Short Date")


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub



    Private Sub frmDTRvb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      
    End Sub

    Private Sub frmDTRvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtinput.Select
        lblDate.Text = Date.Now.ToString("dd/MM/yyyy")
        btnAmIn.Enabled = False
        btnAmOut.Enabled = False
        btnPmIn.Enabled = False
        btnPmOut.Enabled = False

    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtinput.Text = txtinput.Text & btn0.Text
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtinput.Text = txtinput.Text & btn1.Text
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtinput.Text = txtinput.Text & btn2.Text
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtinput.Text = txtinput.Text & btn3.Text
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtinput.Text = txtinput.Text & btn4.Text
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtinput.Text = txtinput.Text & btn5.Text
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        txtinput.Text = txtinput.Text & btn6.Text
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        txtinput.Text = txtinput.Text & btn7.Text
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        txtinput.Text = txtinput.Text & btn8.Text
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        txtinput.Text = txtinput.Text & btn9.Text
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Dim str As String
        Dim loc As Integer
        If txtinput.Text.Length > 0 Then
            str = txtinput.Text.Chars(txtinput.Text.Length - 1)
            loc = txtinput.Text.Length
            txtinput.Text = txtinput.Text.Remove(loc - 1, 1)
        End If
    End Sub
    Public Sub selectEmpid()
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM tblEmployees WHERE pin='" & txtinput.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    empid = OleDBDR.Item(0)
                End If
                Button1.Enabled = False
            Else
                MsgBox("Sorry Your Pin is Invalid", MsgBoxStyle.Critical, "Error")
                txtinput.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub addDate()

        If empid <> "" Then
            Try

                ConnectDatabase()
                With OleDBC
                    .Connection = conn
                    .CommandText = " INSERT INTO [tblLogs]([date],[employeeID]) VALUES ('" & dates & "','" & empid & "')"
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                OleDBC.Dispose()
                conn.Close()
            End Try
        End If
    End Sub
    Sub selDate()
        Try

            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM tblLogs where date= #" & dates & "# and employeeID ='" & empid & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
            Else
                OleDBC.Dispose()
                conn.Close()
                addDate()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub selectTimeIn()
        If empid <> "" Then
            Try

                ConnectDatabase()
                With OleDBC
                    .Connection = conn
                    .CommandText = "SELECT * FROM tblLogs where date= #" & dates & "# and employeeID ='" & empid & "'"
                End With
                OleDBDR = OleDBC.ExecuteReader
                If OleDBDR.HasRows Then
                    If OleDBDR.Read Then

                        If IsDBNull(OleDBDR.Item(3)) Then
                            btnAmIn.Enabled = True
                        ElseIf IsDBNull(OleDBDR.Item(4)) Then
                            btnAmOut.Enabled = True
                        ElseIf IsDBNull(OleDBDR.Item(5)) Then
                            btnPmIn.Enabled = True
                        ElseIf IsDBNull(OleDBDR.Item(6)) Then
                            btnPmOut.Enabled = True
                        Else
                            btnAmIn.Enabled = False
                            btnAmOut.Enabled = False
                            btnPmIn.Enabled = False
                            btnPmOut.Enabled = False

                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                OleDBC.Dispose()
                conn.Close()
            End Try
        End If
    End Sub
    Sub amIn()
        Dim timein As String
        timein = "TIME IN CHECK: " + lblTime.Text
        Try

            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = " update [tblLogs] set [amTimeIn] ='" & time_IN & "' where date = #" & dates & "# and employeeID ='" & empid & "'"
                .ExecuteNonQuery()
            End With
            MsgBox(timein, MsgBoxStyle.OkOnly, "WELCOME")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub
    Sub amOut()
        Dim timeOut As String
        timeOut = "TIME OUT CHECK: " + lblTime.Text
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = " update [tblLogs] set [amTimeOut] ='" & time_IN & "' where date = # " & dates & "# and employeeID ='" & empid & "'"
                .ExecuteNonQuery()
            End With
            MsgBox(timeOut, MsgBoxStyle.OkOnly, "THANK YOU")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub

    Sub PMIn()
        Dim timeIn As String
        timeIn = "TIME IN CHECK: " + lblTime.Text
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = " update [tblLogs] set [pmTimeIn] ='" & time_Out & "' where date = #" & dates & "# and employeeID ='" & empid & "'"
                .ExecuteNonQuery()
            End With
            MsgBox(timeIn, MsgBoxStyle.OkOnly, "WELCOME")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub
    Sub PMOut()
        Dim timeOut As String
        timeOut = "TIME OUT CHECK: " + lblTime.Text
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = " update [tblLogs] set [pmTimeOut] ='" & time_IN & "' where date = #" & dates & "# and employeeID ='" & empid & "'"
                .ExecuteNonQuery()
            End With
            MsgBox(timeOut, MsgBoxStyle.OkOnly, "THANK YOU")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        selectEmpid()
        selDate()
        selectTimeIn()
    End Sub

    Private Sub btnAmIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmIn.Click
        amIn()
        txtinput.Text = ""
        btnAmIn.Enabled = False
        Button1.Enabled = True

    End Sub

    Private Sub btnAmOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmOut.Click
        amOut()
        txtinput.Text = ""
        Button1.Enabled = True
        btnAmOut.Enabled = False
    End Sub

    Private Sub btnPmIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPmIn.Click
        PMIn()
        txtinput.Text = ""
        Button1.Enabled = True
        btnPmIn.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = True
        txtinput.Text = ""
        empid = ""
        txtinput.Select()
        btnAmIn.Enabled = False
        btnAmOut.Enabled = False
        btnPmIn.Enabled = False
        btnPmOut.Enabled = False
    End Sub

    Private Sub btnPmOut_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPmOut.Click
        PMOut()
        txtinput.Text = ""
        Button1.Enabled = True
        btnPmOut.Enabled = False
    End Sub

End Class