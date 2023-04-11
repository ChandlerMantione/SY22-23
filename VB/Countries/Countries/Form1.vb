
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    Dim Count As Integer
    Dim Current As Integer
    Structure Country
        Dim Name As String
        Dim Capital As String
        Dim Population As String
        Dim Size As String
        Dim Picture As String
    End Structure
    Function GetCountry(Index As Integer) As Country
        Dim Fields() As String
        Dim C As Country
        Fields = Lines(Index).Split("|")
        C.Name = Fields(0)
        C.Capital = Fields(1)
        C.Population = Fields(2)
        C.Size = Fields(3)
        C.Picture = Fields(4)
        Return C
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles DisplayPictureBox.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        DisplayPictureBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim L As String
        L = CountryTextBox.Text
        L += "|"
        L += CapitalTextBox.Text
        L += "|"
        L += PopulationTextBox.Text
        L += "|"
        L += SizeTextBox.Text
        L += "|"
        L += DisplayPictureBox.ImageLocation
        Lines(Current) = L
        Save()
    End Sub
    Public Sub Save()
        Dim OutFile As IO.StreamWriter
        OutFile = IO.File.CreateText("Countries.txt")
        For index = 0 To Count
            If Lines(index) <> "" Then OutFile.WriteLine(Lines(index))
        Next
        OutFile.Close()
    End Sub
    Sub Clear()
        CountryTextBox.Clear()
        CapitalTextBox.Clear()
        PopulationTextBox.Clear()
        SizeTextBox.Clear()
        DisplayPictureBox.Image = Nothing
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Dim Lines(100) As String
    Sub Load()
        Dim InFile As StreamReader
        Dim IDX As Integer
        If IO.File.Exists("Countries.txt") Then
            InFile = IO.File.OpenText("Countries.txt")
            While InFile.Peek <> -1
                Lines(IDX) = InFile.ReadLine
                CountrysComboBox.Items.Add(GetCountry(IDX).Name)
                IDX = IDX + 1
            End While
            Count = IDX
            DebugTextBox.Text = Count
            ShowCountry(0)
            InFile.Close()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub
    Sub ShowCountry(Index As Integer)
        Dim Fields() As String
        Fields = Lines(Index).Split("|")
        CountryTextBox.Text = Fields(0)
        CapitalTextBox.Text = Fields(1)
        PopulationTextBox.Text = Fields(2)
        SizeTextBox.Text = Fields(3)
        If IO.File.Exists(Fields(4)) Then
            DisplayPictureBox.Load(Fields(4))
        End If
    End Sub

    Private Sub First_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Current = 0
        ShowCountry(Current)
    End Sub

    Private Sub Last_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Current = Count - 1
        ShowCountry(Current)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Current < Count - 1 Then
            Current = Current + 1
            ShowCountry(Current)
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If Current > 0 Then
            Current = Current - 1
            ShowCountry(Current)
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Clear()
        Current = Count
        Count = +1
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Lines(Current) = ""
        Save()
        Load()
    End Sub

    Private Sub CountrysComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CountrysComboBox.SelectedIndexChanged
        ShowCountry(CountrysComboBox.SelectedIndex)
    End Sub
End Class

