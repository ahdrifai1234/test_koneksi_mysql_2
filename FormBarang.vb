Imports MySqlConnector

Public Class FormBarang

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txt_kode_barang.Text = ""
        txt_nama_barang.Text = ""
        txt_satuan.Text = ""
        txt_harga_satuan.Text = ""
        txt_lokasi_rak.Text = ""
        txt_created_at.Text = ""
        txt_kode_barang.Enabled = False
        txt_nama_barang.Enabled = False
        txt_satuan.Enabled = False
        txt_harga_satuan.Enabled = False
        txt_lokasi_rak.Enabled = False
        txt_created_at.Enabled = False

        'siapkan tombol
        btn_input.Text = "INPUT"
        btn_edit.Text = "EDIT"
        btn_hapus.Text = "HAPUS"
        btn_tutup.Text = "TUTUP"
        btn_input.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_tutup.Enabled = True

        'fill data
        Call koneksi()
        Sql = "select * from product"
        Da = New MySqlDataAdapter(Sql, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "product")


        'setting header
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.Font = New Font("Arial", 11, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle = headerStyle
        ' Autosize columns to fit content
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Set the DataGridView control's border
        DataGridView1.DataSource = Ds.Tables("product")
        DataGridView1.Columns(0).HeaderText = "Kode Barang"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Satuan"
        DataGridView1.Columns(3).HeaderText = "Harga Satuan"
        DataGridView1.Columns(4).HeaderText = "Lokasi Rak"
        DataGridView1.Columns(5).HeaderText = "Created At"
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.Columns("created_at").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridView1.Columns("nama_barang").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns("harga_satuan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("harga_satuan").DefaultCellStyle.Format = "N0"

    End Sub

    Sub fieldAktif()
        txt_kode_barang.Enabled = True
        txt_nama_barang.Enabled = True
        txt_satuan.Enabled = True
        txt_harga_satuan.Enabled = True
        txt_lokasi_rak.Enabled = True
        txt_created_at.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        txt_created_at.Enabled = False

        txt_kode_barang.Focus()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        With DataGridView1
            i = .CurrentRow.Index
            If e.RowIndex > 0 Then
                txt_kode_barang.Text = .Rows(i).Cells(0).Value
                txt_nama_barang.Text = .Rows(i).Cells(1).Value
                txt_satuan.Text = .Rows(i).Cells(2).Value
                txt_harga_satuan.Text = .Rows(i).Cells(3).Value
                txt_lokasi_rak.Text = .Rows(i).Cells(4).Value
                txt_created_at.Text = .Rows(i).Cells(5).Value
            End If
        End With
    End Sub

    Private Sub txt_satuan_TextChanged(sender As Object, e As EventArgs) Handles txt_satuan.TextChanged

    End Sub

    Sub getKodeBarangNext()
        Call koneksi()
        Sql = "SELECT CONCAT('B-', LPAD(MAX(CAST(SUBSTR(kode_barang, 3,4) AS UNSIGNED)) + 1, 4, '0')) AS kode_barang FROM product"
        Cmd = New MySqlCommand(Sql, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Dim kode_barang As String = Rd.Item("kode_barang")
            If kode_barang = "" Then
                MsgBox("Gagal Generate Kode Barang, hubungi admin")
                Exit Sub
            Else
                txt_kode_barang.Text = kode_barang
            End If
        End If
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        If btn_input.Text = "INPUT" Then
            'siapkan tombol
            btn_input.Text = "SIMPAN"
            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "BATAL"
            txt_kode_barang.Enabled = False
            txt_nama_barang.Focus()
            'siapkan form
            Call fieldAktif()

            txt_kode_barang.Enabled = False
            getKodeBarangNext()
        Else
            If txt_kode_barang.Text = "" Or txt_nama_barang.Text = "" Or txt_satuan.Text = "" Or txt_harga_satuan.Text = "" Or txt_lokasi_rak.Text = "" Then
                MsgBox("Data belum lengkap, mohon dilengkapi")
                Exit Sub
            Else
                'cek apakah kode barang sudah ada
                If txt_kode_barang.Text.Length <> 6 Then
                    MsgBox("Kode barang harus 6 karakter dan sesuai Penulisan. Ex B-0001")
                    Exit Sub
                End If

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("kode_barang").Value = txt_kode_barang.Text Then
                        MsgBox("Kode barang sudah ada")
                        Exit Sub
                    End If
                Next

                Call koneksi()
                Sql = "INSERT INTO product VALUES (@kode_barang, @nama_barang, @satuan, @harga_satuan, @lokasi_rak, @created_at)"
                Cmd = New MySqlCommand(Sql, Conn)
                Cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text)
                Cmd.Parameters.AddWithValue("@nama_barang", txt_nama_barang.Text)
                Cmd.Parameters.AddWithValue("@satuan", txt_satuan.Text)
                Cmd.Parameters.AddWithValue("@harga_satuan", txt_harga_satuan.Text)
                Cmd.Parameters.AddWithValue("@lokasi_rak", txt_lokasi_rak.Text)
                Cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan")
                Call formKondisiAwal()
            End If
        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "EDIT" Then
            'siapkan tombol
            btn_edit.Text = "SIMPAN"
            btn_input.Enabled = False
            btn_hapus.Enabled = False
            btn_tutup.Text = "BATAL"
            txt_kode_barang.Focus()
            'siapkan form
            Call fieldAktif()
        Else
            Call koneksi()
            Sql = "UPDATE product SET nama_barang = @nama_barang, satuan = @satuan, harga_satuan = @harga_satuan, lokasi_rak = @lokasi_rak, created_at = @created_at WHERE kode_barang = @kode_barang"
            Cmd = New MySqlCommand(Sql, Conn)
            Cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text)
            Cmd.Parameters.AddWithValue("@nama_barang", txt_nama_barang.Text)
            Cmd.Parameters.AddWithValue("@satuan", txt_satuan.Text)
            Cmd.Parameters.AddWithValue("@harga_satuan", txt_harga_satuan.Text)
            Cmd.Parameters.AddWithValue("@lokasi_rak", txt_lokasi_rak.Text)
            Cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            Call formKondisiAwal()
        End If
    End Sub

    Private Sub txt_kode_barang_TextChanged(sender As Object, e As EventArgs) Handles txt_kode_barang.TextChanged

    End Sub

    Private Sub txt_kode_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kode_barang.KeyPress
        If e.KeyChar() = Chr(13) Then
            Call koneksi()
            Sql = "SELECT * FROM product WHERE kode_barang = @kode_barang"
            Cmd = New MySqlCommand(Sql, Conn)
            Cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text)
            Cmd.ExecuteNonQuery()
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                txt_nama_barang.Text = Rd.Item("nama_barang")
                txt_satuan.Text = Rd.Item("satuan")
                txt_harga_satuan.Text = Rd.Item("harga_satuan")
                txt_lokasi_rak.Text = Rd.Item("lokasi_rak")
                txt_created_at.Text = Rd.Item("created_at")
            Else
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If btn_hapus.Text = "HAPUS" Then
            'siapkan tombol
            btn_hapus.Text = "YA"
            btn_input.Enabled = False
            btn_edit.Enabled = False
            btn_tutup.Text = "TIDAK"
            txt_kode_barang.Focus()
            'siapkan form
            Call fieldAktif()
        Else
            If txt_kode_barang.Text = "" Or txt_nama_barang.Text = "" Or txt_satuan.Text = "" Or txt_harga_satuan.Text = "" Or txt_lokasi_rak.Text = "" Then
                MsgBox("Data belum lengkap, mohon dilengkapi untuk penghapusan data")
                Exit Sub
            Else
                Call koneksi()
                Sql = "DELETE FROM product WHERE kode_barang = @kode_barang"
                Cmd = New MySqlCommand(Sql, Conn)
                Cmd.Parameters.AddWithValue("@kode_barang", txt_kode_barang.Text)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call formKondisiAwal()
            End If
        End If
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        If btn_tutup.Text = "TUTUP" Then
            Me.Close()
        Else
            Call formKondisiAwal()
        End If
    End Sub

    Private Sub btn_input_penjualan_Click(sender As Object, e As EventArgs) Handles btn_input_penjualan.Click
        InitializeComponent()
        If Me.TopLevel Then
            Me.IsMdiContainer = True
        Else
            MessageBox.Show("This form must be a top-level form to be an MDI container.")
        End If
    End Sub

    Private Sub txt_lokasi_rak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_lokasi_rak.SelectedIndexChanged

    End Sub

End Class