Public Class Form_EmlakIsleminiGerceklestir

    Dim vt As New VeriTabani

    Public konutid, saticiid, aliciid As String


    Sub listele()
        DataGridView3.DataSource = vt.KonutListele(konutid)

        DataGridView1.DataSource = vt.MusteriListele("ID", saticiid)
        DataGridView2.DataSource = vt.MusteriListele2("ID", aliciid)

        TextBox1.Text = DataGridView3.Rows(0).Cells("Fiyat").Value.ToString()
        cmb_ParaBirimi.Text = DataGridView3.Rows(0).Cells("ParaBirimi").Value.ToString()

        If DataGridView3.Rows(0).Cells("Durum").Value.ToString() = "Aylık Kiralık" Then
            RadioButton2.Checked = True
        ElseIf DataGridView3.Rows(0).Cells("Durum").Value.ToString() = "Günlük Kiralık" Then
            RadioButton1.Checked = True
        Else
            RadioButton3.Checked = True
        End If

    End Sub
    Private Sub Form_EmlakIsleminiGerceklestir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Görsel Seç"
        OpenFileDialog1.Filter = "Görsel Dosyası (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If vt.EmlakIsleminiTamamla(konutid, saticiid, aliciid, DataGridView3.Rows(0).Cells("EmlakTipi").Value.ToString(), DataGridView3.Rows(0).Cells("Il").Value.ToString(), DataGridView3.Rows(0).Cells("Ilce").Value.ToString(), DataGridView3.Rows(0).Cells("Adres").Value.ToString(), DataGridView3.Rows(0).Cells("MetreKare").Value.ToString(), DataGridView3.Rows(0).Cells("OdaSayisi").Value.ToString(), DataGridView3.Rows(0).Cells("BinaYasi").Value.ToString(), DataGridView3.Rows(0).Cells("BulunduguKat").Value.ToString(), DataGridView3.Rows(0).Cells("ToplamKatSayisi").Value.ToString(), DataGridView3.Rows(0).Cells("Isitma").Value.ToString(), DataGridView3.Rows(0).Cells("BanyoSayisi").Value.ToString(), DataGridView3.Rows(0).Cells("Balkon").Value.ToString(), DataGridView3.Rows(0).Cells("EsyaDurumu").Value.ToString(), DataGridView3.Rows(0).Cells("Aidat").Value.ToString(), DataGridView3.Rows(0).Cells("KrediyeUygunMu").Value.ToString(), DataGridView3.Rows(0).Cells("Durum").Value.ToString(), DataGridView3.Rows(0).Cells("Fiyat").Value.ToString(), DataGridView3.Rows(0).Cells("ParaBirimi").Value.ToString(), PictureBox1.ImageLocation) = True Then
            If Me.PictureBox1.Image IsNot Nothing Then
                Me.PictureBox1.Image.Save(IO.Path.Combine(Application.StartupPath + "//gorsel//" + konutid + " - " + aliciid + ".jpg"))
            End If
            MessageBox.Show("İşlem Tamamlandı")
        End If

    End Sub
End Class