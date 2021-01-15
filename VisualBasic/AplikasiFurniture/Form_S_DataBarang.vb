Public Class Form_S_DataBarang
    Dim sql As String
    Dim proses As New clskoneksi
    Dim datasupplier As DataTable
    Sub tidak_aktif()
        cb_sup.Enabled = False
    End Sub
    Sub cek_radio()
        Call tidak_aktif()
        If (R_Semua.Checked = True) Then

        ElseIf (R_PerSupplier.Checked = True) Then
            cb_sup.Enabled = True
            sql = "SELECT * FROM tbl_supplier"
            datasupplier = proses.ExecuteQuery(sql)

            If (datasupplier.Rows.Count > 0) Then
                cb_sup.DataSource = datasupplier
                'cb_sup.DisplayMember = "kode_supplier"
                cb_sup.ValueMember = "kode_supplier"
                
            End If
        End If
    End Sub

    Private Sub b_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cetak.Click
        If (R_PerSupplier.Checked = True) Then
            Form_V_DataBarang.Label1.Text = " WHERE kode_supplier = '" & cb_sup.Text & "'"
            Form_V_DataBarang.Label2.Text = "CR_DataBarang_PerSupplier"
        Else
            Form_V_DataBarang.Label1.Text = ""
            Form_V_DataBarang.Label2.Text = "CR_DataBarang"
        End If

        Form_V_DataBarang.ShowDialog()


    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Me.Close()
    End Sub

    Private Sub R_PerSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_PerSupplier.CheckedChanged
        Call cek_radio()
    End Sub

    Private Sub R_Semua_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_Semua.CheckedChanged
        Call cek_radio()
    End Sub

    Private Sub Form_S_DataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class