Public Class SubPayment
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        SubTapPay.Show()
        Me.Close()
    End Sub
End Class