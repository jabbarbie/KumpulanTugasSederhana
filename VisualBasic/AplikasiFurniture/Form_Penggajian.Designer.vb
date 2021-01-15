<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Penggajian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Penggajian))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tgl_input = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_gajipokok = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_pencarian = New System.Windows.Forms.TextBox
        Me.txt_namakaryawan = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nik = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_jabatan = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.B_Edit = New System.Windows.Forms.Button
        Me.DG_Penggajijan = New System.Windows.Forms.DataGridView
        Me.B_Tambah = New System.Windows.Forms.Button
        Me.B_Keluar = New System.Windows.Forms.Button
        Me.B_Batal = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.B_Hapus = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Penggajijan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tgl_input)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_gajipokok)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_namakaryawan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nik)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_jabatan)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(654, 263)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Tanggal Input"
        '
        'tgl_input
        '
        Me.tgl_input.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl_input.Location = New System.Drawing.Point(514, 126)
        Me.tgl_input.Name = "tgl_input"
        Me.tgl_input.Size = New System.Drawing.Size(116, 26)
        Me.tgl_input.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Gaji Pokok"
        '
        'txt_gajipokok
        '
        Me.txt_gajipokok.Enabled = False
        Me.txt_gajipokok.Location = New System.Drawing.Point(169, 182)
        Me.txt_gajipokok.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_gajipokok.Name = "txt_gajipokok"
        Me.txt_gajipokok.Size = New System.Drawing.Size(117, 26)
        Me.txt_gajipokok.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_pencarian)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 84)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(23, 35)
        Me.txt_pencarian.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(155, 26)
        Me.txt_pencarian.TabIndex = 2
        '
        'txt_namakaryawan
        '
        Me.txt_namakaryawan.Enabled = False
        Me.txt_namakaryawan.Location = New System.Drawing.Point(169, 80)
        Me.txt_namakaryawan.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_namakaryawan.Name = "txt_namakaryawan"
        Me.txt_namakaryawan.Size = New System.Drawing.Size(155, 26)
        Me.txt_namakaryawan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Karyawan"
        '
        'txt_nik
        '
        Me.txt_nik.Enabled = False
        Me.txt_nik.Location = New System.Drawing.Point(169, 34)
        Me.txt_nik.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_nik.Name = "txt_nik"
        Me.txt_nik.Size = New System.Drawing.Size(117, 26)
        Me.txt_nik.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'txt_jabatan
        '
        Me.txt_jabatan.Enabled = False
        Me.txt_jabatan.Location = New System.Drawing.Point(169, 123)
        Me.txt_jabatan.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_jabatan.Name = "txt_jabatan"
        Me.txt_jabatan.Size = New System.Drawing.Size(155, 26)
        Me.txt_jabatan.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Jabatan"
        '
        'B_Edit
        '
        Me.B_Edit.BackColor = System.Drawing.Color.Thistle
        Me.B_Edit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Edit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.B_Edit.Image = CType(resources.GetObject("B_Edit.Image"), System.Drawing.Image)
        Me.B_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Edit.Location = New System.Drawing.Point(126, 449)
        Me.B_Edit.Name = "B_Edit"
        Me.B_Edit.Size = New System.Drawing.Size(97, 43)
        Me.B_Edit.TabIndex = 7
        Me.B_Edit.Text = "Edit"
        Me.B_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Edit.UseVisualStyleBackColor = False
        '
        'DG_Penggajijan
        '
        Me.DG_Penggajijan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Penggajijan.Location = New System.Drawing.Point(16, 324)
        Me.DG_Penggajijan.Name = "DG_Penggajijan"
        Me.DG_Penggajijan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Penggajijan.Size = New System.Drawing.Size(654, 107)
        Me.DG_Penggajijan.TabIndex = 50
        '
        'B_Tambah
        '
        Me.B_Tambah.BackColor = System.Drawing.Color.Thistle
        Me.B_Tambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Tambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.B_Tambah.Image = CType(resources.GetObject("B_Tambah.Image"), System.Drawing.Image)
        Me.B_Tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Tambah.Location = New System.Drawing.Point(16, 449)
        Me.B_Tambah.Name = "B_Tambah"
        Me.B_Tambah.Size = New System.Drawing.Size(101, 43)
        Me.B_Tambah.TabIndex = 6
        Me.B_Tambah.Text = "&Tambah"
        Me.B_Tambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Tambah.UseVisualStyleBackColor = False
        '
        'B_Keluar
        '
        Me.B_Keluar.BackColor = System.Drawing.Color.Thistle
        Me.B_Keluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_Keluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Keluar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.B_Keluar.Image = CType(resources.GetObject("B_Keluar.Image"), System.Drawing.Image)
        Me.B_Keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Keluar.Location = New System.Drawing.Point(578, 449)
        Me.B_Keluar.Name = "B_Keluar"
        Me.B_Keluar.Size = New System.Drawing.Size(92, 43)
        Me.B_Keluar.TabIndex = 49
        Me.B_Keluar.Text = "Keluar"
        Me.B_Keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Keluar.UseVisualStyleBackColor = False
        '
        'B_Batal
        '
        Me.B_Batal.BackColor = System.Drawing.Color.Thistle
        Me.B_Batal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Batal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.B_Batal.Image = CType(resources.GetObject("B_Batal.Image"), System.Drawing.Image)
        Me.B_Batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Batal.Location = New System.Drawing.Point(462, 449)
        Me.B_Batal.Name = "B_Batal"
        Me.B_Batal.Size = New System.Drawing.Size(101, 43)
        Me.B_Batal.TabIndex = 48
        Me.B_Batal.Text = "Batal"
        Me.B_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Batal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "DATA PENGGAJIAN"
        '
        'B_Hapus
        '
        Me.B_Hapus.BackColor = System.Drawing.Color.Thistle
        Me.B_Hapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Hapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.B_Hapus.Image = CType(resources.GetObject("B_Hapus.Image"), System.Drawing.Image)
        Me.B_Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Hapus.Location = New System.Drawing.Point(229, 449)
        Me.B_Hapus.Name = "B_Hapus"
        Me.B_Hapus.Size = New System.Drawing.Size(97, 43)
        Me.B_Hapus.TabIndex = 8
        Me.B_Hapus.Text = "&Hapus"
        Me.B_Hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Hapus.UseVisualStyleBackColor = False
        '
        'Form_Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.B_Keluar
        Me.ClientSize = New System.Drawing.Size(685, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.B_Edit)
        Me.Controls.Add(Me.DG_Penggajijan)
        Me.Controls.Add(Me.B_Tambah)
        Me.Controls.Add(Me.B_Keluar)
        Me.Controls.Add(Me.B_Batal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_Hapus)
        Me.Name = "Form_Penggajian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Penggajian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_Penggajijan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents txt_namakaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_jabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents B_Edit As System.Windows.Forms.Button
    Friend WithEvents DG_Penggajijan As System.Windows.Forms.DataGridView
    Friend WithEvents B_Tambah As System.Windows.Forms.Button
    Friend WithEvents B_Keluar As System.Windows.Forms.Button
    Friend WithEvents B_Batal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B_Hapus As System.Windows.Forms.Button
    Friend WithEvents txt_gajipokok As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tgl_input As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
