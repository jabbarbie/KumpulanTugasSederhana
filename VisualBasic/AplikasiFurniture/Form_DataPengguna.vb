Public Class Form_DataPengguna
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datapengguna As DataTable

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
        txt_username.Clear()
        txt_nik.Clear()
        txt_password.Clear()
        cb_status.SelectedIndex = -1
        txt_pencarian.Clear()
        txt_nama.Clear()

        sql = Nothing
        b_tambah.Text = "&Tambah"
        b_edit.Text = "&Edit"
    End Sub
    Sub aktif()
        txt_username.Enabled = True
        txt_nik.Enabled = True
        txt_password.Enabled = True
        cb_status.Enabled = True
        ' txt_pencarian.Enabled = True

        b_tambah.Enabled = True
        b_edit.Enabled = True
        b_hapus.Enabled = True
        b_batal.Enabled = True
        b_keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_username.Enabled = False
        txt_nik.Enabled = False
        txt_password.Enabled = False
        cb_status.Enabled = False
        'txt_pencarian.Enabled = False

        b_tambah.Enabled = False
        b_edit.Enabled = False
        b_hapus.Enabled = False
        b_batal.Enabled = False
        b_keluar.Enabled = False
    End Sub
    Sub data_pengguna(Optional ByVal kode As String = "Semuanya")
        sql = "SELECT username,status FROM tbl_pengguna WHERE username = '" & Form_Menu.ToolStripStatusLabel3.Text & "'"
        datapengguna = proses.ExecuteQuery(sql)
        If (datapengguna.Rows.Count > 0) Then
            With datapengguna.Rows(0)
                If (.Item("status").ToString = "Admin") Then
                    ' Jika status admin
                    If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
                        sql = "SELECT * FROM tbl_pengguna ORDER BY username ASC"
                    Else
                        sql = "SELECT * FROM tbl_pengguna WHERE username LIKE '" & kode & "' OR nama_lengkap LIKE '" & kode & "' ORDER BY username ASC"
                    End If
                Else
                    ' Jika status user
                    sql = "SELECT * FROM tbl_pengguna WHERE username = '" & Form_Menu.ToolStripStatusLabel3.Text & "'"
                    txt_pencarian.Enabled = False
                    b_cari.Enabled = False
                End If
            End With
        Else
            MsgBox("Data Pengguna tidak ditemukan", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End If
        datapengguna = proses.ExecuteQuery(sql)
        DG_Pengguna.DataSource = datapengguna
        With DG_Pengguna
            .Columns("username").Width = "350"
        End With

    End Sub
    Sub cek_username()
        If Not (txt_username.Text = "") Then
            sql = "SELECT username FROM tbl_pengguna WHERE username = '" & txt_username.Text & "'"
            datapengguna = proses.ExecuteQuery(sql)
            If datapengguna.Rows.Count > 0 Then
                MsgBox("Username sudah ada !!", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub

            End If
        End If
    End Sub
    Private Sub Form_DataPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_pengguna()
    End Sub

    Private Sub b_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_tambah.Click
        sql = "SELECT username,status FROM tbl_pengguna WHERE username = '" & Form_Menu.ToolStripStatusLabel3.Text & "'"
        datapengguna = proses.ExecuteQuery(sql)
        If (datapengguna.Rows.Count = 1) Then
            If (datapengguna.Rows(0).Item("status").ToString = "User") Then
                MsgBox("Hanya admin yang dapat menambah data user", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
        End If
        If (b_tambah.Text = "&Tambah") Then
            ' Koding Tambah - Ketika nama button tambah namanya tambah :v
            Call aktif()
            b_edit.Enabled = False
            b_hapus.Enabled = False
            b_tambah.Text = "&Simpan"

            txt_username.Focus()
        Else
            ' Koding Simpan Tambah
            Call cek_username()
            If (txt_username.Text = "") Or (txt_password.Text = "") Or (txt_nik.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
            Try
                sql = "INSERT INTO tbl_pengguna (username, status, pass, nik) VALUES "
                sql += "('" & txt_username.Text & "', '" & cb_status.Text & "', '" & txt_password.Text & "', '" & txt_nik.Text & "')"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            ' MsgBox("Data pengguna berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            Call normal()

            Call data_pengguna()
            proses.CloseConn()
            End If
    End Sub

    Private Sub b_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_batal.Click
        Call normal()

    End Sub

    Private Sub b_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_hapus.Click
        If (Form_Menu.ToolStripStatusLabel3.Text = DG_Pengguna.SelectedCells(0).Value.ToString) Then
            MsgBox("Data Pengguna tidak dapat dihapus karena sedang aktif", MsgBoxStyle.Critical, vbOKOnly)
            Exit Sub
        End If
        Dim pesan As DialogResult
        pesan = MessageBox.Show("Apakah benar anda akan menghapus Data pengguna " & DG_Pengguna.SelectedCells(1).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)

        If pesan = Windows.Forms.DialogResult.OK Then
            Try
                sql = "DELETE FROM tbl_pengguna WHERE username = '" & DG_Pengguna.SelectedCells(0).Value & "'"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Menghapus Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.OkOnly, "Pesan")
            Call data_pengguna()

        End If
    End Sub
    Sub DG_Edit()
        Try
            With DG_Pengguna
                txt_username.Text = .SelectedCells(0).Value.ToString
                txt_nik.Text = .SelectedCells(1).Value.ToString
                cb_status.Text = .SelectedCells(3).Value.ToString
                txt_password.Text = .SelectedCells(2).Value.ToString
            End With
            Call cari_karyawan()
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
        sql = "SELECT status FROM tbl_pengguna WHERE username = '" & Form_Menu.ToolStripStatusLabel3.Text & "'"
        datapengguna = proses.ExecuteQuery(sql)
        'MsgBox(sql)
        If (datapengguna.Rows(0).Item("status").ToString = "User") Then
            cb_status.Enabled = False
            txt_nik.Enabled = False
        End If
    End Sub

    Private Sub DG_Pengguna_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Pengguna.CellDoubleClick
        Call aktif()
        Call DG_Edit()

        b_tambah.Enabled = False
        b_hapus.Enabled = False
        b_edit.Text = "&Simpan"
        txt_username.Enabled = False
    End Sub

    Private Sub b_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit.Click
        If (b_edit.Text = "&Edit") Then
            Call aktif()
            Call DG_Edit()

            txt_username.Enabled = False
            b_tambah.Enabled = False
            b_hapus.Enabled = False
            b_edit.Text = "&Simpan"
        Else
            ' Koding Simpan Tambah
            Try
                sql = "UPDATE tbl_pengguna SET "
                sql += "nama_lengkap='" & txt_nik.Text & "', "
                sql += "status='" & cb_status.Text & "', "
                sql += "pass='" & txt_password.Text & "', "
                'sql += "alamat='" & txt_alamat.Text & "', "
                sql += "nik='" & txt_nik.Text & "' "

                sql += " WHERE username = '" & txt_username.Text & "' "
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Edit Gagal", MsgBoxStyle.Critical, "Peringantan")

                Exit Sub
            End Try
            ' MsgBox("Data pengguna berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            MsgBox("Data Berhasil di Edit", MsgBoxStyle.OkOnly, "Pesan")

            Call normal()
            Call data_pengguna()

            proses.CloseConn()
        End If
    End Sub

    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_pengguna(txt_pencarian.Text)
        End If
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub b_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cari.Click
        Call data_pengguna(txt_pencarian.Text)
    End Sub
    Sub cari_karyawan()
        If (Len(txt_nik.Text) > 1) Then
            ' 1 nik boleh memiliki 2 atau lebih data user
            sql = "SELECT nama_karyawan FROM tbl_karyawan WHERE nik = '" & txt_nik.Text & "'"
            datapengguna = proses.ExecuteQuery(sql)
            If (datapengguna.Rows.Count >= 1) Then
                txt_nama.Text = datapengguna.Rows(0).Item("nama_karyawan").ToString
            Else
                MsgBox("Data Karyawan dengan NIK " & txt_nik.Text & " Tidak Ditemukan ", MsgBoxStyle.Exclamation, "Pesan")
            End If
        End If
    End Sub
    Private Sub txt_nik_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nik.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cari_karyawan()
        End If
    End Sub
End Class