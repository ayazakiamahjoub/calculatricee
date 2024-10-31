Imports System.Runtime.CompilerServices
Public Class Form1
    Dim op As Char
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_A.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        op = "+"
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        op = "-"
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        op = "*"
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        op = "/"
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then

            Dim a = Integer.Parse(txt_A.Text)
            Dim b = Integer.Parse(txt_B.Text)
            Dim res = 0
            Dim test = True
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" And Not b = 0 Then
                res = a / b
            Else
                MessageBox.Show("Veuiller choisir un opérateur")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + " " + op + " " + b.ToString + "=" + res.ToString
            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers")
        End If
    End Sub
End Class
