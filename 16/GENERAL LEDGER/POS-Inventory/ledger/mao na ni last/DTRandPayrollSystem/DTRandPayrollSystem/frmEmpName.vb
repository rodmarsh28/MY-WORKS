Public Class frmEmpName
    Public empid As String
    Public rate As Double

    Sub empname()
        Try
            Dim c As Integer
            c = 0
            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployees where status = 'Active' "
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1) + "' " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + "."
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

    Private Sub frmEmpName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub frmEmpName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empname()
    End Sub
    Sub selectempid()
        Dim sssData As String
        Dim phData As String
        Dim piData As String
        Try

            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployees where employeeID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmPayroll.txtemID.Text = OleDBDR.Item(0)
                    frmPayroll.txtName.Text = OleDBDR.Item(1) + ", " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + "."
                    frmPayroll.txtPos.Text = OleDBDR.Item(9)
                    frmPayroll.txtPayMethod.Text = OleDBDR.Item(11)
                    frmPayroll.dtrDH.Value = OleDBDR.Item(12)
                    frmPayroll.field = OleDBDR.Item(14)
                    frmPayroll.rate = OleDBDR.Item(10)
                    frmPayroll.txtDR.Text = OleDBDR.Item(10)
                    If frmPayroll.txtPayMethod.Text = "Monthly" Then
                        frmPayroll.lblRW.Text = "Absent/Rest Days"
                    Else
                        frmPayroll.lblRW.Text = "Regular Worked Days"
                    End If
                    frmPayroll.premDed = OleDBDR.Item(21)
                    sssData = OleDBDR.Item(15)
                    If sssData = "" Then
                        frmPayroll.sssNo = False
                    Else
                        frmPayroll.sssNo = True
                    End If
                    phData = OleDBDR.Item(17)
                    If phData = "" Then
                        frmPayroll.phNo = False
                    Else
                        frmPayroll.phNo = True
                    End If
                    piData = OleDBDR.Item(18)
                    If piData = "" Then
                        frmPayroll.piNo = False
                    Else
                        frmPayroll.piNo = True
                    End If
                End If
                empid = OleDBDR.Item(0)
                End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub
    Sub selectempidviewer()
        Try

            ConnectDatabase()
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployees where employeeID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmPayrollViewer.txtemID.Text = OleDBDR.Item(0)
                    frmPayrollViewer.txtName.Text = OleDBDR.Item(1) + ", " + OleDBDR.Item(2) + " " + OleDBDR.Item(3) + "."
                    frmPayrollViewer.txtPos.Text = OleDBDR.Item(9)
                    frmPayrollViewer.txtPayMethod.Text = OleDBDR.Item(11)
                    frmPayrollViewer.dtrDH.Value = OleDBDR.Item(12)
                    frmPayrollViewer.txtDR.Text = OleDBDR.Item(10)
                End If
                empid = OleDBDR.Item(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            OleDBC.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub dgw_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentDoubleClick
        If frmMain.payrollviewer = True Then
            selectempidviewer()
            frmPayrollViewer.showpayrollInfo()
            Me.Close()
        Else
            selectempid()
            Me.Close()
        End If
    End Sub




End Class