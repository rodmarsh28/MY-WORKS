Public Class MainForm

    Private Sub ABOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click

    End Sub

    Private Sub REGISTERACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERACCOUNTToolStripMenuItem.Click
        frmRegForm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        frmLogin.ShowDialog()
    End Sub

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click


    End Sub

    Private Sub ACCOUNTLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserList.ShowDialog()
    End Sub

    Private Sub MANAGEACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MANAGEACCOUNTToolStripMenuItem.Click
        frmUserList.ShowDialog()
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        frmInventorySystem.Show()
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        frmAccountingSystem.Show()
    End Sub
End Class