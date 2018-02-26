Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If TextBox4.Text = "" Then
                TextBox4.Text = "League of Legends"
            Else
                If TextBox5.Text = "" Then
                    TextBox5.Text = "League of Legends"
                Else
                    TextBox6.Text = "League of Legends"
                End If
            End If
        Else
            If TextBox4.Text = "League of Legends" Then
                TextBox4.Text = ""
            End If
            If TextBox5.Text = "League of Legends" Then
                TextBox5.Text = ""
            End If
            If TextBox6.Text = "League of Legends" Then
                TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            If TextBox4.Text = "" Then
                TextBox4.Text = "PUBG"
            Else
                If TextBox5.Text = "" Then
                    TextBox5.Text = "PUBG"
                Else
                    TextBox6.Text = "PUBG"
                End If
            End If
        Else
            If TextBox4.Text = "PUBG" Then
                TextBox4.Text = ""
            End If
            If TextBox5.Text = "PUBG" Then
                TextBox5.Text = ""
            End If
            If TextBox6.Text = "PUBG" Then
                TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            If TextBox4.Text = "" Then
                TextBox4.Text = "Injustice 2"
            Else
                If TextBox5.Text = "" Then
                    TextBox5.Text = "Injustice 2"
                Else
                    TextBox6.Text = "Injustice 2"
                End If
            End If
        Else
            If TextBox4.Text = "Injustice 2" Then
                TextBox4.Text = ""
            End If
            If TextBox5.Text = "Injustice 2" Then
                TextBox5.Text = ""
            End If
            If TextBox6.Text = "Injustice 2" Then
                TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        PUBG.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        LeagueOfLegends.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False
        Injustice_2.Visible = True
    End Sub



    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Visible = False
        TestForm.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Visible = False
        GS.Visible = True
    End Sub
End Class
