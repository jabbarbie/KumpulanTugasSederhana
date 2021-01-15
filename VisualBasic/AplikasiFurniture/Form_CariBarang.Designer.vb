<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CariBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CariBarang))
        Me.DG_Barang = New System.Windows.Forms.DataGridView
        Me.B_Tambah = New System.Windows.Forms.Button
        Me.B_Keluar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_pencarian = New System.Windows.Forms.TextBox
        CType(Me.DG_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Barang
        '
        Me.DG_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Barang.Location = New System.Drawing.Point(16, 117)
        Me.DG_Barang.Name = "DG_Barang"
        Me.DG_Barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Barang.Size = New System.Drawing.Size(433, 314)
        Me.DG_Barang.TabIndex = 50
        '
        'B_Tambah
        '
        Me.B_Tambah.BackColor = System.Drawing.Color.Thistle
        Me.B_Tambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Tambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.B_Tambah.Image = CType(resources.GetObject("B_Tambah.Image"), System.Drawing.Image)
        Me.B_Tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Tambah.Location = New System.Drawing.Point(250, 449)
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
        Me.B_Keluar.Location = New System.Drawing.Point(357, 449)
        Me.B_Keluar.Name = "B_Keluar"
        Me.B_Keluar.Size = New System.Drawing.Size(92, 43)
        Me.B_Keluar.TabIndex = 49
        Me.B_Keluar.Text = "Keluar"
        Me.B_Keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.B_Keluar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "CARI DATA BARANG"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_pencarian)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 63)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Location = New System.Drawing.Point(16, 21)
        Me.txt_pencarian.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(321, 26)
        Me.txt_pencarian.TabIndex = 2
        '
        'Form_CariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelButton = Me.B_Keluar
        Me.ClientSize = New System.Drawing.Size(468, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DG_Barang)
        Me.Controls.Add(Me.B_Tambah)
        Me.Controls.Add(Me.B_Keluar)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form_CariBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Data Barang"
        CType(Me.DG_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_Barang As System.Windows.Forms.DataGridView
    Friend WithEvents B_Tambah As System.Windows.Forms.Button
    Friend WithEvents B_Keluar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox

End Class
