
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    Dim Count As Integer
    Dim Current As Integer
    Structure Pokeman
        Dim Pokemon As String
        Dim Type As String
        Dim Generation As String
        Dim Evolution As String
        Dim ID As String
        Dim Region As String
        Dim Picture As String
    End Structure
    Function GetPokemon(Index As Integer) As Pokeman
        Dim Fields() As String
        Dim P As Pokeman
        Fields = Lines(Index).Split("|")
        P.Pokemon = Fields(0)
        P.Type = Fields(1)
        P.Generation = Fields(2)
        P.Evolution = Fields(3)
        P.ID = Fields(4)
        P.Region = Fields(5)
        P.Picture = Fields(6)
        Return P
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles DisplayPictureBox.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        DisplayPictureBox.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim L As String
        L = PokemonTextBox.Text
        L += "|"
        L += TypeTextBox.Text
        L += "|"
        L += GenerationTextBox.Text
        L += "|"
        L += EvolutionTextBox.Text
        L += "|"
        L += IDTextBox.Text
        L += "|"
        L += RegionTextBox.Text
        L += "|"
        L += DisplayPictureBox.ImageLocation
        Lines(Current) = L
        Save()
    End Sub
    Public Sub Save()
        Dim OutFile As IO.StreamWriter
        OutFile = IO.File.CreateText("Pokemon.txt")
        For index = 0 To Count
            If Lines(index) <> "" Then OutFile.WriteLine(Lines(index))
        Next
        OutFile.Close()
    End Sub
    Sub Clear()
        PokemonTextBox.Clear()
        TypeTextBox.Clear()
        GenerationTextBox.Clear()
        EvolutionTextBox.Clear()
        IDTextBox.Clear()
        RegionTextBox.Clear()
        DisplayPictureBox.Image = Nothing
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Dim Lines(100) As String
    Sub Load()
        Dim InFile As StreamReader
        Dim IDX As Integer
        If IO.File.Exists("Pokemon.txt") Then
            InFile = IO.File.OpenText("Pokemon.txt")
            While InFile.Peek <> -1
                Lines(IDX) = InFile.ReadLine
                PokemonComboBox.Items.Add(GetPokemon(IDX).Pokemon)
                IDX = IDX + 1
            End While
            Count = IDX
            ShowPokemon(0)
            InFile.Close()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub
    Sub ShowPokemon(Index As Integer)
        Dim Fields() As String
        Fields = Lines(Index).Split("|")
        PokemonTextBox.Text = Fields(0)
        TypeTextBox.Text = Fields(1)
        GenerationTextBox.Text = Fields(2)
        EvolutionTextBox.Text = Fields(3)
        IDTextBox.Text = Fields(4)
        RegionTextBox.Text = Fields(5)
        If IO.File.Exists(Fields(6)) Then
            DisplayPictureBox.Load(Fields(6))
        End If
    End Sub

    Private Sub First_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Current = 0
        ShowPokemon(Current)
    End Sub

    Private Sub Last_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Current = Count - 1
        ShowPokemon(Current)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Current < Count - 1 Then
            Current = Current + 1
            ShowPokemon(Current)
        End If
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If Current > 0 Then
            Current = Current - 1
            ShowPokemon(Current)
        End If
    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        Clear()
        Current = Count
        Count = +1
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Lines(Current) = ""
        Save()
        Load()
    End Sub

    Private Sub CountrysComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PokemonComboBox.SelectedIndexChanged
        ShowPokemon(PokemonComboBox.SelectedIndex)
    End Sub
End Class