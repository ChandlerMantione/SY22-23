Imports System.Reflection.Metadata.Ecma335

Class MainWindow
    Private Sub volumeConvertButton_Click(sender As Object, e As RoutedEventArgs) Handles volumeConvertButton.Click
        Dim amt As Decimal
        Dim frate As Decimal
        Dim trate As Decimal
        Decimal.TryParse(fromTextBox.Text, amt)
        If standardvolumeCombo.Text = "tablespoon" Then frate = 14.7868
        If standardvolumeCombo.Text = "fluid ounce" Then frate = 29.5735
        If standardvolumeCombo.Text = "gill" Then frate = 118.294
        If standardvolumeCombo.Text = "cup" Then frate = 236.588
        If standardvolumeCombo.Text = "pint" Then frate = 473.176
        If standardvolumeCombo.Text = "quart" Then frate = 946.353
        If standardvolumeCombo.Text = "gallon" Then frate = 3785.41

        If metricvolumeCombo.Text = "liter" Then trate = 1000
        If metricvolumeCombo.Text = "milliliter" Then trate = 14.7868
        If metricvolumeCombo.Text = "kiloliter" Then trate = 14.7868
        toTextBox.Text = Convert(amt, frate, trate)
    End Sub
    Private Sub lengthConvertButton_Click(sender As Object, e As RoutedEventArgs) Handles lengthConvertButton_.Click
        Dim amt As Decimal
        Dim frate As Decimal
        Dim trate As Decimal
        Decimal.TryParse(fromTextBox.Text, amt)
        If standardLengthCombo.Text = "inch" Then frate = 25.4
        If standardLengthCombo.Text = "foot" Then frate = 304.8
        If standardLengthCombo.Text = "yard" Then frate = 914.4
        If standardLengthCombo.Text = "mile" Then frate = 1.609 * 10 ^ 6

        If metricLengthCombo.Text = "kilometer" Then trate = 39370.1
        If metricLengthCombo.Text = "millimeter" Then trate = 0.0393701
        If metricLengthCombo.Text = "meter" Then trate = 39.3701
        If metricLengthCombo.Text = "centimeter" Then trate = 0.393701
        toTextBox.Text = Convert(amt, frate, trate)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
        fromTextBox.Text = ""
        toTextBox.Text = ""
        standardLengthCombo.Text = ""
        standardvolumeCombo.Text = ""
        metricvolumeCombo.Text = ""
        metricLengthCombo.Text = ""
    End Sub
    Function Convert(amt As Decimal, frate As Decimal, trate As Decimal)

        Return amt * frate / trate

    End Function
End Class

