Public Class frmManageAccounts
    Dim ACCNO As String
    Dim ACCDESC As String
    Dim ACCTYPE As String



    Private Sub frmManageAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showAccountType()
    End Sub
    Sub selectACCNo()

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
                .CommandText = "SELECT * from tblCOA order by COANO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 4, Len(OleDBDR(0)))
                ACCNO = "" & Format(Val(StrID) + 1, "0000")
            Else
                ACCNO = "0001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub addAccountType()
        Dim type As String = InputBox("INPUT ACCOUNT DESCRIPTION ")
        If type = " " Or type = "" Then
            MessageBox.Show("INVALID INPUT")
            Exit Sub
        End If
        ACCTYPE = type
        saveAccountType()
    End Sub
    Sub addAccount()
        Dim desc As String = InputBox("INPUT ACCOUNT DESCRIPTION ", "ACCOUNT NO : " & ACCNO)
        If desc = " " Or desc = "" Then
            MessageBox.Show("INVALID INPUT")
            Exit Sub
        End If
        ACCDESC = desc
        saveAccount()
    End Sub
    Sub saveAccount()
        selectACCNo()
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
                    .CommandText = "INSERT INTO tblCOA VALUES('" & ACCNO & _
                        "','" & dgwType.CurrentRow.Cells(0).Value & _
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        addAccountType()
        showAccountType()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        addAccount()
        showAccount()
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
                .CommandText = "SELECT * from tblCOA where TYPENO = '" & dgwType.CurrentRow.Cells(0).Value & "'"
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

    Private Sub dgwType_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwType.CellMouseDoubleClick
        showAccount()
    End Sub
End Class