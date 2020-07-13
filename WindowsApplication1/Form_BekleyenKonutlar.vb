Public Class Form_BekleyenKonutlar
    Dim vt As New VeriTabani

    Sub duzenlemeislemi()
        If CheckBox2.Checked = True Then
            DataGridView1.ReadOnly = False
        Else
            DataGridView1.ReadOnly = True
        End If
    End Sub
    
    Private Sub Form_BekleyenKonutlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = vt.BekleyenKonutlariListele()
    End Sub

    Private Sub cmb_Il_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Il.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = vt.FiltreliKonutListele(cmb_Il.Text, cmb_EmlakTipi.Text, cmb_Durum.Text, cmb_EsyaDurumu.Text)
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("Aradığınız Kriterde Konut Bulunamadı")
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        duzenlemeislemi()
        If CheckBox1.Checked = True Then
            If MessageBox.Show("Konutun Silinmesini İstiyor Musunuz?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If vt.KonutSil("Boş", DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString()) Then
                    MessageBox.Show("Konut Silindi")
                End If
            End If
        End If

        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            Form_MusteriSec.konutid = DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString()
            Form_MusteriSec.saticiid = DataGridView1.Rows(e.RowIndex).Cells("SaticiID").Value.ToString()
            Form_MusteriSec.Dock = DockStyle.Fill
            Form_MusteriSec.MdiParent = Form_Menu
            Form_MusteriSec.Show()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        duzenlemeislemi()

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If CheckBox2.Checked = True Then
            If vt.KonutDuzenle("Boş", DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("SaticiID").Value.ToString(), "", DataGridView1.Rows(e.RowIndex).Cells("EmlakTipi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Il").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Ilce").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Adres").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("MetreKare").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("OdaSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BinaYasi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BulunduguKat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("ToplamKatSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Isitma").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("BanyoSayisi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Balkon").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("EsyaDurumu").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Aidat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KrediyeUygunMu").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Durum").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Fiyat").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("ParaBirimi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KayitTarihi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Gorsel").Value.ToString()) = True Then
                MessageBox.Show("Güncellendi")
            End If
        End If
    End Sub
End Class