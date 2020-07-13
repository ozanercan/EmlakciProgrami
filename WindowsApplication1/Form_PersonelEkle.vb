Public Class Form_PersonelEkle
    Dim vt As New VeriTabani

    Private Sub Form_PersonelEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vt.idolustur("Personel")
        cmb_Il.SelectedIndex = 0
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If vt.PersonelEkle(txt_PersonelID.Text, mtxt_TcNo.Text, txt_Ad.Text, txt_Soyad.Text, mtxt_CepTel.Text, cmb_Il.Text, txt_ilce.Text, rtxt_Adres.Text, txt_KullaniciAdi.Text, txt_Sifre.Text) = True Then
            MessageBox.Show(txt_Ad.Text + " " + txt_Soyad.Text + " Adlı Personel Kayıt Edilmiştir." + Chr(13) + Chr(13) + "Kullanıcı Adı: " + txt_KullaniciAdi.Text + Chr(13) + "Şifre: " + txt_Sifre.Text)
        Else
            MessageBox.Show("Personel Kayıt İşlemi Başarısız Oldu")
        End If

    End Sub
End Class