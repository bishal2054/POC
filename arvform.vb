Imports System.Data.OleDb

Public Class arvform
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection


    Private Sub arvform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkerDatabaseDataSet.Parkerdatabase' table. You can move, or remove it, as needed.
        Me.ParkerdatabaseTableAdapter.Fill(Me.ParkerDatabaseDataSet.Parkerdatabase)
        ParkerdatabaseBindingSource.AddNew()
        Label9.Text = System.DateTime.Now
        Label14.Text = "Not Departed"
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Please fill all the details", vbCritical, "Arrival form")

        Else
            Try

                provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                datafile = "C:\Users\user\Desktop\Project\Parkerdatabase.accdb"
                connstring = provider & datafile

                myconnection.ConnectionString = connstring
                myconnection.Open()

                Dim myadd As New OleDbCommand("INSERT INTO parkerdatabase (parkno,cname,contact,vecno,vtype,gender,atime,dtime) VALUES(@pn, @cn, @co, @vn, @vt, @gn, @at, @dt)", myconnection)
                myadd.Parameters.AddWithValue("@pn", Label12.Text)
                myadd.Parameters.AddWithValue("@cn", TextBox1.Text)
                myadd.Parameters.AddWithValue("@co", TextBox2.Text)
                myadd.Parameters.AddWithValue("@vn", TextBox3.Text)

                myadd.Parameters.AddWithValue("@vt", ComboBox1.Text)
                myadd.Parameters.AddWithValue("@gn", ComboBox2.Text)
                myadd.Parameters.AddWithValue("@at", Label9.Text)
                myadd.Parameters.AddWithValue("@dt", Label14.Text)
                myadd.ExecuteNonQuery()

                Dim mycopy As New OleDbCommand("INSERT INTO permanentdatabase (parkno,cname,contact,vecno,vtype,gender,atime,dtime) SELECT * FROM parkerdatabase WHERE parkno = @pk", myconnection)
                mycopy.Parameters.AddWithValue("@pk", Label12.Text)
                mycopy.ExecuteNonQuery()

                ParkerdatabaseBindingSource.AddNew() ' 
                MsgBox("Successfully saved", vbInformation, "Arrival form")
            Catch ex As Exception
                MsgBox("Error Found", vbCritical, "Arrival form")

            End Try
            park.Close()
            park.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        park.Show()
        Me.Close()
    End Sub

End Class