Public Class Coin
    Public Property Total As Decimal
    Public Sub InsertNickel()
        Total = Total + 0.25
    End Sub
    Public Sub InsertDime()
        Total = Total + 0.25
    End Sub
    Public Sub InsertQuarter()
        Total = Total + 0.25
    End Sub
    Public Sub InsertDollar()
        Total = Total + 1.0
    End Sub
    Public Sub Spin()
        If Total >= 0.25 Then
            Total = Total - 0.25
        End If
    End Sub
End Class
