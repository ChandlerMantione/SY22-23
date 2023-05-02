Public Class CoinDespenser
    Public Property Total As Decimal
    Dim Counts(9) As Integer
    Dim Prices(9) As Decimal
    Public Event DispenseCoins(Amount As Decimal)
    Public Event DispenseProduct(N As Integer)
    Public Sub SetPrice(N As Integer, P As Decimal)
        Prices(N) = P
    End Sub
    Public Sub Restock(N As Integer)
        Counts(N) = 10
    End Sub
    Public Sub InsertNickel()
        Total = Total + 0.05
    End Sub
    Public Sub InsertDime()
        Total = Total + 0.1
    End Sub
    Public Sub InsertQuarter()
        Total = Total + 0.25
    End Sub
    Public Sub InsertHalfDollar()
        Total = Total + 0.5
    End Sub

    Public Sub InsertDollar()
        Total = Total + 1.0
    End Sub

    Public Sub Vend(N As Integer)
        If Total >= Prices(N) Then
            Counts(N) = Counts(N) - 1
            Total = Total - Prices(N)
            RaiseEvent DispenseProduct(N)
        End If
    End Sub
    Public Function GetPrice(N As Integer) As Decimal
        Return Prices(N)
    End Function
End Class


