Public Class form1
    Dim money As Integer = 7
    Dim tick As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If money > 6 Then
            Me.BackColor = Color.White
            money -= 7
            Label4.Text = money.ToString("c0")
            SlotSpin1.Spin()
            SlotSpin2.Spin()
            SlotSpin3.Spin()
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tick += 1
        Label1.Text = SlotSpin1.itemValue
        Label2.Text = SlotSpin2.itemValue
        Label3.Text = SlotSpin3.itemValue
        If tick = 8 Then
            Timer1.Enabled = False
            tick = 0
            If SlotSpin1.itemValue = SlotSpin2.itemValue And SlotSpin2.itemValue = SlotSpin3.itemValue Then
                Me.BackColor = Color.Green
                money += (SlotSpin1.itemValue + SlotSpin2.itemValue + SlotSpin3.itemValue) * 3
                Label4.Text = money.ToString("c0")
            Else
                money += SlotSpin1.itemValue + SlotSpin2.itemValue + SlotSpin3.itemValue
                Label4.Text = money.ToString("c0")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        money += 1
        Label4.Text = money.ToString("c0")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If money > 0 Then
            money = 0
            Label4.Text = money.ToString("c0")
            PictureBox2.Visible = True
        End If
    End Sub
End Class
