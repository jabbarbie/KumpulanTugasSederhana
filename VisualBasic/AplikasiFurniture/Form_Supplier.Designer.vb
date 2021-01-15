<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Supplier))
        Me.txt_alamat = New System.Windows.Forms.TextBox
        Me.txt_namasupplier = New System.Windows.Forms.TextBox
        Me.b_keluar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.b_edit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.b_cari = New System.Windows.Forms.Button
        Me.txt_pencarian = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_kodesupplier = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_notelp = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.b_batal = New System.Windows.Forms.Button
        Me.b_tambah = New System.Windows.Forms.Button
        Me.DG_Supplier = New System.Windows.Forms.DataGridView
        Me.b_hapus = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(169, 126)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(155, 26)
        Me.txt_alamat.TabIndex = 7
        '
        'txt_namasupplier
        '
        Me.txt_namasupplier.Location = New System.Drawing.Point(169, 80)
        Me.txt_namasupplier.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_namasupplier.Name = "txt_namasupplier"
        Me.txt_namasupplier.Size = New System.Drawing.Size(155, 26)
        Me.txt_namasupplier.TabIndex = 3
        '
        'b_keluar
        '
        Me.b_keluar.BackColor = System.Drawing.Color.Thistle
        Me.b_keluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_keluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_keluar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_keluar.Image = CType(resources.GetObject("b_keluar.Image"), System.Drawing.Image)
        Me.b_keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_keluar.Location = New System.Drawing.Point(575, 461)
        Me.b_keluar.Name = "b_keluar"
        Me.b_keluar.Size = New System.Drawing.Size(92, 43)
        Me.b_keluar.TabIndex = 40
        Me.b_keluar.Text = "Keluar"
        Me.b_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_keluar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alamat"
        '
        'b_edit
        '
        Me.b_edit.BackColor = System.Drawing.Color.Thistle
        Me.b_edit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_edit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_edit.Image = CType(resources.GetObject("b_edit.Image"), System.Drawing.Image)
        Me.b_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_edit.Location = New System.Drawing.Point(129, 461)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(97, 43)
        Me.b_edit.TabIndex = 37
        Me.b_edit.Text = "&Edit"
        Me.b_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_edit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 24)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "DATA SUPPLIER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.b_cari)
        Me.GroupBox2.Controls.Add(Me.txt_pencarian)
        Me.GroupBox2.Location = New System.Drawing.Point(350, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 84)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'b_cari
        '
        Me.b_cari.Location = New System.Drawing.Point(191, 35)
        Me.b_cari.Name = "b_cari"
        Me.b_cari.Size = New System.Drawing.Size(75, 31)
        Me.b_cari.TabIndex = 3
        Me.b_cari.Text = "Cari"
        Me.b_cari.UseVisualStyleBackColor = True
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(23, 35)
        Me.txt_pencarian.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(155, 26)
        Me.txt_pencarian.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_namasupplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_kodesupplier)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_notelp)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(654, 222)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Supplier"
        '
        'txt_kodesupplier
        '
        Me.txt_kodesupplier.Location = New System.Drawing.Point(169, 34)
        Me.txt_kodesupplier.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_kodesupplier.Name = "txt_kodesupplier"
        Me.txt_kodesupplier.Size = New System.Drawing.Size(96, 26)
        Me.txt_kodesupplier.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Supplier"
        '
        'txt_notelp
        '
        Me.txt_notelp.Location = New System.Drawing.Point(169, 167)
        Me.txt_notelp.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_notelp.Name = "txt_notelp"
        Me.txt_notelp.Size = New System.Drawing.Size(155, 26)
        Me.txt_notelp.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "No. Telphone"
        '
        'b_batal
        '
        Me.b_batal.BackColor = System.Drawing.Color.Thistle
        Me.b_batal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_batal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_batal.Image = CType(resources.GetObject("b_batal.Image"), System.Drawing.Image)
        Me.b_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_batal.Location = New System.Drawing.Point(461, 461)
        Me.b_batal.Name = "b_batal"
        Me.b_batal.Size = New System.Drawing.Size(101, 43)
        Me.b_batal.TabIndex = 39
        Me.b_batal.Text = "Batal"
        Me.b_batal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_batal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_batal.UseVisualStyleBackColor = False
        '
        'b_tambah
        '
        Me.b_tambah.BackColor = System.Drawing.Color.Thistle
        Me.b_tambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_tambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_tambah.Image = CType(resources.GetObject("b_tambah.Image"), System.Drawing.Image)
        Me.b_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_tambah.Location = New System.Drawing.Point(12, 461)
        Me.b_tambah.Name = "b_tambah"
        Me.b_tambah.Size = New System.Drawing.Size(101, 43)
        Me.b_tambah.TabIndex = 36
        Me.b_tambah.Text = "Tambah"
        Me.b_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_tambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_tambah.UseVisualStyleBackColor = False
        '
        'DG_Supplier
        '
        Me.DG_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Supplier.Location = New System.Drawing.Point(12, 305)
        Me.DG_Supplier.Name = "DG_Supplier"
        Me.DG_Supplier.Size = New System.Drawing.Size(654, 150)
        Me.DG_Supplier.TabIndex = 41
        '
        'b_hapus
        '
        Me.b_hapus.BackColor = System.Drawing.Color.Thistle
        Me.b_hapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_hapus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_hapus.Image = CType(resources.GetObject("b_hapus.Image"), System.Drawing.Image)
        Me.b_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b_hapus.Location = New System.Drawing.Point(239, 461)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(97, 43)
        Me.b_hapus.TabIndex = 42
        Me.b_hapus.Text = "&Hapus"
        Me.b_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_hapus.UseVisualStyleBackColor = False
        '
        'Form_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.b_keluar
        Me.ClientSize = New System.Drawing.Size(679, 516)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.DG_Supplier)
        Me.Controls.Add(Me.b_keluar)
        Me.Controls.Add(Me.b_edit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.b_batal)
        Me.Controls.Add(Me.b_tambah)
        Me.Name = "Form_Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Supplier"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_alamat As System.Windows.Forms.TextBox
    Friend WithEvents txt_namasupplier As System.Windows.Forms.TextBox
    Friend WithEvents b_keluar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b_edit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents b_cari As System.Windows.Forms.Button
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_kodesupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_notelp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents b_batal As System.Windows.Forms.Button
    Friend WithEvents b_tambah As System.Windows.Forms.Button
    Friend WithEvents DG_Supplier As System.Windows.Forms.DataGridView
    Friend WithEvents b_hapus As System.Windows.Forms.Button
End Class
