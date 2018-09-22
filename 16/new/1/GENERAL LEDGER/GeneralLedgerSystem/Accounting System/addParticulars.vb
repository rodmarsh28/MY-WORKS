Public Class addParticulars

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtParticulars.Text = "" Or txtAmount.Text = "" Then
            
        Else
            Dim row As Integer
            frmCheckVoucher.PARTID = frmCheckVoucher.PARTID + 1
            row = frmCheckVoucher.dgw.RowCount
            frmCheckVoucher.dgw.Rows.Add()
            frmCheckVoucher.dgw.Item(0, row).Value = frmCheckVoucher.PARTID
            frmCheckVoucher.dgw.Item(1, row).Value = txtParticulars.Text
            frmCheckVoucher.dgw.Item(2, row).Value = txtAmount.Text
            Me.Close()
        End If

    End Sub


    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1)))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtParticulars_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParticulars.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub txtParticulars_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtParticulars.TextChanged

    End Sub

    Private Sub addParticulars_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtParticulars.Text = ""
        txtAmount.Text = ""
    End Sub
End Class