<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Karyawan))
        Me.Label5 = New System.Windows.Forms.Label
        Me.b_tambah = New System.Windows.Forms.Button
        Me.b_batal = New System.Windows.Forms.Button
        Me.b_edit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.b_cari = New System.Windows.Forms.Button
        Me.txt_pencarian = New System.Windows.Forms.TextBox
        Me.b_keluar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cb_jk = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tgl_lahir = New System.Windows.Forms.DateTimePicker
        Me.txt_tempatlahir = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cb_jabatan = New System.Windows.Forms.ComboBox
        Me.txt_alamat = New System.Windows.Forms.TextBox
        Me.txt_notelp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_nama = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nik = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DG_Karyawan = New System.Windows.Forms.DataGridView
        Me.b_hapus = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Karyawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Alamat"
        '
        'b_tambah
        '
        Me.b_tambah.BackColor = System.Drawing.Color.Thistle
        Me.b_tambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_tambah.Image = CType(resources.GetObject("b_tambah.Image"), System.Drawing.Image)
        Me.b_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_tambah.Location = New System.Drawing.Point(20, 469)
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
        Me.b_batal.Location = New System.Drawing.Point(469, 469)
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
        Me.b_edit.Location = New System.Drawing.Point(128, 469)
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
        Me.b_cari.Location = New System.Drawing.Point(188, 30)
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
        Me.b_keluar.Location = New System.Drawing.Point(576, 469)
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
        Me.GroupBox1.Controls.Add(Me.cb_jk)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tgl_lahir)
        Me.GroupBox1.Controls.Add(Me.txt_tempatlahir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cb_jabatan)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_notelp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nik)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(654, 286)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Karyawan"
        '
        'cb_jk
        '
        Me.cb_jk.FormattingEnabled = True
        Me.cb_jk.Items.AddRange(New Object() {"L", "P"})
        Me.cb_jk.Location = New System.Drawing.Point(171, 220)
        Me.cb_jk.Name = "cb_jk"
        Me.cb_jk.Size = New System.Drawing.Size(121, 28)
        Me.cb_jk.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Jenis Kelamin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Tanggal Lahir"
        '
        'tgl_lahir
        '
        Me.tgl_lahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl_lahir.Location = New System.Drawing.Point(461, 136)
        Me.tgl_lahir.Name = "tgl_lahir"
        Me.tgl_lahir.Size = New System.Drawing.Size(102, 26)
        Me.tgl_lahir.TabIndex = 14
        '
        'txt_tempatlahir
        '
        Me.txt_tempatlahir.Location = New System.Drawing.Point(461, 98)
        Me.txt_tempatlahir.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_tempatlahir.Name = "txt_tempatlahir"
        Me.txt_tempatlahir.Size = New System.Drawing.Size(121, 26)
        Me.txt_tempatlahir.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(350, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tempat Lahir"
        '
        'cb_jabatan
        '
        Me.cb_jabatan.FormattingEnabled = True
        Me.cb_jabatan.Items.AddRange(New Object() {"Kasir", "Admin"})
        Me.cb_jabatan.Location = New System.Drawing.Point(171, 179)
        Me.cb_jabatan.Name = "cb_jabatan"
        Me.cb_jabatan.Size = New System.Drawing.Size(121, 28)
        Me.cb_jabatan.TabIndex = 4
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(461, 183)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(187, 76)
        Me.txt_alamat.TabIndex = 5
        '
        'txt_notelp
        '
        Me.txt_notelp.Location = New System.Drawing.Point(169, 139)
        Me.txt_notelp.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_notelp.Name = "txt_notelp"
        Me.txt_notelp.Size = New System.Drawing.Size(155, 26)
        Me.txt_notelp.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "No. Telp"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(169, 93)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(155, 26)
        Me.txt_nama.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Karyawan"
        '
        'txt_nik
        '
        Me.txt_nik.Enabled = False
        Me.txt_nik.Location = New System.Drawing.Point(169, 43)
        Me.txt_nik.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_nik.Name = "txt_nik"
        Me.txt_nik.Size = New System.Drawing.Size(155, 26)
        Me.txt_nik.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Karyawan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Jabatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(264, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "DATA KARYAWAN"
        '
        'DG_Karyawan
        '
        Me.DG_Karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Karyawan.Location = New System.Drawing.Point(17, 341)
        Me.DG_Karyawan.Name = "DG_Karyawan"
        Me.DG_Karyawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Karyawan.Size = New System.Drawing.Size(654, 108)
        Me.DG_Karyawan.TabIndex = 48
        '
        'b_hapus
        '
        Me.b_hapus.BackColor = System.Drawing.Color.Thistle
        Me.b_hapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_hapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_hapus.Image = CType(resources.GetObject("b_hapus.Image"), System.Drawing.Image)
        Me.b_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_hapus.Location = New System.Drawing.Point(231, 469)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(101, 43)
        Me.b_hapus.TabIndex = 49
        Me.b_hapus.Text = "&Hapus"
        Me.b_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_hapus.UseVisualStyleBackColor = False
        '
        'Form_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 524)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.DG_Karyawan)
        Me.Controls.Add(Me.b_tambah)
        Me.Controls.Add(Me.b_batal)
        Me.Controls.Add(Me.b_edit)
        Me.Controls.Add(Me.b_keluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form_Karyawan"
        Me.Text = "Form_DataPengguna"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Karyawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents b_tambah As System.Windows.Forms.Button
    Friend WithEvents b_batal As System.Windows.Forms.Button
    Friend WithEvents b_edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents b_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_notelp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DG_Karyawan As System.Windows.Forms.DataGridView
    Friend WithEvents txt_alamat As System.Windows.Forms.TextBox
    Friend WithEvents cb_jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents b_cari As System.Windows.Forms.Button
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents txt_tempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tgl_lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cb_jk As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
