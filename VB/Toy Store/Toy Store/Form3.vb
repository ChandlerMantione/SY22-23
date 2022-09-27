Public Class PickleRickPlushForm
    Private Sub PickleRickPlushForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Integer.TryParse(TextBox1.Text, PickleRickPlush)
    End Sub
End Class