Public Class Form1
    Dim area As Integer
    Dim length As Integer
    Dim width As Integer
    Private Sub TB_TextChanged(sender As Object, e As EventArgs) Handles widthTB.TextChanged, lengthTB.TextChanged
        If widthTB.Text <> "" And lengthTB.Text <> "" Then
            width = widthTB.Text
            length = lengthTB.Text
            area = (width * length)
            areaTB.Text = area
        Else area = 0
            areaTB.Text = area
        End If
    End Sub
End Class
