Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.Threading

Class MainWindow
    Dim G1 As Color
    Dim G2 As Color
    Dim Shape As String
    Private Sub RedSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        RedValue.Content = RedSlider.Value
        ChangeColor()
    End Sub

    Private Sub GreenSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        GreenValue.Content = GreenSlider.Value
        ChangeColor()
    End Sub

    Private Sub BlueSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        BlueValue.Content = BlueSlider.Value
        ChangeColor()
    End Sub
    Sub ChangeColor()
        ColorRectangle.Fill = New SolidColorBrush(Color.FromRgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value))
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        sender.Background = ColorRectangle.Fill
    End Sub

    Private Sub Gradient1_Click(sender As Object, e As RoutedEventArgs) Handles Gradient1.Click
        G1 = Color.FromRgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value)
        Gradient1.Background = New SolidColorBrush(G1)
    End Sub

    Private Sub Gradient2_Click(sender As Object, e As RoutedEventArgs) Handles Gradient2.Click
        G2 = Color.FromRgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value)
        Gradient2.Background = New SolidColorBrush(G2)
    End Sub

    Private Sub RadialButton_Click(sender As Object, e As RoutedEventArgs) Handles RadialButton.Click
        ColorRectangle.Fill = New RadialGradientBrush(G1, G2)
    End Sub

    Sub SetLinearGradient()
        ColorRectangle.Fill = New LinearGradientBrush(G1, G2, AngleSlider.Value)
    End Sub

    Private Sub MyParentCanvas_MouseMove(sender As Object, e As MouseEventArgs)
        Select Case Shape
            Case "Rectangle"
                Dim el As New Rectangle
                el.Width = WidthSlider.Value
                el.Height = HeightSlider.Value
                el.Fill = ColorRectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "Ellipse"
                Dim el As New Ellipse
                el.Width = WidthSlider.Value
                el.Height = HeightSlider.Value
                el.Fill = ColorRectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "Triangle"
                Dim el As New Polygon
                el.Width = WidthSlider.Value
                el.Height = HeightSlider.Value
                el.Fill = ColorRectangle.Fill
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)
                el.Points.Add(New Point(0, 0))
                el.Points.Add(New Point(WidthSlider.Value, 0))
                el.Points.Add(New Point(WidthSlider.Value, HeightSlider.Value))
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "Pentagon"
                Dim el As New Polygon
                el.Fill = ColorRectangle.Fill
                Dim numpoints As Integer = 6
                For index = 0 To numpoints - 1
                    Dim angle As Decimal
                    angle = (2 * Math.PI / numpoints) * index
                    el.Points.Add(New Point(Math.Cos(angle) * WidthSlider.Value, Math.Sin(angle) * WidthSlider.Value))
                Next
                Dim p As Point = Mouse.GetPosition(drawingCanvas)
                Canvas.SetLeft(el, p.X)
                Canvas.SetTop(el, p.Y)

                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Add(el)
                End If
            Case "Erase"
                Dim P As Point = Mouse.GetPosition(drawingCanvas)
                Dim Result As HitTestResult = VisualTreeHelper.HitTest(drawingCanvas, P)
                If e.LeftButton = MouseButtonState.Pressed Then
                    drawingCanvas.Children.Remove(Result.VisualHit)
                End If
            Case Else

        End Select
    End Sub

    Private Sub angleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double))
        SetLinearGradient()
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        G1 = Colors.Red
        Gradient1.Background = New SolidColorBrush(G1)
        G2 = Colors.Green
        Gradient2.Background = New SolidColorBrush(G2)
        SetLinearGradient()
    End Sub

    Private Sub RectangleButton_Click(sender As Object, e As RoutedEventArgs) Handles RectangleButton.Click
        Shape = "Rectangle"
    End Sub

    Private Sub EllipseButton_Click(sender As Object, e As RoutedEventArgs) Handles EllipseButton.Click
        Shape = "Ellipse"
    End Sub
    Private Sub TriangleButton_Click(sender As Object, e As RoutedEventArgs) Handles TriangleButton.Click
        Shape = "Triangle"
    End Sub
    Private Sub PentagonButton_Click(sender As Object, e As RoutedEventArgs) Handles PentagonButton.Click
        Shape = "Pentagon"
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
        drawingCanvas.Children.Clear()
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As RoutedEventArgs) Handles SaveButton.Click
        ExportToPng(drawingCanvas)
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

    End Sub

    Private Sub drawingCanvas_Loaded(sender As Object, e As RoutedEventArgs)
        Dim dt As DispatcherTimer = New DispatcherTimer()
        AddHandler dt.Tick, AddressOf dispatcherTimer_Tick

        dt.Interval = New TimeSpan(0, 0, 1)
        dt.Start()
    End Sub
    Public Sub dispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        For Each u In drawingCanvas.Children
            Canvas.SetLeft(u, Canvas.GetLeft(u) + Left_Right_Slider.Value)
        Next
        For Each u In drawingCanvas.Children
            Canvas.SetTop(u, Canvas.GetTop(u) + Up_Down_Slider.Value)
        Next
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As RoutedEventArgs) Handles EraseButton.Click
        Shape = "Erase"
    End Sub
End Class
