<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        txt_kode_barang = New TextBox()
        txt_nama_barang = New TextBox()
        txt_satuan = New TextBox()
        txt_harga_satuan = New TextBox()
        txt_created_at = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btn_clear_form = New Button()
        btn_input = New Button()
        btn_edit = New Button()
        btn_hapus = New Button()
        btn_tutup = New Button()
        txt_lokasi_rak = New ComboBox()
        lbl_generate_otomatis = New Label()
        Label8 = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        ToolStripStatusLabel5 = New ToolStripStatusLabel()
        ToolStripStatusLabel6 = New ToolStripStatusLabel()
        DataBarang = New GroupBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        DataBarang.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(19, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(931, 234)
        DataGridView1.TabIndex = 1
        ' 
        ' txt_kode_barang
        ' 
        txt_kode_barang.Location = New Point(285, 43)
        txt_kode_barang.Name = "txt_kode_barang"
        txt_kode_barang.Size = New Size(202, 27)
        txt_kode_barang.TabIndex = 1
        ' 
        ' txt_nama_barang
        ' 
        txt_nama_barang.Location = New Point(285, 78)
        txt_nama_barang.Name = "txt_nama_barang"
        txt_nama_barang.Size = New Size(351, 27)
        txt_nama_barang.TabIndex = 2
        ' 
        ' txt_satuan
        ' 
        txt_satuan.Location = New Point(285, 116)
        txt_satuan.Name = "txt_satuan"
        txt_satuan.Size = New Size(351, 27)
        txt_satuan.TabIndex = 3
        ' 
        ' txt_harga_satuan
        ' 
        txt_harga_satuan.Location = New Point(285, 154)
        txt_harga_satuan.Name = "txt_harga_satuan"
        txt_harga_satuan.Size = New Size(351, 27)
        txt_harga_satuan.TabIndex = 4
        ' 
        ' txt_created_at
        ' 
        txt_created_at.Location = New Point(285, 230)
        txt_created_at.Name = "txt_created_at"
        txt_created_at.Size = New Size(202, 27)
        txt_created_at.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(150, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(495, 40)
        Label1.TabIndex = 4
        Label1.Text = "DATA BARANG TOKO KOMPUTER JAYA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(24, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 22)
        Label2.TabIndex = 5
        Label2.Text = "KODE BARANG"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Location = New Point(24, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 22)
        Label3.TabIndex = 5
        Label3.Text = "NAMA BARANG"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(24, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 22)
        Label4.TabIndex = 5
        Label4.Text = "SATUAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Location = New Point(24, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 22)
        Label5.TabIndex = 5
        Label5.Text = "HARGA SATUAN"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Location = New Point(24, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 22)
        Label6.TabIndex = 5
        Label6.Text = "LOKASI"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Location = New Point(24, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 22)
        Label7.TabIndex = 5
        Label7.Text = "TANGGAL INPUT"
        ' 
        ' btn_clear_form
        ' 
        btn_clear_form.BackColor = Color.Gainsboro
        btn_clear_form.Location = New Point(705, 66)
        btn_clear_form.Name = "btn_clear_form"
        btn_clear_form.Size = New Size(110, 127)
        btn_clear_form.TabIndex = 10
        btn_clear_form.Text = "CLEAR"
        btn_clear_form.UseVisualStyleBackColor = False
        ' 
        ' btn_input
        ' 
        btn_input.BackColor = Color.WhiteSmoke
        btn_input.Location = New Point(41, 26)
        btn_input.Name = "btn_input"
        btn_input.Size = New Size(148, 34)
        btn_input.TabIndex = 7
        btn_input.Text = "INPUT"
        btn_input.UseVisualStyleBackColor = False
        ' 
        ' btn_edit
        ' 
        btn_edit.BackColor = Color.WhiteSmoke
        btn_edit.Location = New Point(210, 26)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(148, 34)
        btn_edit.TabIndex = 8
        btn_edit.Text = "EDIT"
        btn_edit.UseVisualStyleBackColor = False
        ' 
        ' btn_hapus
        ' 
        btn_hapus.BackColor = Color.WhiteSmoke
        btn_hapus.Location = New Point(364, 26)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(148, 34)
        btn_hapus.TabIndex = 9
        btn_hapus.Text = "HAPUS"
        btn_hapus.UseVisualStyleBackColor = False
        ' 
        ' btn_tutup
        ' 
        btn_tutup.BackColor = Color.WhiteSmoke
        btn_tutup.Location = New Point(580, 26)
        btn_tutup.Name = "btn_tutup"
        btn_tutup.Size = New Size(148, 34)
        btn_tutup.TabIndex = 11
        btn_tutup.Text = "TUTUP"
        btn_tutup.UseVisualStyleBackColor = False
        ' 
        ' txt_lokasi_rak
        ' 
        txt_lokasi_rak.FormattingEnabled = True
        txt_lokasi_rak.Items.AddRange(New Object() {"RAK 1", "RAK 2", "RAK 3", "RAK 4", "RAK 5"})
        txt_lokasi_rak.Location = New Point(285, 192)
        txt_lokasi_rak.Name = "txt_lokasi_rak"
        txt_lokasi_rak.Size = New Size(351, 28)
        txt_lokasi_rak.TabIndex = 12
        ' 
        ' lbl_generate_otomatis
        ' 
        lbl_generate_otomatis.AutoSize = True
        lbl_generate_otomatis.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl_generate_otomatis.Location = New Point(493, 49)
        lbl_generate_otomatis.Name = "lbl_generate_otomatis"
        lbl_generate_otomatis.Size = New Size(129, 17)
        lbl_generate_otomatis.TabIndex = 13
        lbl_generate_otomatis.Text = "*generated by system."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(493, 236)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 17)
        Label8.TabIndex = 13
        Label8.Text = "*generated by system."
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel3, ToolStripStatusLabel5, ToolStripStatusLabel6})
        StatusStrip1.Location = New Point(0, 699)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1014, 26)
        StatusStrip1.TabIndex = 15
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(86, 20)
        ToolStripStatusLabel1.Text = "Username : "
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(68, 20)
        ToolStripStatusLabel3.Text = "| Nama : "
        ' 
        ' ToolStripStatusLabel5
        ' 
        ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        ToolStripStatusLabel5.Size = New Size(80, 20)
        ToolStripStatusLabel5.Text = "| Tanggal : "
        ' 
        ' ToolStripStatusLabel6
        ' 
        ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        ToolStripStatusLabel6.Size = New Size(85, 20)
        ToolStripStatusLabel6.Text = "2025-01-25"
        ' 
        ' DataBarang
        ' 
        DataBarang.Controls.Add(Label2)
        DataBarang.Controls.Add(Label3)
        DataBarang.Controls.Add(Label8)
        DataBarang.Controls.Add(Label4)
        DataBarang.Controls.Add(lbl_generate_otomatis)
        DataBarang.Controls.Add(Label7)
        DataBarang.Controls.Add(btn_clear_form)
        DataBarang.Controls.Add(txt_lokasi_rak)
        DataBarang.Controls.Add(Label5)
        DataBarang.Controls.Add(Label6)
        DataBarang.Controls.Add(txt_kode_barang)
        DataBarang.Controls.Add(txt_nama_barang)
        DataBarang.Controls.Add(txt_satuan)
        DataBarang.Controls.Add(txt_harga_satuan)
        DataBarang.Controls.Add(txt_created_at)
        DataBarang.Location = New Point(43, 114)
        DataBarang.Name = "DataBarang"
        DataBarang.Size = New Size(856, 275)
        DataBarang.TabIndex = 16
        DataBarang.TabStop = False
        DataBarang.Text = "Form Data Barang"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(48, 487)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(952, 182)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Bagian List Barang"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btn_input)
        GroupBox2.Controls.Add(btn_tutup)
        GroupBox2.Controls.Add(btn_edit)
        GroupBox2.Controls.Add(btn_hapus)
        GroupBox2.Location = New Point(48, 417)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(950, 64)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Action Barang"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Location = New Point(43, 38)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(856, 78)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        ' 
        ' FormBarang
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1014, 725)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(DataBarang)
        Controls.Add(StatusStrip1)
        MaximizeBox = False
        Name = "FormBarang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        DataBarang.ResumeLayout(False)
        DataBarang.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_kode_barang As TextBox
    Friend WithEvents txt_nama_barang As TextBox
    Friend WithEvents txt_satuan As TextBox
    Friend WithEvents txt_harga_satuan As TextBox
    Friend WithEvents txt_created_at As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_clear_form As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_tutup As Button
    Friend WithEvents txt_lokasi_rak As ComboBox
    Friend WithEvents lbl_generate_otomatis As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents DataBarang As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox

End Class
