Public Class frmAccountingSystem
    Dim nl As Integer = 0
    Private Sub REQUESTFORPAYMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQUESTFORPAYMENTToolStripMenuItem.Click
        frmRequestForPaymentList.ShowDialog()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
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
                    "INNER JOIN dbo.tblCOA ON dbo.tblAccountEntry.ACCNO = dbo.tblCOA.ACCNO where dbo.tblCV.CVNO = 'CV-00001'"
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

                        While nl < 1
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
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class