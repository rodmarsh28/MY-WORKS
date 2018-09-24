Public Class frmAddEmployees
    Dim lastname As String
    Dim firstname As String
    Dim middlename As String
    Sub clear()
        txtemID.Text = ""
        txtln.Text = ""
        txtFn.Text = ""
        txtMn.Text = ""
        txtAdd.Text = ""
        txtCN.Text = ""
        txtBD.Text = Now
        txtGender.Text = ""
        txtCS.Text = ""
        txtPos.Text = ""
        txtRate.Text = ""
        txtPM.Text = ""
        txtDH.Text = Now
        txtStatus.Text = ""
        txtSSSNo.Text = ""
        txtTinNo.Text = ""
        txtPINo.Text = ""
        txtPHNo.Text = ""
        txtreligion.Text = ""
        txtGradeLevel.Text = ""
        txtDept.Text = ""
        txtDivision.Text = ""
        cmbDedB.Text = ""
        txtSpouseLN.Text = ""
        txtSpouseFN.Text = ""
        txtSpouseMN.Text = ""
        dgws.Rows.Clear()

    End Sub
    Sub generateEmployeeID()
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
                .CommandText = "SELECT * from tblEmployeesInfo order by employeeID DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtemID.Text = "EMP-" & Format(Val(StrID) + 1, "00000")
            Else
                txtemID.Text = "EMP-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO ADD THIS EMPLOYEE INFORMATIONS ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "INSERT INTO tblEmployeesInfo VALUES('" & txtemID.Text & _
                        "','" & txtln.Text & _
                        "','" & txtFn.Text & _
                        "','" & txtMn.Text & _
                        "','" & txtAdd.Text & _
                        "','" & txtCN.Text & _
                        "','" & txtHomeNo.Text & _
                        "','" & txtreligion.Text & _
                        "','" & txtGender.Text & _
                        "','" & txtBD.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtCS.Text & _
                        "','" & txtDept.Text & _
                        "','" & txtDivision.Text & _
                        "','" & txtPos.Text & _
                        "','" & txtRate.Text & _
                        "','" & txtGradeLevel.Text & _
                        "','" & txtPM.Text & _
                        "','" & txtDH.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtStatus.Text & _
                        "','" & txtField.Text & _
                        "','" & txtSSSNo.Text & _
                        "','" & txtTinNo.Text & _
                        "','" & txtPINo.Text & _
                        "','" & txtPHNo.Text & _
                        "','" & cmbDedB.Text & "','Employees Info Added " & Now.ToString("MM/dd/yyyy") & "' )"
                    .ExecuteNonQuery()
                End With
                If txtSpouseLN.Text = "" And txtSpouseFN.Text = "" And txtSpouseMN.Text = "" Then
                Else
                    saveSpouse()
                End If
                If dgws.RowCount = "0" Then
                Else
                    dgwItemProcess()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("Employee Information Added !", MsgBoxStyle.Information, "SUCCESS")
                clear()
                Me.Close()
            End Try
        End If
    End Sub
    Sub saveSpouse()
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
                .CommandText = "INSERT INTO tblSpouseInfo VALUES('" & txtemID.Text & _
                    "','" & txtSpouseLN.Text & _
                    "','" & txtSpouseFN.Text & _
                    "','" & txtSpouseMN.Text & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub saveChildren()
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
                .CommandText = "INSERT INTO tblChildrenInfo VALUES('" & txtemID.Text & _
                    "','" & lastname & _
                    "','" & firstname & _
                    "','" & middlename & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub dgwItemProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgws.RowCount
        While col < row1
            lastname = dgws.Item(0, col).Value
            firstname = dgws.Item(1, col).Value
            middlename = dgws.Item(2, col).Value
            saveChildren()
            col = col + 1

        End While
    End Sub


    Private Sub frmAddEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cmbAdd.Text = "Add" Then
            generateEmployeeID()
        End If
    End Sub

    Private Sub btnAddChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChildren.Click
        Dim ln As String = InputBox("Last Name", "Please Fill the Box")
        If ln = " " Or ln = "" Then
            MessageBox.Show("You must enter lastname")
            Exit Sub
        End If
        Dim fn As String = InputBox("First Name", "Please Fill the Box")
        If fn = " " Or fn = "" Then
            MessageBox.Show("You must enter firstname")
            Exit Sub
        End If
        Dim mn As String = InputBox("Middle Name", "Please Fill the Box")
        If mn = " " Or mn = "" Then
            MessageBox.Show("You must enter middlename")
            Exit Sub
        End If
        Dim rows As Integer = dgws.RowCount
        dgws.Rows.Add()
        dgws.Item(0, rows).Value = ln
        dgws.Item(1, rows).Value = fn
        dgws.Item(2, rows).Value = mn
        dgws.ClearSelection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In dgws.SelectedRows
            dgws.Rows.Remove(row)
        Next
    End Sub

    Private Sub cmbAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdd.Click
        save()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class