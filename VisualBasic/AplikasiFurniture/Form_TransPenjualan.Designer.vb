<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TransPenjualan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TransPenjualan))
        Me.DG_Transjual = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_kdtrans = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.b_simpan = New System.Windows.Forms.Button
        Me.b_batal = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tgl_trans = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_kasir = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.b_kon = New System.Windows.Forms.Button
        Me.txt_alamatkon = New System.Windows.Forms.TextBox
        Me.txt_namakon = New System.Windows.Forms.TextBox
        Me.txt_kdkonsumen = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_kembali = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_dibayar = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.b_barang = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.b_hapus = New System.Windows.Forms.Button
        Me.txt_totalitem = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_jenisbrng = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_harga = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_subtotal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_qty = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_nama = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_kdbarang = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.L_Total = New System.Windows.Forms.TextBox
        CType(Me.DG_Transjual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Transjual
        '
        Me.DG_Transjual.AllowUserToAddRows = False
        Me.DG_Transjual.AllowUserToDeleteRows = False
        Me.DG_Transjual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Transjual.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Transjual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Transjual.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Transjual.Location = New System.Drawing.Point(15, 281)
        Me.DG_Transjual.Name = "DG_Transjual"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = "Rp. 0"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Transjual.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Transjual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Transjual.Size = New System.Drawing.Size(988, 189)
        Me.DG_Transjual.TabIndex = 230
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(520, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Tgl. Transaksi"
        '
        'txt_kdtrans
        '
        Me.txt_kdtrans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_kdtrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kdtrans.Location = New System.Drawing.Point(645, 19)
        Me.txt_kdtrans.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_kdtrans.Name = "txt_kdtrans"
        Me.txt_kdtrans.Size = New System.Drawing.Size(133, 22)
        Me.txt_kdtrans.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(520, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Kode Transaksi"
        '
        'b_simpan
        '
        Me.b_simpan.BackColor = System.Drawing.Color.Thistle
        Me.b_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_simpan.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_simpan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_simpan.Image = CType(resources.GetObject("b_simpan.Image"), System.Drawing.Image)
        Me.b_simpan.Location = New System.Drawing.Point(383, 26)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(93, 39)
        Me.b_simpan.TabIndex = 222
        Me.b_simpan.Text = "&Selesai"
        Me.b_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_simpan.UseVisualStyleBackColor = False
        '
        'b_batal
        '
        Me.b_batal.BackColor = System.Drawing.Color.Thistle
        Me.b_batal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_batal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_batal.Image = CType(resources.GetObject("b_batal.Image"), System.Drawing.Image)
        Me.b_batal.Location = New System.Drawing.Point(488, 26)
        Me.b_batal.Name = "b_batal"
        Me.b_batal.Size = New System.Drawing.Size(86, 39)
        Me.b_batal.TabIndex = 223
        Me.b_batal.Text = "Batal"
        Me.b_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_batal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(123, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 22)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Toko Furniture ""Raja Kasur"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Jl. Dipenogoro Palangka Raya"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(128, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Telp. 0856 763644"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'tgl_trans
        '
        Me.tgl_trans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_trans.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tgl_trans.Location = New System.Drawing.Point(645, 49)
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.Size = New System.Drawing.Size(135, 22)
        Me.tgl_trans.TabIndex = 154
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(814, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Kasir :"
        '
        'txt_kasir
        '
        Me.txt_kasir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_kasir.Enabled = False
        Me.txt_kasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kasir.Location = New System.Drawing.Point(881, 18)
        Me.txt_kasir.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_kasir.Name = "txt_kasir"
        Me.txt_kasir.Size = New System.Drawing.Size(103, 22)
        Me.txt_kasir.TabIndex = 157
        Me.txt_kasir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.b_kon)
        Me.GroupBox1.Controls.Add(Me.txt_alamatkon)
        Me.GroupBox1.Controls.Add(Me.txt_namakon)
        Me.GroupBox1.Controls.Add(Me.txt_kdkonsumen)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_kasir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tgl_trans)
        Me.GroupBox1.Controls.Add(Me.txt_kdtrans)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(994, 87)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        '
        'b_kon
        '
        Me.b_kon.Image = CType(resources.GetObject("b_kon.Image"), System.Drawing.Image)
        Me.b_kon.Location = New System.Drawing.Point(14, 48)
        Me.b_kon.Name = "b_kon"
        Me.b_kon.Size = New System.Drawing.Size(124, 23)
        Me.b_kon.TabIndex = 231
        Me.b_kon.Text = "Daftar Konsumen"
        Me.b_kon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_kon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_kon.UseVisualStyleBackColor = True
        '
        'txt_alamatkon
        '
        Me.txt_alamatkon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_alamatkon.Enabled = False
        Me.txt_alamatkon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamatkon.Location = New System.Drawing.Point(146, 49)
        Me.txt_alamatkon.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_alamatkon.Name = "txt_alamatkon"
        Me.txt_alamatkon.Size = New System.Drawing.Size(225, 22)
        Me.txt_alamatkon.TabIndex = 162
        '
        'txt_namakon
        '
        Me.txt_namakon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_namakon.Enabled = False
        Me.txt_namakon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namakon.Location = New System.Drawing.Point(230, 21)
        Me.txt_namakon.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_namakon.Name = "txt_namakon"
        Me.txt_namakon.Size = New System.Drawing.Size(109, 22)
        Me.txt_namakon.TabIndex = 160
        '
        'txt_kdkonsumen
        '
        Me.txt_kdkonsumen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_kdkonsumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kdkonsumen.Location = New System.Drawing.Point(146, 20)
        Me.txt_kdkonsumen.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_kdkonsumen.Name = "txt_kdkonsumen"
        Me.txt_kdkonsumen.Size = New System.Drawing.Size(78, 22)
        Me.txt_kdkonsumen.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 16)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "Kode Konsumen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txt_kembali)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_dibayar)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.b_barang)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.b_hapus)
        Me.GroupBox2.Controls.Add(Me.txt_totalitem)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.b_batal)
        Me.GroupBox2.Controls.Add(Me.b_simpan)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 486)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(988, 98)
        Me.GroupBox2.TabIndex = 160
        Me.GroupBox2.TabStop = False
        '
        'txt_kembali
        '
        Me.txt_kembali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_kembali.Enabled = False
        Me.txt_kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kembali.Location = New System.Drawing.Point(881, 56)
        Me.txt_kembali.Name = "txt_kembali"
        Me.txt_kembali.Size = New System.Drawing.Size(96, 21)
        Me.txt_kembali.TabIndex = 237
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(811, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 15)
        Me.Label17.TabIndex = 236
        Me.Label17.Text = "Kembali"
        '
        'txt_dibayar
        '
        Me.txt_dibayar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_dibayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dibayar.Location = New System.Drawing.Point(881, 24)
        Me.txt_dibayar.Name = "txt_dibayar"
        Me.txt_dibayar.Size = New System.Drawing.Size(96, 21)
        Me.txt_dibayar.TabIndex = 235
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(811, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 15)
        Me.Label16.TabIndex = 234
        Me.Label16.Text = "Dibayar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 13)
        Me.Label10.TabIndex = 233
        Me.Label10.Text = "[ F3 ] - Daftar Barang"
        '
        'b_barang
        '
        Me.b_barang.BackColor = System.Drawing.Color.Thistle
        Me.b_barang.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.b_barang.Image = CType(resources.GetObject("b_barang.Image"), System.Drawing.Image)
        Me.b_barang.Location = New System.Drawing.Point(259, 24)
        Me.b_barang.Name = "b_barang"
        Me.b_barang.Size = New System.Drawing.Size(121, 41)
        Me.b_barang.TabIndex = 232
        Me.b_barang.Text = "Daftar Barang"
        Me.b_barang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_barang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_barang.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 13)
        Me.Label14.TabIndex = 131
        Me.Label14.Text = "[ F4 ] - Daftar Supplier"
        '
        'b_hapus
        '
        Me.b_hapus.BackColor = System.Drawing.Color.Thistle
        Me.b_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_hapus.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_hapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_hapus.Image = CType(resources.GetObject("b_hapus.Image"), System.Drawing.Image)
        Me.b_hapus.Location = New System.Drawing.Point(580, 26)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(93, 39)
        Me.b_hapus.TabIndex = 224
        Me.b_hapus.Text = "&Hapus"
        Me.b_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_hapus.UseVisualStyleBackColor = False
        '
        'txt_totalitem
        '
        Me.txt_totalitem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_totalitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalitem.Location = New System.Drawing.Point(772, 24)
        Me.txt_totalitem.Name = "txt_totalitem"
        Me.txt_totalitem.Size = New System.Drawing.Size(33, 21)
        Me.txt_totalitem.TabIndex = 208
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(699, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Total Item :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txt_jenisbrng)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_harga)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_subtotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_qty)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_nama)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_kdbarang)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 213)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(985, 62)
        Me.GroupBox3.TabIndex = 161
        Me.GroupBox3.TabStop = False
        '
        'txt_jenisbrng
        '
        Me.txt_jenisbrng.Enabled = False
        Me.txt_jenisbrng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jenisbrng.Location = New System.Drawing.Point(463, 26)
        Me.txt_jenisbrng.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_jenisbrng.Name = "txt_jenisbrng"
        Me.txt_jenisbrng.Size = New System.Drawing.Size(90, 22)
        Me.txt_jenisbrng.TabIndex = 203
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(426, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 16)
        Me.Label19.TabIndex = 171
        Me.Label19.Text = "Jenis Brng"
        '
        'txt_harga
        '
        Me.txt_harga.Enabled = False
        Me.txt_harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_harga.Location = New System.Drawing.Point(646, 25)
        Me.txt_harga.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(91, 22)
        Me.txt_harga.TabIndex = 205
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(585, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 168
        Me.Label15.Text = "Harga"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(900, 26)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(74, 22)
        Me.txt_subtotal.TabIndex = 207
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(833, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 166
        Me.Label12.Text = "Sub Total"
        '
        'txt_qty
        '
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(772, 26)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(25, 22)
        Me.txt_qty.TabIndex = 206
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(743, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 16)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Qty"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama.Location = New System.Drawing.Point(237, 26)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(185, 22)
        Me.txt_nama.TabIndex = 201
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Nama"
        '
        'txt_kdbarang
        '
        Me.txt_kdbarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_kdbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kdbarang.Location = New System.Drawing.Point(76, 26)
        Me.txt_kdbarang.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_kdbarang.Name = "txt_kdbarang"
        Me.txt_kdbarang.Size = New System.Drawing.Size(106, 22)
        Me.txt_kdbarang.TabIndex = 200
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "Kd Barang"
        '
        'L_Total
        '
        Me.L_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Total.Location = New System.Drawing.Point(696, 37)
        Me.L_Total.Margin = New System.Windows.Forms.Padding(5)
        Me.L_Total.Name = "L_Total"
        Me.L_Total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.L_Total.Size = New System.Drawing.Size(313, 49)
        Me.L_Total.TabIndex = 162
        Me.L_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form_TransPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 596)
        Me.Controls.Add(Me.L_Total)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DG_Transjual)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form_TransPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TRANSAKSI - PENJUALAN"
        CType(Me.DG_Transjual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_Transjual As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_kdtrans As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents b_batal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tgl_trans As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_kasir As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_totalitem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_kdbarang As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents L_Total As System.Windows.Forms.TextBox
    Friend WithEvents txt_jenisbrng As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_kdkonsumen As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_alamatkon As System.Windows.Forms.TextBox
    Friend WithEvents txt_namakon As System.Windows.Forms.TextBox
    Friend WithEvents b_kon As System.Windows.Forms.Button
    Friend WithEvents b_barang As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_dibayar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_kembali As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
