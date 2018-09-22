Public Class accEntry
    Dim selectrows As Boolean = False

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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub chkDebit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDebit.CheckedChanged

    End Sub

   

    Private Sub accEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showAccountType()
        txtDebit.Enabled = False
        txtCredit.Enabled = False
        txtCredit.Text = ""
        txtDebit.Text = ""
    End Sub


    Private Sub dgwType_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwType.CellMouseClick
        showAccount()
        selectrows = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If IsNothing(dgwAcc.CurrentRow) Then
        If selectrows = False Then
            MsgBox("PLEASE SELECT ACC FIRST", MsgBoxStyle.Critical, "error")
        ElseIf txtDebit.Text = "" And txtCredit.Text = "" Then
            MsgBox("NO AMOUNT INPUT", MsgBoxStyle.Critical, "error")
        Else
            Dim row As Integer
            row = frmCheckVoucher.dgw1.RowCount
            frmCheckVoucher.dgw1.Rows.Add()
            frmCheckVoucher.dgw1.Item(0, row).Value = dgwAcc.CurrentRow.Cells(0).Value
            frmCheckVoucher.dgw1.Item(1, row).Value = dgwAcc.CurrentRow.Cells(1).Value
            If chkDebit.Checked = True Then
                frmCheckVoucher.dgw1.Item(2, row).Value = txtDebit.Text
                frmCheckVoucher.dgw1.Item(3, row).Value = "0"
            ElseIf chkCredit.Checked = True Then
                frmCheckVoucher.dgw1.Item(3, row).Value = txtCredit.Text
                frmCheckVoucher.dgw1.Item(2, row).Value = "0"
            End If
            Me.Close()
        End If
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Sub chekUpdate()
        If chkDebit.Checked = True Then
            txtCredit.Text = ""
            txtCredit.Enabled = False
            txtDebit.Enabled = True

        ElseIf chkCredit.Checked = True Then
            txtDebit.Text = ""
            txtDebit.Enabled = False
            txtCredit.Enabled = True

        End If
    End Sub



    Private Sub chkDebit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDebit.Click
        chkDebit.Checked = True
        chkCredit.Checked = False
        chekUpdate()
    End Sub

    Private Sub chkCredit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCredit.Click
        chkCredit.Checked = True
        chkDebit.Checked = False
        chekUpdate()
    End Sub

    Private Sub dgwAcc_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgwAcc.CellMouseClick
        selectrows = True
    End Sub
End Class