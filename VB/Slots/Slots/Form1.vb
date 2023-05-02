Imports System.ComponentModel
Imports System.Data.SqlTypes
Imports System.Reflection.Emit

Public Class Form1
    Dim rand As New Random
    Dim num1 As Integer
    Dim num2 As Integer
    Dim num3 As Integer
    Dim WithEvents C As New Coin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C.Spin()
        Label1.Text = C.Total.ToString
        num1 = rand.Next(1, 9)
        num2 = rand.Next(1, 9)
        num3 = rand.Next(1, 9)
        PictureBox1.Image = ImageList1.Images(num1)
        PictureBox2.Image = ImageList1.Images(num2)
        PictureBox3.Image = ImageList1.Images(num3)
        If num1 = num2 And num2 = num3 Then
            C.Total = C.Total + 0.25 * 100
            Label1.Text = C.Total
            MsgBox("Small Win")
        ElseIf num1 = 0 And num2 = 0 And num3 = 0 Then
            C.Total = C.Total + 0.25 * 1000
            Label1.Text = C.Total
            MsgBox("Big Win")
        ElseIf (num1 = 1 Or num1 = 2 Or num1 = 6 Or num1 = 7) And (num2 = 1 Or num2 = 2 Or num2 = 6 Or num2 = 7) And (num3 = 1 Or num3 = 2 Or num3 = 6 Or num3 = 7) Then
            C.Total = C.Total + 0.25 * 25
            Label1.Text = C.Total
            MsgBox("Fruit Win")
        End If
    End Sub

    Private Sub NickelButton_Click(sender As Object, e As EventArgs) Handles NickelButton.Click
        C.InsertNickel()
        Label1.Text = C.Total.ToString("c2")
    End Sub


    Private Sub DimeButton_Click(sender As Object, e As EventArgs) Handles DimeButton.Click
        C.InsertDime()
        Label1.Text = C.Total.ToString("c2")
    End Sub
    Private Sub QuarterButton_Click(sender As Object, e As EventArgs) Handles QuarterButton.Click
        C.InsertQuarter()
        Label1.Text = C.Total.ToString("c2")
    End Sub
    Private Sub DollarButton_Click(sender As Object, e As EventArgs) Handles DollarButton.Click
        C.InsertDollar()
        Label1.Text = C.Total.ToString("c2")
    End Sub

    Private Sub DispenseButton_Click(sender As Object, e As EventArgs) Handles DispenseButton.Click
        Label1.Text = 0
    End Sub
End Class
