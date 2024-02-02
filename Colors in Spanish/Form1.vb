'Name:Colors in spanish
'Purpose: gives you the name of a color in spanish
'Programmer: H.Goodwill 2/1/2024

Public Class frmMain
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        lblSpanish.Text = "Azul"
        lblSpanish.BackColor = Color.Blue
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        lblSpanish.Text = "Verde"
        lblSpanish.BackColor = Color.Green
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        lblSpanish.Text = "Rojo"
        lblSpanish.BackColor = Color.Red
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblSpanish_Click(sender As Object, e As EventArgs) Handles lblSpanish.Click

    End Sub
End Class
