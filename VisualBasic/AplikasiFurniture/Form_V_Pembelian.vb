﻿Public Class Form_V_Pembelian
    Dim tbldataPembelian As DataTable

    Dim proses As New clskoneksi
    Dim sql As String
    Dim file_laporan As String = "CR_Pembelian"
    Dim kode_estimasi As String
    Sub koneksi_laporan()
        Dim strreportpath As String = Application.StartupPath & "\" & file_laporan & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("File Laporan Tidak Ditemukan !!!" & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(tbldataPembelian)
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ReportSource = rptdocument
    End Sub


    Private Sub Form_CR_Estimasi_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Form_Menu.Enabled = True
        'Form_Menu.Focus()
    End Sub

    Private Sub Form_V_DataPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        file_laporan = Label2.Text
        'sql = "SELECT tbl_Pembelian.*,tbl_Pembelian.nama "
        'sql += " FROM tbl_Pembelian INNER JOIN tbl_Pembelian ON tbl_Pembelian.kode_Pembelian = tbl_Pembelian.kode_Pembelian "
        sql = "SELECT * "
        sql += " FROM query_pembelianlengkap  "
        sql += Label1.Text
        'MsgBox(sql)
        'sql += " ORDER BY kode_Pembelian DESC"
        tbldataPembelian = proses.ExecuteQuery(sql)
        Call koneksi_laporan()
    End Sub
End Class