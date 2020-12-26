Imports System.Data.OleDb
Public Class service
    Public con As New OleDbConnection
    Dim cmd1 As New OleDbCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dal As New OleDb.OleDbDataAdapter

        Dim publictable As New DataTable

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\parkerdatabase.accdb"
        con.Open()
        With cmd1
            .Connection = con
            .CommandText = "select *from service"

        End With
        con.Close()
        dal.SelectCommand = cmd1
        dal.Fill(publictable)
        DataGridView1.DataSource = publictable
        dal.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dal As New OleDb.OleDbDataAdapter

        Dim publictable As New DataTable
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\parkerdatabase.accdb"
        con.Open()
        Dim sql As String
        sql = "UPDATE [service] SET [Price] = " & TextBox1.Text & " where [Vehicle]='" & ComboBox1.Text & "'"

        Dim cmd2 As OleDbCommand = New OleDbCommand(sql, con)
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        With cmd1
            .Connection = con
            .CommandText = "select *from service"

        End With
        con.Close()
        dal.SelectCommand = cmd1
        dal.Fill(publictable)
        DataGridView1.DataSource = publictable
        dal.Dispose()
        con.Close()
        Me.Show()
    End Sub

 
    Private Sub service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dal As New OleDb.OleDbDataAdapter

        Dim publictable As New DataTable

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\parkerdatabase.accdb"
        con.Open()
        With cmd1
            .Connection = con
            .CommandText = "select *from service"

        End With
        con.Close()
        dal.SelectCommand = cmd1
        dal.Fill(publictable)
        DataGridView1.DataSource = publictable
        dal.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class