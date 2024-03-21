Public Class Form1
    Dim area As Integer
    Dim perimeter As Integer
    Dim length As Integer
    Dim width As Integer
    Dim price As Integer = 0
    Private Sub TB_TextChanged(sender As Object, e As EventArgs) Handles widthTB.TextChanged, lengthTB.TextChanged
        If widthTB.Text <> "" And lengthTB.Text <> "" Then
            width = widthTB.Text
            length = lengthTB.Text
            area = (width * length)
            areaTB.Text = area
            perimeter = ((width * 2) + length)
            perimeterTB.Text = perimeter
        Else area = 0
            areaTB.Text = area
            perimeter = 0
            perimeterTB.Text = perimeter
        End If
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        If RadioButton1.Checked = True Then
            price += area * 1.5
        ElseIf RadioButton2.Checked = True Then
            price += area * 10
        ElseIf RadioButton3.Checked = True Then
            price += area * 0.5
        ElseIf RadioButton4.Checked = True Then
            price += area * 12
        End If
        priceTB.Text = price.ToString("C2")
    End Sub
End Class
