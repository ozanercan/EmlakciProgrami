Public Class Form_MusteriListele

    Dim vt As New VeriTabani
    Public id As String

    Private Sub Form_MusteriListele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = vt.MusteriListele2("ID", id)
    End Sub
End Class