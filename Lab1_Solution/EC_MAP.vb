Public Class EC_MAP
    Dim counter As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBoxOU.Click

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If (counter = 0) Then
            lblOutput.Visible = True
            counter = counter + 1
        Else
            lblOutput.Visible = False
            counter = counter - 1
        End If

    End Sub
End Class
