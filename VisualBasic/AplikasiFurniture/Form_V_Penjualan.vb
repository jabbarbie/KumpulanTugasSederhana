Public Class Form_V_Penjualan
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

    Private Sub Form_V_Datapenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        file_laporan = Label2.Text
        'sql = "SELECT tbl_penjualan.*,tbl_penjualan.nama "
        'sql += " FROM tbl_penjualan INNER JOIN tbl_penjualan ON tbl_penjualan.kode_penjualan = tbl_penjualan.kode_penjualan "
        sql = "SELECT * "
        sql += " FROM query_penjualanlengkap  "
        sql += Label1.Text
        ' sql += " ORDER BY kode_transbeli DESC"
        'MsgBox(sql)
        tbldatapenjualan = proses.ExecuteQuery(sql)
        Call koneksi_laporan()
    End Sub
End Class