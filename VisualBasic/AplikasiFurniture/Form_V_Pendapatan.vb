Public Class Form_V_Pendapatan
    Dim tbldatapenjualan As DataTable

    Dim proses As New clskoneksi
    Dim sql As String
    Dim file_laporan As String
    Dim kode_estimasi As String
    Sub koneksi_laporan()
        Dim strreportpath As String = Application.StartupPath & "\" & file_laporan & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("File Laporan Tidak Ditemukan !!!" & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(tbldatapenjualan)
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ReportSource = rptdocument
    End Sub


    Private Sub Form_CR_Estimasi_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Form_Menu.Enabled = True
        'Form_Menu.Focus()
    End Sub

   
    Private Sub Form_V_Pendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        file_laporan = Label2.Text
        'sql += "SELECT Sum([tbl_barang]![harga_jual]*[tbl_penjualandetail]![qty]) AS Total_Penjualan, [tbl_barang]![harga_beli]*[tbl_pembeliandetail]![qty] AS Total_Pembelian, Sum([tbl_penggajian]![gaji_pokok]) AS Gaji, tbl_penjualan.tanggal_transaksi "
        'sql += " FROM (tbl_pembelian INNER JOIN (((tbl_penjualan RIGHT JOIN tbl_penjualandetail ON tbl_penjualan.kode_transjual = tbl_penjualandetail.kode_transjual) INNER JOIN tbl_barang ON tbl_penjualandetail.kode_barang = tbl_barang.kode_barang) INNER JOIN tbl_pembeliandetail ON tbl_barang.kode_barang = tbl_pembeliandetail.kode_barang) ON tbl_pembelian.kode_transbeli = tbl_pembeliandetail.kode_transbeli) LEFT JOIN tbl_penggajian ON YEAR(tbl_penjualan.tanggal_transaksi) = YEAR(tbl_penggajian.tgl_input) "
        'sql += " GROUP BY [tbl_barang]![harga_beli]*[tbl_pembeliandetail]![qty], tbl_penjualan.tanggal_transaksi "

        'sql = "SELECT * "
        'sql += " FROM query_pendapatan  "
        'sql += Label1.Text
        ' sql += " ORDER BY kode_transbeli DESC"

        tbldatapenjualan = proses.ExecuteQuery(Form_S_Keuntungan.sql)
        Call koneksi_laporan()
    End Sub
End Class