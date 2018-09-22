Public Class frmManageAccounts
    Dim ACCNO As String
    Dim ACCDESC As String
    Dim ACCTYPE As String
    Dim ACCCATEGORIES
    Dim selectrows As Boolean
    Dim genAccNo As String


    Private Sub frmManageAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showAccountType()
    End Sub
    'Sub selectACCNo()

    '    Dim StrID As String
    '    Try
    '        If conn.State = ConnectionState.Open Then
    '            OleDBC.Dispose()
    '            conn.Close()
    '        End If
    '        If conn.State <> ConnectionState.Open Then
    '            ConnectDatabase()
    '        End If
    '        With OleDBC
    '            .Connection = conn
    '            .CommandText = "SELECT * from tblCOA order by ACCNO DESC"
    '        End With
    '        OleDBDR = OleDBC.ExecuteReader
    '        If OleDBDR.Read Then
    '            StrID = Mid(OleDBDR(0), 4, Len(OleDBDR(0)))
    '            ACCNO = "" & Format(Val(StrID) + 1, "0000")
    '        Else
    '            ACCNO = "0001"
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally

    '    End Try
    'End Sub
    'Sub selectACCNo()

    '    Dim StrID As String
    '    Try
    '        If conn.State = ConnectionState.Open Then
    '            OleDBC.Dispose()
    '            conn.Close()
    '        End If
    '        If conn.State <> ConnectionState.Open Then
    '            ConnectDatabase()
    '        End If
    '        With OleDBC
    '            .Connection = conn
    '            .CommandText = "SELECT * from tblCOA order by ACCNO DESC"
    '        End With
    '        OleDBDR = OleDBC.ExecuteReader
    '        If OleDBDR.Read Then
    '            ACCNO = OleDBDR.Item(0)
    '        Else
    '            ACCNO = "00000"
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally

    '    End Try
    'End Sub
    Sub addAccountType()
        Dim type As String = InputBox("INPUT ACCOUNT TYPE DESCRIPTION ")
        If type = " " Or type = "" Then
            MessageBox.Show("INVALID INPUT")
            Exit Sub
        End If
        ACCTYPE = type
        saveAccountType()
    End Sub
    Sub addAccount()
        If dgwCategories.SelectedRows.Count = 0 Then
            MsgBox("PLEASE SELECT ACC TYPE FIRST", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim desc As String = InputBox("INPUT ACCOUNT DESCRIPTION ", "ACCOUNT NO : " & genAccNo)
            If desc = " " Or desc = "" Then
                MessageBox.Show("INVALID INPUT")
                Exit Sub
            End If
            ACCDESC = desc
            saveAccount()
            showAccount()
        End If

    End Sub
    Sub addAccountCategories()
        Dim type As String = InputBox("INPUT ACCOUNT CATEGORY DESCRIPTION ")
        If type = " " Or type = "" Then
            MessageBox.Show("INVALID INPUT")
            Exit Sub
        End If
        ACCCATEGORIES = type
        saveAccountCategories()
        showAccountCategories()
    End Sub
    Sub saveAccount()

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
                    .CommandText = "INSERT INTO tblCOA VALUES('" & genAccNo & _
                        "','" & dgwCategories.CurrentRow.Cells(0).Value & _
                        "','" & ACCDESC & "')"
                    .ExecuteNonQuery()
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("ACCOUNT ADDED", MsgBoxStyle.Information, "SUCCESS")
            End Try
        End If
    End Sub
    Sub saveAccountType()
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
                    .CommandText = "INSERT INTO tblcoaType VALUES('" & ACCTYPE & "')"

                    .ExecuteNonQuery()
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("ACCOUNT TYPE ADDED", MsgBoxStyle.Information, "SUCCESS")
            End Try
        End If
    End Sub
    Sub saveAccountCategories()
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
                    .CommandText = "INSERT INTO tblAccCategories VALUES('" & dgwType.CurrentRow.Cells(0).Value & "','" & ACCCATEGORIES & "')"
                    .ExecuteNonQuery()
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("ACCOUNT CATEGORIES ADDED", MsgBoxStyle.Information, "SUCCESS")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        addAccountType()
        showAccountType()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'selectACCNo()
        If dgwAcc.Rows.Count > 0 Then
            Dim strID As String
            strID = Mid(ACCNO, 4, Len(ACCNO))
            genAccNo = dgwType.CurrentRow.Cells(0).Value & dgwCategories.CurrentRow.Cells(0).Value & Format(Val(strID) + 1, "0000")
        Else
            genAccNo = dgwType.CurrentRow.Cells(0).Value & dgwCategories.CurrentRow.Cells(0).Value & "0001"
        End If
       
        addAccount()
        textSearch.Text = ""
    End Sub
    Sub showAccountType()
        Try
            Dim c As Integer
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblcoaType "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwType.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwType.Rows.Add()
                    dgwType.Item(0, c).Value = OleDBDR.Item(0)
                    dgwType.Item(1, c).Value = OleDBDR.Item(1)
                    c = c + 1
                End While
                dgwType.ClearSelection()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showAccount()
        Try
            Dim c As Integer
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblCOA where CATEGORYID = '" & dgwCategories.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwAcc.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwAcc.Rows.Add()
                    dgwAcc.Item(0, c).Value = OleDBDR.Item(0)
                    ACCNO = OleDBDR.Item(0)
                    dgwAcc.Item(1, c).Value = OleDBDR.Item(2)
                    c = c + 1
                End While
                dgwAcc.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showAccountCategories()
        Try
            Dim c As Integer
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblAccCategories where TYPENO = '" & dgwType.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwCategories.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwCategories.Rows.Add()
                    dgwCategories.Item(0, c).Value = OleDBDR.Item(0)
                    dgwCategories.Item(1, c).Value = OleDBDR.Item(2)
                    c = c + 1
                End While
                dgwCategories.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgwType_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwType.CellMouseClick

        showAccountCategories()
        textSearch.Text = ""
    End Sub

    Private Sub dgwType_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwType.CellMouseDoubleClick

    End Sub

   
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textSearch.TextChanged
        Try
            Dim c As Integer
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblCOA where ACCNO like '%" & textSearch.Text & "%' and CATEGORYID  = '" & dgwCategories.CurrentRow.Cells(0).Value & "' " & _
                                "or ACCOUNTNAME like '%" & textSearch.Text & "%' and CATEGORYID = '" & dgwCategories.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwAcc.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwAcc.Rows.Add()
                    dgwAcc.Item(0, c).Value = OleDBDR.Item(0)
                    dgwAcc.Item(1, c).Value = OleDBDR.Item(2)
                    c = c + 1
                End While
                dgwAcc.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgwType_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwType.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If dgwType.SelectedRows.Count = 0 Then
            MsgBox("PLEASE SELECT ACCOUNT TYPE FIRST", MsgBoxStyle.Critical, "ERROR")
        Else
            addAccountCategories()
        End If

    End Sub



    Private Sub dgwCategories_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwCategories.CellMouseClick
        showAccount()
    End Sub

    Private Sub dgwCategories_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwCategories.CellContentClick

    End Sub

    Private Sub dgwCategories_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgwCategories.CurrentCellChanged
        dgwAcc.Rows.Clear()
    End Sub
End Class