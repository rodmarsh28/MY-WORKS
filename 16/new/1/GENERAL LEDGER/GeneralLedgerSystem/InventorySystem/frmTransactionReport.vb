Public Class frmTransactionReport
    Dim total As Double = 0.0
    Public MODE As String

    Sub MWSReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMWSDESC order by date desc"
                End With
            Else
               
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMWSDESC where ISISSUED = 'YES' order by date desc"
                End With
            End If
         
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(8)

                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lbltotalam.Visible = False
            lblTotalAmount.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub MWSSearchReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMWSDESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and MWSDESCNO like '%" & txtID.Text & "%' order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMWSDESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and MWSDESCNO like '%" & txtID.Text & "%' and ISISSUED = 'YES' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(8)

                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lbltotalam.Visible = False
            lblTotalAmount.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub MISReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMISDESC where ISRECEIVED != 'RETURNED' order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMISDESC where ISRECEIVED = 'YES' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(10)
                    dgw.Item(3, c).Value = OleDBDR.Item(9)
                    total = total + dgw.Item(2, c).Value
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")
            lbltotalam.Visible = True
            lblTotalAmount.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub MISSearchReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMISDESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and MISNO like '%" & txtID.Text & "%' and ISRECEIVED != 'RETURNED' order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblMISDESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and MISNO like '%" & txtID.Text & "%' and ISRECEIVED = 'YES' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(10)
                    dgw.Item(3, c).Value = OleDBDR.Item(9)
                    total = total + dgw.Item(2, c).Value
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")
            lbltotalam.Visible = True
            lblTotalAmount.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PRSReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPRSDESC order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPRSDESC where REQSTATUS = 'APPROVED FOR PO' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(5)

                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lbltotalam.Visible = False
            lblTotalAmount.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub PRSSearchReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPRSDESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and PRSNO like '%" & txtID.Text & "%' order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPRSDESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and PRSNO like '%" & txtID.Text & "%' and REQSTATUS = 'APPROVED FOR PO' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(5)
                   
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lbltotalam.Visible = False
            lblTotalAmount.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub POReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPODESC order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPODESC where POSTATUS = 'RECEIVED' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(8)
                    dgw.Item(3, c).Value = OleDBDR.Item(13)
                    total = total + dgw.Item(2, c).Value
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")
            lbltotalam.Visible = True
            lblTotalAmount.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub POSearchReport()
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
            If CheckBox1.Checked = True Then
                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPODESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and PONO like '%" & txtID.Text & "%' order by date desc"
                End With
            Else

                With OleDBC
                    .Connection = conn
                    .CommandText = "select * from tblPODESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                        "' and PONO like '%" & txtID.Text & "%' and POSTATUS = 'RECEIVED' order by date desc"
                End With
            End If

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(8)
                    dgw.Item(3, c).Value = OleDBDR.Item(13)
                    total = total + dgw.Item(2, c).Value
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")
            lbltotalam.Visible = True
            lblTotalAmount.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub MRSReport()
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
                .CommandText = "select * from tblMRSDESC order by date desc"
            End With

            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(7)
                    total = total + dgw.Item(2, c).Value
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")
            lbltotalam.Visible = True
            lblTotalAmount.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub MRSSearchReport()
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
                .CommandText = "select * from tblPODESC where date between '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' and '" & Format(dtpTo.Value, "MM/dd/yyyy") & _
                    "' and PONO like '%" & txtID.Text & "%' order by date desc"
            End With
            OleDBDR = OleDBC.ExecuteReader
            dgw.Rows.Clear()
            total = 0
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dgw.Rows.Add()
                    dgw.Item(0, c).Value = Format(OleDBDR.Item(1), "MM/dd/yyyy")
                    dgw.Item(1, c).Value = OleDBDR.Item(0)
                    dgw.Item(2, c).Value = OleDBDR.Item(7)
                    total = total + dgw.Item(2, c).Value
                    c = c + 1
                End While
            End If
            dgw.ClearSelection()
            dgw.ClearSelection()
            lblItemCount.Text = dgw.RowCount
            lblTotalAmount.Text = CDbl(total).ToString("#,##0.00")
            lbltotalam.Visible = True
            lblTotalAmount.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If dtpFrom.Text = Format(Now, "dd/MM/yyyy") And dtpTo.Text = Format(Now, "dd/MM/yyyy") And txtID.Text = "" Then
            If tittleLabel.Text = "ALL ITEMS WIDTHRAWAL REPORT" Then
                MWSReport()
            ElseIf tittleLabel.Text = "ALL ITEMS ISSUED REPORT" Then
                MISReport()
            ElseIf tittleLabel.Text = "ALL PURCHASE REQUEST REPORT" Then
                PRSReport()
            ElseIf tittleLabel.Text = "ALL PURCHASE ORDER REPORT" Then
                POReport()
            End If

        End If






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tittleLabel.Text = "ALL ITEMS WIDTHRAWAL REPORT" Then
            MWSSearchReport()
        ElseIf tittleLabel.Text = "ALL ITEMS ISSUED REPORT" Then
            MISSearchReport()
        ElseIf tittleLabel.Text = "ALL PURCHASE REQUEST REPORT" Then
            PRSSearchReport()
        ElseIf tittleLabel.Text = "ALL PURCHASE ORDER REPORT" Then
            POSearchReport()
        ElseIf tittleLabel.Text = "ALL RECEIVED ITEMS REPORT" Then
            MRSSearchReport()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dtpFrom.Value = Now
        dtpTo.Value = Now
        txtID.Text = ""
        If tittleLabel.Text = "ALL ITEMS WIDTHRAWAL REPORT" Then
            MWSReport()
        ElseIf tittleLabel.Text = "ALL ITEMS ISSUED REPORT" Then
            MISReport()
        ElseIf tittleLabel.Text = "ALL PURCHASE REQUEST REPORT" Then
            PRSReport()
        ElseIf tittleLabel.Text = "ALL PURCHASE ORDER REPORT" Then
            POReport()
        ElseIf tittleLabel.Text = "ALL RECEIVED ITEMS REPORT" Then
            MRSReport()
        End If
    End Sub
    Sub printMWS()
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
                .CommandText = "SELECT dbo.tblMWSDESC.MWSDESCNO,dbo.tblMWSDESC.[DATE],dbo.tblMWSDESC.[sTO],dbo.tblMWSDESC.[SECTION]," & _
                    "dbo.tblMWSDESC.DEPARTMENT,dbo.tblMWSDESC.JUSTIFICATION,dbo.tblMWSDESC.PREPAREDBY,dbo.tblMWSDESC.APPROVEDBY,dbo.tblMWSITEM.MATERIALDESC,dbo.tblCOA.ACCOUNTNAME,dbo.tblMWSITEM.UNIT," & _
                    "dbo.tblMWSITEM.QTY FROM dbo.tblMWSDESC INNER JOIN dbo.tblMWSITEM ON dbo.tblMWSDESC.MWSDESCNO = dbo.tblMWSITEM.MWSDESCNO INNER JOIN dbo.tblCOA ON dbo.tblMWSITEM.ACCNO = dbo.tblCOA.ACCNO " & _
                    "where dbo.tblMWSDESC.MWSDESCNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
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
    Sub printMIS()
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
                    "dbo.tblMISDESC.REMARKS,dbo.tblMISDESC.ISSUEDBY,dbo.tblMISDESC.APPROVEDBY,dbo.tblMISDESC.RECEIVEDBY,dbo.tblMISITEM.INVTYCODE,dbo.tblMISITEM.MATERIALDESC,dbo.tblMISITEM.SERIAL," & _
                    "dbo.tblCOA.ACCOUNTNAME,dbo.tblMISITEM.UNIT,dbo.tblMISITEM.QTY FROM dbo.tblMISITEM INNER JOIN dbo.tblMISDESC ON dbo.tblMISITEM.MISNO = dbo.tblMISDESC.MISNO INNER JOIN dbo.tblCOA " & _
                    "ON dbo.tblMISITEM.ACCNO = dbo.tblCOA.ACCNO WHERE dbo.tblMISDESC.MISNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
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
                .Columns.Add("SERIAL")
                .Columns.Add("DEBITTO")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12), OleDBDR.Item(13), OleDBDR.Item(14))
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
    Sub printMRS()
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
                .CommandText = "SELECT dbo.tblMRSDESC.MRSNO,dbo.tblMRSDESC.[DATE],dbo.tblMRSDESC.POREFNO,dbo.tblMRSDESC.DR,dbo.tblMRSDESC.SUPPLIERNAME," & _
                    "dbo.tblMRSDESC.ADDRESS,dbo.tblMRSDESC.REMARKS,dbo.tblMRSDESC.RECEIVEDBY,dbo.tblMRSDESC.DELIVEREDBY,dbo.tblMRSITEM.MATERIALDESC," & _
                    "dbo.tblMRSITEM.SERIAL,dbo.tblMRSITEM.UNIT,dbo.tblMRSITEM.QUANTITY FROM dbo.tblMRSITEM INNER JOIN dbo.tblMRSDESC ON dbo.tblMRSDESC.MRSNO = dbo.tblMRSITEM.MRSNO " & _
                    "WHERE dbo.tblMRSDESC.MRSNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("MRSNO")
                .Columns.Add("DATE")
                .Columns.Add("POREFNO")
                .Columns.Add("DR")
                .Columns.Add("SUPPLIERNAME")
                .Columns.Add("ADDRESS")
                .Columns.Add("REMARKS")
                .Columns.Add("RECEIVEDBY")
                .Columns.Add("DELIVEREDBY")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("SERIAL")
                .Columns.Add("UNIT")
                .Columns.Add("QUANTITY")
            End With

            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11), OleDBDR.Item(12))
                    c = c + 1
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New materialReceivingSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub printPRS()
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
                .CommandText = "SELECT dbo.tblPRSDESC.PRSNO,dbo.tblPRSDESC.[DATE],dbo.tblPRSDESC.REMARKS,dbo.tblPRSDESC.PREPAREDBY,dbo.tblPRSDESC.APPROVEDBY," & _
                    "dbo.tblPRSDESC.REQSTATUS,dbo.tblPRSITEM.ITEMDESC,dbo.tblPRSITEM.SERIAL,dbo.tblPRSITEM.INVTYCODE,dbo.tblPRSITEM.UNIT,dbo.tblPRSITEM.QTY,dbo.tblPRSITEM.STOCKSONHAND" & _
                    " FROM dbo.tblPRSDESC INNER JOIN dbo.tblPRSITEM ON dbo.tblPRSDESC.PRSNO = dbo.tblPRSITEM.PRSNO WHERE dbo.tblPRSDESC.PRSNO = '" & dgw.CurrentRow.Cells(1).Value & "'"
            End With
            OleDBDR = OleDBC.ExecuteReader
            Dim dt As New DataTable
            With dt
                .Columns.Add("PRSNO")
                .Columns.Add("DATE")
                .Columns.Add("REMARKS")
                .Columns.Add("PREPAREDBY")
                .Columns.Add("APPROVEDBY")
                .Columns.Add("REQSTATUS")
                .Columns.Add("MATERIALDESC")
                .Columns.Add("MODEL")
                .Columns.Add("INVTYCODE")
                .Columns.Add("UNIT")
                .Columns.Add("QTY")
                .Columns.Add("STOCKSONHAND")
            End With
            If OleDBDR.HasRows Then
                While OleDBDR.Read
                    dt.Rows.Add(OleDBDR.Item(0), Format(OleDBDR.Item(1), "MM/dd/yyyy"), OleDBDR.Item(2), OleDBDR.Item(3), OleDBDR.Item(4), OleDBDR.Item(5), OleDBDR.Item(6),
                                 OleDBDR.Item(7), OleDBDR.Item(8), OleDBDR.Item(9), OleDBDR.Item(10), OleDBDR.Item(11))
                End While
            End If
            Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptDoc = New purchaseRequestSlip
            rptDoc.SetDataSource(dt)
            reportViewer.CrystalReportViewer1.ReportSource = rptDoc
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub printPO()
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
            reportViewer.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTransactionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgw.ClearSelection()
    End Sub

    Private Sub VIEWREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWREPORTToolStripMenuItem.Click
        printMRS()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        printMWS()
    
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        printMIS()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        printPRS()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        printPO()
    End Sub

   

    Private Sub dgw_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgw.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgw.CurrentCell = dgw(e.ColumnIndex, e.RowIndex)
                If MODE = "MWS" Then
                    dgw.ContextMenuStrip = CMSMWS
                ElseIf MODE = "MIS" Then
                    dgw.ContextMenuStrip = CMSMIS
                ElseIf MODE = "MRS" Then
                    dgw.ContextMenuStrip = CMSMRS
                ElseIf MODE = "PRS" Then
                    dgw.ContextMenuStrip = CMSPRS
                ElseIf MODE = "PO" Then
                    dgw.ContextMenuStrip = CMSPO
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub CMSMWS_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMSMWS.Closed
        dgw.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub CMSMIS_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMSMIS.Closed
        dgw.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub CMSMRS_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMSMRS.Closed
        dgw.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub CMSPRS_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMSPRS.Closed
        dgw.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub CMSPO_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles CMSPO.Closed
        dgw.ContextMenuStrip = ContextMenuStrip1
    End Sub

End Class