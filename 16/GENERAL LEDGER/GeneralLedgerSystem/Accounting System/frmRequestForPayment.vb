Public Class frmRequestForPayment
    Dim particulars As String
    Dim debit As Double
    Dim credit As Double
    Dim totdebit As Double
    Dim totcredit As Double
    Sub clear()
        txtPayee.Text = ""
        txtAddress.Text = ""
        txtPaymentFor.Text = ""
        txtCheck.Text = ""
        txtApproved.Text = ""
        dgw.Rows.Clear()
        totcredit = 0.0
        totdebit = 0.0
        lblTotCredit.Text = "0.00"
        lblTotDebit.Text = "0.00"
    End Sub
    Sub autoCompletePAYEE()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct PAYEE from tblRFP "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtPayee.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtPayee.AutoCompleteCustomSource = col
                txtPayee.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteCHECKEDBY()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct CHECKEDBY from tblRFP "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtCheck.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtCheck.AutoCompleteCustomSource = col
                txtCheck.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteAPPROVEDBY()
        Try
            Dim col As New AutoCompleteStringCollection

            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT Distinct APPROVEDBY from tblRFP "
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtApproved.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtApproved.AutoCompleteCustomSource = col
                txtApproved.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub generateRFPNo()
        Dim StrID As String
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
                .CommandText = "SELECT * from tblRFP order by RFPNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtRFPNO.Text = "RFP-" & Format(Val(StrID) + 1, "00000")
            Else
                txtRFPNO.Text = "RFP-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO SAVE REQUEST FOR PAYMENT ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Try
                frmLoadingBar.Show()
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                    .CommandText = "INSERT INTO tblRFP VALUES('" & txtRFPNO.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtPayee.Text & _
                        "','" & txtAddress.Text & _
                        "','" & txtPaymentFor.Text & _
                        "','" & txtPreparedBy.Text & _
                        "','" & txtCheck.Text & _
                        "','" & txtApproved.Text & _
                        "','" & lblTotDebit.Text & _
                        "','" & lblTotCredit.Text & "','WAITING FOR CASH/CHECK ISSUANCE')"
                    .ExecuteNonQuery()
                End With
                dgwItemProcess()
                printRFP()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE REQUEST FOR PAYMENT HAS BEEN SAVED!", MsgBoxStyle.Information, "SUCCESS")
                frmViewIssuedReq.Refresh()
                clear()
                Me.Close()
            End Try
        End If
    End Sub
    Sub dgwItemProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            particulars = dgw.Item(0, col).Value
            DEBIT = dgw.Item(1, col).Value
            credit = dgw.Item(2, col).Value
            saveItem()
            col = col + 1
        End While

    End Sub
    Sub saveItem()
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
                .CommandText = "INSERT INTO tblRFPItems VALUES('" & txtRFPNO.Text & _
                    "','" & particulars & _
                    "','" & debit & _
                    "','" & credit & "')"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printRFP()

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
                .CommandText = "SELECT dbo.tblRFP.RFPNO,dbo.tblRFP.[DATE],dbo.tblRFP.PAYEE,dbo.tblRFP.ADDRESS,dbo.tblRFP.PAYMENTFOR,dbo.tblRFP.PREPAREDBY," & _
                                "dbo.tblRFP.CHECKEDBY,dbo.tblRFP.APPROVEDBY,dbo.tblRFP.TOTALDEBIT,dbo.tblRFP.TOTALCREDIT,dbo.tblRFPItems.PARTICULARS," & _
                                "dbo.tblRFPItems.DEBIT,dbo.tblRFPItems.CREDIT FROM dbo.tblRFP INNER JOIN dbo.tblRFPItems ON dbo.tblRFP.RFPNO = dbo.tblRFPItems.RFPNO " & _
                                "WHERE dbo.tblRFP.RFPNO = '" & txtRFPNO.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("RFPNO")
                .Columns.Add("DATE")
                .Columns.Add("PAYEE")
                .Columns.Add("ADDRESS")
                .Columns.Add("PAYMENTFOR")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("CHECKEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("TOTALDEBIT")
                .Columns.Add("TOTALCREDIT")
                .Columns.Add("PARTICULARS")
                .Columns.Add("DEBIT")
                .Columns.Add("CREDIT")
                
            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), Convert.ToDecimal(OleDBDR.Item(8)).ToString("c"), Convert.ToDecimal(OleDBDR.Item(9)).ToString("c"), OleDBDR.Item(10), Convert.ToDecimal(OleDBDR.Item(11)).ToString("c"),
                                 Convert.ToDecimal(OleDBDR.Item(12)).ToString("c"))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New requestForCheckPayment
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmRequestForPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateRFPNo()
        autoCompletePAYEE()
        autoCompleteCHECKEDBY()
        autoCompleteAPPROVEDBY()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim parts As String = InputBox("Please Enter PARTICULARS")
        If parts = " " Or parts = "" Then
            MessageBox.Show("You must enter a Particular to Continue")
            Exit Sub
        End If
        Dim debt As String = InputBox("Please Enter Debit Amount")
        If debt = " " Or debt = "" Then
            debt = "0"
        ElseIf Not IsNumeric(debt) Then
            MessageBox.Show("You must enter a Numeric Value to Continue")
            Exit Sub
        End If
        Dim credt As String = InputBox("Please Enter Credit Amount")
        If credt = " " Or credt = "" Then
            credt = "0"
        ElseIf Not IsNumeric(credt) Then
            MessageBox.Show("You must enter a Numeric Value to Continue")
            Exit Sub
        End If
        If debt = "0" And credt = "0" Then
            MsgBox("You dont have Entered Value", MsgBoxStyle.Critical, "ERROR")
        Else
            Dim r As Integer
            r = dgw.Rows.Count
            dgw.Rows.Add()
            dgw.Item(0, r).Value = parts
            dgw.Item(1, r).Value = debt
            dgw.Item(2, r).Value = credt
            totdebit = totdebit + debt
            totcredit = totcredit + credt
            lblTotDebit.Text = totdebit.ToString("n2")
            lblTotCredit.Text = totcredit.ToString("n2")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            totcredit = lblTotCredit.Text - dgw.CurrentRow.Cells(2).Value
            totdebit = lblTotDebit.Text - dgw.CurrentRow.Cells(1).Value
            dgw.Rows.Remove(row)
            lblTotDebit.Text = totdebit.ToString("n2")
            lblTotCredit.Text = totcredit.ToString("n2")
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

 
End Class