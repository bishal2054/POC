Public Class database

    Private Sub database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkerDatabaseDataSet.Permanentdatabase' table.
        Me.PermanentdatabaseTableAdapter.Fill(Me.ParkerDatabaseDataSet.Permanentdatabase)
        
    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Nothing to search", vbInformation)
        Else
            Try
                If CheckBox1.Checked Then
                    PermanentdatabaseDataGridView.DataSource = Me.ParkerDatabaseDataSet.Permanentdatabase.Select("vecno like'" & TextBox1.Text + "%" & "'")
                ElseIf CheckBox2.Checked Then
                    PermanentdatabaseDataGridView.DataSource = Me.ParkerDatabaseDataSet.Permanentdatabase.Select("cname like'" & TextBox1.Text + "%" & "'")
                ElseIf CheckBox3.Checked Then
                    PermanentdatabaseDataGridView.DataSource = Me.ParkerDatabaseDataSet.Permanentdatabase.Select("atime like'" & TextBox1.Text + "%" & "'")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

  

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        PermanentdatabaseDataGridView.DataSource = Me.ParkerDatabaseDataSet.Permanentdatabase.Select("dtime like'" & "%" + TextBox1.Text + "%" & "'")
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        main.Show()
        Me.Close()
    End Sub

 
End Class