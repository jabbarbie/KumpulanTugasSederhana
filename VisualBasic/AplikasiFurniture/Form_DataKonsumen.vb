Public Class Form_DataKonsumen
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datakonsumen As DataTable
    Sub Kode_Otomatis()
        sql = "SELECT kode_konsumen FROM tbl_konsumen ORDER BY kode_konsumen DESC"
        datakonsumen = proses.ExecuteQuery(sql)
        If datakonsumen.Rows.Count = 0 Then
            txt_idkonsumen.Text = "KNS-01"
        Else
            txt_idkonsumen.Text = Val(Microsoft.VisualBasic.Right(datakonsumen.Rows(0).Item("kode_konsumen").ToString, 3)) + 1
            If Len(txt_idkonsumen.Text) = 1 Then
                txt_idkonsumen.Text = "KSN-000" & txt_idkonsumen.Text & ""
            ElseIf Len(txt_idkonsumen.Text) = 2 Then
                txt_idkonsumen.Text = "KSN-00" & txt_idkonsumen.Text & ""
            ElseIf Len(txt_idkonsumen.Text) = 3 Then
                txt_idkonsumen.Text = "KSN-0" & txt_idkonsumen.Text & ""
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
        txt_idkonsumen.Clear()
        txt_nama.Clear()
        txt_notelp.Clear()
        txt_alamat.Clear()
        txt_notelp.Clear()
        cb_status.SelectedIndex = -1
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
        cb_status.Enabled = True
        ' txt_pencarian.Enabled = True

        b_tambah.Enabled = True
        b_edit.Enabled = True
        b_hapus.Enabled = True
        b_batal.Enabled = True
        b_keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_idkonsumen.Enabled = False
        txt_nama.Enabled = False
        txt_notelp.Enabled = False
        txt_alamat.Enabled = False
        txt_notelp.Enabled = False
        cb_status.Enabled = False
        'txt_pencarian.Enabled = False

        b_tambah.Enabled = False
        b_edit.Enabled = False
        b_hapus.Enabled = False
        b_batal.Enabled = False
        b_keluar.Enabled = False
    End Sub
    Sub data_konsumen(Optional ByVal kode As String = "Semuanya")
        If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
            sql = "SELECT * FROM tbl_konsumen ORDER BY nama_konsumen ASC"
        Else
            sql = "SELECT * FROM tbl_konsumen WHERE nama_konsumen LIKE '" & kode & "' OR alamat LIKE '" & kode & "' ORDER BY nama_konsumen ASC"
        End If
        datakonsumen = proses.ExecuteQuery(sql)
        DG_konsumen.DataSource = datakonsumen
        With DG_konsumen
            .Columns("nama_konsumen").Width = "150"
        End With

    End Sub
    Private Sub Form_Datakonsumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_konsumen()
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
            If (txt_nama.Text = "") Or (txt_alamat.Text = "") Or (txt_notelp.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub
            End If
            Try
                sql = "INSERT INTO tbl_konsumen (kode_konsumen, nama_konsumen,jenis_kelamin, alamat,notelp) VALUES "
                sql += "('" & txt_idkonsumen.Text & "', '" & txt_nama.Text & "', '" & cb_status.Text & "', '" & txt_alamat.Text & "', '" & txt_notelp.Text & "')"
                proses.ExecuteNonQuery(sql)

            Catch ex As Exception
                MsgBox("Proses Simpan Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            ' MsgBox("Data konsumen berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            Call normal()
            Call Kode_Otomatis()

            Call data_konsumen()
            proses.CloseConn()
        End If
    End Sub

    Private Sub b_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_batal.Click
        Call normal()

    End Sub

    Private Sub b_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_hapus.Click
        Dim pesan As DialogResult
        pesan = MessageBox.Show("Apakah benar anda akan menghapus Data konsumen " & DG_Konsumen.SelectedCells(0).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)

        If pesan = Windows.Forms.DialogResult.OK Then
            Try
                sql = "DELETE FROM tbl_konsumen WHERE kode_konsumen = '" & DG_Konsumen.SelectedCells(0).Value & "'"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            Catch ex As Exception
                MsgBox("Proses Menghapus Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.OkOnly, "Pesan")
            Call data_konsumen()

        End If
    End Sub
    Sub DG_Edit()
        Try
            With DG_konsumen
                txt_idkonsumen.Text = .SelectedCells(0).Value.ToString
                txt_nama.Text = .SelectedCells(1).Value.ToString
                'cb_status.Text = .SelectedCells(3).Value.ToString
                txt_alamat.Text = .SelectedCells(2).Value.ToString
                'txt_notelp.Text = .SelectedCells(2).Value.ToString
                txt_notelp.Text = .SelectedCells(4).Value.ToString
            End With
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
    End Sub

    Private Sub DG_konsumen_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_konsumen.CellDoubleClick
        Call aktif()
        Call DG_Edit()

        b_tambah.Enabled = False
        b_hapus.Enabled = False
        b_edit.Text = "&Simpan"
        txt_idkonsumen.Enabled = False
    End Sub

    Private Sub b_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_edit.Click
        If (b_edit.Text = "&Edit") Then
            Call aktif()
            Call DG_Edit()

            txt_idkonsumen.Enabled = False
            b_tambah.Enabled = False
            b_hapus.Enabled = False
            b_edit.Text = "&Simpan"
        Else
            ' Koding Simpan Tambah
            Try
                sql = "UPDATE tbl_konsumen SET "
                sql += "nama_konsumen='" & txt_nama.Text & "', "
                'sql += "jenis_kelamin='" & cb_status.Text & "', "
                'sql += "notelp='" & txt_notelp.Text & "', "
                sql += "alamat='" & txt_alamat.Text & "', "
                sql += "notelp='" & txt_notelp.Text & "' "

                sql += " WHERE kode_konsumen = '" & txt_idkonsumen.Text & "' "
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Edit Gagal", MsgBoxStyle.Critical, "Peringantan")

                Exit Sub
            End Try
            ' MsgBox("Data konsumen berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            MsgBox("Data Berhasil di Ubah", MsgBoxStyle.OkOnly, "Pesan")

            Call normal()
            Call data_konsumen()

            proses.CloseConn()
        End If
    End Sub

    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_konsumen(txt_pencarian.Text)
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
        Call data_konsumen(txt_pencarian.Text)
    End Sub

    Private Sub cb_status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_status.SelectedIndexChanged

    End Sub
End Class