<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiMasuk
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
        GroupBox1 = New GroupBox()
        txt_cari_barang = New TextBox()
        btn_cari_barang = New Button()
        DataGridViewCariBarang = New DataGridView()
        btn_penjualan = New Button()
        btn_product = New Button()
        GroupBox2 = New GroupBox()
        txt_stok_saat_ini = New TextBox()
        txt_nama_barang = New TextBox()
        txt_kode_barang = New TextBox()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        txt_tgl_buku = New TextBox()
        Label8 = New Label()
        txt_tambah_stok = New TextBox()
        Label7 = New Label()
        GroupBox4 = New GroupBox()
        DataGridViewTrxMasuk = New DataGridView()
        GroupBox5 = New GroupBox()
        txt_cari_data = New TextBox()
        btn_cari = New Button()
        btn_hapus = New Button()
        btn_tambah = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridViewCariBarang, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(DataGridViewTrxMasuk, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt_cari_barang)
        GroupBox1.Controls.Add(btn_cari_barang)
        GroupBox1.Controls.Add(DataGridViewCariBarang)
        GroupBox1.Controls.Add(btn_penjualan)
        GroupBox1.Controls.Add(btn_product)
        GroupBox1.Location = New Point(9, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(382, 740)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Input Stok Barang"
        ' 
        ' txt_cari_barang
        ' 
        txt_cari_barang.Location = New Point(170, 48)
        txt_cari_barang.Name = "txt_cari_barang"
        txt_cari_barang.Size = New Size(197, 27)
        txt_cari_barang.TabIndex = 1
        ' 
        ' btn_cari_barang
        ' 
        btn_cari_barang.Location = New Point(23, 44)
        btn_cari_barang.Name = "btn_cari_barang"
        btn_cari_barang.Size = New Size(141, 31)
        btn_cari_barang.TabIndex = 0
        btn_cari_barang.Text = "Cari"
        btn_cari_barang.UseVisualStyleBackColor = True
        ' 
        ' DataGridViewCariBarang
        ' 
        DataGridViewCariBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCariBarang.Location = New Point(24, 82)
        DataGridViewCariBarang.Name = "DataGridViewCariBarang"
        DataGridViewCariBarang.RowHeadersWidth = 51
        DataGridViewCariBarang.Size = New Size(343, 300)
        DataGridViewCariBarang.TabIndex = 0
        ' 
        ' btn_penjualan
        ' 
        btn_penjualan.Location = New Point(48, 548)
        btn_penjualan.Name = "btn_penjualan"
        btn_penjualan.Size = New Size(301, 73)
        btn_penjualan.TabIndex = 1
        btn_penjualan.Text = "Penjualan"
        btn_penjualan.UseVisualStyleBackColor = True
        ' 
        ' btn_product
        ' 
        btn_product.Location = New Point(48, 450)
        btn_product.Name = "btn_product"
        btn_product.Size = New Size(301, 73)
        btn_product.TabIndex = 1
        btn_product.Text = "Produk"
        btn_product.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txt_stok_saat_ini)
        GroupBox2.Controls.Add(txt_nama_barang)
        GroupBox2.Controls.Add(txt_kode_barang)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(415, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(895, 153)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Barang"
        ' 
        ' txt_stok_saat_ini
        ' 
        txt_stok_saat_ini.Location = New Point(204, 109)
        txt_stok_saat_ini.Name = "txt_stok_saat_ini"
        txt_stok_saat_ini.ReadOnly = True
        txt_stok_saat_ini.Size = New Size(416, 27)
        txt_stok_saat_ini.TabIndex = 1
        ' 
        ' txt_nama_barang
        ' 
        txt_nama_barang.Location = New Point(204, 66)
        txt_nama_barang.Name = "txt_nama_barang"
        txt_nama_barang.ReadOnly = True
        txt_nama_barang.Size = New Size(416, 27)
        txt_nama_barang.TabIndex = 1
        ' 
        ' txt_kode_barang
        ' 
        txt_kode_barang.Location = New Point(204, 35)
        txt_kode_barang.Name = "txt_kode_barang"
        txt_kode_barang.ReadOnly = True
        txt_kode_barang.Size = New Size(416, 27)
        txt_kode_barang.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(38, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 0
        Label6.Text = "Stok Saat ini"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 0
        Label3.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 0
        Label2.Text = "Kode Barang"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txt_tgl_buku)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(txt_tambah_stok)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(406, 217)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(904, 106)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Stok"
        ' 
        ' txt_tgl_buku
        ' 
        txt_tgl_buku.Location = New Point(204, 68)
        txt_tgl_buku.Name = "txt_tgl_buku"
        txt_tgl_buku.ReadOnly = True
        txt_tgl_buku.Size = New Size(416, 27)
        txt_tgl_buku.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(38, 71)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 20)
        Label8.TabIndex = 0
        Label8.Text = "Tanggal Pembukuan"
        ' 
        ' txt_tambah_stok
        ' 
        txt_tambah_stok.Location = New Point(204, 35)
        txt_tambah_stok.Name = "txt_tambah_stok"
        txt_tambah_stok.Size = New Size(416, 27)
        txt_tambah_stok.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(38, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 20)
        Label7.TabIndex = 0
        Label7.Text = "Penambahan Stok"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(DataGridViewTrxMasuk)
        GroupBox4.Location = New Point(406, 414)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(904, 329)
        GroupBox4.TabIndex = 1
        GroupBox4.TabStop = False
        GroupBox4.Text = "Data Transaksi Masuk"
        ' 
        ' DataGridViewTrxMasuk
        ' 
        DataGridViewTrxMasuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTrxMasuk.Location = New Point(9, 23)
        DataGridViewTrxMasuk.Name = "DataGridViewTrxMasuk"
        DataGridViewTrxMasuk.RowHeadersWidth = 51
        DataGridViewTrxMasuk.Size = New Size(885, 300)
        DataGridViewTrxMasuk.TabIndex = 0
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(txt_cari_data)
        GroupBox5.Controls.Add(btn_cari)
        GroupBox5.Controls.Add(btn_hapus)
        GroupBox5.Controls.Add(btn_tambah)
        GroupBox5.Location = New Point(406, 352)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(904, 56)
        GroupBox5.TabIndex = 1
        GroupBox5.TabStop = False
        ' 
        ' txt_cari_data
        ' 
        txt_cari_data.Location = New Point(596, 19)
        txt_cari_data.Name = "txt_cari_data"
        txt_cari_data.Size = New Size(302, 27)
        txt_cari_data.TabIndex = 1
        txt_cari_data.Visible = False
        ' 
        ' btn_cari
        ' 
        btn_cari.Location = New Point(449, 19)
        btn_cari.Name = "btn_cari"
        btn_cari.Size = New Size(141, 31)
        btn_cari.TabIndex = 0
        btn_cari.Text = "Cari"
        btn_cari.UseVisualStyleBackColor = True
        ' 
        ' btn_hapus
        ' 
        btn_hapus.Location = New Point(204, 19)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(141, 31)
        btn_hapus.TabIndex = 0
        btn_hapus.Text = "Hapus"
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(38, 19)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(141, 31)
        btn_tambah.TabIndex = 0
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' FormTransaksiMasuk
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1322, 913)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FormTransaksiMasuk"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormTransaksiMasuk"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridViewCariBarang, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(DataGridViewTrxMasuk, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_nama_barang As TextBox
    Friend WithEvents txt_kode_barang As TextBox
    Friend WithEvents txt_tgl_buku As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_tambah_stok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_cari As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_cari_data As TextBox
    Friend WithEvents DataGridViewTrxMasuk As DataGridView
    Friend WithEvents btn_penjualan As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents txt_cari_barang As TextBox
    Friend WithEvents btn_cari_barang As Button
    Friend WithEvents DataGridViewCariBarang As DataGridView
    Friend WithEvents txt_stok_saat_ini As TextBox
End Class
