Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New IO.StreamWriter("Out.txt")
        outfile.Write(TextBox1.Text)
        outfile.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If IO.File.Exists("out.txt") Then
            Dim infile As New IO.StreamReader("Out.txt")
            TextBox1.Text = infile.ReadToEnd
            infile.Close()
        End If
    End Sub
End Class
