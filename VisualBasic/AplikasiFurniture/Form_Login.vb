Public Class Form_Login
    Dim tblogin As DataTable
    Dim proses As New clskoneksi
    Dim sql As String

    Sub bersih()
        txt_username.Clear()
        txt_password.Clear()

        txt_username.Focus()

    End Sub
    Sub login()
        'function cek username & pasword
        If txt_username.Text = "" Then txt_username.Focus() : Exit Sub
        If txt_password.Text = "" Then txt_password.Focus() : Exit Sub
        sql = "SELECT * FROM tbl_pengguna WHERE username = '" & txt_username.Text & "' and pass ='" & txt_password.Text & "'"
        '
        tblogin = proses.ExecuteQuery(sql)
        If tblogin.Rows.Count = 0 Then 'kalau username tidak ditemukan dlm database 
            MsgBox("Login tidak berhasil..", MsgBoxStyle.OkOnly, "Pesan")
            txt_username.Focus()
        Else
            Me.Hide()
            Form_Menu.ToolStripStatusLabel3.Text = tblogin.Rows(0).Item("username").ToString
            Form_Menu.ToolStripStatusLabel2.Text = tblogin.Rows(0).Item("status").ToString & " : "
            Call Form_Menu.aktif()
            If (tblogin.Rows(0).Item("status").ToString = "User") Then
                With Form_Menu
                    .DataBarangToolStripMenuItem.Enabled = False
                    .DataKaryawanToolStripMenuItem.Enabled = False
                End With
            End If
            Form_Menu.Show()
        End If
    End Sub
   
    Private Sub txt_username_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_username.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            Call login()
        End If
    End Sub

    Private Sub txt_password_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_password.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            Call login()
        End If
    End Sub

    Private Sub b_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_keluar.Click
        Dim pesan = DialogResult
        pesan = MessageBox.Show("Apakah anda ingin keluar ? ", "Pertanyaan", MessageBoxButtons.YesNo)
        If pesan = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Call bersih()
        End If

    End Sub

    Private Sub b_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_login.Click
        Call login()
    End Sub

    Private Sub Form_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
    End Sub
End Class