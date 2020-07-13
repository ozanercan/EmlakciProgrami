Public Class Form_Menu

    Private Sub YeniMüşteriEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniMüşteriEkleToolStripMenuItem.Click
        Form_MusteriEkle.Show()
        Form_MusteriEkle.Dock = DockStyle.Fill
        Form_MusteriEkle.MdiParent = Me
    End Sub

    Private Sub YeniKonutKaydıEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniKonutKaydıEkleToolStripMenuItem.Click
        Form_KonutEkle.Show()
        Form_KonutEkle.Dock = DockStyle.Fill
        Form_KonutEkle.MdiParent = Me
    End Sub

    Private Sub BekleyenKonutlarıGörToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BekleyenKonutlarıGörToolStripMenuItem.Click
        Form_BekleyenKonutlar.Show()
        Form_BekleyenKonutlar.Dock = DockStyle.Fill
        Form_BekleyenKonutlar.MdiParent = Me
    End Sub

    Private Sub MüşteriDüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriDüzenleToolStripMenuItem.Click
        Form_MusteriDuzenle.Show()
        Form_MusteriDuzenle.Dock = DockStyle.Fill
        Form_MusteriDuzenle.MdiParent = Me
    End Sub

    Private Sub YeniPersonelEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniPersonelEkleToolStripMenuItem.Click
        Form_PersonelEkle.Show()
        Form_PersonelEkle.Dock = DockStyle.Fill
        Form_PersonelEkle.MdiParent = Me
    End Sub

    Private Sub PersonelDüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelDüzenleToolStripMenuItem.Click
        Form_PersonelDuzenle.Show()
        Form_PersonelDuzenle.Dock = DockStyle.Fill
        Form_PersonelDuzenle.MdiParent = Me
    End Sub

    Private Sub DoluKonutlarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoluKonutlarToolStripMenuItem.Click
        Form_DoluKonutlar.Show()
        Form_DoluKonutlar.Dock = DockStyle.Fill
        Form_DoluKonutlar.MdiParent = Me
    End Sub

    Private Sub Form_Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class