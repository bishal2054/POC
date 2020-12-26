Imports System.Data.OleDb
Public Class park
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim statu As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub park_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constring As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Project\Parkerdatabase.accdb"

        Dim sqlstring As String = "select * from parkerdatabase "
        Dim con As New OleDb.OleDbConnection

        Dim cmd As New OleDb.OleDbCommand(sqlstring, con)
        cmd.CommandType = CommandType.Text

        con.ConnectionString = constring
        con.Open()
        Dim readers As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While readers.Read
            statu = readers("parkno").ToString

            If statu = "t1" Then
                t1.Text = "Pt1"
                t1.BackColor = Color.Red
            ElseIf statu = "t2" Then
                t2.Text = "Pt2"
                t2.BackColor = Color.Red
            ElseIf statu = "t3" Then
                t3.Text = "Pt3"
                t3.BackColor = Color.Red
            ElseIf statu = "t4" Then
                t4.Text = "Pt4"
                t4.BackColor = Color.Red
            ElseIf statu = "t5" Then
                t5.Text = "Pt5"
                t5.BackColor = Color.Red
            ElseIf statu = "t6" Then
                t6.Text = "Pt6"
                t6.BackColor = Color.Red
            ElseIf statu = "t7" Then
                t7.Text = "Pt7"
                t7.BackColor = Color.Red
            ElseIf statu = "t8" Then
                t8.Text = "Pt8"
                t8.BackColor = Color.Red
            ElseIf statu = "t9" Then
                t9.Text = "Pt9"
                t9.BackColor = Color.Red
            ElseIf statu = "t10" Then
                t10.Text = "Pt10"
                t10.BackColor = Color.Red
            ElseIf statu = "t11" Then
                t11.Text = "Pt11"
                t11.BackColor = Color.Red
            ElseIf statu = "t12" Then
                t12.Text = "Pt12"
                t12.BackColor = Color.Red
            ElseIf statu = "t13" Then
                t13.Text = "Pt13"
                t13.BackColor = Color.Red
            ElseIf statu = "t14" Then
                t14.Text = "Pt14"
                t14.BackColor = Color.Red
            ElseIf statu = "t15" Then
                t15.Text = "Pt15"
                t15.BackColor = Color.Red
            ElseIf statu = "t16" Then
                t16.Text = "Pt16"
                t16.BackColor = Color.Red
            ElseIf statu = "t17" Then
                t17.Text = "Pt17"
                t17.BackColor = Color.Red
            ElseIf statu = "t18" Then
                t18.Text = "Pt18"
                t18.BackColor = Color.Red
            ElseIf statu = "t19" Then
                t19.Text = "Pt19"
                t19.BackColor = Color.Red
            ElseIf statu = "t20" Then
                t20.Text = "Pt20"
                t20.BackColor = Color.Red
            ElseIf statu = "t21" Then
                t21.Text = "Pt21"
                t21.BackColor = Color.Red
            ElseIf statu = "t22" Then
                t22.Text = "Pt22"
                t22.BackColor = Color.Red
            ElseIf statu = "t23" Then
                t23.Text = "Pt23"
                t23.BackColor = Color.Red
            ElseIf statu = "t24" Then
                t24.Text = "Pt24"
                t24.BackColor = Color.Red
            ElseIf statu = "t25" Then
                t25.Text = "Pt25"
                t25.BackColor = Color.Red
            ElseIf statu = "t26" Then
                t26.Text = "Pt26"
                t26.BackColor = Color.Red
            ElseIf statu = "t27" Then
                t27.Text = "Pt27"
                t27.BackColor = Color.Red
            ElseIf statu = "t28" Then
                t28.Text = "Pt28"
                t28.BackColor = Color.Red
            ElseIf statu = "t29" Then
                t29.Text = "Pt29"
                t29.BackColor = Color.Red
            ElseIf statu = "t30" Then
                t30.Text = "Pt30"
                t30.BackColor = Color.Red
            ElseIf statu = "t31" Then
                t31.Text = "Pt31"
                t31.BackColor = Color.Red
            ElseIf statu = "t32" Then
                t32.Text = "Pt32"
                t32.BackColor = Color.Red
            ElseIf statu = "t33" Then
                t33.Text = "Pt33"
                t33.BackColor = Color.Red
            ElseIf statu = "t34" Then
                t34.Text = "Pt34"
                t34.BackColor = Color.Red
            ElseIf statu = "t35" Then
                t35.Text = "Pt35"
                t35.BackColor = Color.Red
            ElseIf statu = "t36" Then
                t36.Text = "Pt36"
                t36.BackColor = Color.Red
            ElseIf statu = "t37" Then
                t37.Text = "Pt37"
                t37.BackColor = Color.Red
            ElseIf statu = "t38" Then
                t38.Text = "Pt38"
                t38.BackColor = Color.Red
            ElseIf statu = "t39" Then
                t39.Text = "Pt39"
                t39.BackColor = Color.Red
            ElseIf statu = "t40" Then
                t40.Text = "Pt40"
                t40.BackColor = Color.Red
            ElseIf statu = "t41" Then
                t41.Text = "Pt41"
                t41.BackColor = Color.Red
            ElseIf statu = "t42" Then
                t42.Text = "Pt42"
                t42.BackColor = Color.Red
            ElseIf statu = "t43" Then
                t43.Text = "Pt43"
                t43.BackColor = Color.Red
            ElseIf statu = "t44" Then
                t44.Text = "Pt44"
                t44.BackColor = Color.Red
            ElseIf statu = "t45" Then
                t45.Text = "Pt45"
                t45.BackColor = Color.Red
            ElseIf statu = "t46" Then
                t46.Text = "Pt46"
                t46.BackColor = Color.Red
            ElseIf statu = "t47" Then
                t47.Text = "Pt47"
                t47.BackColor = Color.Red
            ElseIf statu = "t48" Then
                t48.Text = "Pt48"
                t48.BackColor = Color.Red
            ElseIf statu = "t49" Then
                t49.Text = "Pt49"
                t49.BackColor = Color.Red
            ElseIf statu = "t50" Then
                t50.Text = "Pt50"
                t50.BackColor = Color.Red
            ElseIf statu = "f1" Then
                f1.Text = "Pf1"
                f1.BackColor = Color.Red
            ElseIf statu = "f2" Then
                f2.Text = "Pf2"
                f8.BackColor = Color.Red
            ElseIf statu = "f3" Then
                f3.Text = "Pf3"
                f3.BackColor = Color.Red
            ElseIf statu = "f4" Then
                f4.Text = "Pf4"
                f4.BackColor = Color.Red
            ElseIf statu = "f5" Then
                f5.Text = "Pf5"
                f5.BackColor = Color.Red
            ElseIf statu = "f6" Then
                f6.Text = "Pf6"
                f6.BackColor = Color.Red
            ElseIf statu = "f7" Then
                f7.Text = "Pf7"
                f7.BackColor = Color.Red
            ElseIf statu = "f8" Then
                f8.Text = "Pf8"
                f8.BackColor = Color.Red
            ElseIf statu = "f9" Then
                f9.Text = "Pf9"
                f9.BackColor = Color.Red
            ElseIf statu = "f10" Then
                f10.Text = "Pf10"
                f10.BackColor = Color.Red
            ElseIf statu = "f11" Then
                f11.Text = "Pf11"
                f11.BackColor = Color.Red
            ElseIf statu = "f12" Then
                f12.Text = "Pf12"
                f12.BackColor = Color.Red
            ElseIf statu = "f13" Then
                f13.Text = "Pf13"
                f13.BackColor = Color.Red
            ElseIf statu = "f14" Then
                f14.Text = "Pf14"
                f14.BackColor = Color.Red
            ElseIf statu = "f15" Then
                f15.Text = "Pf15"
                f15.BackColor = Color.Red
            ElseIf statu = "f16" Then
                f16.Text = "Pf16"
                f16.BackColor = Color.Red
            ElseIf statu = "f17" Then
                f17.Text = "Pf17"
                f17.BackColor = Color.Red
            ElseIf statu = "f18" Then
                f18.Text = "Pf18"
                f18.BackColor = Color.Red
            ElseIf statu = "f19" Then
                f19.Text = "Pf19"
                f19.BackColor = Color.Red
            ElseIf statu = "f20" Then
                f20.Text = "Pf20"
                f20.BackColor = Color.Red
            Else
                Continue While

            End If
        End While
        myconnection.Close()

    End Sub
  

    Private Sub f1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1.Click
        If f1.Text = "f1" Then
            arvform.Show()
            arvform.Label12.Text = f1.Text
            arvform.Label11.Text = f1.Text
            Me.Refresh()
        ElseIf f1.Text = "Pf1" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f1"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f2.Click
        If f2.Text = "f2" Then
            arvform.Show()
            arvform.Label12.Text = f2.Text
            arvform.Label11.Text = f2.Text
            Me.Refresh()
        ElseIf f2.Text = "Pf2" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f2"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f3.Click
        If f3.Text = "f3" Then
            arvform.Show()
            arvform.Label12.Text = f3.Text
            arvform.Label11.Text = f3.Text
            Me.Refresh()
        ElseIf f3.Text = "Pf3" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f3"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub f4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f4.Click
        If f4.Text = "f4" Then
            arvform.Show()
            arvform.Label12.Text = f4.Text
            arvform.Label11.Text = f4.Text
            Me.Refresh()
        ElseIf f4.Text = "Pf4" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f4"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f5.Click
        If f5.Text = "f5" Then
            arvform.Show()
            arvform.Label12.Text = f5.Text
            arvform.Label11.Text = f5.Text
            Me.Refresh()
        ElseIf f5.Text = "Pf5" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f5"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub


    Private Sub f6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f6.Click
        If f6.Text = "f6" Then
            arvform.Show()
            arvform.Label12.Text = f6.Text
            arvform.Label11.Text = f6.Text
            Me.Refresh()
        ElseIf f6.Text = "Pf6" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f6"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f7.Click
        If f7.Text = "f7" Then
            arvform.Show()
            arvform.Label12.Text = f7.Text
            arvform.Label11.Text = f7.Text
            Me.Refresh()
        ElseIf f7.Text = "Pf7" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f7"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f8.Click
        If f8.Text = "f8" Then
            arvform.Show()
            arvform.Label12.Text = f8.Text
            arvform.Label11.Text = f8.Text
            Me.Refresh()
        ElseIf f8.Text = "Pf8" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f8"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f9.Click
        If f9.Text = "f9" Then
            arvform.Show()
            arvform.Label12.Text = f9.Text
            arvform.Label11.Text = f9.Text
            Me.Refresh()
        ElseIf f9.Text = "Pf9" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f9"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f10.Click
        If f10.Text = "f10" Then
            arvform.Show()
            arvform.Label12.Text = f10.Text
            arvform.Label11.Text = f10.Text
            Me.Refresh()
        ElseIf f10.Text = "Pf10" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f10"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f11.Click
        If f11.Text = "f11" Then
            arvform.Show()
            arvform.Label12.Text = f11.Text
            arvform.Label11.Text = f11.Text
            Me.Refresh()
        ElseIf f11.Text = "Pf11" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f11"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub f12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f12.Click
        If f12.Text = "f12" Then
            arvform.Show()
            arvform.Label12.Text = f12.Text
            arvform.Label11.Text = f12.Text
            Me.Refresh()
        ElseIf f12.Text = "Pf12" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f12"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f13.Click
        If f13.Text = "f13" Then
            arvform.Show()
            arvform.Label12.Text = f13.Text
            arvform.Label11.Text = f13.Text
            Me.Refresh()
        ElseIf f13.Text = "Pf13" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f13"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f14.Click
        If f14.Text = "f14" Then
            arvform.Show()
            arvform.Label12.Text = f14.Text
            arvform.Label11.Text = f14.Text
            Me.Refresh()
        ElseIf f14.Text = "Pf14" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f14"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f15.Click
        If f15.Text = "f15" Then
            arvform.Show()
            arvform.Label12.Text = f15.Text
            arvform.Label11.Text = f15.Text
            Me.Refresh()
        ElseIf f15.Text = "Pf15" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f15"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f16.Click
        If f16.Text = "f16" Then
            arvform.Show()
            arvform.Label12.Text = f16.Text
            arvform.Label11.Text = f16.Text
            Me.Refresh()
        ElseIf f16.Text = "Pf16" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f16"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f17.Click
        If f17.Text = "f17" Then
            arvform.Show()
            arvform.Label12.Text = f17.Text
            arvform.Label11.Text = f17.Text
            Me.Refresh()
        ElseIf f17.Text = "Pf17" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f17"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f18.Click
        If f18.Text = "f18" Then
            arvform.Show()
            arvform.Label12.Text = f18.Text
            arvform.Label11.Text = f18.Text
            Me.Refresh()
        ElseIf f18.Text = "Pf18" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f18"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f19.Click
        If f19.Text = "f19" Then
            arvform.Show()
            arvform.Label12.Text = f19.Text
            arvform.Label11.Text = f19.Text
            Me.Refresh()
        ElseIf f19.Text = "Pf19" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f19"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub f20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f20.Click
        If f20.Text = "f20" Then
            arvform.Show()
            arvform.Label12.Text = f20.Text
            arvform.Label11.Text = f20.Text
            Me.Refresh()
        ElseIf f20.Text = "Pf20" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "f20"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub t1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.Click
        If t1.Text = "t1" Then
            arvform.Show()
            arvform.Label12.Text = t1.Text
            arvform.Label11.Text = t1.Text
            Me.Refresh()
        ElseIf t1.Text = "Pt1" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t1"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub


    Private Sub t2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.Click
        If t2.Text = "t2" Then
            arvform.Show()
            arvform.Label12.Text = t2.Text
            arvform.Label11.Text = t2.Text
            Me.Refresh()
        ElseIf t2.Text = "Pt2" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t2"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.Click
        If t3.Text = "t3" Then
            arvform.Show()
            arvform.Label12.Text = t3.Text
            arvform.Label11.Text = t3.Text
            Me.Refresh()
        ElseIf t3.Text = "Pt3" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t3"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub


    Private Sub t4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t4.Click
        If t4.Text = "t4" Then
            arvform.Show()
            arvform.Label12.Text = t4.Text
            arvform.Label11.Text = t4.Text
            Me.Refresh()
        ElseIf t4.Text = "Pt4" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t4"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub t5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t5.Click
        If t5.Text = "t5" Then
            arvform.Show()
            arvform.Label12.Text = t5.Text
            arvform.Label11.Text = t5.Text
            Me.Refresh()
        ElseIf t5.Text = "Pt5" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t5"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub t6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t6.Click
        If t6.Text = "t6" Then
            arvform.Show()
            arvform.Label12.Text = t6.Text
            arvform.Label11.Text = t6.Text
            Me.Refresh()
        ElseIf t6.Text = "Pt6" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t6"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t7.Click
        If t7.Text = "t7" Then
            arvform.Show()
            arvform.Label12.Text = t7.Text
            arvform.Label11.Text = t7.Text
            Me.Refresh()
        ElseIf t7.Text = "Pt7" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t7"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t8.Click
        If t8.Text = "t8" Then
            arvform.Show()
            arvform.Label12.Text = t8.Text
            arvform.Label11.Text = t8.Text
            Me.Refresh()
        ElseIf t8.Text = "Pt8" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t8"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t9.Click
        If t9.Text = "t9" Then
            arvform.Show()
            arvform.Label12.Text = t9.Text
            arvform.Label11.Text = t9.Text
            Me.Refresh()
        ElseIf t9.Text = "Pt9" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t9"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t10.Click
        If t10.Text = "t10" Then
            arvform.Show()
            arvform.Label12.Text = t10.Text
            arvform.Label11.Text = t10.Text
            Me.Refresh()
        ElseIf t10.Text = "Pt10" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t10"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub t11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t11.Click
        If t11.Text = "t11" Then
            arvform.Show()
            arvform.Label12.Text = t11.Text
            arvform.Label11.Text = t11.Text
            Me.Refresh()
        ElseIf t11.Text = "Pt11" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t11"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t12.Click
        If t12.Text = "t12" Then
            arvform.Show()
            arvform.Label12.Text = t12.Text
            arvform.Label11.Text = t12.Text
            Me.Refresh()
        ElseIf t12.Text = "Pt12" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t12"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t13.Click
        If t13.Text = "t13" Then
            arvform.Show()
            arvform.Label12.Text = t13.Text
            arvform.Label11.Text = t13.Text
            Me.Refresh()
        ElseIf t13.Text = "Pt13" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t13"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t14.Click
        If t14.Text = "t14" Then
            arvform.Show()
            arvform.Label12.Text = t14.Text
            arvform.Label11.Text = t14.Text
            Me.Refresh()
        ElseIf t14.Text = "Pt14" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t14"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t15.Click
        If t15.Text = "t15" Then
            arvform.Show()
            arvform.Label12.Text = t15.Text
            arvform.Label11.Text = t15.Text
            Me.Refresh()
        ElseIf t15.Text = "Pt15" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t15"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t16.Click
        If t16.Text = "t16" Then
            arvform.Show()
            arvform.Label12.Text = t16.Text
            arvform.Label11.Text = t16.Text
            Me.Refresh()
        ElseIf t16.Text = "Pt16" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t16"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t17.Click
        If t17.Text = "t17" Then
            arvform.Show()
            arvform.Label12.Text = t17.Text
            arvform.Label11.Text = t17.Text
            Me.Refresh()
        ElseIf t17.Text = "Pt17" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t17"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t18.Click
        If t18.Text = "t18" Then
            arvform.Show()
            arvform.Label12.Text = t18.Text
            arvform.Label11.Text = t18.Text
            Me.Refresh()
        ElseIf t18.Text = "Pt18" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t18"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t19.Click
        If t19.Text = "t19" Then
            arvform.Show()
            arvform.Label12.Text = t19.Text
            arvform.Label11.Text = t19.Text
            Me.Refresh()
        ElseIf t19.Text = "Pt19" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t19"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t20.Click
        If t20.Text = "t20" Then
            arvform.Show()
            arvform.Label12.Text = t20.Text
            arvform.Label11.Text = t20.Text
            Me.Refresh()
        ElseIf t20.Text = "Pt20" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t20"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t21.Click
        If t21.Text = "t21" Then
            arvform.Show()
            arvform.Label12.Text = t21.Text
            arvform.Label11.Text = t21.Text
            Me.Refresh()
        ElseIf t21.Text = "Pt21" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t21"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t22.Click
        If t22.Text = "t22" Then
            arvform.Show()
            arvform.Label12.Text = t22.Text
            arvform.Label11.Text = t22.Text
            Me.Refresh()
        ElseIf t22.Text = "Pt22" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t22"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t23.Click
        If t23.Text = "t23" Then
            arvform.Show()
            arvform.Label12.Text = t23.Text
            arvform.Label11.Text = t23.Text
            Me.Refresh()
        ElseIf t23.Text = "Pt23" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t23"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t24.Click
        If t24.Text = "t24" Then
            arvform.Show()
            arvform.Label12.Text = t24.Text
            arvform.Label11.Text = t24.Text
            Me.Refresh()
        ElseIf t24.Text = "Pt24" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t24"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t25.Click
        If t25.Text = "t25" Then
            arvform.Show()
            arvform.Label12.Text = t25.Text
            arvform.Label11.Text = t25.Text
            Me.Refresh()
        ElseIf t25.Text = "Pt25" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t25"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t26.Click
        If t26.Text = "t26" Then
            arvform.Show()
            arvform.Label12.Text = t26.Text
            arvform.Label11.Text = t26.Text
            Me.Refresh()
        ElseIf t26.Text = "Pt26" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t26"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t27.Click
        If t27.Text = "t27" Then
            arvform.Show()
            arvform.Label12.Text = t27.Text
            arvform.Label11.Text = t27.Text
            Me.Refresh()
        ElseIf t27.Text = "Pt27" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t27"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t28.Click
        If t28.Text = "t28" Then
            arvform.Show()
            arvform.Label12.Text = t28.Text
            arvform.Label11.Text = t28.Text
            Me.Refresh()
        ElseIf t28.Text = "Pt28" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t28"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t29.Click
        If t29.Text = "t29" Then
            arvform.Show()
            arvform.Label12.Text = t29.Text
            arvform.Label11.Text = t29.Text
            Me.Refresh()
        ElseIf t29.Text = "Pt29" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t29"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t30.Click
        If t30.Text = "t30" Then
            arvform.Show()
            arvform.Label12.Text = t30.Text
            arvform.Label11.Text = t30.Text
            Me.Refresh()
        ElseIf t30.Text = "Pt30" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t30"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub t31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t31.Click
        If t31.Text = "t31" Then
            arvform.Show()
            arvform.Label12.Text = t31.Text
            arvform.Label11.Text = t31.Text
            Me.Refresh()
        ElseIf t31.Text = "Pt31" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t31"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t32.Click
        If t32.Text = "t32" Then
            arvform.Show()
            arvform.Label12.Text = t32.Text
            arvform.Label11.Text = t32.Text
            Me.Refresh()
        ElseIf t32.Text = "Pt32" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t32"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t33.Click
        If t33.Text = "t33" Then
            arvform.Show()
            arvform.Label12.Text = t33.Text
            arvform.Label11.Text = t33.Text
            Me.Refresh()
        ElseIf t33.Text = "Pt33" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t33"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t34.Click
        If t34.Text = "t34" Then
            arvform.Show()
            arvform.Label12.Text = t34.Text
            arvform.Label11.Text = t34.Text
            Me.Refresh()
        ElseIf t34.Text = "Pt34" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t34"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t35.Click
        If t35.Text = "t35" Then
            arvform.Show()
            arvform.Label12.Text = t35.Text
            arvform.Label11.Text = t35.Text
            Me.Refresh()
        ElseIf t35.Text = "Pt35" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t35"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t36.Click
        If t36.Text = "t36" Then
            arvform.Show()
            arvform.Label12.Text = t36.Text
            arvform.Label11.Text = t36.Text
            Me.Refresh()
        ElseIf t36.Text = "Pt36" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t36"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t37.Click
        If t37.Text = "t37" Then
            arvform.Show()
            arvform.Label12.Text = t37.Text
            arvform.Label11.Text = t37.Text
            Me.Refresh()
        ElseIf t37.Text = "Pt37" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t37"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t38.Click
        If t38.Text = "t38" Then
            arvform.Show()
            arvform.Label12.Text = t38.Text
            arvform.Label11.Text = t38.Text
            Me.Refresh()
        ElseIf t38.Text = "Pt38" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t38"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t39.Click
        If t39.Text = "t39" Then
            arvform.Show()
            arvform.Label12.Text = t39.Text
            arvform.Label11.Text = t39.Text
            Me.Refresh()
        ElseIf t39.Text = "Pt39" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t39"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t40.Click
        If t40.Text = "t40" Then
            arvform.Show()
            arvform.Label12.Text = t40.Text
            arvform.Label11.Text = t40.Text
            Me.Refresh()
        ElseIf t40.Text = "Pt40" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t40"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub t41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t41.Click
        If t41.Text = "t41" Then
            arvform.Show()
            arvform.Label12.Text = t41.Text
            arvform.Label11.Text = t41.Text
            Me.Refresh()
        ElseIf t41.Text = "Pt41" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t41"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t42.Click
        If t42.Text = "t42" Then
            arvform.Show()
            arvform.Label12.Text = t42.Text
            arvform.Label11.Text = t42.Text
            Me.Refresh()
        ElseIf t42.Text = "Pt42" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t42"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t43.Click
        If t43.Text = "t43" Then
            arvform.Show()
            arvform.Label12.Text = t43.Text
            arvform.Label11.Text = t43.Text
            Me.Refresh()
        ElseIf t43.Text = "Pt43" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t43"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t44.Click
        If t44.Text = "t44" Then
            arvform.Show()
            arvform.Label12.Text = t44.Text
            arvform.Label11.Text = t44.Text
            Me.Refresh()
        ElseIf t44.Text = "Pt44" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t44"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t45.Click
        If t45.Text = "t45" Then
            arvform.Show()
            arvform.Label12.Text = t45.Text
            arvform.Label11.Text = t45.Text
            Me.Refresh()
        ElseIf t45.Text = "Pt45" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t45"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t46.Click
        If t46.Text = "t46" Then
            arvform.Show()
            arvform.Label12.Text = t46.Text
            arvform.Label11.Text = t46.Text
            Me.Refresh()
        ElseIf t46.Text = "Pt46" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t46"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t47.Click
        If t47.Text = "t47" Then
            arvform.Show()
            arvform.Label12.Text = t47.Text
            arvform.Label11.Text = t47.Text
            Me.Refresh()
        ElseIf t47.Text = "Pt47" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t47"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t48.Click
        If t48.Text = "t48" Then
            arvform.Show()
            arvform.Label12.Text = t48.Text
            arvform.Label11.Text = t48.Text
            Me.Refresh()
        ElseIf t48.Text = "Pt48" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t48"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t49.Click
        If t49.Text = "t49" Then
            arvform.Show()
            arvform.Label12.Text = t49.Text
            arvform.Label11.Text = t49.Text
            Me.Refresh()
        ElseIf t49.Text = "Pt49" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t49"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub
    Private Sub t50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t50.Click
        If t50.Text = "t50" Then
            arvform.Show()
            arvform.Label12.Text = t50.Text
            arvform.Label11.Text = t50.Text
            Me.Refresh()
        ElseIf t50.Text = "Pt50" Then
            Dim ques As MsgBoxResult
            ques = MsgBox("Do you want to depart ?", MessageBoxButtons.YesNo, "")
            If ques = MsgBoxResult.Yes Then
                depart.Show()
                depart.Label5.Text = "t50"
                Me.Refresh()
            Else
                Me.Show()
            End If
        End If
    End Sub


    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        main.Show()
        Me.Hide()
    End Sub

   
End Class




