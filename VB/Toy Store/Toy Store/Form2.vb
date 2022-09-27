Public Class CartForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = PickleRickPlush
        Label2.Text = ButterFlyPen
        Label3.Text = InfinityCubeBlack
        Label4.Text = InfinityCubeSilver
        Label5.Text = ChessBoard
        Label6.Text = ChineseFingerTrap
        PPickleRickPlushLabel.Text = PickleRickPlush * 25
        PButterflyPenLabel.Text = ButterFlyPen * 10
        PBlackInfinityCubeLabel.Text = InfinityCubeBlack * 6
        PSilverInfinityCubeLabel.Text = InfinityCubeSilver * 10
        PChessBoardLabel.Text = ChessBoard * 20
        PChineseFingerTrapLabel.Text = ChineseFingerTrap * 0.25
        TotalAmountLabel.Text = (PickleRickPlush * 25) + (ButterFlyPen * 10) + (InfinityCubeBlack * 6) + (InfinityCubeSilver * 10) + (ChessBoard * 20) + (ChineseFingerTrap * 0.25)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ProcedToCheckoutButton_Click(sender As Object, e As EventArgs)
        CheckOutForm.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class