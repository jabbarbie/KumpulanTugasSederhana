Public Class Form_S_Keuntungan
    Public sql As String
    Dim proses As New clskoneksi
    Dim tblkeuntungan As DataTable
    Sub bersih()
        NumTahun1.Value = Year(Now)
        NumTahun2.Value = Year(Now)

    End Sub
    Sub tidak_aktif()
        NumTahun1.Enabled = False
        cb_bulan.Enabled = False
        NumTahun2.Enabled = False
    End Sub
    Sub cari_total()
        Dim tgl As String
        Dim hasilpend As Integer

        If (R_PerPeriode.Checked = True Or R_PerTahun.Checked = True) Then
            ' [tbl_barang]![harga_jual]*[tbl_penjualandetail]![qty]
            sql = "SELECT SUM(SubTotal) AS totalpenjualan FROM query_penjualan "
            If (R_PerTahun.Checked = True) Then
                sql += "WHERE YEAR(tanggal_transaksi) = " & NumTahun2.Value
            Else
                sql += "WHERE (MONTH(tanggal_transaksi) = " & cb_bulan.Text & ") AND YEAR(tanggal_transaksi) = " & NumTahun1.Value
            End If
            tblkeuntungan = proses.ExecuteQuery(sql)
            Label1.Text = Val(tblkeuntungan.Rows(0).Item("totalpenjualan").ToString)
            txt_penjualan.Text = Format(Val(Label1.Text.ToString), " ###,##")

            sql = "SELECT SUM(SubTotal) AS totalpembelian FROM query_pembelianlengkap "
            If (R_PerTahun.Checked = True) Then
                sql += "WHERE YEAR(tanggal_transaksi) = " & NumTahun2.Value
            Else
                sql += "WHERE (MONTH(tanggal_transaksi) = " & cb_bulan.Text & ") AND YEAR(tanggal_transaksi) = " & NumTahun1.Value
            End If
            tblkeuntungan = proses.ExecuteQuery(sql)
            Label2.Text = Val(tblkeuntungan.Rows(0).Item("totalpembelian").ToString)
            txt_pembelian.Text = Format(Val(Label2.Text.ToString), " ###,##")

            sql = "SELECT SUM(gaji_pokok) AS totalgaji FROM query_penggajian "
            If (R_PerTahun.Checked = True) Then
                sql += "WHERE YEAR(tgl_input) = " & NumTahun2.Value
            Else
                sql += "WHERE (MONTH(tgl_input) = " & cb_bulan.Text & ") AND YEAR(tgl_input) = " & NumTahun1.Value
            End If
            tblkeuntungan = proses.ExecuteQuery(sql)
            Label3.Text = Val(tblkeuntungan.Rows(0).Item("totalgaji").ToString)
            txt_gaji.Text = Format(Val(Label3.Text.ToString), " ###,##")
            hasilpend = Val(Label1.Text) - Val(Label2.Text) - Val(Label3.Text)

            txt_pendapatan.Text = Format(hasilpend, " ###,##")

            tgl = "01/" & cb_bulan.Text & "/2016"
            sql = "SELECT " & Val(Label1.Text) & " AS Total_Penjualan, "
            sql += Val(Label2.Text) & " AS Total_Pembelian, "
            sql += Val(Label3.Text) & " AS Gaji, "
            sql += "#" & tgl & "#" & " AS tanggal_transaksi "

            tblkeuntungan = proses.ExecuteQuery(sql)
        End If
    End Sub
    Sub cek_radio()
        Call tidak_aktif()
        If (R_PerPeriode.Checked = True) Then
            cb_bulan.Enabled = True
            NumTahun1.Enabled = True
        ElseIf (R_PerTahun.Checked = True) Then
            NumTahun2.Enabled = True
        End If
    End Sub
    Private Sub Form_LaporanPemasukanCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
        Call tidak_aktif()
        Call cek_radio()
    End Sub

    Private Sub b_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cetak.Click
        If txt_pendapatan.Text = "" Then MsgBox("Penapatan Kosong", MsgBoxStyle.Exclamation, "Pesan") : Exit Sub
        If (R_PerPeriode.Checked = True) Then
            'Form_V_Pendapatan.Label1.Text = "WHERE MONTH(tanggal_transaksi) = " & cb_bulan.Text & ""
            Form_V_Pendapatan.Label2.Text = "CR_RugiLaba_PerPeriode"
        ElseIf (R_PerTahun.Checked = True) Then
            If NumTahun2.Value <= 2010 Then
                MsgBox("Tahun tidak valid.. !", MsgBoxStyle.Critical, "Pesan")
                Exit Sub
            Else
                Form_V_Pendapatan.Label2.Text = "CR_RugiLaba_Pertahun"
            End If
            End If

        Form_V_Pendapatan.ShowDialog()
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Me.Close()
    End Sub

    Private Sub R_PerPeriode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_PerPeriode.CheckedChanged
        Call cek_radio()
    End Sub

    Private Sub R_PerTahun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_PerTahun.CheckedChanged
        Call cek_radio()
        Call cari_total()
    End Sub

    Private Sub R_Semua_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call cek_radio()
    End Sub

    Private Sub cb_bulan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_bulan.SelectedIndexChanged
        Call cari_total()
    End Sub

    Private Sub NumTahun2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumTahun2.ValueChanged
        Call cari_total()
    End Sub

    Private Sub NumTahun1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumTahun1.ValueChanged
        Call cari_total()
    End Sub
End Class