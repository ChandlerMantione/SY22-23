Public Class Form1
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        Dim amount As Decimal
        Decimal.TryParse(AmountTextBox.Text, amount)
        Dim Fee As Decimal
        Fee = amount * 0.03
        NameTextBox.Clear()
        CCTextBox.Clear()
        EXPDateTextBox.Clear()
        ZipTextBox.Clear()
        AmountTextBox.Clear()
        FeeTextBox.Text = Fee.ToString("c2")
    End Sub
End Class
