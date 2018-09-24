Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module modconn
    Public strSQL As String
    Public OleDBC As New OleDbCommand
    Public OleDBDR As OleDbDataReader
    Public conn As New System.Data.OleDb.OleDbConnection
    Public strConnString As String
    Public userid As String
    Public usertype As String
    Public da As OleDbDataAdapter
    Public ds As DataSet


   
    Public Sub ConnectDatabase()
        If frmJob.cmbDatabase.Text = "Packaging" Then
            strConnString = "PROVIDER=microsoft.ACE.OleDb.12.0;Data Source=Packaging.accdb"
            conn.ConnectionString = strConnString
            conn.Open()
        ElseIf frmJob.cmbDatabase.Text = "Logistic" Then
            strConnString = "PROVIDER=microsoft.ACE.OleDb.12.0;Data Source=Logistic.accdb"
            conn.ConnectionString = strConnString
            conn.Open()
        ElseIf frmJob.cmbDatabase.Text = "Prawn" Then
            strConnString = "PROVIDER=microsoft.ACE.OleDb.12.0;Data Source=Prawn.accdb"
            conn.ConnectionString = strConnString
            conn.Open()
        End If

    End Sub
End Module
