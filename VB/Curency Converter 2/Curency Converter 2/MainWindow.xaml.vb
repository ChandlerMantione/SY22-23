Class MainWindow

    Function Convert(Amt As Decimal, Fromrate As Decimal, Torate As Decimal) As Decimal
        Return Amt / Fromrate * Torate
    End Function

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim fRate As Decimal
        Dim tRate As Decimal
        Dim amt As Decimal
        Decimal.TryParse(FromTextbox.Text, amt)
        If FromCombo.Text = "Dollars" Then
            fRate = 1
        End If
        If FromCombo.Text = "Pesos" Then
            fRate = 18.4
        End If
        If FromCombo.Text = "Euros" Then
            fRate = 0.92
        End If
        If FromCombo.Text = "Pound Sterling" Then
            fRate = 0.81
        End If
        If ToCombo.Text = "Dollars" Then
            tRate = 1
        End If
        If ToCombo.Text = "Pesos" Then
            tRate = 18.4
        End If
        If ToCombo.Text = "Euros" Then
            tRate = 0.92
        End If
        If ToCombo.Text = "Pound Sterling" Then
            tRate = 0.81
        End If
        ToTextBox.Text = Convert(amt, fRate, tRate).ToString("c2")
    End Sub
End Class
