Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertnickel()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            PictureBox8.Visible = True
        Else
            PictureBox8.Visible = False
        End If
        If q > 0 Then
            PictureBox7.Visible = True
        Else
            PictureBox7.Visible = False
        End If
        If di > 0 Then
            PictureBox6.Visible = True
        Else
            PictureBox6.Visible = False
        End If
        If n > 0 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BuyButton.Click, Button6.Click
        Select Case IDTextBox.Text
            Case ProductControl11.productID
                cs.buy(ProductControl11)
            Case ProductControl12.productID
                cs.buy(ProductControl12)
            Case ProductControl13.productID
                cs.buy(ProductControl13)
            Case ProductControl14.productID
                cs.buy(ProductControl14)
            Case ProductControl15.productID
                cs.buy(ProductControl15)
            Case ProductControl16.productID
                cs.buy(ProductControl16)
            Case ProductControl17.productID
                cs.buy(ProductControl17)
            Case ProductControl18.productID
                cs.buy(ProductControl18)
            Case ProductControl19.productID
                cs.buy(ProductControl19)
            Case ProductControl110.productID
                cs.buy(ProductControl110)
            Case ProductControl111.productID
                cs.buy(ProductControl111)
            Case ProductControl112.productID
                cs.buy(ProductControl112)
            Case ProductControl113.productID
                cs.buy(ProductControl113)
            Case ProductControl114.productID
                cs.buy(ProductControl114)
            Case ProductControl115.productID
                cs.buy(ProductControl115)
            Case ProductControl116.productID
                cs.buy(ProductControl116)
        End Select
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub ProductControl11_dispenseproduct(p As Image) Handles cs.dispenseproduct
        PictureBox11.Image = p
    End Sub
End Class
