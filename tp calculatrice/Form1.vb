Public Class Form1
    Public operant1 As Integer
    Public operant2 As Integer
    Public result As Double
    Public signe As String
    Private Sub BT_1_Click(sender As Object, e As EventArgs) Handles BT_1.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "1"
    End Sub

    Private Sub BT_CANCEL_Click(sender As Object, e As EventArgs) Handles BT_CANCEL.Click
        TXT_AFFICHAGE.ResetText()
    End Sub

    Private Sub BT_2_Click(sender As Object, e As EventArgs) Handles BT_2.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "2"
    End Sub

    Private Sub BT_3_Click(sender As Object, e As EventArgs) Handles BT_3.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "3"
    End Sub

    Private Sub BT_4_Click(sender As Object, e As EventArgs) Handles BT_4.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "4"
    End Sub

    Private Sub BT_5_Click(sender As Object, e As EventArgs) Handles BT_5.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "5"
    End Sub

    Private Sub BT_6_Click(sender As Object, e As EventArgs) Handles BT_6.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "6"
    End Sub

    Private Sub BT_7_Click(sender As Object, e As EventArgs) Handles BT_7.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "7"
    End Sub

    Private Sub BT_8_Click(sender As Object, e As EventArgs) Handles BT_8.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "8"
    End Sub

    Private Sub BT_9_Click(sender As Object, e As EventArgs) Handles BT_9.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "9"
    End Sub

    Private Sub BT_0_Click(sender As Object, e As EventArgs) Handles BT_0.Click
        TXT_AFFICHAGE.Text = TXT_AFFICHAGE.Text + "0"
    End Sub

    Private Sub BT_ADDITION_Click(sender As Object, e As EventArgs) Handles BT_ADDITION.Click
        operant1 = Integer.Parse(TXT_AFFICHAGE.Text)
        TXT_AFFICHAGE.Text = ""
        signe = "+"
    End Sub

    Private Sub BT_SOUSTRACTION_Click(sender As Object, e As EventArgs) Handles BT_SOUSTRACTION.Click
        operant1 = Integer.Parse(TXT_AFFICHAGE.Text)
        TXT_AFFICHAGE.Text = ""
        signe = "-"
    End Sub

    Private Sub BT_MULTIPLICATION_Click(sender As Object, e As EventArgs) Handles BT_MULTIPLICATION.Click
        operant1 = Integer.Parse(TXT_AFFICHAGE.Text)
        TXT_AFFICHAGE.Text = ""
        signe = "*"
    End Sub

    Private Sub BT_DIVISION_Click(sender As Object, e As EventArgs) Handles BT_DIVISION.Click
        operant1 = Integer.Parse(TXT_AFFICHAGE.Text)
        TXT_AFFICHAGE.Text = ""
        signe = "/"
    End Sub

    Private Sub BT_RESULTAT_Click(sender As Object, e As EventArgs) Handles BT_RESULTAT.Click
        operant2 = Integer.Parse(TXT_AFFICHAGE.Text)
        If signe = "+" Then
            result = operant1 + operant2
        ElseIf signe = "-" Then
            result = operant1 - operant2
        ElseIf signe = "/" Then
            result = operant1 / operant2
        Else
            result = operant1 * operant2
        End If
        TXT_AFFICHAGE.Text = result
    End Sub


End Class
