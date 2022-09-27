Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim total As Decimal
        Decimal.TryParse(TextBox1.Text, total)
        Dim tip As Decimal
        Dim tax As Decimal
        If FiveRadioButton.Checked Then
            tip = total * 0.05
        End If
        If TenRadioButton.Checked Then
            tip = total * 0.1
        End If
        If FifteenRadioButton.Checked Then
            tip = total * 0.15
        End If
        If TwantyRadioButton.Checked Then
            tip = total * 0.2
        End If
        If TwentyFiveRadioButton.Checked Then
            tip = total * 0.25
        End If
        Dim grandtotal As Decimal
        tax = total * 0.0255
        grandtotal = total + tip + tax
        TipLabel.Text = tip.ToString("c2")
        TotalLabel.Text = grandtotal.ToString("c2")
        TaxLabel.Text = tax.ToString("c2")
    End Sub
    Private Sub TwentyFiveRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TwentyFiveRadioButton.CheckedChanged, TwantyRadioButton.CheckedChanged, TenRadioButton.CheckedChanged, FiveRadioButton.CheckedChanged, FifteenRadioButton.CheckedChanged
        Dim total As Decimal
        Decimal.TryParse(TextBox1.Text, total)
        Dim tip As Decimal
        Dim tax As Decimal
        If FiveRadioButton.Checked Then
            tip = total * 0.05
        End If
        If TenRadioButton.Checked Then
            tip = total * 0.1
        End If
        If FifteenRadioButton.Checked Then
            tip = total * 0.15
        End If
        If TwantyRadioButton.Checked Then
            tip = total * 0.2
        End If
        If TwentyFiveRadioButton.Checked Then
            tip = total * 0.25
        End If
        Dim grandtotal As Decimal
        tax = total * 0.0255
        grandtotal = total + tip + tax
        TipLabel.Text = tip.ToString("c2")
        TotalLabel.Text = grandtotal.ToString("c2")
        TaxLabel.Text = tax.ToString("c2")
    End Sub
End Class
