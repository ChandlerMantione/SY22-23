Imports System.Net.Security

Public Class From2DPlatformer
    Dim MoveSpeed = 7
    Dim IsJumping As Boolean
    Private Sub From2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.KeyCode.Right
                RightTimer.Start()
            Case Keys.KeyCode.Left
                LeftTimer.Start()
            Case Keys.KeyCode.Up
                UpTimer.Start()
                IsJumping = True
        End Select
    End Sub

    Private Sub TimerRight_Tick(sender As Object, e As EventArgs) Handles RightTimer.Tick
        PlayerPictureBox.Left += MoveSpeed
    End Sub

    Private Sub From2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.KeyCode.Right
                RightTimer.Stop()
            Case Keys.KeyCode.Left
                LeftTimer.Stop()
            Case Keys.KeyCode.Up
                UpTimer.Stop()
                IsJumping = False
        End Select
    End Sub

    Private Sub LeftTimer_Tick(sender As Object, e As EventArgs) Handles LeftTimer.Tick
        PlayerPictureBox.Left -= MoveSpeed
    End Sub

    Private Sub UpTimer_Tick(sender As Object, e As EventArgs) Handles UpTimer.Tick
        PlayerPictureBox.Top -= MoveSpeed
    End Sub

    Private Sub From2DPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameLogicTimer.Start()
    End Sub

    Private Sub GameLogicTimer_Tick(sender As Object, e As EventArgs) Handles GameLogicTimer.Tick
        If PlayerPictureBox.Bounds.IntersectsWith(AirPictureBox.Bounds) Then
            If IsJumping = False Then
                GravityTimer.Start()
            End If
        ElseIf PlayerPictureBox.Bounds.IntersectsWith(GroundPictureBox.Bounds) Then
            GravityTimer.Stop()
        End If

        For Each B As Control In Me.Controls
            If TypeOf B Is PictureBox Then
                If PlayerPictureBox.Bounds.IntersectsWith(B.Bounds) Then
                    GravityTimer.Stop()
                End If
            End If
        Next
    End Sub

    Private Sub GravityTimer_Tick(sender As Object, e As EventArgs) Handles GravityTimer.Tick
        PlayerPictureBox.Top += MoveSpeed
    End Sub
End Class
