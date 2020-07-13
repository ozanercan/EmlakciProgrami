Public Class Form_PersonelDuzenle

    Dim vt As New VeriTabani

    Sub duzenlemeislemi()
        If CheckBox2.Checked = True Then
            DataGridView1.ReadOnly = False
        Else
            DataGridView1.ReadOnly = True
        End If
    End Sub
    Private Sub Form_PersonelDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = vt.PersonelListele("Genel", TextBox1.Text)
    End Sub


    Sub listele()
        If RadioButton1.Checked = True Then
            DataGridView1.DataSource = vt.PersonelListele("Ad", TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            DataGridView1.DataSource = vt.PersonelListele("Tc", TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        listele()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If vt.PersonelDuzenle(DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("TcNo").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Ad").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Soyad").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("CepTel").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Il").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Ilce").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Adres").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KullaniciAdi").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("Sifre").Value.ToString(), DataGridView1.Rows(e.RowIndex).Cells("KayitTarihi").Value.ToString()) = True Then
            MessageBox.Show("Güncellendi")
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        duzenlemeislemi()
        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            Dim soru As DialogResult = MessageBox.Show(DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString() + " IDLI " + DataGridView1.Rows(e.RowIndex).Cells("Ad").Value.ToString() + " " + DataGridView1.Rows(e.RowIndex).Cells("Soyad").Value.ToString() + " Kişisini Silmek İstiyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If soru = Windows.Forms.DialogResult.Yes Then
                If vt.PersonelSil(DataGridView1.Rows(e.RowIndex).Cells("ID").Value) = True Then
                    listele()
                    MessageBox.Show("Silme İşlemi Başarılı", "UYARI")
                End If

            End If
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        duzenlemeislemi()
    End Sub
End Class