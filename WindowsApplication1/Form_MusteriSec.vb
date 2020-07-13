Public Class Form_MusteriSec

    Public konutid As String
    Public saticiid As String

    Dim vt As New VeriTabani
    Sub listele()
        If RadioButton1.Checked = True Then
            DataGridView1.DataSource = vt.MusteriListele("Ad", TextBox1.Text)
        ElseIf RadioButton2.Checked = True Then
            DataGridView1.DataSource = vt.MusteriListele("Tc", TextBox1.Text)
        End If
    End Sub
    Private Sub Form_MusteriyeVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = vt.MusteriListele("Genel", TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        listele()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Form_EmlakIsleminiGerceklestir.konutid = konutid
        Form_EmlakIsleminiGerceklestir.saticiid = saticiid
        Form_EmlakIsleminiGerceklestir.aliciid = DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString()
        Form_EmlakIsleminiGerceklestir.Dock = DockStyle.Fill
        Form_EmlakIsleminiGerceklestir.MdiParent = Form_Menu
        Form_EmlakIsleminiGerceklestir.Show()
    End Sub
End Class