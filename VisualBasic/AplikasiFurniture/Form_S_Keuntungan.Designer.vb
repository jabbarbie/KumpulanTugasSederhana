<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_S_Keuntungan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_S_Keuntungan))
        Me.R_PerPeriode = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NumTahun1 = New System.Windows.Forms.NumericUpDown
        Me.cb_bulan = New System.Windows.Forms.ComboBox
        Me.NumTahun2 = New System.Windows.Forms.NumericUpDown
        Me.R_PerTahun = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.b_cetak = New System.Windows.Forms.Button
        Me.b_keluar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_pendapatan = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_gaji = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_pembelian = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_penjualan = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.NumTahun1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTahun2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'R_PerPeriode
        '
        Me.R_PerPeriode.AutoSize = True
        Me.R_PerPeriode.Location = New System.Drawing.Point(93, 11)
        Me.R_PerPeriode.Name = "R_PerPeriode"
        Me.R_PerPeriode.Size = New System.Drawing.Size(96, 24)
        Me.R_PerPeriode.TabIndex = 2
        Me.R_PerPeriode.Text = "Per Bulan"
        Me.R_PerPeriode.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.NumTahun1)
        Me.Panel1.Controls.Add(Me.cb_bulan)
        Me.Panel1.Controls.Add(Me.NumTahun2)
        Me.Panel1.Controls.Add(Me.R_PerTahun)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.R_PerPeriode)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 102)
        Me.Panel1.TabIndex = 3
        '
        'NumTahun1
        '
        Me.NumTahun1.Location = New System.Drawing.Point(359, 10)
        Me.NumTahun1.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NumTahun1.Name = "NumTahun1"
        Me.NumTahun1.Size = New System.Drawing.Size(100, 26)
        Me.NumTahun1.TabIndex = 16
        '
        'cb_bulan
        '
        Me.cb_bulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_bulan.FormattingEnabled = True
        Me.cb_bulan.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cb_bulan.Location = New System.Drawing.Point(223, 10)
        Me.cb_bulan.Name = "cb_bulan"
        Me.cb_bulan.Size = New System.Drawing.Size(121, 28)
        Me.cb_bulan.TabIndex = 15
        '
        'NumTahun2
        '
        Me.NumTahun2.Location = New System.Drawing.Point(223, 55)
        Me.NumTahun2.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NumTahun2.Name = "NumTahun2"
        Me.NumTahun2.Size = New System.Drawing.Size(145, 26)
        Me.NumTahun2.TabIndex = 14
        '
        'R_PerTahun
        '
        Me.R_PerTahun.AutoSize = True
        Me.R_PerTahun.Location = New System.Drawing.Point(93, 57)
        Me.R_PerTahun.Name = "R_PerTahun"
        Me.R_PerTahun.Size = New System.Drawing.Size(100, 24)
        Me.R_PerTahun.TabIndex = 13
        Me.R_PerTahun.Text = "Per Tahun"
        Me.R_PerTahun.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'b_cetak
        '
        Me.b_cetak.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_cetak.Image = CType(resources.GetObject("b_cetak.Image"), System.Drawing.Image)
        Me.b_cetak.Location = New System.Drawing.Point(446, 333)
        Me.b_cetak.Name = "b_cetak"
        Me.b_cetak.Size = New System.Drawing.Size(75, 37)
        Me.b_cetak.TabIndex = 9
        Me.b_cetak.Text = "&Cetak"
        Me.b_cetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_cetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_cetak.UseVisualStyleBackColor = True
        '
        'b_keluar
        '
        Me.b_keluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_keluar.Image = CType(resources.GetObject("b_keluar.Image"), System.Drawing.Image)
        Me.b_keluar.Location = New System.Drawing.Point(527, 333)
        Me.b_keluar.Name = "b_keluar"
        Me.b_keluar.Size = New System.Drawing.Size(75, 37)
        Me.b_keluar.TabIndex = 10
        Me.b_keluar.Text = "&Keluar"
        Me.b_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_keluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = " "
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = " "
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = " "
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " "
        Me.Label4.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_pendapatan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_gaji)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_pembelian)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_penjualan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 224)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total Pendapatan"
        '
        'txt_pendapatan
        '
        Me.txt_pendapatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pendapatan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pendapatan.Location = New System.Drawing.Point(443, 178)
        Me.txt_pendapatan.Name = "txt_pendapatan"
        Me.txt_pendapatan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_pendapatan.Size = New System.Drawing.Size(156, 26)
        Me.txt_pendapatan.TabIndex = 21
        Me.txt_pendapatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Total Gaji"
        '
        'txt_gaji
        '
        Me.txt_gaji.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_gaji.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_gaji.Location = New System.Drawing.Point(443, 123)
        Me.txt_gaji.Name = "txt_gaji"
        Me.txt_gaji.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_gaji.Size = New System.Drawing.Size(156, 26)
        Me.txt_gaji.TabIndex = 19
        Me.txt_gaji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total Pembelian"
        '
        'txt_pembelian
        '
        Me.txt_pembelian.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pembelian.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pembelian.Location = New System.Drawing.Point(443, 62)
        Me.txt_pembelian.Name = "txt_pembelian"
        Me.txt_pembelian.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_pembelian.Size = New System.Drawing.Size(156, 26)
        Me.txt_pembelian.TabIndex = 17
        Me.txt_pembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total Penjualan"
        '
        'txt_penjualan
        '
        Me.txt_penjualan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_penjualan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_penjualan.Location = New System.Drawing.Point(443, 25)
        Me.txt_penjualan.Name = "txt_penjualan"
        Me.txt_penjualan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_penjualan.Size = New System.Drawing.Size(156, 26)
        Me.txt_penjualan.TabIndex = 15
        Me.txt_penjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form_S_Keuntungan
        '
        Me.AcceptButton = Me.b_cetak
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(614, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.b_keluar)
        Me.Controls.Add(Me.b_cetak)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_S_Keuntungan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Laporan Rugi Laba"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumTahun1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTahun2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents R_PerPeriode As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents b_cetak As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents b_keluar As System.Windows.Forms.Button
    Friend WithEvents R_PerTahun As System.Windows.Forms.RadioButton
    Friend WithEvents NumTahun2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_bulan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumTahun1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_pendapatan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_gaji As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_penjualan As System.Windows.Forms.TextBox
End Class
