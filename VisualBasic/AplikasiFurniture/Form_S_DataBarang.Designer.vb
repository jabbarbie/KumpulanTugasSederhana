<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_S_DataBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_S_DataBarang))
        Me.R_Semua = New System.Windows.Forms.RadioButton
        Me.R_PerSupplier = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cb_sup = New System.Windows.Forms.ComboBox
        Me.b_cetak = New System.Windows.Forms.Button
        Me.b_keluar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'R_Semua
        '
        Me.R_Semua.AutoSize = True
        Me.R_Semua.Checked = True
        Me.R_Semua.Location = New System.Drawing.Point(123, 19)
        Me.R_Semua.Name = "R_Semua"
        Me.R_Semua.Size = New System.Drawing.Size(78, 24)
        Me.R_Semua.TabIndex = 0
        Me.R_Semua.TabStop = True
        Me.R_Semua.Text = "&Semua"
        Me.R_Semua.UseVisualStyleBackColor = True
        '
        'R_PerSupplier
        '
        Me.R_PerSupplier.AutoSize = True
        Me.R_PerSupplier.Location = New System.Drawing.Point(124, 64)
        Me.R_PerSupplier.Name = "R_PerSupplier"
        Me.R_PerSupplier.Size = New System.Drawing.Size(121, 24)
        Me.R_PerSupplier.TabIndex = 2
        Me.R_PerSupplier.Text = "Per Supplier :"
        Me.R_PerSupplier.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cb_sup)
        Me.Panel1.Controls.Add(Me.R_PerSupplier)
        Me.Panel1.Controls.Add(Me.R_Semua)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 128)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cb_sup
        '
        Me.cb_sup.FormattingEnabled = True
        Me.cb_sup.Location = New System.Drawing.Point(243, 60)
        Me.cb_sup.Name = "cb_sup"
        Me.cb_sup.Size = New System.Drawing.Size(121, 28)
        Me.cb_sup.TabIndex = 8
        '
        'b_cetak
        '
        Me.b_cetak.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_cetak.Image = CType(resources.GetObject("b_cetak.Image"), System.Drawing.Image)
        Me.b_cetak.Location = New System.Drawing.Point(139, 142)
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
        Me.b_keluar.Location = New System.Drawing.Point(220, 142)
        Me.b_keluar.Name = "b_keluar"
        Me.b_keluar.Size = New System.Drawing.Size(75, 37)
        Me.b_keluar.TabIndex = 10
        Me.b_keluar.Text = "&Keluar"
        Me.b_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.b_keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.b_keluar.UseVisualStyleBackColor = True
        '
        'Form_S_DataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.b_keluar)
        Me.Controls.Add(Me.b_cetak)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_S_DataBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Laporan Data Barang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents R_Semua As System.Windows.Forms.RadioButton
    Friend WithEvents R_PerSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_sup As System.Windows.Forms.ComboBox
    Friend WithEvents b_cetak As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents b_keluar As System.Windows.Forms.Button
End Class
