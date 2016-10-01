Public Class Form1
    'randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    Dim s1, s2, s3, s4, s5 As Integer
    Dim s6, s7, s8, s9, s10 As Integer
    Dim ran As New Random
  
    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        s1 = CInt(ran.Next(50, 101))
        s2 = CInt(ran.Next(50, 101))
        s3 = CInt(ran.Next(50, 101))
        s4 = CInt(ran.Next(50, 101))
        s5 = CInt(ran.Next(50, 101))
        s6 = CInt(ran.Next(30, 101))
        s7 = CInt(ran.Next(30, 101))
        s8 = CInt(ran.Next(30, 101))
        s9 = CInt(ran.Next(30, 101))
        ' s10 = CInt(ran.Next(30, 101))
        s10 = CInt(Math.Floor((100-50+1)*Rnd()))+30
        txtTestScore1.Text = s1
        txtTestScore2.Text = s2
        txtTestScore3.Text = s3
        txtTestScore4.Text = s4
        txtTestScore5.Text = s5
        txtTestScore6.Text = s6
        txtTestScore7.Text = s7
        txtTestScore8.Text = s8
        txtTestScore9.Text = s9
        txtTestScore10.Text = s10
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTestScore1.Clear()
        txtTestScore2.Clear()
        txtTestScore3.Clear()
        txtTestScore4.Clear()
        txtTestScore5.Clear()
        '---------------------
        txtTestScore6.Clear()
        txtTestScore7.Clear()
        txtTestScore8.Clear()
        txtTestScore9.Clear()
        txtTestScore10.Clear()
        '---------------------
        txtMean.Clear()
        txtSD.Clear()

    End Sub

    Private Sub btnComputeStats_Click(sender As Object, e As EventArgs) Handles btnComputeStats.Click
        Dim mean, sd As Double
        mean = (s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10) / 10
        txtMean.Text = FormatNumber(mean, 2)

        sd = Math.Sqrt(((s1 - mean) ^ 2 + (s2 - mean) ^ 2 + (s3 - mean) ^ 2 + (s4 - mean) ^ 2 + (s5 - mean) ^ 2 + (s6 - mean) ^ 2 + (s7 - mean) ^ 2 + (s8 - mean) ^ 2 + (s9 - mean) ^ 2 + (s10 - mean) ^ 2) / 10)


        txtSD.Text = CStr(FormatNumber(sd, 2))

    End Sub
End Class
