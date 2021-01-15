Public Class Form_Supplier
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datasupplier As DataTable

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
        txt_kodesupplier.Clear()
        txt_namasupplier.Clear()
        txt_alamat.Clear()
        txt_alamat.Clear()
        txt_notelp.Clear()
        txt_pencarian.Clear()

        sql = Nothing
        b_tambah.Text = "&Tambah"
        b_edit.Text = "&Edit"
    End Sub
    Sub aktif()
        txt_namasupplier.Enabled = True
        txt_alamat.Enabled = True
        txt_notelp.Enabled = True
       ' txt_pencarian.Enabled = True

        b_tambah.Enabled = True
        b_edit.Enabled = True
        b_hapus.Enabled = True
        b_batal.Enabled = True
        b_keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_kodesupplier.Enabled = False
        txt_namasupplier.Enabled = False
        txt_alamat.Enabled = False
        txt_notelp.Enabled = False
        'txt_pencarian.Enabled = False

        b_tambah.Enabled = False
        b_edit.Enabled = False
        b_hapus.Enabled = False
        b_batal.Enabled = False
        b_keluar.Enabled = False
    End Sub
    Sub data_supplier(Optional ByVal kode As String = "Semuanya")
        If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
            sql = "SELECT * FROM tbl_supplier ORDER BY nama_supplier ASC"
        Else
            sql = "SELECT * FROM tbl_supplier WHERE kode_supplier LIKE '" & kode & "' OR nama_supplier LIKE '" & kode & "' ORDER BY nama_supplier ASC"
        End If
        datasupplier = proses.ExecuteQuery(sql)
        'If datasupplier.Rows.Count > 0 Then
        DG_Supplier.DataSource = datasupplier
        With DG_Supplier
            .Columns("nama_supplier").Width = "150"
        End With
        'End If
    End Sub
    Sub Kode_Otomatis()
        sql = "SELECT kode_supplier FROM tbl_supplier ORDER BY kode_supplier DESC"
        datasupplier = proses.ExecuteQuery(sql)
        If datasupplier.Rows.Count = 0 Then
            txt_kodesupplier.Text = "SUP-0001"
        Else
            txt_kodesupplier.Text = Val(Microsoft.VisualBasic.Right(datasupplier.Rows(0).Item("kode_supplier").ToString, 2)) + 1
            If Len(txt_kodesupplier.Text) = 1 Then
                txt_kodesupplier.Text = "SUP-000" & txt_kodesupplier.Text & ""
            ElseIf Len(txt_kodesupplier.Text) = 2 Then
                txt_kodesupplier.Text = "SUP-00" & txt_kodesupplier.Text & ""
            ElseIf Len(txt_kodesupplier.Text) = 3 Then
                txt_kodesupplier.Text = "SUP-0" & txt_kodesupplier.Text & ""
            End If
        End If
    End Sub
    Private Sub Form_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_supplier()

    End Sub

    Private Sub b_tambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_tambah.Click
        If (b_tambah.Text = "&Tambah") Then
            ' Koding Tambah - Ketika nama button tambah namanya tambah :v
            Call aktif()
            b_edit.Enabled = False
            b_hapus.Enabled = False
            b_tambah.Text = "&Simpan"

            Call Kode_Otomatis()
            txt_namasupplier.Focus()
        Else
            If (txt_kodesupplier.Text = "") Or (txt_namasupplier.Text = "") Or (txt_alamat.Text = "") Or (txt_notelp.Text = "") Then
                MsgBox("Data lelum lengkap, pastikan semuanya terisi", MsgBoxStyle.Information, "Pesan")
                Exit Sub

            End If
            Try
                sql = "INSERT INTO tbl_supplier (kode_supplier, nama_supplier, alamat, no_telp) VALUES "
                sql += "('" & txt_kodesupplier.Text & "', '" & txt_namasupplier.Text & "', '" & txt_alamat.Text & "', '" & txt_notelp.Text & "')"
                proses.ExecuteNonQuery(sql)
                MsgBox("Data berhasil di simpan", MsgBoxStyle.Information, "Pesan")
            Catch ex As Exception
                MsgBox("Proses Simpan Gagal", MsgBoxStyle.Critical, "Peringatan")
               Exit Sub
            End Try
            txt_namasupplier.Focus()
            Call bersih()
            Call data_supplier()
            b_tambah.Text = "&Simpan"
            Call Kode_Otomatis()

            proses.CloseConn()
        End If
    End Sub

    Private Sub b_edit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_edit.Click
        If (b_edit.Text = "&Edit") Then
            Call aktif()
            Call DG_Edit()

            b_tambah.Enabled = False
            b_hapus.Enabled = False
            b_edit.Text = "&Simpan"
        Else
            ' Koding Simpan Tambah
            Try
                sql = "UPDATE tbl_supplier SET "
                sql += "nama_supplier='" & txt_namasupplier.Text & "', "
                sql += "alamat='" & txt_alamat.Text & "', "
                sql += "no_telp='" & txt_notelp.Text & "' "
                
                sql += " WHERE kode_supplier = '" & txt_kodesupplier.Text & "' "
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Simpan Edit Gagal", MsgBoxStyle.Critical, "Peringantan")
                Exit Sub
            End Try
            ' MsgBox("Data supplier berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
            MsgBox("Data Berhasil di Ubah", MsgBoxStyle.OkOnly, "Pesan")
            Call normal()
            Call data_supplier()
            proses.CloseConn()
        End If
    End Sub

    Private Sub b_hapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_hapus.Click
        Dim pesan As DialogResult
        pesan = MessageBox.Show("Apakah benar anda akan menghapus Data supplier " & DG_Supplier.SelectedCells(1).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)

        If pesan = Windows.Forms.DialogResult.OK Then
            Try
                sql = "DELETE FROM tbl_supplier WHERE kode_supplier = '" & DG_Supplier.SelectedCells(0).Value & "'"
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Proses Menghapus Gagal", MsgBoxStyle.Critical, "Peringatan")
                Exit Sub
            End Try
            MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.OkOnly, "Pesan")
            Call data_supplier()

        End If
    End Sub

    Private Sub b_batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_batal.Click
        Call normal()
    End Sub

    Private Sub b_keluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()

    End Sub
    Sub DG_Edit()
        Try
            With DG_Supplier
                txt_kodesupplier.Text = .SelectedCells(0).Value.ToString
                txt_namasupplier.Text = .SelectedCells(1).Value.ToString
                txt_alamat.Text = .SelectedCells(2).Value.ToString
                txt_notelp.Text = .SelectedCells(3).Value.ToString
   
            End With
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Data", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
    End Sub
    Private Sub DG_Supplier_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Supplier.CellDoubleClick
        Call aktif()
        Call DG_Edit()

        b_tambah.Enabled = False
        b_hapus.Enabled = False
        b_edit.Text = "&Simpan"
    End Sub

    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_supplier(txt_pencarian.Text)
        End If
    End Sub

    Private Sub b_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cari.Click
        Call data_supplier(txt_pencarian.Text)
    End Sub
End Class