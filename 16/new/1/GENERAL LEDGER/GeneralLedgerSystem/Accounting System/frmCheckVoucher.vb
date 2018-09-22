Public Class frmCheckVoucher
    Public PARTID As Integer = 0
    Dim partIds As String
    Dim particulars As String
    Dim partamount As Double
    Dim accEntryId As String
    Dim accno As String
    Dim debit As Double
    Dim credit As Double
    Sub selectPARTID()
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
                .CommandText = "SELECT * from tblParticulars order by PARTID DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                PARTID = OleDBDR.Item(0)
            
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

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
                txtCheckNo.Text = "CV-" & Format(Val(StrID) + 1, "00000")
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
                printCV()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("THE CASH / CHECK VOUCHER HAS BEEN CREATED!", MsgBoxStyle.Information, "SUCCESS")
                frmViewIssuedReq.Refresh()
                Me.Close()
            End Try
        End If
    End Sub
    Sub particularsProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            particulars = dgw.Item(1, col).Value
            partamount = dgw.Item(2, col).Value
            saveParticulars()
            col = col + 1
        End While

    End Sub
    Sub accEntryProcess()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgw.RowCount
        While col < row1
            accno = dgw.Item(1, col).Value
            debit = dgw.Item(2, col).Value
            credit = dgw.Item(3, col).Value
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
                    "','" & partamount &  "')"

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
                    "','" & credit &  "')"

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
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT dbo.tblCV.CVNO,dbo.tblCV.REQNO,dbo.tblCV.[DATE],dbo.tblCV.TINNO,dbo.tblCV.PAYEE,dbo.tblCV.ADDRESS,dbo.tblCV.BANKNAME," & _
                    "dbo.tblCV.CHECKNO,dbo.tblCV.TOTALAMOUNT,dbo.tblCV.AMOUNTINWORDS,dbo.tblCV.PREPAREDBY,dbo.tblCV.CHECKEDBY,dbo.tblCV.APPROVEDBY,dbo.tblCOA.ACCOUNTNAME," & _
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
                .Columns.Add("ACCOUNTNAME")
                .Columns.Add("DEBIT")
                .Columns.Add("CREDIT")
                .Columns.Add("PARTICULARS")
                .Columns.Add("AMOUNT")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), OleDBDR.Item(1), Format(OleDBDR.Item(2), "MM/dd/yyyy"), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6), OleDBDR.Item(7),
                                 OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14), OleDBDR.Item(15), OleDBDR.Item(16),
                                 OleDBDR.Item(17))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New checkVoucher
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In dgw.SelectedRows
            dgw.Rows.Remove(row)
            PARTID = PARTID - 1
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In dgw1.SelectedRows
            dgw1.Rows.Remove(row)
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        addParticulars.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        accEntry.ShowDialog()
    End Sub

End Class