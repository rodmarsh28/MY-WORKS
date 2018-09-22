Public Class frmPrintDTR
    Public y As Integer

    Sub print()
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Panel3.Height += y

            PrintDocument1.Print()
            frmEmployee.showEmp()
            Me.Close()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel3.Width, Me.Panel3.Height)
        Panel3.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel3.Width, Me.Panel3.Height))

        e.Graphics.DrawImage(bm, 0, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub frmPrintDTR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPrintDTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblfrom.Text = Format(frmDTRGenerator.DateTimePicker1.Value, "Short Date")
        lblto.Text = Format(frmDTRGenerator.DateTimePicker2.Value, "Short Date")
        lblempID.Text = frmDTRGenerator.employeeID
        dgw.ClearSelection()
    End Sub

    Private Sub UserToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        print()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class