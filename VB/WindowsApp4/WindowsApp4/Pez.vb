Public Class Pez
    Public Event IsEmpty()
    Public Property Count As Integer
    Public Sub POP()
        If Count > 0 Then
            Count = Count - 1
        Else
            RaiseEvent IsEmpty()
        End If
    End Sub
End Class
