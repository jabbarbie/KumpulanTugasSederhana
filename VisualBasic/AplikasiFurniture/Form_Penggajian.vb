Public Class Form_Penggajian
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datakaryawan As DataTable

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
        txt_nik.Clear()
        txt_namakaryawan.Clear()
        txt_jabatan.Clear()
        txt_pencarian.Clear()
        txt_gajipokok.Clear()

        sql = Nothing
        B_Tambah.Text = "&Tambah"
        B_Edit.Text = "&Edit"
    End Sub
    Sub aktif()
        txt_gajipokok.Enabled = True
        tgl_input.Enabled = True
        txt_nik.Enabled = True
        B_Tambah.Enabled = True
        B_Edit.Enabled = True
        B_Hapus.Enabled = True
        B_Batal.Enabled = True
        B_Keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_gajipokok.Enabled = False
        tgl_input.Enabled = False

        B_Tambah.Enabled = False
        B_Edit.Enabled = False
        B_Hapus.Enabled = False
        B_Batal.Enabled = False
        B_Keluar.Enabled = False
    End Sub
    Sub data_penggajian(Optional ByVal kode As String = "Semuanya")
        If kode = "Semuanya" Then
            sql = "SELECT p.kode_penggajian, k.nik, k.nama_karyawan, k.jabatan, p.tgl_input, p.gaji_pokok FROM tbl_penggajian p INNER JOIN tbl_karyawan k ON p.nik = k.nik "
        Else
            sql = "SELECT p.kode_penggajian, k.nik, k.nama_karyawan, k.jabatan, p.tgl_input, p.gaji_pokok FROM tbl_penggajian p INNER JOIN tbl_karyawan k ON p.nik = k.nik WHERE k.nik = '" & txt_nik.Text & "' "
        End If
        'sql = "SELECT * FROM tbl_karyawan k INNER JOIN tbl_penggajian p ON k.nik = p.nik ORDER BY tanggal_transaksi ASC"
        datakaryawan = proses.ExecuteQuery(sql)
        'If datakaryawan.Rows.Count > 0 Then
        DG_Penggajijan.DataSource = datakaryawan
        With DG_Penggajijan
            .Columns(0).Visible = False
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).Width = 180
            .Columns(5).Width = 110
            .Columns(5).DefaultCellStyle.Format = "N0"

        End With
        'End If

    End Sub

    Private Sub Form_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_penggajian()
    End Sub

    Private Sub B_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Tambah.Click
        If (B_Tambah.Text = "&Tambah") Then
            ' Koding Tambah - Ketika nama button tambah namanya tambah :v
            Call aktif()
            B_Edit.Enabled = False
            B_Hapus.Enabled = False
            B_Tambah.Text = "&Simpan"

            txt_nik.Focus()
        Else
            If (txt_nik.Text = "") Or (tgl_input.Text = "") Or (txt_gajipokok.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
            ' Koding Simpan Tambah
            If (Val(txt_gajipokok.Text) <= 0) Then
                MsgBox("Nominal Tidak Valid", MsgBoxStyle.Critical, "Pesan")
                Exit Sub
            End If
            Try
                sql = "INSERT INTO tbl_penggajian (nik , tgl_input, gaji_pokok) VALUES "
                sql += "('" & txt_nik.Text & "', '" & tgl_input.Text & "', " & txt_gajipokok.Text & ")"
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
            txt_namakaryawan.Focus()
            Call bersih()
            Call data_penggajian()
            B_Tambah.Text = "&Tambah"
            Call normal()
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
        If (DG_Penggajijan.RowCount = 1) Then MsgBox("Tidak ada data barang yang terpilih", MsgBoxStyle.OkOnly, "Pesan") : Exit Sub
        ' Cek apakah ada data barang yang sedang digunakan 
        pesan = MessageBox.Show("Apakah benar anda akan menghapus Data Pengganjian " & DG_Penggajijan.SelectedCells(1).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)

        If pesan = Windows.Forms.DialogResult.OK Then
            Try
                sql = "DELETE FROM tbl_penggajian WHERE kode_penggajian = " & DG_Penggajijan.SelectedCells(0).Value & ""
                MsgBox(sql)
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Menghapus Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.OkOnly, "Pesan")
        End If
    End Sub

    Sub DG_Edit()
        Try
            With DG_Penggajijan
                txt_nik.Text = .SelectedCells(1).Value.ToString
                Call cari_datakaryawan()
                txt_gajipokok.Text = .SelectedCells(5).Value.ToString
                tgl_input.Value = .SelectedCells(4).Value.ToString
            End With
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
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
            Try
                sql = "UPDATE tbl_penggajian SET "
                sql += "nik='" & txt_namakaryawan.Text & "', "
                'sql += "jenis='" & txt_jenis.Text & "', "
                sql += "tgl_input=" & txt_jabatan.Text & ", "
                'sql += "harga_jual=" & txt_hargajual.Text & ", "
                'sql += "stok=" & txt_stok.Text & " ,"
                sql += "gaji_pokok=" & txt_gajipokok.Text & " "
                sql += " WHERE kode_penggajian = " & DG_Penggajijan.SelectedCells(0).Value.ToString & " "
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Edit Gagal", MsgBoxStyle.Critical, "Peringantan")
                Exit Sub
            End Try
            ' MsgBox("Data barang berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            MsgBox("Data Berhasil di Edit", MsgBoxStyle.OkOnly, "Pesan")
            Call normal()
            Call data_penggajian()
            proses.CloseConn()
        End If
    End Sub

    Private Sub B_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Batal.Click
        Call normal()
    End Sub
    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_penggajian(txt_pencarian.Text)
        End If
    End Sub

    Sub cari_datakaryawan()
        sql = "SELECT * FROM tbl_karyawan WHERE nik = '" & txt_nik.Text & "' "
        datakaryawan = proses.ExecuteQuery(sql)
        If (datakaryawan.Rows.Count > 0) Then
            With datakaryawan.Rows(0)
                txt_namakaryawan.Text = .Item("nama_karyawan").ToString
                txt_jabatan.Text = .Item("jabatan").ToString
            End With
            Call data_penggajian(txt_nik.Text)
            txt_gajipokok.Focus()
        Else
            MsgBox("Data Karyawan tidak ditemukan", MsgBoxStyle.Information, "Pesan")
        End If
    End Sub
    Private Sub txt_nik_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nik.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cari_datakaryawan()
        End If
    End Sub

    Private Sub DG_Penggajijan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Penggajijan.CellClick
        Call aktif()
        Call DG_Edit()

        B_Tambah.Enabled = False
        B_Hapus.Enabled = False
        B_Edit.Text = "&Simpan"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call cari_datakaryawan()
    End Sub
End Class
