Public Class SubSuccessPay
    Private Sub SubSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr.Interval = 3000 ' Set the interval to 3000 milliseconds (3 seconds)
        tmr.Start() ' Start the timer
        RetrievePay()
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        TransaPay()
        tmr.Stop() ' Stop the timer
        Dim frm As New SubPrintPay() ' Create an instance of the next form
        frm.Show() ' Show the next form
        Me.Close() ' Hide the current form
    End Sub
End Class