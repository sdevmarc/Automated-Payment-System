Public Class Transaction
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        MdiForm("Pay")
    End Sub

    Private Sub btnCashIn_Click(sender As Object, e As EventArgs) Handles btnCashIn.Click
        MdiForm("CashIn")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main.Show()
        Me.Close()
    End Sub
End Class