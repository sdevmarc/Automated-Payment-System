Public Class SubLinkFailed
    Private Sub SubLinkFailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveFailed()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        SubRegister.Close()
        SubRegCard.Close()
        Register.Show()
        Me.Close()
    End Sub
End Class