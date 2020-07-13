Public Class Form_DoluKonutlar

    Dim vt As New VeriTabani

    Sub duzenlemeislemi()
        If CheckBox2.Checked = True Then
            DataGridView1.ReadOnly = False
        Else
            DataGridView1.ReadOnly = True
        End If
    End Sub
    Sub listele()
        If RadioButton1.Checked = True Then
            DataGridView1.DataSource = vt.KonutListele(RadioButton1.Text, TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            DataGridView1.DataSource = vt.KonutListele(RadioButton2.Text, TextBox1.Text)
        End If
    End Sub
    Private Sub Form_DoluKonutlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = vt.KonutListele("Genel", TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        listele()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        duzenlemeislemi()
        If CheckBox1.Checked = True Then
            If MessageBox.Show("Konutun Silinmesini İstiyor Musunuz?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If vt.KonutSil("Dolu", DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString()) Then
                    vt.dt.Clear()
                    DataGridView1.DataSource = vt.KonutListele("Genel", TextBox1.Text)
                    MessageBox.Show("Konut Silindi")
                End If
            End If
        End If



        If CheckBox2.Checked = False And CheckBox1.Checked = False Then
            If MessageBox.Show(DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString() + " IDLI " + DataGridView1.Rows(e.RowIndex).Cells("Adres").Value.ToString() + " Adresinde ki " + DataGridView1.Rows(e.RowIndex).Cells("EmlakTipi").Value.ToString() + " Boşa Çıkacak, Bunu Yapmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show(DataGridView1.Rows(e.RowIndex).Cells("Adres").Value.ToString())
                If vt.KonutEkle(DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("SaticiID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("EmlakTipi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Durum").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Il").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Ilce").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Adres").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("MetreKare").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("OdaSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BinaYasi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BulunduguKat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("ToplamKatSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Isitma").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BanyoSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Balkon").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("EsyaDurumu").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Aidat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KrediyeUygunMu").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Fiyat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("ParaBirimi").Value.ToString()) Then
                    vt.KonutSil("Dolu", DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString())
                    MessageBox.Show("Konut Boş Konutlara Aktarıldı")
                End If
            End If
        End If

        

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Form_MusteriListele.Dock = DockStyle.Fill
        Form_MusteriListele.MdiParent = Form_Menu
        If DataGridView1.SelectedCells(e.RowIndex).OwningColumn.HeaderText.ToString() = "SaticiID" Then
            Form_MusteriListele.id = DataGridView1.Rows(e.RowIndex).Cells("SaticiID").Value.ToString()
            Form_MusteriListele.Show()
        ElseIf DataGridView1.SelectedCells(e.RowIndex).OwningColumn.HeaderText.ToString() = "AliciID" Then
            Form_MusteriListele.id = DataGridView1.Rows(e.RowIndex).Cells("AliciID").Value.ToString()
            Form_MusteriListele.Show()
        End If
        


    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit


        If CheckBox2.Checked = True Then
            vt.KonutDuzenle("Dolu", DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("SaticiID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("AliciID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("EmlakTipi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Il").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Ilce").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Adres").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("MetreKare").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("OdaSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BinaYasi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BulunduguKat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("ToplamKatSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Isitma").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BanyoSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Balkon").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("EsyaDurumu").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Aidat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KrediyeUygunMu").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Durum").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Fiyat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("ParaBirimi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KayitTarihi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Gorsel").Value.ToString())
        End If
        MessageBox.Show("Güncellendi")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        duzenlemeislemi()


    End Sub
End Class