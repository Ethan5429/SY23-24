Public Class ProductControl1
    Public Property productname As String
    Public Property productID As String
    Public Property productprice As Decimal
    Public Property productimage As Image
    Public Property productcount As Integer

    Private Sub ProductControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = productimage
        IDLabel.Text = productID
        PriceLabel.Text = productprice.ToString("c2")
    End Sub
    Public Sub buy()
        If productcount > 0 Then
            productcount -= 1
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
