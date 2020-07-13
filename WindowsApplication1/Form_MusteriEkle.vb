Public Class Form_MusteriEkle

    Dim vt As New VeriTabani

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If vt.MusteriEkle(txt_MusteriID.Text, cmb_MusteriTuru.Text, mtxt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, mtxt_IsTel.Text, mtxt_EvTel.Text, mtxt_CepTel.Text, mtxt_Faks.Text, cmb_Il.Text, txt_ilce.Text, rtxt_Adres.Text, txt_EPosta.Text, txt_WebSite.Text, rtxt_Aciklama.Text) = True Then
            MessageBox.Show(txt_Ad.Text + " " + txt_Soyad.Text + " Müşteri Eklenmiştir.")
        Else
            MessageBox.Show("Müşteri Eklenememiştir.")
        End If


    End Sub

    Private Sub Form_MusteriEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_MusteriID.Text = vt.idolustur("Musteri")
        cmb_MusteriTuru.SelectedIndex = 0
        cmb_Il.SelectedIndex = 0
    End Sub
End Class