Public Class Form_TransPembelian
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datatrans As DataTable

    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()
        Call Kode_Otomatis()
        Call tidak_aktif()

        DG_Transbeli.DataSource = Nothing
        
        txt_kdtrans.Focus()
    End Sub
    Sub bersih()
        txt_kdtrans.Clear()
        txt_kdsup.Clear()
        txt_supnama.Clear()
        txt_supalamat.Clear()

        txt_kdbarang.Clear()
        txt_nama.Clear()
        txt_hargabeli.Clear()
        txt_hargajual.Clear()

        txt_qty.Clear()
        txt_subtotal.Clear()
        txt_totalitem.Clear()
        txt_jenisbrng.Clear()
        txt_merkbrg.Clear()
        txt_merkbrg.Clear()

        L_Total.Text = "Rp. 0"

        sql = Nothing
    End Sub
    Sub aktif()
        txt_kdbarang.Enabled = True
        txt_nama.Enabled = True
        txt_hargabeli.Enabled = True
        txt_hargajual.Enabled = True
        txt_qty.Enabled = True
        txt_totalitem.Enabled = True
        txt_merkbrg.Enabled = True
        txt_jenisbrng.Enabled = True

        b_hapus.Enabled = True
        b_batal.Enabled = True
        b_keluar.Enabled = True
    End Sub
    Sub tidak_aktif()
        txt_supnama.Enabled = False
        txt_supalamat.Enabled = False
        txt_kasir.Enabled = False

        'txt_kdbarang.Enabled = False
        txt_nama.Enabled = False
        txt_hargabeli.Enabled = False
        txt_hargajual.Enabled = False
        txt_qty.Enabled = False
        txt_subtotal.Enabled = False
        txt_totalitem.Enabled = False
        txt_merkbrg.Enabled = False
        txt_jenisbrng.Enabled = False

        B_Hapus.Enabled = False
        B_Batal.Enabled = False
        b_keluar.Enabled = False
    End Sub
    Sub data_trans(Optional ByVal kode As String = "Semuanya")
        'If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
        sql = "SELECT * FROM tbl_pembelian ORDER BY nama ASC"
        'Else
        ' sql = "SELECT * FROM tbl_trans WHERE kode_trans LIKE '" & kode & "' OR nama LIKE '" & kode & "' ORDER BY nama ASC"
        'End If
        datatrans = proses.ExecuteQuery(sql)
        'If datatrans.Rows.Count > 0 Then
        DG_Transbeli.DataSource = datatrans
        With DG_Transbeli
            .Columns("nama").Width = "150"
        End With
        'End If
    End Sub
    Sub Kode_Otomatis()
        sql = "SELECT kode_transbeli FROM tbl_pembelian ORDER BY kode_transbeli DESC"
        datatrans = proses.ExecuteQuery(sql)
        If datatrans.Rows.Count = 0 Then
            txt_kdtrans.Text = "TRB-0001"
        Else
            txt_kdtrans.Text = Microsoft.VisualBasic.Right(datatrans.Rows(0).Item("kode_transbeli").ToString, 3) + 1
            'MsgBox(txt_kdtrans.Text)
            If Len(txt_kdtrans.Text) = 1 Then
                txt_kdtrans.Text = "TRB-000" & txt_kdtrans.Text & ""
            ElseIf Len(txt_kdtrans.Text) = 2 Then
                txt_kdtrans.Text = "TRB-00" & txt_kdtrans.Text & ""
            ElseIf Len(txt_kdtrans.Text) = 3 Then
                txt_kdtrans.Text = "TRB-0" & txt_kdtrans.Text & ""
            End If
        End If
    End Sub
    Sub Kode_Otomatis_BRN()
        sql = "SELECT kode_barang FROM tbl_barang ORDER BY kode_barang  DESC"
        datatrans = proses.ExecuteQuery(sql)
        If datatrans.Rows.Count = 0 Then
            txt_kdbarang.Text = "BRN-0001"
        Else
            txt_kdbarang.Text = Val(Microsoft.VisualBasic.Right(datatrans.Rows(0).Item("kode_barang").ToString, 3)) + 1
            If Len(txt_kdbarang.Text) = 1 Then
                txt_kdbarang.Text = "BRN-000" & txt_kdbarang.Text & ""
            ElseIf Len(txt_kdbarang.Text) = 2 Then
                txt_kdbarang.Text = "BRN-00" & txt_kdbarang.Text & ""
            ElseIf Len(txt_kdbarang.Text) = 3 Then
                txt_kdbarang.Text = "BRN-0" & txt_kdbarang.Text & ""
            End If
        End If
    End Sub
    Private Sub b_barang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_Barang.ShowDialog()
    End Sub

    Private Sub Form_TransPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()
    End Sub

    

    Private Sub b_sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_sup.Click
        Form_CariSupplier.ShowDialog()
    End Sub
    Sub cari_supplier()
        Try
            sql = "SELECT * FROM tbl_supplier WHERE kode_supplier = '" & txt_kdsup.Text & "'"
            datatrans = proses.ExecuteQuery(sql)
        Catch ex As Exception
            MsgBox("Query Data Error !!!", MsgBoxStyle.Critical, "Peringatan")
            'MsgBox(sql)
            Exit Sub
        End Try
        If (datatrans.Rows.Count > 0) Then
            With datatrans
                txt_supnama.Text = .Rows(0).Item("nama_supplier").ToString
                txt_supalamat.Text = .Rows(0).Item("alamat").ToString
            End With
            txt_kdbarang.Focus()
            Call Kode_Otomatis_BRN()
            Call aktif()
        Else
            MsgBox("Data Supplier Tidak Ditemukan", MsgBoxStyle.Exclamation, "Peringatan")
        End If
        datatrans = Nothing
        sql = Nothing
    End Sub
    Private Sub txt_kdsup_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kdsup.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cari_supplier()
        End If
    End Sub
    Sub data_barang()
        Dim total As Integer = 0
        Try
            sql = "SELECT kode_barang, nama, harga_beli, qty, SubTotal FROM query_pembelian WHERE kode_transbeli = '" & txt_kdtrans.Text & "' "
            datatrans = proses.ExecuteQuery(sql)
        Catch ex As Exception
            MsgBox("Gagal Menampilkan Detail Pembelian", MsgBoxStyle.Critical, "Pesan")
            Exit Sub
        End Try
        If datatrans.Rows.Count > 0 Then
            DG_Transbeli.DataSource = datatrans
            With DG_Transbeli
                .Columns(0).HeaderText = "Kode Barang"
                .Columns(1).HeaderText = "Nama"
                .Columns(2).HeaderText = "Harga Beli"
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
            txt_totalitem.Text = DG_Transbeli.RowCount.ToString
            For i As Integer = 0 To DG_Transbeli.RowCount - 1
                total += DG_Transbeli.Rows(i).Cells(4).Value
            Next
            L_Total.Text = Format(Val(total.ToString), "Rp, ###,##")

        End If
    End Sub
    Private Sub txt_kdbarang_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kdbarang.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_nama.Focus()
        End If
    End Sub
    Sub simpan()
        If Not (txt_kdtrans.Text = "") Then
            sql = "SELECT kode_transbeli FROM tbl_pembelian WHERE kode_transbeli = '" & txt_kdtrans.Text & "'"
            datatrans = proses.ExecuteQuery(sql)
            'MsgBox(datatrans.Rows.Count)
            If (datatrans.Rows.Count) <= 0 Then
                sql = "INSERT INTO tbl_pembelian (kode_transbeli, tanggal_transaksi, username, kode_supplier) VALUES ('" & txt_kdtrans.Text & "','" & tgl_trans.Text & "', '" & txt_kasir.Text & "','" & txt_kdsup.Text & "')"
                proses.ExecuteNonQuery(sql)
                'MsgBox(sql)
            End If
            datatrans = Nothing
            sql = Nothing
        End If
    End Sub
    Private Sub ProsesSimpanHandle(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nama.KeyPress, txt_hargabeli.KeyPress, txt_qty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If (txt_kdbarang.Text = "" Or txt_nama.Text = "" Or txt_qty.Text = "" Or txt_hargabeli.Text = "") Then
                MsgBox("Data barang belum lengkap", MsgBoxStyle.Information, "Pesan")
            Else
                Try
                    sql = "INSERT INTO tbl_barang (kode_barang, nama, harga_beli, harga_jual, stok, kode_supplier, merk, jenis) VALUES ('" & txt_kdbarang.Text & "','" & txt_nama.Text & "', " & txt_hargabeli.Text & "," & txt_hargajual.Text & "," & txt_qty.Text & ",'" & txt_kdsup.Text & "','" & txt_merkbrg.Text & "','" & txt_jenisbrng.Text & "')"
                    proses.ExecuteNonQuery(sql)
                    'MsgBox(sql)
                    sql = "INSERT INTO tbl_pembeliandetail (kode_transbeli,kode_barang,qty) VALUES ('" & txt_kdtrans.Text & "','" & txt_kdbarang.Text & "', " & txt_qty.Text & ") "
                    proses.ExecuteNonQuery(sql)
                    'MsgBox(sql)
                    Call simpan()

                    Call data_barang()

                    Call Kode_Otomatis_BRN()
                    txt_nama.Clear()
                    txt_hargabeli.Clear()
                    txt_hargajual.Clear()
                    txt_qty.Clear()
                    txt_subtotal.Clear()
                    txt_merkbrg.Clear()
                    txt_jenisbrng.Clear()


                    txt_kdbarang.Focus()
                Catch ex As Exception
                    MsgBox("Kode Error Di SubProsesHandle : " + sql, MsgBoxStyle.Critical, "Pesan Kesalahan")
                End Try
            End If
        End If
    End Sub
    Private Sub txt_qty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_qty.TextChanged
        If (Val(txt_hargabeli.Text) > 0 And Val(Val(txt_qty.Text))) Then
            txt_subtotal.Text = Val(txt_qty.Text) * Val(txt_hargabeli.Text)
        End If
    End Sub

    Private Sub txt_kdtrans_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kdtrans.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Kode_Otomatis()
            txt_kdsup.Focus()
        End If
    End Sub

    Private Sub txt_nama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nama.TextChanged
        If txt_kdbarang.Text = "" Then
            Call Kode_Otomatis_BRN()
        End If
    End Sub

    Private Sub txt_kdtrans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_kdtrans.TextChanged
        Call data_barang()
    End Sub

 
    Private Sub Form_TransPembelian_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave

    End Sub

    
    Private Sub b_tambahh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_tambahh.Click
        Call normal()

    End Sub
End Class