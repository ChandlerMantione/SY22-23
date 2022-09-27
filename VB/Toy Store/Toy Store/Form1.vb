Public Class ShopForm
    Private Sub ShopForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub ExitButton1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CartButton_Click(sender As Object, e As EventArgs) Handles CartButton.Click
        CartForm.ShowDialog()

    End Sub

    Private Sub PickleRickPlushBuyButton_Click(sender As Object, e As EventArgs) Handles PickleRickPlushBuyButton.Click
        PickleRickPlushForm.ShowDialog()

    End Sub

    Private Sub ButterFlyPenBuyButton_Click(sender As Object, e As EventArgs) Handles ButterFlyPenBuyButton.Click
        ButterflyPenForm.ShowDialog()
    End Sub

    Private Sub InfinityCubeBuyButton_Click(sender As Object, e As EventArgs) Handles InfinityCubeBuyButton.Click
        InfinityCubeForm.ShowDialog()
    End Sub

    Private Sub ChessBoardButton_Click(sender As Object, e As EventArgs) Handles ChessBoardButton.Click
        ChessBoardForm.ShowDialog()
    End Sub

    Private Sub ChineseFingerTrapButton_Click(sender As Object, e As EventArgs) Handles ChineseFingerTrapButton.Click
        ChineseFingerTrapForm.ShowDialog()
    End Sub
End Class
