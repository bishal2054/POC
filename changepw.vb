Imports System.Data.OleDb
Public Class changepw
    Public con As New OleDbConnection
    Dim cmd1 As New OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
        If TextBox3.Text = TextBox2.Text Then
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\parkerdatabase.accdb"
            con.Open()
            Dim sql As String
            sql = "UPDATE [login] SET [password] = '" & TextBox3.Text & "' where [password]='" & TextBox1.Text & "'"

            Dim cmd2 As OleDbCommand = New OleDbCommand(sql, con)
            Try
                cmd2.ExecuteNonQuery()
                MsgBox("Password changed successfully", vbInformation, "Changed")
                LoginForm1.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Incorrect Old Password", MsgBoxStyle.Exclamation, "Warning")
                Me.Show()
            End Try
        Else
            MsgBox("Password and Confirm Password do not match", MsgBoxStyle.Exclamation, "Warning")
            Me.Show()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class