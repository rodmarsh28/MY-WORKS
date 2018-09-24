Public Class frmCheckVoucher
    Dim nl As Integer = 0
    Dim particulars As String
    Dim partamount As Double
    Dim accEntryId As String
    Dim accno As String
    Dim debit As Double
    Dim credit As Double
    Public Totamount As Double = 0.0
    Public totDebit As Double = 0.0
    Public totCredit As Double = 0.0

    Sub clear()
        txtCVNo.Text = ""
        txtReqNo.Text = ""
        dtpDate.Value = Now
        txtTIN.Text = ""
        txtPayee.Text = ""
        txtAddress.Text = ""
        txtBankName.Text = ""
        txtCheckNo.Text = ""
        txtCheckedBy.Text = ""
        txtApprovedBy.Text = ""
        dgw.Rows.Clear()
        dgw1.Rows.Clear()
        lblTotAmount.Text = "0.00"
        lblDebit.Text = "0.00"
        lblCredit.Text = "0.00"
        txtAmountinWords.Text = ""
        Totamount = 0.0
        totDebit = 0.0
        totCredit = 0.0

    End Sub
    Sub autoCompleteTIN()
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
                .CommandText = "SELECT Distinct TINNO from tblCV"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtTIN.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtTIN.AutoCompleteCustomSource = col
                txtTIN.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                .CommandText = "SELECT Distinct PAYEE from tblCV"
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
    Sub autoCompleteADDRESS()
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
                .CommandText = "SELECT Distinct ADDRESS from tblCV"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtAddress.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtAddress.AutoCompleteCustomSource = col
                txtAddress.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub autoCompleteBANKNAME()
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
                .CommandText = "SELECT Distinct BANKNAME from tblCV"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtBankName.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtBankName.AutoCompleteCustomSource = col
                txtBankName.AutoCompleteMode = AutoCompleteMode.Suggest
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
                .CommandText = "SELECT Distinct CHECKEDBY from tblCV"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtCheckedBy.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtCheckedBy.AutoCompleteCustomSource = col
                txtCheckedBy.AutoCompleteMode = AutoCompleteMode.Suggest
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
                .CommandText = "SELECT Distinct APPROVEDBY from tblCV"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    col.Add(OleDBDR.Item(0))
                End While
                txtApprovedBy.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtApprovedBy.AutoCompleteCustomSource = col
                txtApprovedBy.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub selectCVNo()
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
                .CommandText = "SELECT * from tblCV order by CVNO DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 6, Len(OleDBDR(0)))
                txtCVNo.Text = "CV-" & Format(Val(StrID) + 1, "00000")
            Else
                txtCVNo.Text = "CV-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub


    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO CREATE AND SAVE CASH / CHECK VOUCHER ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

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
                    .CommandText = "INSERT INTO tblCV VALUES('" & txtCVNo.Text & _
                        "','" & txtReqNo.Text & _
                        "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtTIN.Text & _
                        "','" & txtPayee.Text & _
                        "','" & txtAddress.Text & _
                        "','" & txtBankName.Text & _
                        "','" & txtCheckNo.Text & _
                        "','" & lblTotAmount.Text & _
                        "','" & lblDebit.Text & _
                        "','" & lblCredit.Text & _
                        "','" & txtAmountinWords.Text & _
                        "','" & txtPreparedBy.Text & _
                        "','" & txtCheckedBy.Text & _
                        "','" & txtApprovedBy.Text & "','ISSUED')"
                    .ExecuteNonQuery()
                End With
                particularsProcess()
                accEntryProcess()
                updateStatus()
                printCV()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE CASH / CHECK VOUCHER HAS BEEN CREATED!", MsgBoxStyle.Information, "SUCCESS")
                frmRequestForPaymentList.ShowRequestforPayment()
                Me.Close()
            End Try
        End If
    End Sub
    Sub updateStatus()

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
                .CommandText = "update tblPODESC SET POSTATUS= 'WAITING FOR ITEMS RECEIVED' where PONO ='" & txtReqNo.Text & "' " & _
                               "update tblRFP SET status= 'CHECK / CASH ISSUED' where RFPNO ='" & txtReqNo.Text & "'"
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
        End Try

    End Sub

    Sub particularsProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            particulars = dgw.Item(0, col).Value
            partamount = dgw.Item(1, col).Value
            saveParticulars()
            col = col + 1
        End While

    End Sub
    Sub accEntryProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw1.RowCount
        While col < row1
            accno = dgw1.Item(0, col).Value
            debit = dgw1.Item(2, col).Value
            credit = dgw1.Item(3, col).Value
            saveAccEntry()
            col = col + 1
        End While

    End Sub
    Sub saveParticulars()

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
                .CommandText = "INSERT INTO tblParticulars VALUES('" & txtCVNo.Text & _
                    "','" & particulars & _
                    "','" & partamount & "')"

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub saveAccEntry()

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
                .CommandText = "INSERT INTO tblAccountEntry VALUES('" & txtCVNo.Text & _
                    "','" & accno & _
                    "','" & debit & _
                    "','" & credit & "')"

                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printCV()

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
                .CommandText = "SELECT dbo.tblCV.CVNO,dbo.tblCV.REQNO,dbo.tblCV.[DATE],dbo.tblCV.TINNO,dbo.tblCV.PAYEE,dbo.tblCV.ADDRESS,dbo.tblCV.BANKNAME," & _
                    "dbo.tblCV.CHECKNO,dbo.tblCV.TOTALAMOUNT,dbo.tblCV.AMOUNTINWORDS,dbo.tblCV.PREPAREDBY,dbo.tblCV.CHECKEDBY,dbo.tblCV.APPROVEDBY,dbo.tblAccountEntry.ACCNO,dbo.tblCOA.ACCOUNTNAME," & _
                    "dbo.tblAccountEntry.DEBIT,dbo.tblAccountEntry.CREDIT,dbo.tblParticulars.PARTICULARS,dbo.tblParticulars.AMOUNT FROM dbo.tblCV INNER JOIN dbo.tblAccountEntry " & _
                    "ON dbo.tblCV.CVNO = dbo.tblAccountEntry.CVNO INNER JOIN dbo.tblParticulars ON dbo.tblCV.CVNO = dbo.tblParticulars.CVNO " & _
                    "INNER JOIN dbo.tblCOA ON dbo.tblAccountEntry.ACCNO = dbo.tblCOA.ACCNO where dbo.tblCV.CVNO = '" & txtCVNo.Text & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("CVNO")
                .Columns.Add("REQNO")
                .Columns.Add("DATE")
                .Columns.Add("TINNO")
                .Columns.Add("PAYEE")
                .Columns.Add("ADDRESS")
                .Columns.Add("BANKNAME")
                .Columns.Add("CHECKNO")
                .Columns.Add("TOTALAMOUNT")
                .Columns.Add("AMOUNTINWORDS")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("CHECKEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("ACCNO")
                .Columns.Add("ACCOUNTNAME")
                .Columns.Add("ACCOUNTNAME1")
                .Columns.Add("DEBIT")
                .Columns.Add("CREDIT")
                .Columns.Add("PARTICULARS")
                .Columns.Add("AMOUNT")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    If OleDBDR.Item(16) = "0" Then
                        dt.Rows.Add(OleDBDR.Item(0), OleDBDR.Item(1), Format(OleDBDR.Item(2), "MM/dd/yyyy"), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6), OleDBDR.Item(7),
                                     CDbl(OleDBDR.Item(8)).ToString("#,##0.00"), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14), " ",
                                     CDbl(OleDBDR.Item(15)).ToString("#,##0.00"), CDbl(OleDBDR.Item(16)).ToString("#,##0.00"), OleDBDR.Item(17), CDbl(OleDBDR.Item(18)).ToString("#,##0.00"))
                    Else

                        While nl < 2
                            dt.Rows.Add(OleDBDR.Item(0), OleDBDR.Item(1), Format(OleDBDR.Item(2), "MM/dd/yyyy"), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6), OleDBDR.Item(7),
                                     CDbl(OleDBDR.Item(8)).ToString("#,##0.00"), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), " ", " ", " ", "-",
                                     "-", OleDBDR.Item(17), CDbl(OleDBDR.Item(18)).ToString("#,##0.00"))
                            nl = nl + 1
                        End While
                        dt.Rows.Add(OleDBDR.Item(0), OleDBDR.Item(1), Format(OleDBDR.Item(2), "MM/dd/yyyy"), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6), OleDBDR.Item(7),
                                     CDbl(OleDBDR.Item(8)).ToString("#,##0.00"), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), " ", OleDBDR.Item(14),
                                     CDbl(OleDBDR.Item(15)).ToString("#,##0.00"), CDbl(OleDBDR.Item(16)).ToString("#,##0.00"), OleDBDR.Item(17), CDbl(OleDBDR.Item(18)).ToString("#,##0.00"))
                    End If
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New checkVoucher
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printCheque()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            Totamount = Totamount - dgw.CurrentRow.Cells(1).Value
            dgw.Rows.Remove(row)
            lblTotAmount.Text = CDbl(Totamount).ToString("#,##0.00")

            'PARTID = PARTID - 1


        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In dgw1.SelectedRows
            totDebit = totDebit - dgw1.CurrentRow.Cells(2).Value
            totCredit = totCredit - dgw1.CurrentRow.Cells(3).Value
            dgw1.Rows.Remove(row)
            lblDebit.Text = CDbl(totDebit).ToString("#,##0.00")
            lblCredit.Text = CDbl(totCredit).ToString("#,##0.00")
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        addParticulars.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        accEntry.ShowDialog()
    End Sub

    Private Sub txtAmountinWords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountinWords.TextChanged
        txtAmountinWords.Text = UCase(txtAmountinWords.Text)
    End Sub

    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub lblTotAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTotAmount.TextChanged
        If lblTotAmount.Text = "0" Then
            txtAmountinWords.Text = ""
        Else
            txtAmountinWords.Text = ConvertNumberToENG(Val(Totamount))
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If lblTotAmount.Text = lblDebit.Text And lblCredit.Text Then
            save()
        Else
            MsgBox("THE AMOUNT YOU INPUT IS NOT MATCHED, PLEASE CHECK AND TRY AGAIN", MsgBoxStyle.Critical, "ERROR")
        End If
        clear()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        clear()
        Me.Close()

    End Sub
    Private Sub frmCheckVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autoCompleteTIN()
        autoCompletePAYEE()
        autoCompleteADDRESS()
        autoCompleteBANKNAME()
        autoCompleteCHECKEDBY()
        autoCompleteAPPROVEDBY()

    End Sub
End Class