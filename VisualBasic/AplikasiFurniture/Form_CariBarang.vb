Public Class Form_CariBarang
    Dim sql As String
    Dim proses As New clskoneksi
    Dim databarang As DataTable

    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()

        txt_pencarian.Focus()
        B_Keluar.Enabled = True
        B_Tambah.Enabled = True

    End Sub
    Sub bersih()
        sql = Nothing
        txt_pencarian.Clear()
        B_Tambah.Text = "&Tambah"

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
            .Columns("nama").Width = "150"
        End With
        'End If
    End Sub
    Private Sub Form_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_barang()

    End Sub
    Sub simpan()
        ' MsgBox("Data barang berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
        If DG_Barang.Rows.Count <= 0 Then
            MsgBox("Data Kosong")
            Exit Sub
        End If
        Form_TransPenjualan.txt_kdbarang.Text = DG_Barang.SelectedCells(0).Value.ToString
        Call bersih()
        Call data_barang()
        B_Tambah.Text = "&Simpan"
        
        proses.CloseConn()
        Call Form_TransPenjualan.cari_databarang()
        Me.Close()
    End Sub
    Private Sub B_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()
    End Sub


    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_barang(txt_pencarian.Text)
        End If
    End Sub

    Private Sub DG_Barang_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Barang.CellDoubleClick
        Call simpan()

    End Sub

    Private Sub B_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Tambah.Click
        Call simpan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call data_barang(txt_pencarian.Text)
    End Sub
End Class
