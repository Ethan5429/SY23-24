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

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        If RadioButton1.Checked = True Then
            price += area * 1
        ElseIf RadioButton2.Checked = True Then
            price += area * 2
        ElseIf RadioButton3.Checked = True Then
            price += area * 3
        ElseIf RadioButton4.Checked = True Then
            price += area * 4
        End If
        priceTB.Text = price
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
    End Sub
End Class
