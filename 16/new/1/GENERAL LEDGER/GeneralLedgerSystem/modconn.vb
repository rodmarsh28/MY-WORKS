Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module modconn
    Public strSQL As String
    Public OleDBC As New SqlCommand
    Public OleDBDR As SqlDataReader
    Public da As New SqlDataAdapter
    Public ds As DataSet
    Public conn As New SqlConnection
    Public strConnString As String
    Public Sub ConnectDatabase()
        'strConnString = "Persist Security Info=False;Integrated Security=true;Initial Catalog=generalLedgerDB;server=(local)"
        strConnString = "Data Source=" & My.Settings.mServer & ";" & _
                        "Initial Catalog=" & My.Settings.mDBname & ";" & _
                        "User ID=" & My.Settings.mUserDB & ";" & _
                        "Password=" & My.Settings.mPassDB
        conn.ConnectionString = strConnString
        conn.Open()
    End Sub

End Module
