Public Class Form_Barang
    Dim sql As String
    Dim proses As New clskoneksi
    Dim databarang As DataTable
    
    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()
        Call tidak_aktif()

        txt_pencarian.Focus()
        B_Keluar.Enabled = True
        B_Tambah.Enabled = True
        B_Edit.Enabled = True
        B_Hapus.Enabled = True
    End Sub
    Sub bersih()
        txt_kodebarang.Clear()
        txt_namabarang.Clear()
        txt_jenis.Clear()
        txt_hargabeli.Clear()
        txt_hargajual.Clear()
        txt_stok.Value = 0
        txt_pencarian.Clear()
        txt_merk.Clear()
        txt_dibeli.Clear()

        sql = Nothing
        B_Tambah.Text = "&Tambah"
        B_Edit.Text = "&Edit"
    End Sub
    Sub aktif()
        txt_namabarang.Enabled = True
        txt_jenis.Enabled = True
        txt_hargabeli.Enabled = True
        txt_hargajual.Enabled = True
        txt_stok.Enabled = True
        ' txt_pencarian.Enabled = True
        txt_merk.Enabled = True

        B_Tambah.Enabled = True
        B_Edit.Enabled = True
        B_Hapus.Enabled = True
        B_Batal.Enabled = True
        B_Keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_namabarang.Enabled = False
        txt_jenis.Enabled = False
        txt_hargabeli.Enabled = False
        txt_hargajual.Enabled = False
        txt_stok.Enabled = False
        'txt_pencarian.Enabled = False
        txt_merk.Enabled = False

        B_Tambah.Enabled = False
        B_Edit.Enabled = False
        B_Hapus.Enabled = False
        B_Batal.Enabled = False
        B_Keluar.Enabled = False
    End Sub
    Sub data_barang(Optional ByVal kode As String = "Semuanya")
        If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
            sql = "SELECT * FROM tbl_barang ORDER BY nama ASC"
        Else
            sql = "SELECT * FROM tbl_barang WHERE kode_barang LIKE '" & kode & "' OR nama LIKE '" & kode & "' ORDER BY nama ASC"
        End If
        databarang = proses.ExecuteQuery(sql)
        'If databarang.Rows.Count > 0 Then
        DG_Barang.DataSource = databarang
        With DG_Barang
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

            .Columns(3).DefaultCellStyle.Format = "N0"
            .Columns(4).DefaultCellStyle.Format = "N0"
            .Columns("nama").Width = "150"
        End With
        'End If
    End Sub
    Sub Kode_Otomatis()
        sql = "SELECT kode_barang FROM tbl_barang ORDER BY kode_barang DESC"
        databarang = proses.ExecuteQuery(sql)
        If databarang.Rows.Count = 0 Then
            txt_kodebarang.Text = "BRN-0001"
        Else
            txt_kodebarang.Text = (Microsoft.VisualBasic.Right(databarang.Rows(0).Item("kode_barang").ToString, 3)) + 1
            If Len(txt_kodebarang.Text) = 1 Then
                txt_kodebarang.Text = "BRN-000" & txt_kodebarang.Text & ""
            ElseIf Len(txt_kodebarang.Text) = 2 Then
                txt_kodebarang.Text = "BRN-00" & txt_kodebarang.Text & ""
            ElseIf Len(txt_kodebarang.Text) = 3 Then
                txt_kodebarang.Text = "BRN-0" & txt_kodebarang.Text & ""
            End If
        End If
    End Sub
    Private Sub Form_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_barang()

    End Sub

    Private Sub B_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Tambah.Click
        If (B_Tambah.Text = "&Tambah") Then
            ' Koding Tambah - Ketika nama button tambah namanya tambah :v
            Call aktif()
            B_Edit.Enabled = False
            B_Hapus.Enabled = False
            B_Tambah.Text = "&Simpan"

            Call Kode_Otomatis()
            txt_namabarang.Focus()
        Else
            ' Koding Simpan Tambah
            If (txt_namabarang.Text = "") Or (txt_jenis.Text = "") Or (txt_hargabeli.Text = "") Or (txt_hargajual.Text = "") Or (txt_merk.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
            Try
                sql = "INSERT INTO tbl_barang (kode_barang, nama, jenis, harga_beli, harga_jual, stok, merk) VALUES "
                sql += "('" & txt_kodebarang.Text & "', '" & txt_namabarang.Text & "', '" & txt_jenis.Text & "', " & Val(txt_hargabeli.Text) & ", " & Val(txt_hargajual.Text) & ", " & txt_stok.Value & ",'" & txt_merk.Text & "')"
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")

            txt_namabarang.Focus()
            Call bersih()
            Call data_barang()
            B_Tambah.Text = "&Simpan"
            Call Kode_Otomatis()

            proses.CloseConn()
        End If
    End Sub

    Private Sub B_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()
    End Sub

    Private Sub B_Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Hapus.Click
        Dim pesan As DialogResult
        If (DG_Barang.RowCount = 1) Then MsgBox("Tidak ada data barang yang terpilih", MsgBoxStyle.OkOnly, "Pesan") : Exit Sub
        ' Cek apakah ada data barang yang sedang digunakan 
        sql = "SELECT kode_barang FROM tbl_penjualandetail WHERE kode_barang = '" & DG_Barang.SelectedCells(0).Value.ToString & "'"
        databarang = proses.ExecuteQuery(sql)
        If (databarang.Rows.Count > 0) Then
            MsgBox("Data barang tidak bisa dihapus, karena terhubung dengan data transaksi", MsgBoxStyle.Exclamation, "Pesan")
            Exit Sub

        End If
        pesan = MessageBox.Show("Apakah benar anda akan menghapus Data Barang " & DG_Barang.SelectedCells(1).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)

        If pesan = Windows.Forms.DialogResult.OK Then
            Try
                sql = "DELETE FROM tbl_barang WHERE kode_barang = '" & DG_Barang.SelectedCells(0).Value & "'"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Menghapus Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.OkOnly, "Pesan")
            Call data_barang()

        End If
    End Sub

    Sub DG_Edit()
        Try
            With DG_Barang
                txt_kodebarang.Text = .SelectedCells(0).Value.ToString
                txt_namabarang.Text = .SelectedCells(1).Value.ToString
                txt_jenis.Text = .SelectedCells(2).Value.ToString
                txt_hargabeli.Text = .SelectedCells(3).Value.ToString
                txt_hargajual.Text = .SelectedCells(4).Value.ToString
                txt_stok.Value = .SelectedCells(5).Value.ToString
                txt_merk.Text = .SelectedCells(7).Value.ToString
                txt_dibeli.Text = .SelectedCells(8).Value.ToString
                End With
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
    End Sub

    Private Sub DG_Barang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Barang.CellContentClick

    End Sub

    Private Sub DG_Barang_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Barang.CellDoubleClick
        Call aktif()
        Call DG_Edit()

        B_Tambah.Enabled = False
        B_Hapus.Enabled = False
        B_Edit.Text = "&Simpan"
    End Sub

    Private Sub B_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Edit.Click
        If (B_Edit.Text = "&Edit") Then
            Call aktif()
            Call DG_Edit()

            B_Tambah.Enabled = False
            B_Hapus.Enabled = False
            B_Edit.Text = "&Simpan"
        Else
            ' Koding Simpan Tambah
            If (txt_namabarang.Text = "") Or (txt_jenis.Text = "") Or (Val(txt_hargabeli.Text) <= 0) Or (Val(txt_hargajual.Text)) Or (Val(txt_stok.Value) <= 0) Or (txt_merk.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
            Try
                sql = "UPDATE tbl_barang SET "
                sql += "nama='" & txt_namabarang.Text & "', "
                sql += "jenis='" & txt_jenis.Text & "', "
                sql += "harga_beli=" & txt_hargabeli.Text & ", "
                sql += "harga_jual=" & txt_hargajual.Text & ", "
                sql += "stok=" & txt_stok.Text & " ,"
                sql += "merk='" & txt_merk.Text & "'"
                sql += " WHERE kode_barang = '" & txt_kodebarang.Text & "' "
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Edit Gagal", MsgBoxStyle.Critical, "Peringantan")
                Exit Sub
            End Try
            ' MsgBox("Data barang berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            MsgBox("Data Berhasil di Ubah", MsgBoxStyle.OkOnly, "Pesan")
            Call normal()
            Call data_barang()
            proses.CloseConn()
        End If
    End Sub

    Private Sub B_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Batal.Click
        Call normal()
    End Sub
    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_barang(txt_pencarian.Text)
        End If
    End Sub
    Private Sub txt_hargabeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hargabeli.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = False ' Jika user menginputkan data selain angka, maka tidak ada di respon oleh sistem
    End Sub
    Private Sub txt_hargajual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_hargajual.KeyPress

        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = False ' Jika user menginputkan data selain angka, maka tidak ada di respon oleh sistem
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call data_barang(txt_pencarian.Text)
    End Sub
End Class
