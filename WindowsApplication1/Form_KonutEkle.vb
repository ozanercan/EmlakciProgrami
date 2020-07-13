Public Class Form_KonutEkle

    Dim vt As New VeriTabani

    Private Sub Form_KonutEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_Musteri.DataSource = vt.GenelMusteriListele()
        txt_KonutID.Text = vt.idolustur("Konut")
        cmb_EmlakTipi.SelectedIndex = 0
        cmb_Durum.SelectedIndex = 0
        cmb_Balkon.SelectedIndex = 0
        cmb_EsyaDurumu.SelectedIndex = 0
        cmb_Il.SelectedIndex = 0
        cmb_KrediyeUygun.SelectedIndex = 0
        cmb_ParaBirimi.SelectedIndex = 0
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_MusteriEkle.Show()
    End Sub

    Private Sub DataGridView_Musteri_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Musteri.CellEnter
        txt_MusteriID.Text = DataGridView_Musteri.Rows(e.RowIndex).Cells("ID").Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vt.KonutEkle(txt_KonutID.Text, txt_MusteriID.Text, cmb_EmlakTipi.Text, cmb_Durum.Text, cmb_Il.Text, txt_ilce.Text, rtxt_Adres.Text, mtxt_MetreKare.Text, txt_OdaSayisi.Text, txt_BinaYasi.Text, txt_BulunduguKat.Text, txt_ToplamKatSayisi.Text, txt_Isitma.Text, txt_BanyoSayisi.Text, cmb_Balkon.Text, cmb_EsyaDurumu.Text, txt_Aidat.Text, cmb_KrediyeUygun.Text, mtxt_Fiyat.Text, cmb_ParaBirimi.Text) = True Then
            MessageBox.Show("Konut Eklendi.")
        Else
            MessageBox.Show("Konut Eklenemedi")
        End If
    End Sub
End Class