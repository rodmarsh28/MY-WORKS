Public Class InputAccount
    Public mode As String
    'Private Sub InputAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        frmFindMaterials.debitTo = txtInput.Text
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub InputAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showAccount()
        txtSearch.Text = ""
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
                .CommandText = "SELECT dbo.tblCOA.ACCNO,dbo.tblCOA.ACCOUNTNAME,dbo.tblAccCategories.CATEGORY,dbo.tblcoaType.ACCTYPE FROM dbo.tblcoaType INNER JOIN dbo.tblAccCategories " & _
                                "ON dbo.tblcoaType.TYPENO = dbo.tblAccCategories.TYPENO INNER JOIN dbo.tblCOA ON dbo.tblAccCategories.CATEGORYID = dbo.tblCOA.CATEGORYID"

            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwAcc.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwAcc.Rows.Add()
                    dgwAcc.Item(0, c).Value = OleDBDR.Item(0)
                    dgwAcc.Item(1, c).Value = OleDBDR.Item(1)
                    dgwAcc.Item(2, c).Value = OleDBDR.Item(2)
                    dgwAcc.Item(3, c).Value = OleDBDR.Item(3)
                    c = c + 1
                End While
                dgwAcc.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgwAcc.SelectedRows.Count > 0 Then
            If mode = "FM" Then
                frmFindMaterials.debitTo = dgwAcc.CurrentRow.Cells(0).Value
                Me.Hide()
            
            ElseIf mode = "MWS" Then
                frmAddReqOfDept.txtDebitTo.Text = dgwAcc.CurrentRow.Cells(1).Value
                frmAddReqOfDept.accno = dgwAcc.CurrentRow.Cells(0).Value
                Me.Close()
            End If
        Else
            MsgBox("PLEASE SELECT ACC FIRST", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

   


    Private Sub dgwAcc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
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
                .CommandText = "SELECT dbo.tblCOA.ACCNO,dbo.tblCOA.ACCOUNTNAME,dbo.tblAccCategories.CATEGORY,dbo.tblcoaType.ACCTYPE FROM dbo.tblcoaType INNER JOIN dbo.tblAccCategories " & _
                                "ON dbo.tblcoaType.TYPENO = dbo.tblAccCategories.TYPENO INNER JOIN dbo.tblCOA ON dbo.tblAccCategories.CATEGORYID = dbo.tblCOA.CATEGORYID where ACCNO like " & _
                                "'%" & txtSearch.Text & "%' or ACCOUNTNAME like '%" & txtSearch.Text & "%' or CATEGORY like '%" & txtSearch.Text & "%' or ACCTYPE like '%" & txtSearch.Text & "%'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgwAcc.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgwAcc.Rows.Add()
                    dgwAcc.Item(0, c).Value = OleDBDR.Item(0)
                    dgwAcc.Item(1, c).Value = OleDBDR.Item(1)
                    dgwAcc.Item(2, c).Value = OleDBDR.Item(2)
                    dgwAcc.Item(3, c).Value = OleDBDR.Item(3)
                    c = c + 1
                End While
                dgwAcc.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgwAcc_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwAcc.CellMouseDoubleClick
        If dgwAcc.SelectedRows.Count > 0 Then
            If mode = "FM" Then
                frmFindMaterials.debitTo = dgwAcc.CurrentRow.Cells(0).Value
                Me.Hide()
            ElseIf mode = "MWS" Then
                frmAddReqOfDept.txtDebitTo.Text = dgwAcc.CurrentRow.Cells(1).Value
                frmAddReqOfDept.accno = dgwAcc.CurrentRow.Cells(0).Value
                Me.Close()
            End If
        Else
            MsgBox("PLEASE SELECT ACC FIRST", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub dgwAcc_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwAcc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class