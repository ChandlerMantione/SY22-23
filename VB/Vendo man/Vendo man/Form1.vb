Public Class Form1
    Dim WithEvents cd As New CoinDespenser
    Private Sub NickelButton_Click(sender As Object, e As EventArgs) Handles NickelButton.Click
        cd.InsertNickel()
        Label1.Text = cd.Total.ToString("c2")
    End Sub

    Private Sub DimeButton_Click(sender As Object, e As EventArgs) Handles DimeButton.Click
        cd.InsertDime()
        Label1.Text = cd.Total.ToString("c2")
    End Sub

    Private Sub QuarterButton_Click(sender As Object, e As EventArgs) Handles QuarterButton.Click
        cd.InsertQuarter()
        Label1.Text = cd.Total.ToString("c2")
    End Sub

    Private Sub HalfDollarButton_Click(sender As Object, e As EventArgs) Handles HalfDollarButton.Click
        cd.InsertHalfDollar()
        Label1.Text = cd.Total.ToString("c2")
    End Sub

    Private Sub DollarButton_Click(sender As Object, e As EventArgs) Handles DollarButton.Click
        cd.InsertDollar()
        Label1.Text = cd.Total.ToString("c2")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cd.Restock(1)
        cd.SetPrice(1, 0.75)
        cd.Restock(2)
        cd.SetPrice(2, 0.75)
        cd.Restock(3)
        cd.SetPrice(3, 0.75)
        cd.Restock(4)
        cd.SetPrice(4, 0.5)
        cd.Restock(5)
        cd.SetPrice(5, 1.5)
        cd.Restock(6)
        cd.SetPrice(6, 2.0)
        cd.Restock(7)
        cd.SetPrice(7, 2.5)
        cd.Restock(8)
        cd.SetPrice(8, 3.0)
        cd.Restock(9)
        cd.SetPrice(9, 4.0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cd.Vend(1)
        Label1.Text = cd.Total.ToString
    End Sub

    Private Sub cd_DispenseProduct(N As Integer) Handles cd.DispenseProduct
        PictureBox11.Image = ImageList1.Images(N)
    End Sub

    Private Sub CokeButton_Click(sender As Object, e As EventArgs) Handles CokeButton.Click
        cd.Vend(1)
    End Sub

    Private Sub PepsiButton_Click(sender As Object, e As EventArgs) Handles PepsiButton.Click
        cd.Vend(2)
    End Sub

    Private Sub SpriteButton_Click(sender As Object, e As EventArgs) Handles SpriteButton.Click
        cd.Vend(3)
    End Sub

    Private Sub MnMsButton_Click(sender As Object, e As EventArgs) Handles MnMsButton.Click
        cd.Vend(4)
    End Sub

    Private Sub FruitButton_Click(sender As Object, e As EventArgs) Handles FruitButton.Click
        cd.Vend(5)
    End Sub

    Private Sub ChexMixButton_Click(sender As Object, e As EventArgs) Handles ChexMixButton.Click
        cd.Vend(6)
    End Sub

    Private Sub SkittlesButton_Click(sender As Object, e As EventArgs) Handles SkittlesButton.Click
        cd.Vend(7)
    End Sub

    Private Sub StarburstButton_Click(sender As Object, e As EventArgs) Handles StarburstButton.Click
        cd.Vend(8)
    End Sub

    Private Sub IceCreamButton_Click(sender As Object, e As EventArgs) Handles IceCreamButton.Click
        cd.Vend(9)
    End Sub
End Class
