Public Class Form_Karyawan
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datakaryawan As DataTable
    Sub Kode_Otomatis()
        sql = "SELECT nik FROM tbl_karyawan ORDER BY nik DESC"
        datakaryawan = proses.ExecuteQuery(sql)
        If datakaryawan.Rows.Count = 0 Then
            txt_nik.Text = "NIK-0001"
        Else
            txt_nik.Text = Val(Microsoft.VisualBasic.Right(datakaryawan.Rows(0).Item("nik").ToString, 3)) + 1
            If Len(txt_nik.Text) = 1 Then
                txt_nik.Text = "NIK-000" & txt_nik.Text & ""
            ElseIf Len(txt_nik.Text) = 2 Then
                txt_nik.Text = "NIK-00" & txt_nik.Text & ""
            ElseIf Len(txt_nik.Text) = 3 Then
                txt_nik.Text = "NIK-0" & txt_nik.Text & ""
            End If
        End If
    End Sub
    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()
        Call tidak_aktif()

        txt_pencarian.Focus()
        b_keluar.Enabled = True
        b_tambah.Enabled = True
        b_edit.Enabled = True
        b_hapus.Enabled = True
    End Sub
    Sub bersih()
        txt_nik.Clear()
        txt_nama.Clear()
        txt_notelp.Clear()
        txt_alamat.Clear()
        txt_notelp.Clear()
        cb_jabatan.SelectedIndex = -1
        cb_jk.SelectedIndex = -1
        txt_tempatlahir.Clear()
        tgl_lahir.Value = Now()

        txt_pencarian.Clear()

        sql = Nothing
        b_tambah.Text = "&Tambah"
        b_edit.Text = "&Edit"
    End Sub
    Sub aktif()

        txt_nama.Enabled = True
        txt_notelp.Enabled = True
        txt_alamat.Enabled = True
        txt_notelp.Enabled = True
        cb_jabatan.Enabled = True
        ' txt_pencarian.Enabled = True
        cb_jk.Enabled = True
        txt_tempatlahir.Enabled = True
        tgl_lahir.Enabled = True

        b_tambah.Enabled = True
        b_edit.Enabled = True
        b_hapus.Enabled = True
        b_batal.Enabled = True
        b_keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_nik.Enabled = False
        txt_nama.Enabled = False
        txt_notelp.Enabled = False
        txt_alamat.Enabled = False
        txt_notelp.Enabled = False
        cb_jabatan.Enabled = False
        'txt_pencarian.Enabled = False
        cb_jk.Enabled = False
        txt_tempatlahir.Enabled = False
        tgl_lahir.Enabled = False

        b_tambah.Enabled = False
        b_edit.Enabled = False
        b_hapus.Enabled = False
        b_batal.Enabled = False
        b_keluar.Enabled = False
    End Sub
    Sub data_karyawan(Optional ByVal kode As String = "Semuanya")
        If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
            sql = "SELECT * FROM tbl_karyawan ORDER BY nama_karyawan ASC"
        Else
            sql = "SELECT * FROM tbl_karyawan WHERE nik LIKE '" & kode & "' OR nama_karyawan LIKE '" & kode & "' OR alamat LIKE '" & kode & "' ORDER BY nama_karyawan ASC"
        End If
        datakaryawan = proses.ExecuteQuery(sql)
        DG_Karyawan.DataSource = datakaryawan
        With DG_Karyawan
            .Columns("nama_karyawan").Width = "150"
        End With

    End Sub
    Private Sub Form_Datakaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_karyawan()
    End Sub

    Private Sub b_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_tambah.Click
        If (b_tambah.Text = "&Tambah") Then
            ' Koding Tambah - Ketika nama button tambah namanya tambah :v
            Call aktif()
            Call Kode_Otomatis()

            b_edit.Enabled = False
            b_hapus.Enabled = False
            b_tambah.Text = "&Simpan"

            txt_nama.Focus()

        Else
            ' Koding Simpan Tambah
            If (txt_nik.Text = "") Or (txt_nama.Text = "") Or (txt_tempatlahir.Text = "") Or (txt_alamat.Text = "") Or (txt_notelp.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
            Try
                sql = "INSERT INTO tbl_karyawan (nik, nama_karyawan,jenis_kelamin, tempat_lahir, tanggal_lahir, jabatan, alamat,notelp) VALUES "
                sql += "('" & txt_nik.Text & "', '" & txt_nama.Text & "','" & cb_jk.Text & "','" & txt_tempatlahir.Text & "','" & tgl_lahir.Text & "','" & cb_jabatan.Text & "', '" & txt_alamat.Text & "', '" & txt_notelp.Text & "')"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            Call normal()
            Call Kode_Otomatis()

            Call data_karyawan()
            proses.CloseConn()
        End If
    End Sub

    Private Sub b_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_batal.Click
        Call normal()

    End Sub

    Private Sub b_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_hapus.Click
        Dim pesan As DialogResult
        pesan = MessageBox.Show("Apakah benar anda akan menghapus Data karyawan " & DG_Karyawan.SelectedCells(0).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)

        If pesan = Windows.Forms.DialogResult.OK Then
            Try
                sql = "DELETE FROM tbl_karyawan WHERE nik = '" & DG_Karyawan.SelectedCells(0).Value & "'"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Menghapus Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.OkOnly, "Pesan")
            Call data_karyawan()

        End If
    End Sub
    Sub DG_Edit()
        Try
            With DG_Karyawan
                txt_nik.Text = .SelectedCells(0).Value.ToString
                txt_nama.Text = .SelectedCells(1).Value.ToString
                cb_jk.Text = .SelectedCells(3).Value.ToString
                txt_tempatlahir.Text = .SelectedCells(4).Value.ToString
                tgl_lahir.Value = .SelectedCells(5).Value.ToString

                cb_jabatan.Text = .SelectedCells(6).Value.ToString
                txt_alamat.Text = .SelectedCells(2).Value.ToString
                txt_notelp.Text = .SelectedCells(7).Value.ToString
            End With
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
    End Sub

    Private Sub DG_karyawan_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Karyawan.CellDoubleClick
        Call aktif()
        Call DG_Edit()

        b_tambah.Enabled = False
        b_hapus.Enabled = False
        b_edit.Text = "&Simpan"
        txt_nik.Enabled = False
    End Sub

    Private Sub b_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit.Click
        If (b_edit.Text = "&Edit") Then
            Call aktif()
            Call DG_Edit()

            txt_nik.Enabled = False
            b_tambah.Enabled = False
            b_hapus.Enabled = False
            b_edit.Text = "&Simpan"
        Else
            If (txt_nik.Text = "" Or txt_nama.Text = "" Or txt_alamat.Text = "" Or txt_tempatlahir.Text = "") Then MsgBox("Data belum lengkap", MsgBoxStyle.Information, "Pesan") : Exit Sub
            Try
                sql = "UPDATE tbl_karyawan SET "
                sql += "nama_karyawan='" & txt_nama.Text & "', "
                sql += "jabatan='" & cb_jabatan.Text & "', "
                sql += "alamat='" & txt_alamat.Text & "', "
                sql += "jenis_kelamin='" & cb_jk.Text & "', "
                sql += "tempat_lahir='" & txt_tempatlahir.Text & "', "
                sql += "tanggal_lahir='" & tgl_lahir.Text & "', "

                sql += "notelp='" & txt_notelp.Text & "' "

                sql += " WHERE nik = '" & txt_nik.Text & "' "
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Edit Gagal " & sql, MsgBoxStyle.Critical, "Peringantan")

                Exit Sub
            End Try
            ' MsgBox("Data karyawan berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            MsgBox("Data Berhasil di Ubah", MsgBoxStyle.OkOnly, "Pesan")

            Call normal()
            Call data_karyawan()

            proses.CloseConn()
        End If
    End Sub

    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_karyawan(txt_pencarian.Text)
        End If
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()
        Form_Menu.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

 
    Private Sub b_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cari.Click
        Call data_karyawan(txt_pencarian.Text)
    End Sub
End Class