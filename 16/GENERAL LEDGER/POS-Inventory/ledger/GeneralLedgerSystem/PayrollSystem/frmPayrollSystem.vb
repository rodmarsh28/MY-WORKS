Public Class frmPayrollSystem

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmViewEmployee.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmPayrollViewer.ShowDialog()
    End Sub

    Private Sub AddPayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPayrollToolStripMenuItem.Click
        frmAddPayroll.ShowDialog()
    End Sub
End Class