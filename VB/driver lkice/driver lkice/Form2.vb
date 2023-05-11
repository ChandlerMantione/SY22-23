Public Class Form2
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        StreetTextBox.Clear()
        ZIPTextBox.Clear()
        AgeTextBox.Clear()
    End Sub
End Class