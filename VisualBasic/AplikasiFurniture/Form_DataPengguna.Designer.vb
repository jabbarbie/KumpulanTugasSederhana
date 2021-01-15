<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_DataPengguna
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DataPengguna))
        Me.b_tambah = New System.Windows.Forms.Button
        Me.b_batal = New System.Windows.Forms.Button
        Me.b_edit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.b_cari = New System.Windows.Forms.Button
        Me.txt_pencarian = New System.Windows.Forms.TextBox
        Me.b_keluar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_nama = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cb_status = New System.Windows.Forms.ComboBox
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_nik = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_username = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DG_Pengguna = New System.Windows.Forms.DataGridView
        Me.b_hapus = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Pengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_tambah
        '
        Me.b_tambah.BackColor = System.Drawing.Color.Thistle
        Me.b_tambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_tambah.Image = CType(resources.GetObject("b_tambah.Image"), System.Drawing.Image)
        Me.b_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_tambah.Location = New System.Drawing.Point(20, 430)
        Me.b_tambah.Name = "b_tambah"
        Me.b_tambah.Size = New System.Drawing.Size(101, 43)
        Me.b_tambah.TabIndex = 43
        Me.b_tambah.Text = "&Tambah"
        Me.b_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_tambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_tambah.UseVisualStyleBackColor = False
        '
        'b_batal
        '
        Me.b_batal.BackColor = System.Drawing.Color.Thistle
        Me.b_batal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_batal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_batal.Image = CType(resources.GetObject("b_batal.Image"), System.Drawing.Image)
        Me.b_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_batal.Location = New System.Drawing.Point(472, 430)
        Me.b_batal.Name = "b_batal"
        Me.b_batal.Size = New System.Drawing.Size(101, 43)
        Me.b_batal.TabIndex = 46
        Me.b_batal.Text = "Batal"
        Me.b_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_batal.UseVisualStyleBackColor = False
        '
        'b_edit
        '
        Me.b_edit.BackColor = System.Drawing.Color.Thistle
        Me.b_edit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_edit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_edit.Image = CType(resources.GetObject("b_edit.Image"), System.Drawing.Image)
        Me.b_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_edit.Location = New System.Drawing.Point(128, 430)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(97, 43)
        Me.b_edit.TabIndex = 44
        Me.b_edit.Text = "&Edit"
        Me.b_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_edit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.b_cari)
        Me.GroupBox2.Controls.Add(Me.txt_pencarian)
        Me.GroupBox2.Location = New System.Drawing.Point(344, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 72)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'b_cari
        '
        Me.b_cari.Location = New System.Drawing.Point(188, 29)
        Me.b_cari.Name = "b_cari"
        Me.b_cari.Size = New System.Drawing.Size(75, 31)
        Me.b_cari.TabIndex = 3
        Me.b_cari.Text = "Cari"
        Me.b_cari.UseVisualStyleBackColor = True
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(20, 30)
        Me.txt_pencarian.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(155, 26)
        Me.txt_pencarian.TabIndex = 7
        '
        'b_keluar
        '
        Me.b_keluar.BackColor = System.Drawing.Color.Thistle
        Me.b_keluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_keluar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_keluar.Image = CType(resources.GetObject("b_keluar.Image"), System.Drawing.Image)
        Me.b_keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_keluar.Location = New System.Drawing.Point(579, 430)
        Me.b_keluar.Name = "b_keluar"
        Me.b_keluar.Size = New System.Drawing.Size(92, 43)
        Me.b_keluar.TabIndex = 47
        Me.b_keluar.Text = "Keluar"
        Me.b_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_keluar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_status)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nik)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(654, 238)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pengguna"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(169, 145)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(155, 26)
        Me.txt_nama.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nama"
        '
        'cb_status
        '
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"User", "Admin"})
        Me.cb_status.Location = New System.Drawing.Point(486, 102)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(121, 28)
        Me.cb_status.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(169, 191)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(155, 26)
        Me.txt_password.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password"
        '
        'txt_nik
        '
        Me.txt_nik.Location = New System.Drawing.Point(169, 93)
        Me.txt_nik.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_nik.Name = "txt_nik"
        Me.txt_nik.Size = New System.Drawing.Size(155, 26)
        Me.txt_nik.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIK"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(169, 47)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(155, 26)
        Me.txt_username.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "DATA PENGGUNA"
        '
        'DG_Pengguna
        '
        Me.DG_Pengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Pengguna.Location = New System.Drawing.Point(17, 302)
        Me.DG_Pengguna.Name = "DG_Pengguna"
        Me.DG_Pengguna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Pengguna.Size = New System.Drawing.Size(654, 108)
        Me.DG_Pengguna.TabIndex = 48
        '
        'b_hapus
        '
        Me.b_hapus.BackColor = System.Drawing.Color.Thistle
        Me.b_hapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_hapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_hapus.Image = CType(resources.GetObject("b_hapus.Image"), System.Drawing.Image)
        Me.b_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_hapus.Location = New System.Drawing.Point(231, 430)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(101, 43)
        Me.b_hapus.TabIndex = 49
        Me.b_hapus.Text = "&Hapus"
        Me.b_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_hapus.UseVisualStyleBackColor = False
        '
        'Form_DataPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 486)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.DG_Pengguna)
        Me.Controls.Add(Me.b_tambah)
        Me.Controls.Add(Me.b_batal)
        Me.Controls.Add(Me.b_edit)
        Me.Controls.Add(Me.b_keluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form_DataPengguna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Pengguna"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Pengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_tambah As System.Windows.Forms.Button
    Friend WithEvents b_batal As System.Windows.Forms.Button
    Friend WithEvents b_edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents b_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nik As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DG_Pengguna As System.Windows.Forms.DataGridView
    Friend WithEvents cb_status As System.Windows.Forms.ComboBox
    Friend WithEvents b_cari As System.Windows.Forms.Button
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
