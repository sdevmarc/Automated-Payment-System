Public Class SubPrintSuccessPay
    Private Sub SubPrintS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr.Interval = 3000 ' Set the interval to 3000 milliseconds (3 seconds)
        tmr.Start() ' Start the timer
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        tmr.Stop() ' Stop the timer
        Payment.txtAmount.Text = ""
        Payment.Show()
        Me.Close() ' Hide the current form
    End Sub

End Class