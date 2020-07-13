Public Class Form_GirisYap

    Dim vt As New VeriTabani
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.BackColor = Color.Red
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If vt.GiriSYap(TextBox1.Text, TextBox2.Text) = True Then
            Form_Menu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form_GirisYap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
