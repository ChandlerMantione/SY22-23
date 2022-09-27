Public Class InfinityCubeForm
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Integer.TryParse(TextBox1.Text, InfinityCubeBlack)
    End Sub

    Private Sub BuyButton2_Click(sender As Object, e As EventArgs) Handles BuyButton2.Click
        Integer.TryParse(TextBox1.Text, InfinityCubeSilver)
    End Sub
End Class