Public Class Form_CariSupplier
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datasupplier As DataTable

    Sub normal() ' normal berarti kembali ke kondisi dmn form pertama kali dibuka
        Call bersih()

        txt_pencarian.Focus()
        B_Keluar.Enabled = True
        
    End Sub
    Sub bersih()
        sql = Nothing
        txt_pencarian.Clear()
        
    End Sub
    Sub data_supplier(Optional ByVal kode As String = "Semuanya")
        If (kode = "Semuanya" Or txt_pencarian.Text = "") Then
            sql = "SELECT * FROM tbl_supplier ORDER BY nama_supplier ASC"
        Else
            sql = "SELECT * FROM tbl_supplier WHERE kode_supplier LIKE '" & kode & "' OR nama_supplier LIKE '" & kode & "' ORDER BY nama_supplier ASC"
        End If
        datasupplier = proses.ExecuteQuery(sql)
        'If datasupplier.Rows.Count > 0 Then
        DG_supplier.DataSource = datasupplier
        With DG_supplier
            .Columns("nama_supplier").Width = "150"
        End With
        'End If
    End Sub
    Private Sub Form_supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call normal()
        Call data_supplier()

    End Sub
    Sub simpan()
        ' MsgBox("Data supplier berhasil di simpan", MsgBoxStyle.OkOnly, "Pesan")
        If DG_supplier.Rows.Count <= 0 Then
            MsgBox("Data Kosong")
            Exit Sub
        End If
            Form_TransPembelian.txt_kdsup.Text = DG_Supplier.SelectedCells(0).Value.ToString
        Call bersih()
        Call data_supplier()

        proses.CloseConn()
        Call Form_TransPembelian.cari_supplier()
        Me.Close()
    End Sub
    Private Sub B_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Keluar.Click
        Call normal()
        proses.CloseConn()

        Me.Close()
    End Sub


    Private Sub txt_pencarian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pencarian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call data_supplier(txt_pencarian.Text)
        End If
    End Sub

    Private Sub DG_supplier_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_supplier.CellDoubleClick
        Call simpan()

    End Sub

    Private Sub B_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call simpan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call data_supplier(txt_pencarian.Text)
    End Sub
End Class
