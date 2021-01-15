Imports System.Data.OleDb
Public Class clskoneksi
    Protected tabel = New DataTable
    Protected sql As String
    Protected database As New OleDbConnection
    Public Cmd As New OleDbCommand
    Protected Da As New OleDbDataAdapter
    Protected Ds As New DataSet
    Protected Dt As New DataTable
    Public Function OpenConn() As Boolean
        MataUang()
        Try
            database = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.DBFurniture & "")
            database.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            Exit Function
        End Try
    End Function
    Public Sub CloseConn()
        If Not IsNothing(database) Then
            database.Close()
            database = Nothing
        End If
    End Sub
    Public Function ExecuteQuery(ByVal Query As String) As Data.DataTable
        OpenConn()
        Cmd = New Data.OleDb.OleDbCommand(Query, database)
        Da = New Data.OleDb.OleDbDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
    End Function
    Public Sub ExecuteNonQuery(ByVal Query As String)
        OpenConn()
        Cmd = New Data.OleDb.OleDbCommand(Query, database)
        Da = New Data.OleDb.OleDbDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Sub
    Public Sub Kode_Otomatis(ByVal Table As String, ByVal Nama As String, ByVal PKnya As String)
        OpenConn()
        sql = "SELECT " & PKnya & " FROM " & Table & " F"
    End Sub
    Public Sub MataUang()
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("id-ID")
    End Sub
End Class
