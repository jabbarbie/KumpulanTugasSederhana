Public Class Form_V_DataSupplier
    Dim tbldatasupplier As DataTable

    Dim proses As New clskoneksi
    Dim sql As String
    Dim file_laporan As String = "CR_DataSupplier"
    Dim kode_estimasi As String
    Sub koneksi_laporan()
        Dim strreportpath As String = Application.StartupPath & "\" & file_laporan & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            Throw (New Exception("File Laporan Tidak Ditemukan !!!" & vbCrLf & strreportpath))
        End If
        Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdocument.Load(strreportpath)
        rptdocument.SetDataSource(tbldatasupplier)
        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ReportSource = rptdocument
    End Sub


    Private Sub Form_CR_Estimasi_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'Form_Menu.Enabled = True
        'Form_Menu.Focus()
    End Sub

    Private Sub Form_V_Datasupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'file_laporan = Label2.Text
        'sql = "SELECT tbl_supplier.*,tbl_supplier.nama "
        'sql += " FROM tbl_supplier INNER JOIN tbl_supplier ON tbl_supplier.kode_supplier = tbl_supplier.kode_supplier "
        sql = "SELECT * "
        sql += " FROM tbl_supplier  "
        'MsgBox(sql)
        'sql += Label1.Text
        sql += " ORDER BY kode_supplier DESC"
        tbldatasupplier = proses.ExecuteQuery(sql)
        Call koneksi_laporan()
    End Sub
End Class