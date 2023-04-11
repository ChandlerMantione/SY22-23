Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = sender.text
        If sender.text = "Wool" Then
            DisplayPictureBox.Image = PictureBox1.Image
            PriceTextBox.Text = 2.0
        End If
        If sender.text = "Berber" Then
            DisplayPictureBox.Image = PictureBox2.Image
            PriceTextBox.Text = 1.5
        End If
        If sender.text = "Persian" Then
            DisplayPictureBox.Image = PictureBox3.Image
            PriceTextBox.Text = 2.5
        End If
        Dim Length As Decimal
        Dim Width As Decimal
        Dim Price As Decimal
        Decimal.TryParse(LengthTextBox.Text, Length)
        Decimal.TryParse(WidthTextBox.Text, Width)
        Decimal.TryParse(PriceTextBox.Text, Price)
        TotalTextBox.Text = Length * Width * Price
    End Sub
End Class
