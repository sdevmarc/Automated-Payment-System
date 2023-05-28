Public Class SubFailedPay
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        InsertFailed()
        ConnecDB("dis")
        Main.Show()
        Payment.Close()
        Me.Close()
    End Sub

    Private Sub SubFailedPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveCard()
    End Sub
End Class