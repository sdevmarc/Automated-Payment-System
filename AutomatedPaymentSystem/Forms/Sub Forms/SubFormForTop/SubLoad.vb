Public Class SubLoad
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        TopLoading.Show()
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Try
            SubTopBal.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class