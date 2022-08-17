Public Class Form1
    Private Sub ThresherButton_Click(sender As Object, e As EventArgs) Handles ThresherButton.Click
        DisplayPictureBox.Image = ThresherPictureBox.Image
        NameLabel.Text = "Thresher"
        DifficultyLabel.Text = "Easy"
        MovesLabel.Text = "Arm Swipe
Bite
Tail Swipe
Burrow"
        TypeOfEnemyLabel.Text = "Monster"
    End Sub

    Private Sub FairyManButton_Click(sender As Object, e As EventArgs) Handles FairyManButton.Click
        DisplayPictureBox.Image = FairyManPictureBox.Image
        NameLabel.Text = "Fairy Man"
        DifficultyLabel.Text = "Medium-Hard"
        MovesLabel.Text = "Displacement
Lightning Clones
Lightning Strike
Lightning Assault
Electromagnetic Pulse
Grand Volley"
        TypeOfEnemyLabel.Text = "Boss Human"
    End Sub

    Private Sub SharkoButton_Click(sender As Object, e As EventArgs) Handles SharkoButton.Click
        DisplayPictureBox.Image = SharkoPictureBox.Image
        NameLabel.Text = "Sharko"
        DifficultyLabel.Text = "Easy"
        MovesLabel.Text = "Slash
Kick
Jump
Thousand Needles
Roar"
        TypeOfEnemyLabel.Text = "Monster"
    End Sub

    Private Sub DeepOwlButton_Click(sender As Object, e As EventArgs) Handles DeepOwlButton.Click
        DisplayPictureBox.Image = DeepOwlPictureBox.Image
        NameLabel.Text = "DeepOwl"
        DifficultyLabel.Text = "Hard"
        MovesLabel.Text = "Talon Swipe
Feather Teleport
Whirling Dash
Flying Grab
Flock of Feathers"
        TypeOfEnemyLabel.Text = "Monster"
    End Sub

    Private Sub BrainSuckerButton_Click(sender As Object, e As EventArgs) Handles PrimadonButton.Click
        DisplayPictureBox.Image = PrimadonPictureBox.Image
        NameLabel.Text = "Primadon"
        DifficultyLabel.Text = "Medium-Hard"
        MovesLabel.Text = "Stomp
Trample
Punch
Kick
Grab
Rock Throw
Disengage
Enrage"
        TypeOfEnemyLabel.Text = "Boss Monster"
    End Sub
End Class
