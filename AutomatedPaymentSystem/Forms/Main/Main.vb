Public Class Main
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        TopLoading.Show()
        Me.Close()
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Transaction.Show()
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Close()
    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Balance.Show()
    End Sub
End Class
