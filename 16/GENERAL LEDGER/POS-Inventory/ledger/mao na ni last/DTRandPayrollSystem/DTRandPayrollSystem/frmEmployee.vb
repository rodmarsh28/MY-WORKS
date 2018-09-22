
Public Class frmEmployee
    Public updating As Boolean


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmEnrollEmployee.selectEmpID()
        frmEnrollEmployee.Show()
        frmEnrollEmployee.cmbAdd.Text = "Add"
    End Sub
    Public Sub showEmp()
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * from tblEmployees "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4)
                    dgw.Item(5, c).Value = OleDBDR.Item(5)
                    dgw.Item(6, c).Value = OleDBDR.Item(7)
                    dgw.Item(7, c).Value = OleDBDR.Item(6)
                    dgw.Item(8, c).Value = OleDBDR.Item(8)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If dgw.CurrentCell.Selected = True Then
                updating = True
                frmEnrollEmployee.cmbAdd.Text = "Update"
                frmEnrollEmployee.selEmp()
                frmEnrollEmployee.Show()
            Else
                MsgBox("Pleas select data in datagridview", MsgBoxStyle.Information, "Sorry")
            End If
        Catch ex As Exception
            MsgBox("NO RECORDS TO UPDATE", MsgBoxStyle.Information, "ERROR")
        End Try
    End Sub

    Private Sub frmEmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showEmp()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GenerateLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateLogsToolStripMenuItem.Click
        If dgw.CurrentCell.Selected = True Then
            frmDTRGenerator.employeeID = dgw.CurrentRow.Cells(0).Value
            frmDTRGenerator.Show()
            frmMain.printPayroll = False
        Else
            MsgBox("Pleas select data in datagridview", MsgBoxStyle.Information, "Sorry")
        End If

    End Sub
    Sub search()
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT * FROM [tblEmployees] WHERE employeeID & lastname & firstname  like '%" & TextBox1.Text & "%'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    dgw.Item(3, c).Value = OleDBDR.Item(3)
                    dgw.Item(4, c).Value = OleDBDR.Item(4)
                    dgw.Item(5, c).Value = OleDBDR.Item(5)
                    dgw.Item(6, c).Value = OleDBDR.Item(6)
                    dgw.Item(7, c).Value = OleDBDR.Item(7)
                    dgw.Item(8, c).Value = OleDBDR.Item(8)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        search()
    End Sub

    Private Sub GeneratePayslipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub
End Class