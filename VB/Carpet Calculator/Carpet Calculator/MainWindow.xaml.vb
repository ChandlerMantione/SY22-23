Class MainWindow
    Private Sub CloseButton_Click(sender As Object, e As RoutedEventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
        CarpetCombobox.Text = ""
        LengthTextbox.Text = ""
        WidthTextbox.Text = ""
        SumLable.Content = ""
        LengthSlider.Value = 0
        WidthSlider.Value = 0
    End Sub

    Private Sub LengthTextbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles LengthTextbox.TextChanged

    End Sub
    Private Sub WidthTextbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles WidthTextbox.TextChanged

    End Sub
    Private Sub LengthSlider_ValueChanged(sender As Object, e As EventArgs)
        LengthTextbox.Text = LengthSlider.Value
    End Sub

    Private Sub WidthSlider_ValueChanged(sender As Object, e As EventArgs)
        WidthTextbox.Text = WidthSlider.Value
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As RoutedEventArgs) Handles CalcButton.Click
        Dim length As Decimal
        Dim width As Decimal
        Dim Price As Decimal
        Select Case CarpetCombobox.Text
            Case "Red"
                Price = 4
            Case "Green"
                Price = 5
            Case "Blue"
                Price = 6
        End Select
        Decimal.TryParse(LengthTextbox.Text, length)
        Decimal.TryParse(WidthTextbox.Text, width)
        SumLable.Content = length * width * Price
    End Sub
End Class
