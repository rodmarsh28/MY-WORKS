Public Class msgboxx
    Dim row As Integer
    Sub addtoCheckvoucher()

        row = frmCheckVoucher.dgw1.RowCount
        frmCheckVoucher.dgw1.Rows.Add()
        frmCheckVoucher.dgw1.Item(0, row).Value = accEntry.dgwAcc.CurrentRow.Cells(0).Value
        frmCheckVoucher.dgw1.Item(1, row).Value = accEntry.dgwAcc.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        addtoCheckvoucher()
        frmCheckVoucher.dgw1.Item(2, row).Value = txtAmount.Text
        frmCheckVoucher.dgw1.Item(3, row).Value = "0"
        frmCheckVoucher.totDebit = frmCheckVoucher.totDebit + txtAmount.Text
        frmCheckVoucher.lblDebit.Text = CDbl(frmCheckVoucher.totDebit).ToString("#,##0.00")
        txtAmount.Text = ""
        Me.Close()
        accEntry.Close()
    End Sub

    Private Sub btnCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredit.Click
        addtoCheckvoucher()
        frmCheckVoucher.dgw1.Item(2, row).Value = "0"
        frmCheckVoucher.dgw1.Item(3, row).Value = txtAmount.Text
        frmCheckVoucher.totCredit = frmCheckVoucher.totCredit + txtAmount.Text
        frmCheckVoucher.lblCredit.Text = CDbl(frmCheckVoucher.totCredit).ToString("#,##0.00")
        txtAmount.Text = ""
        Me.Close()
        accEntry.Close()
    End Sub
End Class