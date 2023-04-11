Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If ColorCombobox.Text = "Red" Then
            Me.Background = New SolidColorBrush(Colors.Red)
        End If
        If ColorCombobox.Text = "Blue" Then
            Me.Background = New SolidColorBrush(Colors.Blue)
        End If
        If ColorCombobox.Text = "Green" Then
            Me.Background = New SolidColorBrush(Colors.Green)
        End If
        If ColorCombobox.Text = "Blanched Almond" Then
            Me.Background = New SolidColorBrush(Colors.BlanchedAlmond)
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim angle As Decimal
        Decimal.TryParse(AngleTextbox.Text, angle)
        Select Case ColorCombobox.Text
            Case "Red"
                Me.Background = New SolidColorBrush(Colors.Red)
            Case "Blue"
                Me.Background = New SolidColorBrush(Colors.Blue)
            Case "Green"
                Me.Background = New SolidColorBrush(Colors.Green)
            Case "Blanched Almond"
                Me.Background = New SolidColorBrush(Colors.BlanchedAlmond)
            Case Else
                Me.Background = New LinearGradientBrush(Colors.Blue, Colors.Orange, angle)
        End Select
    End Sub

    Private Sub AngleSlider_ValueChanged(sender As Object, e As EventArgs)
        AngleTextbox.Text = sender.Value
        Me.Background = New LinearGradientBrush(Colors.BlanchedAlmond, Colors.BurlyWood, sender.value)
    End Sub

    Private Sub RGBButton_Click(sender As Object, e As RoutedEventArgs) Handles RGBButton.Click
        Dim red As Decimal
        Dim Green As Decimal
        Dim Blue As Decimal
        Decimal.TryParse(RedTextbox.Text, red)
        Decimal.TryParse(GreenTextbox.Text, Green)
        Decimal.TryParse(BlueTextbox.Text, Blue)
        ShowColor()
    End Sub

    Private Sub RedSlider_ValueChanged(sender As Object, e As EventArgs)
        RedTextbox.Text = sender.value
        ShowColor()
    End Sub

    Private Sub GreenSlider_ValueChanged(sender As Object, e As EventArgs)
        GreenTextbox.Text = sender.value
        ShowColor()
    End Sub

    Private Sub BlueSlider_ValueChanged(sender As Object, e As EventArgs)
        BlueTextbox.Text = sender.value
        ShowColor()
    End Sub
    Sub ShowColor()
        Dim Red As Decimal
        Dim Green As Decimal
        Dim Blue As Decimal
        Decimal.TryParse(RedTextbox.Text, red)
        Decimal.TryParse(GreenTextbox.Text, Green)
        Decimal.TryParse(BlueTextbox.Text, Blue)

        Me.Background = New SolidColorBrush(Color.FromArgb(255, Red, Green, Blue))
    End Sub
End Class
