Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim divide As Decimal
        divide = TextBox2.Text / TextBox1.Text
        ListBox1.Items.Add(divide)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim add As Double
        add = CDec(TextBox2.Text) + CDec(TextBox1.Text)
        ListBox1.Items.Add(add)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim times As Decimal
        times = TextBox2.Text * TextBox1.Text
        ListBox1.Items.Add(times)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim squareroot As Decimal
        Dim squareroot2 As Decimal
        Dim final As Decimal
        Dim final2 As Decimal
        squareroot2 = CDec(TextBox1.Text)
        squareroot = CDec(TextBox1.Text)
        final = Math.Sqrt(squareroot2)
        final2 = Math.Sqrt(squareroot)


        ListBox1.Items.Add(final & final2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim minus As Double
        minus = TextBox2.Text - TextBox1.Text
        ListBox1.Items.Add(minus)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
