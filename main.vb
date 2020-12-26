Public Class main

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        park.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Hide()
        LoginForm1.ShowDialog()
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        database.Show()
        Me.Hide()
    End Sub   
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        service.ShowDialog()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        report.Show()
        Me.Hide()
    End Sub
    Private Sub Label2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.BorderStyle = BorderStyle.None
        Label2.BackColor = Color.FromArgb(0, 64, 64)
        Label2.ForeColor = Color.White
    End Sub
    Private Sub label3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.BackColor = Color.White
        Label3.ForeColor = Color.fromargb(0, 64, 64)
    End Sub

    Private Sub label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.BorderStyle = BorderStyle.None
        Label3.BackColor = Color.FromArgb(0, 64, 64)
        Label3.ForeColor = Color.White
    End Sub
   
    Private Sub label5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseHover
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.BackColor = Color.White
        Label5.ForeColor = Color.fromargb(0, 64, 64)
    End Sub

    Private Sub label5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Label5.BorderStyle = BorderStyle.None
        Label5.BackColor = Color.FromArgb(0, 64, 64)
        Label5.ForeColor = Color.White
    End Sub

    Private Sub label6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseHover
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.BackColor = Color.White
        Label6.ForeColor = Color.fromargb(0, 64, 64)
    End Sub

    Private Sub label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.BorderStyle = BorderStyle.None
        Label6.BackColor = Color.FromArgb(0, 64, 64)
        Label6.ForeColor = Color.White
    End Sub

    Private Sub label8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseHover
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.BackColor = Color.White
        Label8.ForeColor = Color.fromargb(0, 64, 64)
    End Sub

    Private Sub label8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseLeave
        Label8.BorderStyle = BorderStyle.None
        Label8.BackColor = Color.FromArgb(0, 64, 64)
        Label8.ForeColor = Color.White
    End Sub
    Private Sub label4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseHover
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.BackColor = Color.White
        Label4.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub label4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Label4.BorderStyle = BorderStyle.None
        Label4.BackColor = Color.FromArgb(0, 64, 64)
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label9.Text = Date.Now.ToString("hh : mm : ss")
        Label10.Text = Date.Now.ToString("yyyy - MM - dd")
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        service.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        LoginForm1.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        report.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        database.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        park.Show()
        Me.Hide()
    End Sub
    Private Sub picturebox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub picturebox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        Label2.BorderStyle = BorderStyle.None
        Label2.BackColor = Color.FromArgb(0, 64, 64)
        Label2.ForeColor = Color.White
    End Sub
    Private Sub picturebox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.BackColor = Color.White
        Label3.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub picturebox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        Label3.BorderStyle = BorderStyle.None
        Label3.BackColor = Color.FromArgb(0, 64, 64)
        Label3.ForeColor = Color.White
    End Sub

    Private Sub picturebox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.BackColor = Color.White
        Label5.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub picturebox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        Label5.BorderStyle = BorderStyle.None
        Label5.BackColor = Color.FromArgb(0, 64, 64)
        Label5.ForeColor = Color.White
    End Sub

    Private Sub picturebox5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.BackColor = Color.White
        Label6.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub picturebox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        Label6.BorderStyle = BorderStyle.None
        Label6.BackColor = Color.FromArgb(0, 64, 64)
        Label6.ForeColor = Color.White
    End Sub

    Private Sub picturebox6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.BackColor = Color.White
        Label8.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub picturebox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        Label8.BorderStyle = BorderStyle.None
        Label8.BackColor = Color.FromArgb(0, 64, 64)
        Label8.ForeColor = Color.White
    End Sub
    Private Sub picturebox4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.BackColor = Color.White
        Label4.ForeColor = Color.FromArgb(0, 64, 64)
    End Sub

    Private Sub picturebox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        Label4.BorderStyle = BorderStyle.None
        Label4.BackColor = Color.FromArgb(0, 64, 64)
        Label4.ForeColor = Color.White
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.Refresh()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Refresh()
    End Sub
End Class
