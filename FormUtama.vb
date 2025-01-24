Public Class FormUtama
    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        FormLogin.MdiParent = Me
        FormLogin.Show()
    End Sub

    Private Sub ExiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExiToolStripMenuItem.Click
        End
    End Sub

    Private Sub DataProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataProdukToolStripMenuItem.Click
        FormBarang.MdiParent = Me
        FormBarang.Show()
    End Sub

    Private Sub ProdukMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukMasukToolStripMenuItem.Click
        FormTransaksiMasuk.MdiParent = Me
        FormTransaksiMasuk.Show()
    End Sub

    Private Sub ProdukKeluarpenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukKeluarpenjualanToolStripMenuItem.Click
        FormTransaksiKeluar.MdiParent = Me
        FormTransaksiKeluar.Show()
    End Sub
End Class