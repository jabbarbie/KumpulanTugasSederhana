Public Class Form_S_Penggajian
    Sub tidak_aktif()
        tgl_dari.Enabled = False
        tgl_sampai.Enabled = False
        num_tahun.Enabled = False
    End Sub
    Sub cek_radio()
        Call tidak_aktif()
        If (R_PerPeriode.Checked = True) Then
            tgl_dari.Enabled = True
            tgl_sampai.Enabled = True
        ElseIf (R_PerTahun.Checked = True) Then
            num_tahun.Enabled = True
        End If
    End Sub
    Private Sub Form_LaporanPemasukanCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tidak_aktif()
        Call cek_radio()
    End Sub

    Private Sub b_cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_cetak.Click
        If (R_PerPeriode.Checked = True) Then
            Form_V_Penggajian.Label1.Text = "WHERE (tgl_input) BETWEEN #" & tgl_dari.Text & "# AND #" & tgl_sampai.Text & "#"
            Form_V_Penggajian.Label2.Text = "CR_Penggajian_PerPeriode"
        ElseIf (R_PerTahun.Checked = True) Then
            If num_tahun.Value <= 2010 Then
                MsgBox("Tahun tidak valid.. !", MsgBoxStyle.Critical, "Pesan")
                Exit Sub
            End If
            Form_V_Penggajian.Label1.Text = "WHERE (YEAR(tgl_input) = " & num_tahun.Value & ") "
            Form_V_Penggajian.Label2.Text = "CR_Penggajian_Pertahun"
        ElseIf (R_Semua.Checked = True) Then
            Form_V_Penggajian.Label1.Text = ""
            Form_V_Penggajian.Label2.Text = "CR_Penggajian"
        End If

        Form_V_Penggajian.ShowDialog()
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Me.Close()
    End Sub

    Private Sub R_PerPeriode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_PerPeriode.CheckedChanged
        Call cek_radio()
    End Sub

    Private Sub R_PerTahun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_PerTahun.CheckedChanged
        Call cek_radio()
    End Sub

    Private Sub R_Semua_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_Semua.CheckedChanged
        Call cek_radio()
    End Sub
End Class