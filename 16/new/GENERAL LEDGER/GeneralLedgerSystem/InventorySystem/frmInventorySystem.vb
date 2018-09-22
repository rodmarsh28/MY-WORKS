Public Class frmInventorySystem
    Public Sub showInventory()
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
                .CommandText = "select * from tblINVENTORY"
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
                    dgw.Item(5, c).Value = OleDBDR.Item(6)

                    c = c + 1
                End While
            End If
            dgw.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmInventorySystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showInventory()
        lblItemcount.Text = dgw.RowCount
    End Sub

    Private Sub MATERIALWITHDRAWALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MATERIALWITHDRAWALToolStripMenuItem.Click
        frmAddReqOfDept.Show()
    End Sub

    Private Sub PENDINGREQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENDINGREQUESTToolStripMenuItem.Click
        frmViewIssuedReq.ShowDialog()
    End Sub

    Private Sub ADDITEMMANUALLYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDITEMMANUALLYToolStripMenuItem.Click
        frmaddMaterials.Show()
    End Sub

    Private Sub GENERATEPURCHASEREQUESTSLIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GENERATEPURCHASEREQUESTSLIPToolStripMenuItem.Click
        frmPurchaseRequestSlip.Show()
        frmPurchaseRequestSlip.txtPreparedBy.Text = MainForm.LBLNAME.Text
    End Sub

    Private Sub TRANSACTIONHISTORYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSACTIONHISTORYToolStripMenuItem.Click
        frmViewPendingPurchase.ShowDialog()
    End Sub

    Private Sub ALLMWSREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLMWSREPORTToolStripMenuItem.Click
        frmTransactionReport.CheckBox1.Checked = True
        frmTransactionReport.tittleLabel.Text = "ALL ITEMS WIDTHRAWAL REPORT"
        frmTransactionReport.MWSReport()
        frmTransactionReport.dgw.Columns(0).HeaderCell.Value = "DATE"
        frmTransactionReport.dgw.Columns(1).HeaderCell.Value = "MWS NO."
        frmTransactionReport.dgw.Columns(2).HeaderCell.Value = "ITEMS ISSUED ?"
        frmTransactionReport.dgw.Columns(3).HeaderCell.Value = ""

        frmTransactionReport.dgw.Columns(2).DefaultCellStyle.Format = ""
        frmTransactionReport.dgw.Columns(3).DefaultCellStyle.Format = ""

        frmTransactionReport.dgw.Columns(0).Width = 200
        frmTransactionReport.dgw.Columns(1).Width = 250
        frmTransactionReport.dgw.Columns(2).Width = 320
        frmTransactionReport.dgw.Columns(3).Width = 0

        frmTransactionReport.mode = "MWS"
        frmTransactionReport.dgw.Columns(3).Visible = False
        frmTransactionReport.Show()
    End Sub

    Private Sub ALLMISREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLMISREPORTToolStripMenuItem.Click
        frmTransactionReport.CheckBox1.Checked = True
        frmTransactionReport.tittleLabel.Text = "ALL ITEMS ISSUED REPORT"
        frmTransactionReport.MISReport()
        frmTransactionReport.dgw.Columns(0).HeaderCell.Value = "DATE"
        frmTransactionReport.dgw.Columns(1).HeaderCell.Value = "MIS NO."
        frmTransactionReport.dgw.Columns(2).HeaderCell.Value = "ACQUISITION COST"
        frmTransactionReport.dgw.Columns(3).HeaderCell.Value = "IS RECEIVED ?"

        frmTransactionReport.dgw.Columns(2).DefaultCellStyle.Format = "c"
        frmTransactionReport.dgw.Columns(3).DefaultCellStyle.Format = ""

        frmTransactionReport.dgw.Columns(0).Width = 170
        frmTransactionReport.dgw.Columns(1).Width = 200
        frmTransactionReport.dgw.Columns(2).Width = 200
        frmTransactionReport.dgw.Columns(3).Width = 200
        frmTransactionReport.dgw.Columns(3).Visible = True
        frmTransactionReport.MODE = "MIS"
        frmTransactionReport.Show()
    End Sub

    Private Sub ALLPRSREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLPRSREPORTToolStripMenuItem.Click
        frmTransactionReport.CheckBox1.Checked = True
        frmTransactionReport.tittleLabel.Text = "ALL PURCHASE REQUEST REPORT"
        frmTransactionReport.PRSReport()
        frmTransactionReport.dgw.Columns(0).HeaderCell.Value = "DATE"
        frmTransactionReport.dgw.Columns(1).HeaderCell.Value = "PRS NO."
        frmTransactionReport.dgw.Columns(2).HeaderCell.Value = "STATUS "
        frmTransactionReport.dgw.Columns(3).HeaderCell.Value = ""

        frmTransactionReport.dgw.Columns(2).DefaultCellStyle.Format = ""
        frmTransactionReport.dgw.Columns(3).DefaultCellStyle.Format = ""

        frmTransactionReport.dgw.Columns(0).Width = 200
        frmTransactionReport.dgw.Columns(1).Width = 250
        frmTransactionReport.dgw.Columns(2).Width = 320
        frmTransactionReport.dgw.Columns(3).Width = 0

        frmTransactionReport.dgw.Columns(3).Visible = False
        frmTransactionReport.MODE = "PRS"
        frmTransactionReport.Show()
    End Sub

    Private Sub ALLPOREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLPOREPORTToolStripMenuItem.Click
        frmTransactionReport.CheckBox1.Checked = True
        frmTransactionReport.tittleLabel.Text = "ALL PURCHASE ORDER REPORT"
        frmTransactionReport.POReport()
        frmTransactionReport.dgw.Columns(0).HeaderCell.Value = "DATE"
        frmTransactionReport.dgw.Columns(1).HeaderCell.Value = "PO NO."
        frmTransactionReport.dgw.Columns(2).HeaderCell.Value = "AMOUNT"
        frmTransactionReport.dgw.Columns(3).HeaderCell.Value = "STATUS "

        frmTransactionReport.dgw.Columns(2).DefaultCellStyle.Format = "c"
        frmTransactionReport.dgw.Columns(3).DefaultCellStyle.Format = ""

        frmTransactionReport.dgw.Columns(0).Width = 140
        frmTransactionReport.dgw.Columns(1).Width = 160
        frmTransactionReport.dgw.Columns(2).Width = 170
        frmTransactionReport.dgw.Columns(3).Width = 300
        frmTransactionReport.dgw.Columns(3).Visible = True
        frmTransactionReport.MODE = "PO"
        frmTransactionReport.Show()
    End Sub

    Private Sub ALLMWSREPORTToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLMWSREPORTToolStripMenuItem1.Click
        frmTransactionReport.CheckBox1.Visible = False
        frmTransactionReport.tittleLabel.Text = "ALL RECEIVED ITEMS REPORT"
        frmTransactionReport.MRSReport()
        frmTransactionReport.dgw.Columns(0).HeaderCell.Value = "DATE"
        frmTransactionReport.dgw.Columns(1).HeaderCell.Value = "MRS NO."
        frmTransactionReport.dgw.Columns(2).HeaderCell.Value = "AMOUNT"
        frmTransactionReport.dgw.Columns(3).HeaderCell.Value = ""

        frmTransactionReport.dgw.Columns(2).DefaultCellStyle.Format = "c"
        frmTransactionReport.dgw.Columns(3).DefaultCellStyle.Format = ""

        frmTransactionReport.dgw.Columns(0).Width = 200
        frmTransactionReport.dgw.Columns(1).Width = 270
        frmTransactionReport.dgw.Columns(2).Width = 300
        frmTransactionReport.dgw.Columns(3).Width = 0

        frmTransactionReport.MODE = "MRS"
        frmTransactionReport.dgw.Columns(3).Visible = False
        frmTransactionReport.Show()
    End Sub

    Private Sub PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEREMPLOYEEACQUISITIONREPORTToolStripMenuItem.Click
        frmTransactionReportForMember.CheckBox1.Checked = True
        frmTransactionReportForMember.Show()
    End Sub
End Class