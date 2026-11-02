Public Class FormLogin
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New System.Drawing.Drawing2D.GraphicsPath()
        p.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Region = New Region(p)
    End Sub

    Private Sub lbljudul_Click(sender As Object, e As EventArgs) Handles lbljudul.Click

    End Sub
End Class