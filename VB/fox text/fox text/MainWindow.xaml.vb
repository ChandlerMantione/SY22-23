﻿Imports System.IO

Class MainWindow
    Private Sub Bold_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontWeight = FontWeights.Bold
    End Sub

    Private Sub Bold_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontWeight = FontWeights.Normal
    End Sub

    Private Sub Italic_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontStyle = FontStyles.Italic
    End Sub

    Private Sub Italic_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textBox1.FontStyle = FontStyles.Normal
    End Sub

    Private Sub IncreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textBox1.FontSize < 18 Then
            textBox1.FontSize += 2
        End If
    End Sub

    Private Sub DecreaseFont_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If textBox1.FontSize > 10 Then
            textBox1.FontSize -= 2
        End If
    End Sub

    Private Sub Exit_Click()
        Me.Close()
    End Sub

    Private Sub Save_Click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.SaveFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            Save_File(filename)
        End If
    End Sub

    Private Sub Open_Click()
        ' Create OpenFileDialog
        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox
        If result = True Then
            ' Open document
            Dim filename As String = dlg.FileName
            Show_File(filename)
        End If
    End Sub

    Private Sub Show_File(fName As String)
        Dim FileReader As System.IO.StreamReader
        FileReader = New StreamReader(fName)

        Dim StringReader As String
        StringReader = FileReader.ReadToEnd()
        textBox1.Text = StringReader
        FileReader.Close()
    End Sub

    Private Sub Save_File(fName As String)
        Dim FileWriter As StreamWriter
        FileWriter = New StreamWriter(fName)
        FileWriter.Write(textBox1.Text)
        FileWriter.Close()
    End Sub
End Class
