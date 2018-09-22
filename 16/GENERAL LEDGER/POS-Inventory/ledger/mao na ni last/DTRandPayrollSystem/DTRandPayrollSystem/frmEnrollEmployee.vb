
Public Class frmEnrollEmployee
    Dim pin As String
    Dim repin As String
    Dim lastpin As String
    Dim attempt As Integer
    Dim allowDeduction As String
    Private Sub frmEnrollEmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
    Sub selectPin()

        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM tblEmployees WHERE pin='" & lastpin & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    MsgBox("THE PIN YOU ENTER IS ALREADY TAKEN", MsgBoxStyle.Critical, "SORRY")
                End If
            Else
                OleDBC.Dispose()
                conn.Close()
                If frmEmployee.updating = True Then
                    updateinfo()
                Else
                    save()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try


    End Sub
    Private Sub validateInput()
      


    End Sub
    Sub CLEAR()
        txtemID.Text = ""
        txtln.Text = ""
        txtfn.Text = ""
        txtmi.Text = ""
        txtAdd.Text = ""
        txtCN.Text = ""
        txtBD.Text = Now
        txtGender.Text = ""
        txtCS.Text = ""
        txtPos.Text = ""
        txtDR.Text = ""
        txtPM.Text = ""
        txtDH.Text = Now
        txtStatus.Text = ""
        txtSSSNo.Text = ""
        txtTinNo.Text = ""
        txtPINo.Text = ""
        txtPHNo.Text = ""
    End Sub
    Public Sub selEmp()
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM tblEmployees WHERE EmployeeID ='" & frmEmployee.dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    txtemID.Text = OleDBDR.Item(0)
                    txtln.Text = OleDBDR.Item(1)
                    txtfn.Text = OleDBDR.Item(2)
                    txtmi.Text = OleDBDR.Item(3)
                    txtAdd.Text = OleDBDR.Item(4)
                    txtCN.Text = OleDBDR.Item(5)
                    txtBD.Text = OleDBDR.Item(6)
                    txtGender.Text = OleDBDR.Item(7)
                    txtCS.Text = OleDBDR.Item(8)
                    txtPos.Text = OleDBDR.Item(9)
                    txtDR.Text = OleDBDR.Item(10)
                    txtPM.Text = OleDBDR.Item(11)
                    txtDH.Text = OleDBDR.Item(12)
                    txtStatus.Text = OleDBDR.Item(13)
                    txtField.Text = OleDBDR.Item(14)
                    txtSSSNo.Text = OleDBDR.Item(15)
                    txtTinNo.Text = OleDBDR.Item(16)
                    txtPINo.Text = OleDBDR.Item(17)
                    txtPHNo.Text = OleDBDR.Item(18)
                    txtinput.Text = OleDBDR.Item(19)
                    lastpin = OleDBDR.Item(19)
                    allowDeduction = OleDBDR.Item(21)
                    If allowDeduction = "1" Then
                        CheckBox1.Checked = True
                    Else
                        CheckBox1.Checked = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub updateinfo()
        If CheckBox1.Checked = True And txtPHNo.Text = "" And txtPINo.Text = "" And txtSSSNo.Text = "" Then
            MsgBox("you allow premiums deduction of this employee but they don't have premiums, automatically we cancel deduction of premiums in this employee", MsgBoxStyle.Information, "Note:")
        End If
        If lastpin = "" Then
            MsgBox("YOUR PIN IS EMPTY ! PLEASE ENTER YOUR PIN", MsgBoxStyle.Critical, "ERROR")
        Else
            If MsgBox("Save Changes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                Try

                    ConnectDatabase()
                    With OleDBC
                        .Connection = conn
                        .CommandText = " update  [tblEmployees] set  [lastname] ='" & txtln.Text & _
                                "',[firstname]='" & txtfn.Text & _
                                "',[mi]='" & txtmi.Text & _
                                "',[address]='" & txtAdd.Text & _
                                "',[contactNo]='" & txtCN.Text & _
                                "',[birthdate]='" & txtBD.Text & _
                                "',[gender]='" & txtGender.Text & _
                                "',[civilstatus]='" & txtCS.Text & _
                                "',[position]='" & txtPos.Text & _
                                "',[dailyRate]='" & txtDR.Text & _
                                "',[paymethod]='" & txtPM.Text & _
                                "',[datehired]='" & txtDH.Text & _
                                "',[status]='" & txtStatus.Text & _
                                "',[field]='" & txtField.Text & _
                                "',[SSSNo]='" & txtSSSNo.Text & _
                                "',[tinNo]='" & txtTinNo.Text & _
                                "',[pagibigNo]='" & txtPINo.Text & _
                                "',[philhealthNo]='" & txtPHNo.Text & _
                                "',[pin]='" & txtinput.Text & _
                                "',[userID]=" & userid & _
                                ",[premsDed]='" & allowDeduction & "' WHERE employeeID='" & txtemID.Text & "'"
                        .ExecuteNonQuery()
                    End With
                    MsgBox("EMPLOYEE RECORD UPDATED !", MsgBoxStyle.OkOnly, "SUCCESS")
                    lastpin = ""
                    CLEAR()
                    frmEmployee.updating = False
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    OleDBC.Dispose()
                    conn.Close()
                End Try
            End If
        End If
    End Sub
    Sub save()
        If lastpin = "" Then
            MsgBox("YOUR PIN IS EMPTY ! PLEASE ENTER YOUR PIN", MsgBoxStyle.Critical, "ERROR")
        Else
            If MsgBox("Save Record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                Try

                    ConnectDatabase()
                    With OleDBC
                        .Connection = conn
                        .CommandText = " INSERT INTO tblEmployees VALUES ('" & txtemID.Text & _
                                "','" & txtln.Text & _
                                "','" & txtfn.Text & _
                                "','" & txtmi.Text & _
                                "','" & txtAdd.Text & _
                                "','" & txtCN.Text & _
                                "','" & txtBD.Text & _
                                "','" & txtGender.Text & _
                                "','" & txtCS.Text & _
                                "','" & txtPos.Text & _
                                "','" & txtDR.Text & _
                                "','" & txtPM.Text &
                                "','" & txtDH.Text & _
                                "','" & txtStatus.Text & _
                                "','" & txtField.Text & _
                                "','" & txtSSSNo.Text & _
                                "','" & txtTinNo.Text & _
                                "','" & txtPINo.Text & _
                                "','" & txtPHNo.Text & _
                                "','" & lastpin & _
                                "','" & userid & _
                                "','" & allowDeduction & "')"
                        .ExecuteNonQuery()
                    End With
                    MsgBox("EMPLOYEE RECORD ADDED !", MsgBoxStyle.OkOnly, "SUCCESS")
                    lastpin = ""
                    CLEAR()
                    frmEmployee.updating = False
                    Me.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    OleDBC.Dispose()
                    conn.Close()
                End Try
            End If
        End If
    End Sub
    Sub selectEmpID()

        Dim StrID As String
        Try
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblEmployees order by employeeID DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader

            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 8, Len(OleDBDR(0)))
                txtemID.Text = "EMP-" & Format(Val(StrID) + 1, "00000")
            Else
                txtemID.Text = "EMP-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmEnrollEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub


    Private Sub cmbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        If MessageBox.Show(" Are you sure you want to Cancel", "Are you sure?", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
        Else
            frmEmployee.updating = False
            frmEmployee.dgw.ClearSelection()
            Me.Close()
        End If
    End Sub

    Private Sub btn1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        txtinput.Text = txtinput.Text & btn1.Text
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        txtinput.Text = txtinput.Text & btn0.Text
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

    Private Sub btnback_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Dim str As String
        Dim loc As Integer
        If txtinput.Text.Length > 0 Then
            str = txtinput.Text.Chars(txtinput.Text.Length - 1)
            loc = txtinput.Text.Length
            txtinput.Text = txtinput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtinput.Text = "" Then
            MsgBox("BLANK PIN ! PLS TRY AGAIN..", MsgBoxStyle.Critical, "Error")
            txtinput.Text = ""
        Else
            attempt = attempt + 1
            If attempt = 1 Then
                pin = txtinput.Text
                txtinput.Text = ""
                lblRE.Visible = True
                lblRE.Text = "RE-ENTER YOUR PIN"
                lblRE.ForeColor = Color.Green

            Else
                repin = txtinput.Text
                If pin = repin Then
                    lastpin = pin
                    txtinput.Enabled = False
                    Button1.Enabled = False
                    lblRE.Visible = False
                Else
                    lblRE.Text = "INVALID PIN ! PLS TRY AGAIN.."
                    lblRE.ForeColor = Color.Red
                    attempt = 0
                    txtinput.Text = ""
                    lblRE.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub cmbAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdd.Click
        If CheckBox1.Checked Then
            allowDeduction = "1"
        Else
            allowDeduction = "0"
        End If
        If frmEmployee.updating = True Then
            validateInput()
            updateinfo()
            frmEmployee.updating = False
            frmEmployee.showEmp()
        Else
            If txtemID.Text = "" Then
                MsgBox("Please fill the Employee ID field", MsgBoxStyle.Information, "Validate Input")
                Exit Sub
                txtemID.Focus()
            ElseIf txtln.Text = "" Then
                MsgBox("Please fill the last name field", MsgBoxStyle.Information, "Validate Input")
                txtln.Focus()
                Exit Sub
            ElseIf txtfn.Text = "" Then
                MsgBox("Please fill the first name field", MsgBoxStyle.Information, "Validate Input")
                txtfn.Focus()
                Exit Sub
            ElseIf txtmi.Text = "" Then
                MsgBox("Please fill the MI field", MsgBoxStyle.Information, "Validate Input")
                txtmi.Focus()
                Exit Sub
            ElseIf txtAdd.Text = "" Then
                MsgBox("Please fill the address field", MsgBoxStyle.Information, "Validate Input")
                Exit Sub
            ElseIf txtGender.Text = "" Then
                MsgBox("Please fill the Gender field", MsgBoxStyle.Information, "Validate Input")
                txtGender.Focus()
                Exit Sub
            ElseIf txtCS.Text = "" Then
                MsgBox("Please fill the civil status field", MsgBoxStyle.Information, "Validate Input")
                txtCS.Focus()
                txtCS.Focus()
                Exit Sub
            ElseIf txtPos.Text = "" Then
                MsgBox("Please fill the Position field", MsgBoxStyle.Information, "Validate Input")
                txtPos.Focus()
                Exit Sub
            ElseIf txtDR.Text = "" Then
                MsgBox("Please fill the daily rate field", MsgBoxStyle.Information, "Validate Input")
                txtDR.Focus()
                Exit Sub
            ElseIf txtPM.Text = "" Then
                MsgBox("Please fill the Payment method field", MsgBoxStyle.Information, "Validate Input")
                txtPM.Focus()
                Exit Sub
            ElseIf txtStatus.Text = "" Then
                MsgBox("Please fill the Status field", MsgBoxStyle.Information, "Validate Input")
                txtStatus.Focus()
                Exit Sub
            ElseIf txtField.Text = "" Then
                MsgBox("Please fill the Status field", MsgBoxStyle.Information, "Validate Input")
                txtField.Focus()
                Exit Sub
            Else
                save()
                frmEmployee.showEmp()
            End If

        End If
    End Sub
End Class