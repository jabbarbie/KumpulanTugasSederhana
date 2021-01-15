Public Class Form_Menu
    Sub aktif()
        DataBarangToolStripMenuItem.Enabled = True
        DataPenggunaToolStripMenuItem.Enabled = True
        DataSupplierToolStripMenuItem.Enabled = True
        PembelianToolStripMenuItem.Enabled = True
        DataKaryawanToolStripMenuItem.Enabled = True
    End Sub
    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Data Barang"
        Form_Barang.ShowDialog()
    End Sub

    Private Sub DataPenggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenggunaToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Data Pengguna"
        Form_DataPengguna.ShowDialog()

    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSupplierToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Data Supplier"
        Form_Supplier.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Login"
        Form_Login.ShowDialog()
        'Application.Exit()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Transaksi Pembelian"
        Form_TransPembelian.txt_kasir.Text = Me.ToolStripStatusLabel3.Text
        Form_TransPembelian.ShowDialog()
    End Sub

    Private Sub Form_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel8.Text = Format(Now, "dd - MMMM - yyyy")
        If (ToolStripStatusLabel3.Text = "Login") Then
            Me.ToolStripStatusLabel6.Text = "Form Login"
            Form_Login.ShowDialog()

        End If
    End Sub

    Private Sub DataCostumerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataCostumerToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Data Konsumen"
        Form_DataKonsumen.ShowDialog()
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        'Me.ToolStripStatusLabel6.Text = "Form Data Karyawan"
        Form_Karyawan.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Transaksi Penjualan"
        Form_TransPenjualan.txt_kasir.Text = Me.ToolStripStatusLabel3.Text
        Form_TransPenjualan.ShowDialog()
    End Sub

    Private Sub DataBarangToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem1.Click
        Me.ToolStripStatusLabel6.Text = "Form Cetak Data Barang"
        Form_S_DataBarang.ShowDialog()
    End Sub

    Private Sub DataSupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSupplierToolStripMenuItem1.Click
        Me.ToolStripStatusLabel6.Text = "Form Cetak Data Supplier"
        Form_V_DataSupplier.ShowDialog()
    End Sub

    Private Sub GrafikPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrafikPenjualanToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Cetak Grafik Penjualan"
        Form_V_Grafik.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem1.Click
        Me.ToolStripStatusLabel6.Text = "Form Cetak Transaksi Penjualan"
        Form_S_Penjualan.ShowDialog()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem1.Click
        Me.ToolStripStatusLabel6.Text = "Form Cetak Transaksi Pembelian"
        Form_S_Pembelian.ShowDialog()
    End Sub

    Private Sub ProfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfilToolStripMenuItem.Click
        Me.ToolStripStatusLabel6.Text = "Form Profil"
        Form_Profil.ShowDialog()
    End Sub

    Private Sub Form_Menu_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.ToolStripStatusLabel6.Text = "Form Menu"
    End Sub

    Private Sub PenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggajianToolStripMenuItem.Click
        Form_Penggajian.ShowDialog()
    End Sub

    Private Sub KeuanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeuanganToolStripMenuItem.Click
        Form_S_Keuntungan.ShowDialog()
    End Sub

    Private Sub PenggajianToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggajianToolStripMenuItem1.Click
        Form_S_Penggajian.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStripStatusLabel8.Text = Format(Now, "dddd, dd mmmm yyyy - hh:mm:ss")
    End Sub

    Private Sub GrafikPenjualanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrafikPenjualanToolStripMenuItem1.Click
        Form_V_GrafikPenjualan4.ShowDialog()
    End Sub
End Class