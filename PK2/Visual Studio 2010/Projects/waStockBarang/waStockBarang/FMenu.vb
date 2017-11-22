Public Class FMenu

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FBarang.StartPosition = FormStartPosition.CenterScreen
        FBarang.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        FPelanggan.StartPosition = FormStartPosition.CenterScreen
        FPelanggan.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        FSupplier.StartPosition = FormStartPosition.CenterScreen
        FSupplier.Show()
    End Sub
End Class
