Public Class frmEmployeeLisst
    'if 1 = payrollViewer 2 = addPayroll
    Public mode As String
    Public Sub showEmployee()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            Dim c As Integer
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployee"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = OleDBDR.Item(0)
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub payrollViewerCMD()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployee where EMPID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmPayrollViewer.txtemID.Text = OleDBDR.Item(0)
                    frmPayrollViewer.txtName.Text = OleDBDR.Item(1)
                    frmPayrollViewer.txtPos.Text = OleDBDR.Item(7)
                    frmAddPayroll.txtDR.Text = OleDBDR.Item(8)
                    frmPayrollViewer.txtPayMethod.Text = OleDBDR.Item(9)
                    frmPayrollViewer.dtrDH.Value = OleDBDR.Item(10)
                End If
                Me.Close()
                frmPayrollViewer.showEmployeesPayroll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub AddPayrollCMD()
        Dim sssData As String
        Dim phData As String
        Dim piData As String
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "select * from tblEmployee where EMPID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmAddPayroll.txtemID.Text = OleDBDR.Item(0)
                    frmAddPayroll.txtName.Text = OleDBDR.Item(1)
                    frmAddPayroll.txtPos.Text = OleDBDR.Item(7)
                    frmAddPayroll.txtPayMethod.Text = OleDBDR.Item(9)
                    frmAddPayroll.dtrDH.Value = OleDBDR.Item(10)
                    frmAddPayroll.field = OleDBDR.Item(11)
                    frmAddPayroll.rate = OleDBDR.Item(8)
                    frmAddPayroll.txtDR.Text = OleDBDR.Item(8)
                    If frmAddPayroll.txtPayMethod.Text = "Monthly" Then
                        frmAddPayroll.lblRW.Text = "Absent/Rest Days"
                    Else
                        frmAddPayroll.lblRW.Text = "Regular Worked Days"
                    End If
                    frmAddPayroll.premDed = OleDBDR.Item(12)
                    sssData = OleDBDR.Item(13)
                    If sssData = "" Then
                        frmAddPayroll.sssNo = False
                    Else
                        frmAddPayroll.sssNo = True
                    End If
                    phData = OleDBDR.Item(16)
                    If phData = "" Then
                        frmAddPayroll.phNo = False
                    Else
                        frmAddPayroll.phNo = True
                    End If
                    piData = OleDBDR.Item(15)
                    If piData = "" Then
                        frmAddPayroll.piNo = False
                    Else
                        frmAddPayroll.piNo = True
                    End If
                    frmAddPayroll.clear()
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEmployeeLisst_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEmployeeLisst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showEmployee()
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick
        If mode = "1" Then
            payrollViewerCMD()
        ElseIf mode = "2" Then
            AddPayrollCMD()
        End If

    End Sub
End Class