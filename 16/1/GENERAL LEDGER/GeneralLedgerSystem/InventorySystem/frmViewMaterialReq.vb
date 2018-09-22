Public Class frmViewIssuedReq

    Sub REFRESHDGV()
        showPendingRequest()
        showNotReceivedItemIssue()
    End Sub

    Sub showPendingRequest()
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
                .CommandText = "select * from tblMWSDESC where ISISSUED = 'NO'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(3)
                    dgw.Item(3, c).Value = OleDBDR.Item(4)
                    dgw.Item(4, c).Value = OleDBDR.Item(8)
                    dgw.Item(5, c).Value = OleDBDR.Item(6)
                    dgw.Item(6, c).Value = OleDBDR.Item(7)


                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblCount.Text = dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub showNotReceivedItemIssue()
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
                .CommandText = "select * from tblMISDESC where ISRECEIVED = 'NO'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(3)
                    dgw.Item(3, c).Value = OleDBDR.Item(4)
                    dgw.Item(4, c).Value = OleDBDR.Item(9)
                    dgw.Item(5, c).Value = OleDBDR.Item(8)
                    dgw.Item(6, c).Value = OleDBDR.Item(7)
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblCount.Text = dgw.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmViewMaterialReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub selectReport()
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
                .CommandText = "SELECT dbo.tblMWSDESC.MWSDESCNO,dbo.tblMWSDESC.[DATE],dbo.tblMWSDESC.[TO],dbo.tblMWSDESC.[SECTION]," & _
                    "dbo.tblMWSDESC.DEPARTMENT,dbo.tblMWSDESC.JUSTIFICATION,dbo.tblMWSDESC.PREPAREDBY,dbo.tblMWSDESC.APPROVEDBY,dbo.tblMWSITEM.MATERIALDESC,dbo.tblMWSITEM.ITEMCATEGORIES,dbo.tblMWSITEM.UNIT," & _
                    "dbo.tblMWSITEM.QTY FROM dbo.tblMWSDESC INNER JOIN dbo.tblMWSITEM ON dbo.tblMWSDESC.MWSDESCNO = dbo.tblMWSITEM.MWSDESCNO where dbo.tblMWSDESC.MWSDESCNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("MWSDESCNO")
                .Columns.Add("DATE")
                .Columns.Add("TO")
                .Columns.Add("SECTION")
                .Columns.Add("DEPARTMENT")
                .Columns.Add("JUSTIFICATION")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("DEBITTO")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("APPROVEDBY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(8),
                                 OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(6), OleDBDR.Item(7))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New materialWithdrawalSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub viewMIS()
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
                .CommandText = "SELECT dbo.tblMISDESC.MISNO,dbo.tblMISDESC.[DATE],dbo.tblMISDESC.MWSREF,dbo.tblMISDESC.[SECTION],dbo.tblMISDESC.DEPARTMENT," & _
                    "dbo.tblMISDESC.REMARKS,dbo.tblMISDESC.ISSUEDBY,dbo.tblMISDESC.APPROVEDBY,dbo.tblMISITEM.INVTYCODE,dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.SERIAL," & _
                    "dbo.tblMISITEM.ITEMCATEGORIES,dbo.tblMISITEM.UNIT,dbo.tblMISITEM.QTY,dbo.tblMISDESC.RECEIVEDBY FROM dbo.tblMISITEM INNER JOIN dbo.tblMISDESC ON dbo.tblMISITEM.MISNO = dbo.tblMISDESC.MISNO WHERE dbo.tblMISDESC.MISNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("MISNO")
                .Columns.Add("DATE")
                .Columns.Add("MWSREF")
                .Columns.Add("SECTION")
                .Columns.Add("DEPARTMENT")
                .Columns.Add("REMARKS")
                .Columns.Add("ISSUEDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("RECEIVEDBY")
                .Columns.Add("INVTYCODE")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("DEBITTO")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(14), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New materialIssuanceSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VIEWREQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWREQUESTToolStripMenuItem.Click
        selectReport()

    End Sub

    Private Sub ISSUEREQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISSUEREQUESTToolStripMenuItem.Click
        frmMaterialsIssuance.txtMWSRefNo.Text = dgw.CurrentRow.Cells(1).Value
        frmMaterialsIssuance.txtSection.Text = dgw.CurrentRow.Cells(2).Value
        frmMaterialsIssuance.txtDepartment.Text = dgw.CurrentRow.Cells(3).Value
        frmMaterialsIssuance.txtRequestor.Text = dgw.CurrentRow.Cells(5).Value
        frmMaterialsIssuance.txtApprovedBy.Text = dgw.CurrentRow.Cells(6).Value
        frmMaterialsIssuance.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbShowby.SelectedIndexChanged
        If cmbShowby.Text = "PENDING REQUEST" Then
            showPendingRequest()
            dgw.Columns(1).HeaderCell.Value = "MWS ID NO."
            dgw.Columns(4).HeaderCell.Value = "ISSUED"

        ElseIf cmbShowby.Text = "NOT RECEIVED ITEM ISSUE" Then
            showNotReceivedItemIssue()
            dgw.Columns(1).HeaderCell.Value = "MIS ID NO."
            dgw.Columns(4).HeaderCell.Value = "RECEIVED"

        End If
    End Sub

    Private Sub cmbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub RECEIVEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIVEDToolStripMenuItem.Click
        If MsgBox("ARE YOU SURE YOU THIS ISSUANCE IS RECEIVED TO THE REQUESTED PERSON ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "update tblMISDESC set ISRECEIVED ='YES'"
                    .ExecuteNonQuery()
                End With
                MsgBox("THIS ISSUANCE STATUS IS SUCCESSFULLY ISSUED", MsgBoxStyle.Information, "OK, THANKS !")
                showNotReceivedItemIssue()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("PLEASE BE SURE TO PERFORM THIS ACTION", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub

    Private Sub VIEWISSUANCEFORMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWISSUANCEFORMToolStripMenuItem.Click
        viewMIS()
    End Sub

    Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                If cmbShowby.Text = "PENDING REQUEST" Then
                    dgw.ContextMenuStrip = ContextMenuStrip1
                ElseIf cmbShowby.Text = "NOT RECEIVED ITEM ISSUE" Then
                    dgw.ContextMenuStrip = ContextMenuStrip2
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip1.Closed
        dgw.ContextMenuStrip = ContextMenuStrip3
    End Sub

    Private Sub ContextMenuStrip2_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ContextMenuStrip2.Closed
        dgw.ContextMenuStrip = ContextMenuStrip3
    End Sub

   

    Private Sub CANCELWIDTHRAWALREQUESTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELWIDTHRAWALREQUESTToolStripMenuItem.Click
        If MsgBox("ARE YOU SURE YOU CANCEL THIS WIDTHRAWAL REQUEST ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "DELETE FROM tblMWSDESC where MWSDESCNO='" & dgw.CurrentRow.Cells(1).Value & "'; " & _
                                    "DELETE FROM tblMWSITEM where MWSDESCNO='" & dgw.CurrentRow.Cells(1).Value & "'"
                    .ExecuteNonQuery()
                End With
                MsgBox("THIS WIDTHRAWAL REQUEST HAS CANCELLED", MsgBoxStyle.Information, "DONE")
                showNotReceivedItemIssue()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("PLEASE BE SURE TO PERFORM THIS ACTION", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub
    Sub rollBackStocks()

        Dim dt As New DataTable
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
                .CommandText = "SELECT * FROM tblMISITEM where MISNO ='" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader


            With dt
                .Columns.Add("INVTYCODE")
                .Columns.Add("STOCKS")

            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(1), OleDBDR.Item(7))
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For Each row As DataRow In dt.rows
            Dim invtycode As String
            Dim qty As Integer
            invtycode = (row(0))
            qty = (row(1))
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "update tblINVENTORY set STOCKSONHAND = STOCKSONHAND + " & qty & " where INVTYCODE = '" & invtycode & "'"
                .ExecuteNonQuery()
            End With
        Next
    End Sub
    Private Sub RETURNITEMISSUEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RETURNITEMISSUEDToolStripMenuItem.Click
        If MsgBox("ARE YOU SURE YOU WANT TO RETURN ISSUED ITEM/'S ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            rollBackStocks()
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
                    .CommandText = "update tblMISDESC set ISRECEIVED = 'RETURNED' where MISNO ='" & dgw.CurrentRow.Cells(1).Value & "'"
                    .ExecuteNonQuery()
                End With
                MsgBox("THIS ISSUANCES ITEM/'S RETURNED SUCCESSFULLY", MsgBoxStyle.Information, "DONE")
                showPendingRequest()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("PLEASE BE SURE TO PERFORM THIS ACTION", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub
End Class