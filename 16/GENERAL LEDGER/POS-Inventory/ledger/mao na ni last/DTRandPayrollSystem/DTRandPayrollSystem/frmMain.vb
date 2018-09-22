Public Class frmMain
    Public payrollviewer As Boolean
    Public printPayroll As Boolean
    Public printAllPayslips As Boolean
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
            e.Cancel = True

        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmLogin.Show()
        Me.Enabled = False
        DataGridView1.Visible = False
    End Sub

    Private Sub ACCOUNTUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddUser.Show()
    End Sub

    Private Sub EMPLOYEEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnrollEmployee.Show()
    End Sub
    'Sub showRecords()
    '    Try
    '        Dim c As Integer
    '        c = 0
    '        ConnectDatabase()
    '        With OleDBC
    '            .Connection = conn
    '            .CommandText = "SELECT * from tblEmployees "
    '        End With
    '        OleDBDR = OleDBC.ExecuteReader
    '        DataGridView1.Rows.Clear()
    '        If OleDBDR.HasRows Then
    '            While OleDBDR.Read
    '                DataGridView1.Rows.Add()
    '                DataGridView1.Item(0, c).Value = OleDBDR.Item(0)
    '                DataGridView1.Item(1, c).Value = OleDBDR.Item(1) + ", " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + "."
    '                DataGridView1.Item(2, c).Value = OleDBDR.Item(5)
    '                DataGridView1.Item(3, c).Value = OleDBDR.Item(7)
    '                DataGridView1.Item(4, c).Value = OleDBDR.Item(4)
    '                c = c + 1
    '            End While
    '            DataGridView1.ClearSelection()
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        OleDBC.Dispose()
    '        conn.Close()
    '    End Try
    'End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        frmAddUser.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmEmployee.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("calc")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Shell("Notepad")
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPayrollViewer.Show()
        payrollviewer = True
        printAllPayslips = False
        printPayroll = False
    End Sub

    Private Sub DTRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddPayrollToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPayrollToolStripMenuItem.Click
        frmPayroll.Show()
        payrollviewer = False
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmDTRGenerator.Show()
        printPayroll = True
        printAllPayslips = False
        payrollviewer = False
    End Sub

    Private Sub PaySlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaySlipToolStripMenuItem.Click
        printAllPayslips = True
        payrollviewer = False
        printPayroll = False
        frmDTRGenerator.Show()
    End Sub
   
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmPayrollViewer.Show()
        payrollviewer = True
    End Sub
End Class
