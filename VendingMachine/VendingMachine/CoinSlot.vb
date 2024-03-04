Public Class CoinSlot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property quarters As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public Event dispenseproduct(p As Image)
    Public ReadOnly Property total As Decimal
        Get
            _total = nickels * 0.05 + dimes * 0.1 + quarters * 0.25 + dollars
            Return _total
        End Get
    End Property
    Public Sub insertnickel()
        nickels += 1
    End Sub
    Public Sub insertdime()
        dimes += 1
    End Sub
    Public Sub insertquarter()
        quarters += 1
    End Sub
    Public Sub insertdollar()
        dollars += 1
    End Sub
    Public Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        nickels = 0
        dimes = 0
        quarters = 0
        dollars = 0
    End Sub
    Public Sub buy(p As ProductControl1)
        If p.productcount > 0 And p.productprice <= _total Then
            _total = _total - p.productprice
            p.buy()
            nickels = _total / 0.05
            dimes = 0
            quarters = 0
            dollars = 0
            RaiseEvent dispenseproduct(p.productimage)
        End If
    End Sub
End Class
