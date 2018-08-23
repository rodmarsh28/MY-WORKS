Public Class frmAddExpenses
    Public vid As String
    Dim yearUsed As Integer
    Dim eID As String


    Private Sub frmAddExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        selectType()
    End Sub
    Sub clear()
        cmbType.Text = ""
        txtQTY.Text = ""
        txtUnit.Text = ""
        txtUprice.Text = ""
    End Sub
    Sub getYear()
       
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
                .CommandText = "DECLARE @eid as varchar " & _
                                "DECLARE @ld as date " & _
                                "select @ld = (select max([date]) from tblsummaryexpenses where vID = '" & vid & "' and expenseType = '" & cmbType.Text & "') " & _
                                "select @eid = (select max(eid) from tblsummaryexpenses where vID = '" & vid & "' and expenseType = '" & cmbType.Text & "') " & _
                                "select @eid, datediff(year, @ld, GETDATE())"

            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    If IsDBNull(OleDBDR.Item(0)) Then
                        Exit Sub
                    Else
                        eID = OleDBDR.Item(0)
                        yearUsed = OleDBDR.Item(1)
                        update()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub update()
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
                .CommandText = "UPDATE tblsummaryexpenses set yearUsed = '" & yearUsed & "' where eID = '" & eID & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub addExpenses()

        If MsgBox("ARE YOU SURE YOU WANT TO ADD ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "INSERT INTO tblsummaryexpenses VALUES('" & vid & _
                        "','" & cmbType.Text & _
                        "','" & txtUnit.Text & _
                        "','" & txtQTY.Text & _
                        "','" & txtUprice.Text & _
                        "','" & txtUprice.Text * txtQTY.Text & _
                        "','" & lblPrevOdo.Text & _
                        "','" & lblCurrentOdo.Text & _
                        "','" & lblKML.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & "','0')"
                    .ExecuteNonQuery()
                End With
                MsgBox("Expenses Added", MsgBoxStyle.Information, "SUCCESS")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub selectType()
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            Dim c As Integer

            With OleDBC
                .Connection = conn
                .CommandText = "SELECT DISTINCT expenseType FROM tblsummaryexpenses "

            End With
            OleDBDR = OleDBC.ExecuteReader
            cmbType.Items.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    cmbType.Items.Add(OleDBDR.Item(0))
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub selectPrevOdo()
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
                .CommandText = "SELECT currentOdometer FROM tblsummaryexpenses where vID = '" & vid & "' and expenseType = '" & cmbType.Text & "' order by currentOdometer desc "

            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                If OleDBDR.Read Then
                    lblPrevOdo.Text = (OleDBDR.Item(0))
                    Dim kml As Double
                    Dim currentOdo As Double = InputBox("Please Enter Current Odometer")
                    lblCurrentOdo.Text = currentOdo
                    kml = (currentOdo - lblPrevOdo.Text) / txtQTY.Text
                    lblKML.Text = Format(kml, "N")
                End If
            Else
                Dim kml As Double
                Dim prevOdo As Double = InputBox("Please Enter Prev Odometer")
                lblPrevOdo.Text = prevOdo
                Dim currentOdo As Double = InputBox("Please Enter Current Odometer")
                lblCurrentOdo.Text = currentOdo
                kml = (currentOdo - lblPrevOdo.Text) / txtQTY.Text
                lblKML.Text = Format(kml, "N")
            End If
            addExpenses()
        Catch ex As Exception
            MsgBox("The Odometer Inputted Error", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtQTY.Text = "" Then
            txtQTY.Text = "0"
        ElseIf txtUprice.Text = "" Then
            txtUprice.Text = "0.00"
        End If
        txtTotalAmount.Text = Format(txtUprice.Text * txtQTY.Text, "0.00")
        If cmbType.Text = "Fuel" Or cmbType.Text = "fuel" Then
            selectPrevOdo()

        Else
            getYear()
            addExpenses()
        End If

    End Sub

    Private Sub cmbType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.TextChanged

    End Sub
End Class