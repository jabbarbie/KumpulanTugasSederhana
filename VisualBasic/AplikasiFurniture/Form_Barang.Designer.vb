<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Barang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_dibeli = New System.Windows.Forms.TextBox
        Me.txt_merk = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_stok = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_hargajual = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_pencarian = New System.Windows.Forms.TextBox
        Me.txt_jenis = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_namabarang = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_kodebarang = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_hargabeli = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.B_Edit = New System.Windows.Forms.Button
        Me.DG_Barang = New System.Windows.Forms.DataGridView
        Me.B_Tambah = New System.Windows.Forms.Button
        Me.B_Keluar = New System.Windows.Forms.Button
        Me.B_Batal = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.B_Hapus = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_stok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_dibeli)
        Me.GroupBox1.Controls.Add(Me.txt_merk)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_stok)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_hargajual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_jenis)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_namabarang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_kodebarang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_hargabeli)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dibeli"
        '
        'txt_dibeli
        '
        Me.txt_dibeli.Enabled = False
        Me.txt_dibeli.Location = New System.Drawing.Point(455, 213)
        Me.txt_dibeli.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_dibeli.Name = "txt_dibeli"
        Me.txt_dibeli.Size = New System.Drawing.Size(117, 26)
        Me.txt_dibeli.TabIndex = 16
        '
        'txt_merk
        '
        Me.txt_merk.Location = New System.Drawing.Point(169, 216)
        Me.txt_merk.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_merk.Name = "txt_merk"
        Me.txt_merk.Size = New System.Drawing.Size(155, 26)
        Me.txt_merk.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Merk Barang"
        '
        'txt_stok
        '
        Me.txt_stok.Location = New System.Drawing.Point(455, 168)
        Me.txt_stok.Name = "txt_stok"
        Me.txt_stok.Size = New System.Drawing.Size(49, 26)
        Me.txt_stok.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Stok"
        '
        'txt_hargajual
        '
        Me.txt_hargajual.Location = New System.Drawing.Point(169, 171)
        Me.txt_hargajual.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_hargajual.Name = "txt_hargajual"
        Me.txt_hargajual.Size = New System.Drawing.Size(155, 26)
        Me.txt_hargajual.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Harga Jual"
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
        'txt_jenis
        '
        Me.txt_jenis.Location = New System.Drawing.Point(455, 126)
        Me.txt_jenis.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_jenis.Name = "txt_jenis"
        Me.txt_jenis.Size = New System.Drawing.Size(117, 26)
        Me.txt_jenis.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis"
        '
        'txt_namabarang
        '
        Me.txt_namabarang.Location = New System.Drawing.Point(169, 80)
        Me.txt_namabarang.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_namabarang.Name = "txt_namabarang"
        Me.txt_namabarang.Size = New System.Drawing.Size(155, 26)
        Me.txt_namabarang.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'txt_kodebarang
        '
        Me.txt_kodebarang.Enabled = False
        Me.txt_kodebarang.Location = New System.Drawing.Point(169, 34)
        Me.txt_kodebarang.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_kodebarang.Name = "txt_kodebarang"
        Me.txt_kodebarang.Size = New System.Drawing.Size(117, 26)
        Me.txt_kodebarang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'txt_hargabeli
        '
        Me.txt_hargabeli.Location = New System.Drawing.Point(169, 123)
        Me.txt_hargabeli.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_hargabeli.Name = "txt_hargabeli"
        Me.txt_hargabeli.Size = New System.Drawing.Size(155, 26)
        Me.txt_hargabeli.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Harga Beli"
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
        Me.B_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Edit.UseVisualStyleBackColor = False
        '
        'DG_Barang
        '
        Me.DG_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Barang.Location = New System.Drawing.Point(16, 324)
        Me.DG_Barang.Name = "DG_Barang"
        Me.DG_Barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Barang.Size = New System.Drawing.Size(654, 107)
        Me.DG_Barang.TabIndex = 50
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
        Me.B_Tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.B_Keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.B_Batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Batal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "DATA BARANG"
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
        Me.B_Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.B_Hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Hapus.UseVisualStyleBackColor = False
        '
        'Form_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.B_Keluar
        Me.ClientSize = New System.Drawing.Size(685, 499)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.B_Edit)
        Me.Controls.Add(Me.DG_Barang)
        Me.Controls.Add(Me.B_Tambah)
        Me.Controls.Add(Me.B_Keluar)
        Me.Controls.Add(Me.B_Batal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_Hapus)
        Me.Name = "Form_Barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_stok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_stok As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_hargajual As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents txt_jenis As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_namabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_kodebarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_hargabeli As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents B_Edit As System.Windows.Forms.Button
    Friend WithEvents DG_Barang As System.Windows.Forms.DataGridView
    Friend WithEvents B_Tambah As System.Windows.Forms.Button
    Friend WithEvents B_Keluar As System.Windows.Forms.Button
    Friend WithEvents B_Batal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B_Hapus As System.Windows.Forms.Button
    Friend WithEvents txt_merk As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_dibeli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
