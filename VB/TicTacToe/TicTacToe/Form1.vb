Public Class Form1
    Dim turn As String = "X"
    Dim Score1 As Integer
    Dim Score2 As Integer

    Sub reset()
        Me.BackColor = Color.White
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""
    End Sub
    Sub Pick(B As Button)
        B.Text = turn
        If turn = "X" Then
            turn = "O"
        Else
            turn = "X"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click
        Pick(sender)
        If IsWinner() Then
            Me.BackColor = Color.Green
            If turn = "O" Then
                Score1 = Score1 + 1
            Else
                Score2 = Score2 + 1
            End If
            P1ScoreLabel.Text = Score1
            P2ScoreLabel.Text = Score2
            MsgBox("Winner")
            reset()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        reset()
    End Sub
    Function IsWinner() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B1.Text <> "" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B4.Text <> "" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B7.Text <> "" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B1.Text <> "" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B2.Text <> "" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B3.Text <> "" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B1.Text <> "" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B3.Text <> "" Then Return True
        Return False
    End Function
End Class
