<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem1 = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExiToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        UserToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        DataProdukToolStripMenuItem = New ToolStripMenuItem()
        ProdukMasukToolStripMenuItem = New ToolStripMenuItem()
        ProdukKeluarpenjualanToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        HarianToolStripMenuItem = New ToolStripMenuItem()
        BulananToolStripMenuItem = New ToolStripMenuItem()
        TahunanToolStripMenuItem = New ToolStripMenuItem()
        UtilityToolStripMenuItem = New ToolStripMenuItem()
        TentangAplikasiToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        GantiPasswordToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ButtonShadow
        MenuStrip1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, LoginToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, UtilityToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 31)
        MenuStrip1.TabIndex = 15
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem1, LogoutToolStripMenuItem, ToolStripMenuItem1, ExiToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(52, 27)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LoginToolStripMenuItem1
        ' 
        LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        LoginToolStripMenuItem1.ShortcutKeys = Keys.F5
        LoginToolStripMenuItem1.Size = New Size(168, 28)
        LoginToolStripMenuItem1.Text = "Login"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(168, 28)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(165, 6)
        ' 
        ' ExiToolStripMenuItem
        ' 
        ExiToolStripMenuItem.Name = "ExiToolStripMenuItem"
        ExiToolStripMenuItem.Size = New Size(168, 28)
        ExiToolStripMenuItem.Text = "Exit"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UserToolStripMenuItem})
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(79, 27)
        LoginToolStripMenuItem.Text = "Master"
        ' 
        ' UserToolStripMenuItem
        ' 
        UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        UserToolStripMenuItem.Size = New Size(129, 28)
        UserToolStripMenuItem.Text = "User"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataProdukToolStripMenuItem, ProdukMasukToolStripMenuItem, ProdukKeluarpenjualanToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(97, 27)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' DataProdukToolStripMenuItem
        ' 
        DataProdukToolStripMenuItem.Name = "DataProdukToolStripMenuItem"
        DataProdukToolStripMenuItem.Size = New Size(311, 28)
        DataProdukToolStripMenuItem.Text = "Data Produk"
        ' 
        ' ProdukMasukToolStripMenuItem
        ' 
        ProdukMasukToolStripMenuItem.Name = "ProdukMasukToolStripMenuItem"
        ProdukMasukToolStripMenuItem.Size = New Size(311, 28)
        ProdukMasukToolStripMenuItem.Text = "Produk Masuk (pembelian)"
        ' 
        ' ProdukKeluarpenjualanToolStripMenuItem
        ' 
        ProdukKeluarpenjualanToolStripMenuItem.Name = "ProdukKeluarpenjualanToolStripMenuItem"
        ProdukKeluarpenjualanToolStripMenuItem.Size = New Size(311, 28)
        ProdukKeluarpenjualanToolStripMenuItem.Text = "Produk Keluar (penjualan)"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HarianToolStripMenuItem, BulananToolStripMenuItem, TahunanToolStripMenuItem})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(89, 27)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' HarianToolStripMenuItem
        ' 
        HarianToolStripMenuItem.Name = "HarianToolStripMenuItem"
        HarianToolStripMenuItem.Size = New Size(161, 28)
        HarianToolStripMenuItem.Text = "Harian"
        ' 
        ' BulananToolStripMenuItem
        ' 
        BulananToolStripMenuItem.Name = "BulananToolStripMenuItem"
        BulananToolStripMenuItem.Size = New Size(161, 28)
        BulananToolStripMenuItem.Text = "Bulanan"
        ' 
        ' TahunanToolStripMenuItem
        ' 
        TahunanToolStripMenuItem.Name = "TahunanToolStripMenuItem"
        TahunanToolStripMenuItem.Size = New Size(161, 28)
        TahunanToolStripMenuItem.Text = "Tahunan"
        ' 
        ' UtilityToolStripMenuItem
        ' 
        UtilityToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TentangAplikasiToolStripMenuItem, ToolStripMenuItem2, GantiPasswordToolStripMenuItem})
        UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        UtilityToolStripMenuItem.Size = New Size(74, 27)
        UtilityToolStripMenuItem.Text = "Utility"
        ' 
        ' TentangAplikasiToolStripMenuItem
        ' 
        TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        TentangAplikasiToolStripMenuItem.Size = New Size(227, 28)
        TentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(224, 6)
        ' 
        ' GantiPasswordToolStripMenuItem
        ' 
        GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        GantiPasswordToolStripMenuItem.Size = New Size(227, 28)
        GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUtama"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdukMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdukKeluarpenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HarianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BulananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TahunanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
End Class
