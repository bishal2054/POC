Imports System.Data.OleDb
Public Class depart
    Public con As New OleDbConnection
    Dim cmd1 As New OleDbCommand

    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim duration As Integer
    Dim ttimee As Integer
    Dim myconnection As OleDbConnection = New OleDbConnection



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\user\Desktop\Project\Parkerdatabase.accdb"
        connstring = provider & datafile
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim total As Integer
        Dim sqlstring1 As String = "select * from service where Vehicle = '" & Label16.Text & "'"
        Dim mycmd As New OleDb.OleDbCommand(sqlstring1, myconnection)
        mycmd.CommandType = CommandType.Text
        Dim reader As OleDb.OleDbDataReader = mycmd.ExecuteReader()
        Dim price As Integer

        Dim mycmd1 As New OleDbCommand("delete from parkerdatabase where parkno ='" & Label5.Text & "'", myconnection)
        mycmd1.ExecuteNonQuery()

        Dim sql As String
        sql = "UPDATE [permanentdatabase] SET [dtime] = '" & System.DateTime.Now & "' where [parkno]='" & Label5.Text & "'"

        Dim cmd2 As OleDbCommand = New OleDbCommand(sql, myconnection)
        Try
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        While reader.Read
            price = reader("Price")
            total = ttimee * price + price
            Label7.Text = "Rs." & total
        End While
        MsgBox("Departed Successfully", vbInformation, "Departure")

        myconnection.Close()
        park.Close()
        park.Show()
        Me.Close()
    End Sub

   
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        park.Show()
        Me.Close()
    End Sub

 
  
    Private Sub depart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
     

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\user\Desktop\Project\Parkerdatabase.accdb"
        connstring = provider & datafile

        myconnection.ConnectionString = connstring
        myconnection.Open()

        Dim adate As DateTime
        Dim ddate As DateTime
        Dim sqlstring As String = "select * from permanentdatabase where parkno ='" & Label5.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(sqlstring, myconnection)
        cmd.CommandType = CommandType.Text
        Dim readers As OleDbDataReader = cmd.ExecuteReader()

        While readers.Read
            Label9.Text = readers("cname")
            Label11.Text = readers("vecno")
            Label13.Text = readers("atime")
            Label16.Text = readers("vtype")
            adate = readers("atime")
            ddate = System.DateTime.Now
            ttimee = DateDiff(DateInterval.Hour, adate, ddate)
            duration = DateDiff(DateInterval.Minute, adate, ddate)
            Label15.Text = "Total duration  " & ttimee & "  hours "

        End While
        myconnection.Close()
        Label4.Text = System.DateTime.Now
    End Sub
End Class