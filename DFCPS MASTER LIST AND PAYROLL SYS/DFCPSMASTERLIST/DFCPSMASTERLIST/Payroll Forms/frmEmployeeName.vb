﻿Public Class frmEmployeeName
    Dim EmployeeIDs As ComboBox
    Dim combocount As Integer

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
                .CommandText = "SELECT dbo.tblEmployeesInfo.employeeID,dbo.tblEmployeesInfo.lastname,dbo.tblEmployeesInfo.firstname," & _
                    "dbo.tblEmployeesInfo.middlename,dbo.tblEmployeesInfo.[position],dbo.tblEmployeesInfo.payMethod,dbo.tblEmployeesInfo.dateHired," & _
                    "dbo.tblEmployeesInfo.rate,dbo.tblEmployeesInfo.allowBenefitsDeduction,dbo.tblEmployeesInfo.sssNo,dbo.tblEmployeesInfo.phNo," & _
                    "dbo.tblEmployeesInfo.piNo FROM dbo.tblEmployeesInfo where EmployeeID = '" & dgw.CurrentRow.Cells(0).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    frmPayroll.txtemID.Text = OleDBDR.Item(0)
                    frmPayroll.txtName.Text = OleDBDR.Item(1) & ", " & OleDBDR.Item(2) & " " & OleDBDR.Item(3)
                    frmPayroll.txtPos.Text = OleDBDR.Item(4)
                    frmPayroll.txtPayMethod.Text = OleDBDR.Item(5)
                    frmPayroll.dtrDH.Value = OleDBDR.Item(6)
                    frmPayroll.rate = OleDBDR.Item(7)
                    frmPayroll.txtDR.Text = OleDBDR.Item(7)
                    If frmPayroll.txtPayMethod.Text = "Monthly" Then
                        frmPayroll.lblRW.Text = "Absent(HRS)"
                    Else
                        frmPayroll.lblRW.Text = "Regular Worked Days"
                    End If
                    frmPayroll.premDed = OleDBDR.Item(8)
                    sssData = OleDBDR.Item(9)
                    If sssData = "" Then
                        frmPayroll.sssNo = False
                    Else
                        frmPayroll.sssNo = True
                    End If
                    phData = OleDBDR.Item(10)
                    If phData = "" Then
                        frmPayroll.phNo = False
                    Else
                        frmPayroll.phNo = True
                    End If
                    piData = OleDBDR.Item(11)
                    If piData = "" Then
                        frmPayroll.piNo = False
                    Else
                        frmPayroll.piNo = True
                    End If
                    frmPayroll.clear()
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub searchExisting()
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
                .CommandText = "select dbo.tblEmployeesInfo.EmployeeID,dbo.tblEmployeesInfo.lastname,dbo.tblEmployeesInfo.firstname,dbo.tblEmployeesInfo.middlename from dbo.tblEmployeesInfo INNER JOIN " & _
                                "dbo.tblPayrollofEmployees ON dbo.tblEmployeesInfo.EmployeeID = dbo.tblPayrollofEmployees.EmployeeID INNER JOIN dbo.tblPayroll ON dbo.tblPayrollofEmployees.payrollID = " & _
                                "dbo.tblPayroll.payrollID where '" & Format(frmPayroll.dtrFrom.Value, "MM/dd/yyyy") & "' between dbo.tblPayroll.DATEFROM and " & _
                                "dbo.tblPayroll.DATETO  or '" & Format(frmPayroll.dtrTo.Value, "MM/dd/yyyy") & _
                                "' between dbo.tblPayroll.DATEFROM and dbo.tblPayroll.DATETO "

            End With
            OleDBDR = OleDBC.ExecuteReader
            combocount = 0
            EmployeeIDss.Items.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    EmployeeIDss.Items.Add(OleDBDR.Item(0))
                    combocount = combocount + 1
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
                '.CommandText = "select dbo.tblEmployeesInfo.EmployeeID,dbo.tblEmployeesInfo.lastname,dbo.tblEmployeesInfo.firstname,dbo.tblEmployeesInfo.middlename from dbo.tblEmployeesInfo INNER JOIN " & _
                '                "dbo.tblPayrollofEmployees ON dbo.tblEmployeesInfo.EmployeeID = dbo.tblPayrollofEmployees.EmployeeID INNER JOIN dbo.tblPayroll ON dbo.tblPayrollofEmployees.payrollID = " & _
                '                "dbo.tblPayroll.payrollID where '" & Format(frmPayroll.dtrFrom.Value, "MM/dd/yyyy") & "' between dbo.tblPayroll.DATEFROM and " & _
                '                "dbo.tblPayroll.DATETO and dbo.tblPayrollofEmployees.EmployeeID  = '" & frmPayroll.txtemID.Text & "' or '" & Format(frmPayroll.dtrTo.Value, "MM/dd/yyyy") & _
                '                "' between dbo.tblPayroll.DATEFROM and dbo.tblPayroll.DATETO and dbo.tblPayrollofEmployees.EmployeeID  = '" & frmPayroll.txtemID.Text & "'"
                .CommandText = "select * from tblEmployeesInfo"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    Dim row1 As Integer
                    Dim col As Integer = 0
                    Dim hasitems As Integer = 0
                    'Dim i As Integer
                    row1 = combocount
                    While col < row1
                        If EmployeeIDss.Items(col) = OleDBDR.Item(0) Then
                            hasitems = hasitems + 1

                        End If
                        col = col + 1
                    End While
                    If hasitems = 0 Then
                        dgw.Rows.Add()
                        dgw.Item(0, c).Value = OleDBDR.Item(0)
                        dgw.Item(1, c).Value = OleDBDR.Item(1) & ", " & OleDBDR.Item(2) & " " & OleDBDR.Item(3)
                        c = c + 1
                    End If
                End While
            End If
            dgw.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmEmployeeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEmployeeName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick
        AddPayrollCMD()
    End Sub
End Class