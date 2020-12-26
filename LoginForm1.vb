Imports System.Data.OleDb
Public Class LoginForm1

    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        Dim user, pass
        Dim constring As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\Parkerdatabase.accdb"

        Dim sqlstring As String = "select * from login "
        Dim con As New OleDb.OleDbConnection

        Dim cmd As New OleDb.OleDbCommand(sqlstring, con)
        cmd.CommandType = CommandType.Text

        con.ConnectionString = constring
        con.Open()
        Dim readers As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While readers.Read
            user = readers("Username").ToString
            pass = readers("Password").ToString


            If (Username.Text = user And Password.Text = pass) Then
                main.Show()
                Me.Hide()
                Return
            Else
                Continue While

            End If
        End While

        MsgBox("Incorrect Username or Password. Please Enter Correct Username or Password", MsgBoxStyle.Exclamation, "Warnig")
        Me.Show()
    End Sub

    Public Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Username.Text = ""
        Password.Text = ""
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        End
    End Sub


    
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        changepw.show()
        Me.Hide()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Username.Text = Nothing
        Password.Text = Nothing
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Password.PasswordChar = "*"
        Else
            Password.PasswordChar = ""
        End If
    End Sub

End Class
