Public Class Form1
    Dim area As Integer
    Dim perimeter As Integer
    Dim length As Integer
    Dim width As Integer
    Dim price As Decimal = 0
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
        spaceLabel.Visible = False
        price = 0
        If widthTB.Text <> "" And lengthTB.Text <> "" Then
            width = widthTB.Text
            length = lengthTB.Text
            area = (width * length)
            perimeter = ((width * 2) + length)
        Else area = 0
            perimeter = 0
        End If

        If CheckBox1.Checked = True Then
            If area > 500 Then
                area -= 500
                price += 50000
            Else
                spaceLabel.Visible = True
            End If
        End If
        If CheckBox2.Checked = True Then
            If area > 2000 Then
                area -= 2000
                price += 2500
            Else
                spaceLabel.Visible = True
            End If
        End If
        If CheckBox3.Checked = True Then
            price += 2000
        End If
        If CheckBox4.Checked = True Then
            price += 1000
        End If
        If CheckBox5.Checked = True Then
            price += 1250
        End If
        If CheckBox6.Checked = True Then
            price += 5000
        End If

        price += NumericUpDown1.Value
        price += NumericUpDown2.Value * 5
        price += NumericUpDown3.Value * 10
        price += NumericUpDown4.Value * 200

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
