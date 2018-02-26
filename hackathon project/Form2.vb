Public Class Form2

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If TextBox4.Text = "" Then
                TextBox4.Text = "Resident Evil 7"
            Else
                If TextBox5.Text = "" Then
                    TextBox5.Text = "Resident Evil 7"
                Else
                    TextBox6.Text = "Resident Evil 7"
                End If
            End If
        Else
            If TextBox4.Text = "Resident Evil 7" Then
                TextBox4.Text = ""
            End If
            If TextBox5.Text = "Resident Evil 7" Then
                TextBox5.Text = ""
            End If
            If TextBox6.Text = "Resident Evil 7" Then
                TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            If TextBox4.Text = "" Then
                TextBox4.Text = "Prey"
            Else
                If TextBox5.Text = "" Then
                    TextBox5.Text = "Prey"
                Else
                    TextBox6.Text = "Prey"
                End If
            End If
        Else
            If TextBox4.Text = "Prey" Then
                TextBox4.Text = ""
            End If
            If TextBox5.Text = "Prey" Then
                TextBox5.Text = ""
            End If
            If TextBox6.Text = "Prey" Then
                TextBox6.Text = ""
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            If TextBox4.Text = "" Then
                TextBox4.Text = "CSGO"
            Else
                If TextBox5.Text = "" Then
                    TextBox5.Text = "CSGO"
                Else
                    TextBox6.Text = "CSGO"
                End If
            End If
        Else
            If TextBox4.Text = "CSGO" Then
                TextBox4.Text = ""
            End If
            If TextBox5.Text = "CSGO" Then
                TextBox5.Text = ""
            End If
            If TextBox6.Text = "CSGO" Then
                TextBox6.Text = ""
            End If
        End If
    End Sub
End Class