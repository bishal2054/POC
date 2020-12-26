Imports System.Data.OleDb
Public Class report
    Dim con As OleDbConnection = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim cmd1 As OleDbCommand = Nothing
    Dim cmd2 As OleDbCommand = Nothing
    Dim cmd3 As OleDbCommand = Nothing
    Dim cmd4 As OleDbCommand = Nothing
    Dim cmd5 As OleDbCommand = Nothing
    Dim cmd6 As OleDbCommand = Nothing

    Dim total As Integer
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tal As Integer
        Dim yal As Integer
        Dim dal As Integer
        Dim dater As String
        con = New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\parkerdatabase.accdb"
        con.Open()
        cmd = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + DateTimePicker1.Value + "%" & "'", con)
        cmd1 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + DateTimePicker1.Value + "%" & "' and vtype = 'Bike'", con)
        cmd2 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + DateTimePicker1.Value + "%" & "' and vtype = 'Scooter'", con)
        cmd3 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + DateTimePicker1.Value + "%" & "' and vtype = 'Car'", con)
        total = cmd.ExecuteScalar()
        tal = cmd1.ExecuteScalar()
        yal = cmd2.ExecuteScalar()
        dal = cmd3.ExecuteScalar()
        dater = DateTimePicker1.Value
        TextBox2.Text = total
        TextBox1.Text = tal
        TextBox3.Text = yal
        TextBox4.Text = dal
        Me.Chart2.Series("Bike").Points.AddXY(dater, tal)
        Me.Chart2.Series("Scooter").Points.AddXY(dater, yal)
        Me.Chart2.Series("Car").Points.AddXY(dater, dal)
        con.Close()
    End Sub


    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        DateTimePicker1.Value = Date.Today
        Dim ttal As Integer
        Dim tyal As Integer
        Dim tdyal As Integer
        Dim tdal As Integer
        Dim tdatl As Integer
        Dim tytal As Integer

        con = New OleDbConnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\parkerdatabase.accdb"
        Dim t As Date = Date.Today
        Dim y As Date
        Dim ty As Date
        Dim tdy As Date
        Dim tdty As Date
        Dim tday As Date
        Dim tdaty As Date

        y = t.AddDays(-1)
        ty = t.AddDays(-2)
        tdy = t.AddDays(-3)
        tdty = t.AddDays(-4)
        tday = t.AddDays(-5)
        tdaty = t.AddDays(-6)

        con.Open()
        cmd = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + Date.Today + "%" & "'", con)
        cmd1 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + y + "%" & "'", con)
        cmd2 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + ty + "%" & "'", con)
        cmd3 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + tdy + "%" & "'", con)
        cmd4 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + tdty + "%" & "'", con)
        cmd5 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + tday + "%" & "'", con)
        cmd6 = New OleDbCommand("Select count(*) from permanentdatabase where [atime] like'" & "%" + tdaty + "%" & "'", con)
        total = cmd.ExecuteScalar()
        ttal = cmd1.ExecuteScalar()
        tyal = cmd2.ExecuteScalar()
        tdyal = cmd3.ExecuteScalar()
        tdal = cmd4.ExecuteScalar()
        tdatl = cmd5.ExecuteScalar()
        tytal = cmd6.ExecuteScalar()
        Me.Chart1.Series("Parked").Points.AddXY(Date.Today, total)
        Me.Chart1.Series("Parked").Points.AddXY(y, ttal)
        Me.Chart1.Series("Parked").Points.AddXY(ty, tyal)
        Me.Chart1.Series("Parked").Points.AddXY(tdy, tdyal)
        Me.Chart1.Series("Parked").Points.AddXY(tdty, tdal)
        Me.Chart1.Series("Parked").Points.AddXY(tday, tdatl)
        Me.Chart1.Series("Parked").Points.AddXY(tdaty, tytal)
        con.Close()
    End Sub

End Class