Public Class Form2

    Dim timkiemhd As Object

    Private Sub KháchHàngToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KháchHàngToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NhânViênToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        Hoadon.Show()
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        Hoadon2.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class