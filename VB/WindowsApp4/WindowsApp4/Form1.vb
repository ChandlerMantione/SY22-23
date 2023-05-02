Public Class Form1
    Dim WithEvents Maro As New Pez
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maro.Count = 10
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Maro.POP()
        Label1.Text = Maro.Count
    End Sub

    Private Sub Maro_IsEmpty() Handles Maro.IsEmpty
        Me.BackColor = Color.Red
    End Sub
End Class
