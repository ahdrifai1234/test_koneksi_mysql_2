Imports MySqlConnector

Public Class FormTransaksiMasuk
    Dim Conn As MySqlConnection
    Dim MyDB As String
    Dim Da As MySqlDataAdapter
    Dim Ds As DataSet
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader
    Dim Sql As String


    Sub koneksi()
        MyDB = "server=localhost;user=root;password=;database=toko_komputer_jaya;"
        Conn = New MySqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub FormTransaksiMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mendapatkan ukuran layar
        Dim screenSize As Size = Screen.PrimaryScreen.WorkingArea.Size

        ' Menghitung posisi tengah layar
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim formLeft As Integer = (screenSize.Width - formWidth) / 2
        Dim formTop As Integer = (screenSize.Height - formHeight) / 2

        ' Mengatur posisi form
        Me.Location = New Point(formLeft, formTop)

        ' You can add initialization logic here, if needed
        Call formKondisiAwal()
    End Sub

    Sub formKondisiAwal()
        Call fillDataBarang()
    End Sub
    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        FormBarang.MdiParent = Me
        FormBarang.Show()
    End Sub

    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs) Handles btn_penjualan.Click
        FormTransaksiKeluar.MdiParent = Me
        FormTransaksiKeluar.Show()
    End Sub

    Sub fillDataBarang()
        Call koneksi()
        If txt_cari_barang.Text = "" Then
            Sql = "SELECT kode_barang, nama_barang FROM product"
        Else
            Sql = "SELECT kode_barang, nama_barang FROM product WHERE nama_barang LIKE '%" & txt_cari_barang.Text & "%'"
        End If
        Da = New MySqlDataAdapter(Sql, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridViewCariBarang.DataSource = Ds.Tables("barang")
        DataGridViewCariBarang.ReadOnly = True
        DataGridViewCariBarang.Columns(0).HeaderText = "Kode Barang"
        DataGridViewCariBarang.Columns(1).HeaderText = "Nama Barang"
        DataGridViewCariBarang.Columns("nama_barang").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_cari_barang.TextChanged
        Call fillDataBarang()

    End Sub

    Private Sub btn_cari_barang_Click(sender As Object, e As EventArgs) Handles btn_cari_barang.Click

    End Sub

    Sub getStokBarangSelected()
        Call koneksi()
        Sql = "SELECT 20 stok_saat_ini FROM product WHERE kode_barang = '" & txt_kode_barang.Text & "'"
        Cmd = New MySqlCommand(Sql, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            txt_stok_saat_ini.Text = Rd.Item("stok_saat_ini")
            txt_tgl_buku.Text = Format(Now, "yyyy-MM-dd")
        End If
    End Sub

    Private Sub DataGridViewCariBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCariBarang.CellContentClick
        Dim i As Integer
        With DataGridViewCariBarang
            i = .CurrentRow.Index
            If i >= 0 Then
                txt_kode_barang.Text = .Rows(i).Cells(0).Value
                txt_nama_barang.Text = .Rows(i).Cells(1).Value

                Call getStokBarangSelected()
            End If
        End With
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        If txt_tambah_stok.Text = "" Then
            MsgBox("Jumlah stok yang ditambahkan harus diisi", MsgBoxStyle.Exclamation, "Peringatan")
            txt_tambah_stok.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txt_tambah_stok.Text) Then
            MsgBox("Jumlah stok yang ditambahkan harus berupa angka", MsgBoxStyle.Exclamation, "Peringatan")
            txt_tambah_stok.Focus()
            Exit Sub
        End If
        If txt_tambah_stok.Text <= 0 Then
            MsgBox("Jumlah stok yang ditambahkan harus lebih besar dari 0", MsgBoxStyle.Exclamation, "Peringatan")
            txt_tambah_stok.Focus()
            Exit Sub
        End If
        If txt_tambah_stok.Text > 0 Then
            Dim stok_saat_ini As Integer
            Dim stok_tambah As Integer
            Dim stok_akhir As Integer
            stok_saat_ini = txt_stok_saat_ini.Text
            stok_tambah = txt_tambah_stok.Text


            Call koneksi()
            Sql = "INSERT INTO product_masuk VALUES (@kode_barang, @nama_barang, @satuan, @jumlah, @tgl_buku, @harga_total)"
            Cmd = New MySqlCommand(Sql, Conn)
            Cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text)
            Cmd.Parameters.AddWithValue("@nama_barang", txt_nama_barang.Text)
            Cmd.Parameters.AddWithValue("@satuan", "Unit")
            Cmd.Parameters.AddWithValue("@jumlah", txt_tambah_stok.Text)
            Cmd.Parameters.AddWithValue("@tgl_buku", txt_tgl_buku.Text)
            Cmd.Parameters.AddWithValue("@harga_total", txt_tambah_stok.Text)

            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call formKondisiAwal()
            Call fillDataBarang()
        End If
    End Sub

    Private Sub DataGridViewTrxMasuk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTrxMasuk.CellContentClick

    End Sub
End Class