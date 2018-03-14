Imports System.IO
Public Class fb

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, feedback, filename As String
        name = TextBox2.Text
        feedback = RichTextBox1.Text
        Dim writer As IO.StreamWriter
        filename = name + ".feedback"
        writer = New IO.StreamWriter(filename)
        writer.Write(feedback)
        writer.Close()
        TextBox2.Text = ""
        RichTextBox1.Text = ""
        Me.Visible = False
        Form1.Visible = True
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class