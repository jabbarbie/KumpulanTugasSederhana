Public Class Form_TransPenjualan
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datatrans As DataTable
    Dim databarang As DataTable
    Dim totalbelanja As Integer

    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()
        Call tidak_aktif()

        b_simpan.Enabled = True
        'B_Edit.Enabled = True
        b_hapus.Enabled = True
        txt_kdkonsumen.Focus()
    End Sub
    Sub cari_datakonsumen()
        Try
            sql = "SELECT * FROM tbl_konsumen WHERE kode_konsumen = '" & txt_kdkonsumen.Text & "'"
            datatrans = proses.ExecuteQuery(sql)
        Catch ex As Exception
            MsgBox("Query Data Error !!!", MsgBoxStyle.Critical, "Peringatan")
            Exit Sub
        End Try
        If (datatrans.Rows.Count > 0) Then
            With datatrans
                txt_namakon.Text = .Rows(0).Item("nama_konsumen").ToString
                txt_alamatkon.Text = .Rows(0).Item("alamat").ToString
            End With
            txt_kdbarang.Focus()
        Else
            MsgBox("Data Konsumen Tidak Ditemukan", MsgBoxStyle.Exclamation, "Peringatan")
            txt_kdkonsumen.Focus()
            Exit Sub
        End If

        Call Kode_Otomatis()
        datatrans = Nothing
        sql = Nothing
    End Sub
    Sub bersih()
        txt_kdkonsumen.Clear()
        txt_namakon.Clear()
        txt_alamatkon.Clear()

        txt_kdtrans.Clear()
        txt_kdbarang.Clear()
        txt_nama.Clear()
        txt_harga.Clear()

        txt_qty.Clear()
        txt_subtotal.Clear()
        txt_totalitem.Clear()
        txt_jenisbrng.Clear()
        txt_dibayar.Clear()
        txt_kembali.Clear()

        L_Total.Text = "Rp. 0"

        sql = Nothing
        DG_Transjual.DataSource = Nothing
        'b_edit.Text = "&Edit"
    End Sub
    Sub aktif()

        txt_kdbarang.Enabled = True
        txt_nama.Enabled = True
        txt_harga.Enabled = True
        txt_qty.Enabled = True
        txt_totalitem.Enabled = True
        txt_jenisbrng.Enabled = True

        b_simpan.Enabled = True
        'b_edit.Enabled = True
        b_hapus.Enabled = True
        b_batal.Enabled = True

    End Sub
    Sub tidak_aktif()
        txt_kasir.Enabled = False

        'txt_kdbarang.Enabled = False
        txt_nama.Enabled = False
        txt_harga.Enabled = False
        'txt_qty.Enabled = False
        'txt_subtotal.Enabled = False
        txt_totalitem.Enabled = False
        txt_jenisbrng.Enabled = False

        b_simpan.Enabled = False
        'b_edit.Enabled = False
        B_Hapus.Enabled = False
        B_Batal.Enabled = False

    End Sub
    Sub cari_databarang()
        sql = "SELECT * FROM tbl_barang WHERE kode_barang ='" & txt_kdbarang.Text & "'"
        databarang = proses.ExecuteQuery(sql)
        If (databarang.Rows.Count <= 0) Then
            MsgBox("Data Barang Tidak Ditemukan", MsgBoxStyle.Information, "Pesan")
            txt_nama.Clear()
            txt_jenisbrng.Clear()
            txt_harga.Clear()
        Else
            With databarang.Rows(0)
                If (Val(.Item("stok")) <= 0) Then
                    MsgBox("Stok Barang Kosong", MsgBoxStyle.Information, "Pesan")
                    Exit Sub
                End If
                txt_nama.Text = .Item("nama").ToString
                txt_jenisbrng.Text = .Item("jenis").ToString
                txt_harga.Text = .Item("harga_jual").ToString
            End With
            txt_qty.Focus()
        End If
    End Sub
    Sub data_trans(Optional ByVal kode As String = "Semuanya")
        'If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
        sql = "SELECT * FROM tbl_penjualan ORDER BY nama ASC"
        'Else
        ' sql = "SELECT * FROM tbl_trans WHERE kode_trans LIKE '" & kode & "' OR nama LIKE '" & kode & "' ORDER BY nama ASC"
        'End If
        datatrans = proses.ExecuteQuery(sql)
        'If datatrans.Rows.Count > 0 Then
        DG_transjual.DataSource = datatrans
        With DG_transjual
            .Columns("nama").Width = "150"
        End With
        'End If
    End Sub
    Sub Kode_Otomatis()
        sql = "SELECT kode_transjual FROM tbl_penjualan ORDER BY kode_transjual DESC"
        datatrans = proses.ExecuteQuery(sql)
        If datatrans.Rows.Count = 0 Then
            txt_kdtrans.Text = "TRJ-0001"
        Else
           txt_kdtrans.Text = Val(Microsoft.VisualBasic.Right(datatrans.Rows(0).Item("kode_transjual").ToString, 3)) + 1
            If Len(txt_kdtrans.Text) = 1 Then
                txt_kdtrans.Text = "TRJ-000" & txt_kdtrans.Text & ""
            ElseIf Len(txt_kdtrans.Text) = 2 Then
                txt_kdtrans.Text = "TRJ-00" & txt_kdtrans.Text & ""
            ElseIf Len(txt_kdtrans.Text) = 3 Then
                txt_kdtrans.Text = "TRJ-0" & txt_kdtrans.Text & ""
            End If
        End If
    End Sub
 
    Private Sub b_barang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_Barang.ShowDialog()
    End Sub

    Private Sub Form_Transpenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call normal()
        proses.CloseConn()

        Me.Close()
    End Sub

    Private Sub b_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_simpan.Click
        Call bersih()
        Call normal()

    End Sub


    Private Sub b_sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_Supplier.ShowDialog()
    End Sub

   
    Sub data_barang()
       Dim total As Integer = 0
        Try
            sql = "SELECT kode_barang, nama, harga_jual, qty, SubTotal FROM query_penjualan WHERE kode_transjual = '" & txt_kdtrans.Text & "' "
            datatrans = proses.ExecuteQuery(sql)
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Detail penjualan !!!!", MsgBoxStyle.Critical, "Pesan")
            Exit Sub
        End Try
       If datatrans.Rows.Count > 0 Then
            DG_Transjual.DataSource = datatrans
            With DG_Transjual
                .Columns(0).HeaderText = "Kode Barang"
                .Columns(1).HeaderText = "Nama"
                .Columns(2).HeaderText = "Harga"
                .Columns(3).HeaderText = "Qty"
                .Columns(4).HeaderText = "Sub Total"

                .Columns(0).Width = 100
                .Columns(1).Width = 370
                .Columns(2).Width = 200
                .Columns(3).Width = 50
                .Columns(4).Width = 200

                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                .Columns(2).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Format = "N0"
            End With
            txt_totalitem.Text = DG_Transjual.RowCount.ToString
            For i As Integer = 0 To DG_Transjual.RowCount - 1
                total += DG_Transjual.Rows(i).Cells(4).Value
            Next
            L_Total.Text = Format(Val(total.ToString), "Rp, ###,##")
            totalbelanja = total
            txt_dibayar.Focus()
        Else
            'DG_Transjual.DataSource = Nothing
        End If
        txt_nama.Clear()
        txt_harga.Clear()
        txt_harga.Clear()
        txt_qty.Clear()
        txt_subtotal.Clear()
        txt_jenisbrng.Clear()

        txt_kdbarang.Focus()
    End Sub
    Private Sub txt_kdbarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kdbarang.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cari_databarang()
        End If
    End Sub
    Sub simpan()
        If Not (txt_kdtrans.Text = "") Then
            sql = "SELECT kode_transjual FROM tbl_penjualan WHERE kode_transjual = '" & txt_kdtrans.Text & "'"
            datatrans = proses.ExecuteQuery(sql)
            If (datatrans.Rows.Count) <= 0 Then
                sql = "INSERT INTO tbl_penjualan (kode_transjual, tanggal_transaksi, username, kode_konsumen) VALUES ('" & txt_kdtrans.Text & "','" & tgl_trans.Text & "', '" & txt_kasir.Text & "','" & txt_kdkonsumen.Text & "')"
                proses.ExecuteNonQuery(sql)
            End If
            'datatrans = Nothing
            'sql = Nothing
        End If
    End Sub
    Private Sub ProsesSimpanHandle(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nama.KeyPress, txt_qty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If (txt_kdbarang.Text = "" Or txt_nama.Text = "" Or txt_qty.Text = "" Or txt_harga.Text = "" Or Val(txt_subtotal.Text) <= 0) Then
                MsgBox("Data barang belum lengkap", MsgBoxStyle.Information, "Pesan")
            Else
                Try
                    'proses.ExecuteNonQuery(sql)
                    'MsgBox(sql)
                    ' cari ada yang sama tidak 
                    sql = "SELECT kode_barang FROM tbl_penjualandetail WHERE kode_barang = '" & txt_kdbarang.Text & "' AND kode_transjual = '" & txt_kdtrans.Text & "'"
                    databarang = proses.ExecuteQuery(sql)
                    If (databarang.Rows.Count > 0) Then
                        sql = "UPDATE tbl_penjualandetail SET qty = qty + " & Val(txt_qty.Text) & " WHERE kode_transjual = '" & txt_kdtrans.Text & "' AND kode_barang = '" & txt_kdbarang.Text & "'"
                        proses.ExecuteNonQuery(sql)
                        sql = "UPDATE tbl_barang SET stok = stok - " & Val(txt_qty.Text) & ", dibeli = dibeli + " & Val(txt_qty.Text) & " WHERE kode_barang = '" & txt_kdbarang.Text & "' "
                        proses.ExecuteNonQuery(sql)
                    Else
                        sql = "INSERT INTO tbl_penjualandetail (kode_transjual,kode_barang,qty) VALUES ('" & txt_kdtrans.Text & "','" & txt_kdbarang.Text & "', " & txt_qty.Text & ") "
                        proses.ExecuteNonQuery(sql)
                        'MsgBox(sql)
                        sql = "UPDATE tbl_barang SET stok = stok - " & Val(txt_qty.Text) & ", dibeli = dibeli + " & Val(txt_qty.Text) & " WHERE kode_barang = '" & txt_kdbarang.Text & "' "
                        proses.ExecuteNonQuery(sql)
                    End If
                    Call simpan()
                   Call data_barang()

                    txt_nama.Clear()
                    txt_harga.Clear()
                    txt_harga.Clear()
                    txt_qty.Clear()
                    txt_subtotal.Clear()
                    txt_jenisbrng.Clear()

                    txt_kdbarang.Focus()
                Catch ex As Exception
                    MsgBox("Kode Error Di SubProsesHandle : " + sql, MsgBoxStyle.Critical, "Pesan Kesalahan")
                End Try
            End If
        End If
    End Sub
    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        If (Val(txt_harga.Text) > 0) Then
            sql = "SELECT stok FROM tbl_barang WHERE kode_barang = '" & txt_kdbarang.Text & "' "
            databarang = proses.ExecuteQuery(sql)
            If (Val(txt_qty.Text) > Val(databarang.Rows(0).Item("stok").ToString)) Then
                MsgBox("Jumlah beli melebihi stok barang", MsgBoxStyle.Exclamation, "Pesan")
                txt_subtotal.Clear()
                Exit Sub
            End If
            txt_subtotal.Text = Val(txt_qty.Text) * Val(txt_harga.Text)
        End If
    End Sub

 
    Private Sub txt_kdtrans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_kdtrans.TextChanged
        Call data_barang()
    End Sub


    Private Sub txt_kdkonsumen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kdkonsumen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cari_datakonsumen()
        End If
    End Sub

    Private Sub b_barang_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_barang.Click
        Form_CariBarang.ShowDialog()
    End Sub

    Private Sub txt_dibayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_dibayar.KeyPress
        Dim pesan As DialogResult
        If Asc(e.KeyChar) = 13 Then
            If (Val(totalbelanja) > 0 And Val(txt_dibayar.Text) > 0) Then
                txt_kembali.Text = Val(txt_dibayar.Text) - Val(totalbelanja)
                sql = "UPDATE tbl_penjualan SET dibayar =  " & Val(txt_dibayar.Text) & " WHERE kode_transjual = '" & txt_kdtrans.Text & "' "
                proses.ExecuteNonQuery(sql)
                pesan = MessageBox.Show("Ingin Mencetak Struk ?", "Pertanyaaan", MessageBoxButtons.OKCancel)
                If pesan = Windows.Forms.DialogResult.OK Then
                    Form_V_NotaPenjualan.Label1.Text = " WHERE tbl_penjualan.kode_transjual = '" & txt_kdtrans.Text & "'"
                    Form_V_NotaPenjualan.ShowDialog()
                    Call normal()
                End If
            Else
                MsgBox("Total Belanja Kosong", MsgBoxStyle.OkOnly, "Pesan")
            End If
        End If
    End Sub

    Private Sub b_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_hapus.Click
        Dim pesan As DialogResult
        If (txt_kdtrans.Text = "") Then MsgBox("Kode Transaksi Kosong", MsgBoxStyle.Critical, "Peringatan") : Exit Sub


        If (DG_Transjual.Rows.Count <= 0) Then
            sql = "SELECT kode_transjual FROM tbl_penjualan WHERE kode_transjual = '" & txt_kdtrans.Text & "' "
            datatrans = proses.ExecuteQuery(sql)
            If datatrans.Rows.Count <= 0 Then
                MsgBox("Data masih kosong")
                Exit Sub

            End If
            pesan = MessageBox.Show("Data Transaksi Penjualan " & txt_kdtrans.Text & " Kosong, Apakah anda ingin menghapusnya ?", "Konfirmasi", MessageBoxButtons.OKCancel)
            If pesan = Windows.Forms.DialogResult.OK Then
                sql = "DELETE FROM tbl_penjualan WHERE kode_transjual = '" & txt_kdtrans.Text & "'"
                proses.ExecuteNonQuery(sql)
                MsgBox("Data Transaksi Penjualan Berhasil DI Hapus", MsgBoxStyle.OkOnly, "Pesan")
            End If
        Else
            'Try
            pesan = MessageBox.Show("Apakah benar anda akan menghapus Data Barang Belanja  " & DG_Transjual.SelectedCells(1).Value.ToString & "?", "Konfirmasi", MessageBoxButtons.OKCancel)
            If pesan = Windows.Forms.DialogResult.OK Then
                sql = "UPDATE tbl_barang SET stok = stok + " & Val(DG_Transjual.SelectedCells(3).Value.ToString) & " WHERE kode_barang = '" & DG_Transjual.SelectedCells(0).Value.ToString & "' "
                proses.ExecuteNonQuery(sql)

                sql = "DELETE FROM tbl_penjualandetail WHERE kode_transjual = '" & txt_kdtrans.Text & "' AND kode_barang = '" & DG_Transjual.SelectedCells(0).Value.ToString & "'"
                proses.ExecuteNonQuery(sql)
                MsgBox("Data Barang Belanja berhasil dihapus", MsgBoxStyle.OkOnly, "Pesan")

                Call data_barang()
            End If
            'Catch ex As Exception
            'MsgBox("Proses Menghapus Gagal " + sql, MsgBoxStyle.Critical, "Peringatan")
            'Exit Sub
            'End Try
        End If
    End Sub

    Private Sub b_kon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_kon.Click
        Form_CariKonsumen.ShowDialog()
    End Sub

    Private Sub L_Total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L_Total.TextChanged

    End Sub
End Class