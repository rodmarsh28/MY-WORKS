﻿Imports Microsoft.Reporting.WinForms
Public Class frmReport

    Dim subReportPassing As Dictionary(Of String, String)

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      
    End Sub

    Friend Sub MultiDbSetReport(ByVal mySql As Dictionary(Of String, String), ByVal rptUrl As String, _
                                Optional ByVal addPara As Dictionary(Of String, String) = Nothing, Optional ByVal hasUser As Boolean = True, _
                                Optional ByVal subReport As Dictionary(Of String, String) = Nothing)
        Dim dsName As String, ds As DataSet, cmd As String
        If Not subReport Is Nothing Then subReportPassing = subReport

        With rv_display
            .ProcessingMode = ProcessingMode.Local
            .LocalReport.ReportPath = rptUrl
            .LocalReport.DataSources.Clear()

            For Each el In mySql
                dsName = el.Key : cmd = el.Value
                Console.WriteLine(String.Format("{0}: {1}", dsName, cmd))

                ds = LoadSQL(cmd, dsName)
                Dim rDS As New ReportDataSource
                rDS = New ReportDataSource(dsName, ds.Tables(dsName))
                .LocalReport.DataSources.Add(rDS)
            Next

            If hasUser Then
                Dim myPara As New ReportParameter
                myPara.Name = "txtUsername"
                If SystemUser.UserName Is Nothing Then SystemUser.UserName = "bl@deG@mer"
                myPara.Values.Add(SystemUser.USERNAME)
                rv_display.LocalReport.SetParameters(New ReportParameter() {myPara})
            End If

            If Not addPara Is Nothing Then
                For Each nPara In addPara
                    Dim tmpPara As New ReportParameter
                    tmpPara.Name = nPara.Key
                    tmpPara.Values.Add(nPara.Value)
                    .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                Next
            End If

            If Not subReport Is Nothing Then
                AddHandler .LocalReport.SubreportProcessing, AddressOf SubReportLoader
            End If

            .RefreshReport()
        End With
    End Sub

    Private Sub SubReportLoader(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim dsName As String, ds As DataSet

        For Each el In subReportPassing
            dsName = el.Key
            ds = LoadSQL(el.Value, dsName)
            e.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))
        Next
    End Sub

    Friend Sub ReportInit(ByVal mySql As String, ByVal dsName As String, ByVal rptUrl As String, _
                          Optional ByVal addPara As Dictionary(Of String, String) = Nothing, Optional ByVal hasUser As Boolean = True)
        Try
            Dim ds As DataSet = LoadSQL(mySql, dsName)
            If ds Is Nothing Then Exit Sub

            Console.WriteLine("SQL: " & mySql)
            Console.WriteLine("Max: " & ds.Tables(dsName).Rows.Count)
            Console.WriteLine("Report is Existing? " & System.IO.File.Exists(Application.StartupPath & "\" & rptUrl))
            With rv_display
                .ProcessingMode = ProcessingMode.Local
                .LocalReport.ReportPath = rptUrl
                .LocalReport.DataSources.Clear()

                .LocalReport.DataSources.Add(New ReportDataSource(dsName, ds.Tables(dsName)))

                If hasUser Then
                    Dim myPara As New ReportParameter
                    myPara.Name = "txtUsername"
                    If SystemUser.UserName Is Nothing Then SystemUser.UserName = "bl@deG@mer"
                    myPara.Values.Add(SystemUser.USERNAME)
                    .LocalReport.SetParameters(New ReportParameter() {myPara})
                End If

                If Not addPara Is Nothing Then
                    For Each nPara In addPara
                        Dim tmpPara As New ReportParameter
                        tmpPara.Name = nPara.Key
                        tmpPara.Values.Add(nPara.Value)
                        .LocalReport.SetParameters(New ReportParameter() {tmpPara})
                    Next
                End If

                .RefreshReport()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "REPORT GENERATE ERROR")
            Log_Report("REPORT - " & ex.ToString)
        End Try
    End Sub
End Class