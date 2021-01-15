Public Class Form_CariKonsumen
    Dim sql As String
    Dim proses As New clskoneksi
    Dim dataKonsumen As DataTable

    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()

        txt_pencarian.Focus()
        B_Keluar.Enabled = True

    End Sub
    Sub bersih()
        sql = Nothing
        txt_pencarian.Clear()

    End Sub
    Sub data_Konsumen(Optional ByVal kode As String = "Semuanya")
        If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
            sql = "SELECT * FROM tbl_konsumen ORDER BY nama_konsumen ASC"
        Else
            sql = "SELECT * FROM tbl_konsumen WHERE kode_konsumen LIKE '" & kode & "' OR nama_konsumen LIKE '" & kode & "' ORDER BY nama_konsumen ASC"
        End If
        dataKonsumen = proses.ExecuteQuery(sql)
        'If dataKonsumen.Rows.Count > 0 Then
        DG_Konsumen.DataSource = dataKonsumen
        With DG_Konsumen
            .Columns("nama_konsumen").Width = "150"
        End With
        'End If
    End Sub
    Private Sub Form_Konsumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_Konsumen()

    End Sub
    Sub simpan()
        ' MsgBox("Data Konsumen berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
        If DG_Konsumen.Rows.Count <= 0 Then
            MsgBox("Data Kosong")
            Exit Sub
        End If
        Form_TransPenjualan.txt_kdkonsumen.Text = DG_Konsumen.SelectedCells(0).Value.ToString
        Call bersih()
        Call data_Konsumen()

        proses.CloseConn()
        Call Form_TransPenjualan.cari_datakonsumen()
        Me.Close()
    End Sub
    Private Sub B_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()
    End Sub


    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_Konsumen(txt_pencarian.Text)
        End If
    End Sub

    Private Sub DG_Konsumen_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Konsumen.CellDoubleClick
        Call simpan()

    End Sub

    Private Sub B_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call simpan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call data_Konsumen(txt_pencarian.Text)
    End Sub
End Class
