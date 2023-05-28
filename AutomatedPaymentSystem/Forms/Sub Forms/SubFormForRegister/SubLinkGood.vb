Public Class SubLinkGood
    Private Sub SubLinkGood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr.Interval = 3000 ' Set the interval to 3000 milliseconds (3 seconds)
        tmr.Start() ' Start the timer
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        tmr.Stop() ' Stop the timer
        Register.txtID.Text = ""
        Register.txtName.Text = ""
        Register.Show() ' Show the next form
        Me.Close() ' Hide the current form
    End Sub
End Class