Public Class Form_V_NotaPenjualan
    Dim tblnota As DataTable

    Dim proses As New clskoneksi
    Dim sql As String
    Dim file_laporan As String = "CR_NotaPenjualan"
    Dim kode_estimasi As String
    Sub koneksi_laporan()
        Dim strreportpath As String = Application.StartupPath & "\" & file_laporan & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("File Laporan Tidak Ditemukan !!!" & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocument.Load(strreportpath)
        'MsgBox("Total Field " & tblnota.Rows.Count)
        rptdocument.SetDataSource(tblnota)
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ReportSource = rptdocument
    End Sub


    Private Sub Form_CR_Estimasi_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Form_Menu.Enabled = True
        'Form_Menu.Focus()
    End Sub

    Private Sub Form_V_nota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sql = "SELECT tbl_barang.*,tbl_supplier.nama "
        'sql += " FROM tbl_barang INNER JOIN tbl_supplier ON tbl_barang.kode_supplier = tbl_supplier.kode_supplier "
        sql = "SELECT * "
        sql += " FROM query_laporanpenjualan "
        'sql = "SELECT tbl_penjualan.kode_transjual, tbl_penjualan.tanggal_transaksi, tbl_konsumen.nama, tbl_konsumen.notelp, tbl_konsumen.alamat, tbl_barang.kode_barang, tbl_barang.nama, tbl_barang.harga_jual, tbl_penjualandetail.qty, [tbl_barang]![harga_jual]*[tbl_penjualandetail]![qty] AS SubTotal, tbl_penjualan.dibayar, tbl_karyawan.nama "
        'sql += " FROM ((((tbl_penjualan INNER JOIN tbl_penjualandetail ON tbl_penjualan.kode_transjual = tbl_penjualandetail.kode_transjual) INNER JOIN tbl_barang ON tbl_penjualandetail.kode_barang = tbl_barang.kode_barang) INNER JOIN tbl_pengguna ON tbl_penjualan.username = tbl_pengguna.username) INNER JOIN tbl_karyawan ON tbl_pengguna.nik = tbl_karyawan.nik) INNER JOIN tbl_konsumen ON tbl_penjualan.kode_konsumen = tbl_konsumen.kode_konsumen "
        ' MsgBox(sql)
        sql += Label1.Text
        'MsgBox(sql)
        tblnota = proses.ExecuteQuery(sql)
        'MsgBox("Totalnya " & tblnota.Rows.Count & sql)
        Call koneksi_laporan()
    End Sub
End Class