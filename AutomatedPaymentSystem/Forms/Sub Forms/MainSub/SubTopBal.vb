Public Class SubTopBal
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If (MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
            TopLoading.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        TopUp()
        TransTop()
        SubSuccessTop.Show()
        Me.Close()
    End Sub
End Class