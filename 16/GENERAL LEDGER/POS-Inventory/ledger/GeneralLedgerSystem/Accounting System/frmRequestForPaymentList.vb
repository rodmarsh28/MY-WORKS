Public Class frmRequestForPaymentList
    Sub ShowRequestforPayment()
        Try
            Dim c As Integer
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            c = 0
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT DATE,PONO,SUPPLIERNAME from tblPODESC WHERE POSTATUS = 'WAITING FOR CASH/CHECK ISSUANCE' " & _
                                "UNION SELECT tblRFP.DATE,tblRFP.RFPNO,tblRFP.PAYEE from tblRFP WHERE tblRFP.STATUS = 'WAITING FOR CASH/CHECK ISSUANCE'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(0), "MM/dd/yyyy").ToString
                    dgw.Item(1, c).Value = OleDBDR.Item(1)
                    dgw.Item(2, c).Value = OleDBDR.Item(2)
                    'dgw.Item(3, c).Value = OleDBDR.Item(3)
                    c = c + 1
                End While
                dgw.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRequestForPaymentList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowRequestforPayment()
    End Sub
    Sub printPO()
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
                .CommandText = "SELECT dbo.tblPODESC.PONO,dbo.tblPODESC.[DATE],dbo.tblPODESC.PRSREF,dbo.tblPODESC.SUPPLIERNAME,dbo.tblPODESC.ADDRESS," & _
                    "dbo.tblPODESC.CONTACTPERSON,dbo.tblPODESC.CONTACTNO,dbo.tblPODESC.PAYMENTTERM,dbo.tblPODESC.TOTALAMOUNT,dbo.tblPODESC.REMARKS," & _
                    "dbo.tblPODESC.PREPAREDBY,dbo.tblPODESC.RECOMMENDEDBY,dbo.tblPODESC.APPROVEDBY,dbo.tblPODESC.POSTATUS,dbo.tblPOITEM.ITEMDESC," & _
                    "dbo.tblPOITEM.SERIAL,dbo.tblPOITEM.UNIT,dbo.tblPOITEM.UPRICE,dbo.tblPOITEM.LESSVAT,dbo.tblPOITEM.QTY,dbo.tblPOITEM.AMOUNT FROM dbo.tblPODESC " & _
                    "INNER JOIN dbo.tblPOITEM ON dbo.tblPODESC.PONO = dbo.tblPOITEM.PONO WHERE dbo.tblPODESC.PONO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("PONO")
                .Columns.Add("DATE")
                .Columns.Add("PRSREF")
                .Columns.Add("SUPPLIERNAME")
                .Columns.Add("ADDRESS")
                .Columns.Add("CONTACTPERSON")
                .Columns.Add("CONTACTNO")
                .Columns.Add("PAYMENTTERM")
                .Columns.Add("TOTALAMOUNT")
                .Columns.Add("REMARKS")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("RECOMMENDEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("POSTATUS")
                .Columns.Add("ITEMDESC")
                .Columns.Add("SERIAL")
                .Columns.Add("UNIT")
                .Columns.Add("UPRICE")
                .Columns.Add("LESSVAT")
                .Columns.Add("QUANTITY")
                .Columns.Add("AMOUNT")
            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), Convert.ToDecimal(OleDBDR.Item(8)).ToString("c"), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14),
                                  OleDBDR.Item(15), OleDBDR.Item(16), Convert.ToDecimal(OleDBDR.Item(17)).ToString("c"), Convert.ToDecimal(OleDBDR.Item(18)).ToString("c"), OleDBDR.Item(19),
                                  Convert.ToDecimal(OleDBDR.Item(20)).ToString("c"))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New purchaseOrderSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            frmLoadingBar.Close()
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printRFP()

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
                .CommandText = "SELECT dbo.tblRFP.RFPNO,dbo.tblRFP.[DATE],dbo.tblRFP.PAYEE,dbo.tblRFP.ADDRESS,dbo.tblRFP.PAYMENTFOR,dbo.tblRFP.PREPAREDBY," & _
                                "dbo.tblRFP.CHECKEDBY,dbo.tblRFP.APPROVEDBY,dbo.tblRFP.TOTALDEBIT,dbo.tblRFP.TOTALCREDIT,dbo.tblRFPItems.PARTICULARS," & _
                                "dbo.tblRFPItems.DEBIT,dbo.tblRFPItems.CREDIT FROM dbo.tblRFP INNER JOIN dbo.tblRFPItems ON dbo.tblRFP.RFPNO = dbo.tblRFPItems.RFPNO " & _
                                "WHERE dbo.tblRFP.RFPNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
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

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                dgw.ContextMenuStrip = ContextMenuStrip1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip1.Closed
        dgw.ContextMenuStrip = ContextMenuStrip2
    End Sub

   
    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        frmCheckVoucher.txtReqNo.Text = dgw.CurrentRow.Cells(1).Value
        frmCheckVoucher.txtPayee.Text = dgw.CurrentRow.Cells(2).Value
        frmCheckVoucher.txtPreparedBy.Text = MainForm.LBLNAME.Text
        frmCheckVoucher.selectCVNo()
        'frmCheckVoucher.selectPARTID()
        frmCheckVoucher.ShowDialog()
    End Sub

    Private Sub ISSUEAPETTYCASHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISSUEAPETTYCASHToolStripMenuItem.Click
        frmPettyCashVoucher.txtRefNo.Text = dgw.CurrentRow.Cells(1).Value
        frmPettyCashVoucher.txtIssuedBy.Text = MainForm.LBLNAME.Text
        frmPettyCashVoucher.ShowDialog()
    End Sub

    Private Sub VIEWREQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWREQUESTToolStripMenuItem.Click
        If dgw.CurrentRow.Cells(1).Value Like "PO*" Then
            printPO()
        ElseIf dgw.CurrentRow.Cells(1).Value Like "RFP*" Then
            printRFP()
        End If
    End Sub
End Class