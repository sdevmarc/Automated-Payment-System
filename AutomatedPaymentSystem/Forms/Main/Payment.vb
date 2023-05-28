Public Class Payment
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim targetControl As Control = txtAmount
        Dim currentText As String = targetControl.Text

        ' Remove the last character from the current text
        If currentText.Length > 0 Then
            currentText = currentText.Substring(0, currentText.Length - 1)
            targetControl.Text = currentText
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub DigitButton_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim digitButton As Button = DirectCast(sender, Button)
        Dim digit As String = digitButton.Text

        If txtAmount.Text.Length < 5 Then
            txtAmount.Text += digit
        End If

        If txtAmount.Text.Length > 5 Then
            txtAmount.Text = txtAmount.Text.Substring(0, 5)
        End If
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If (String.IsNullOrEmpty(txtAmount.Text)) Then
            MessageBox.Show("Empty Field! Please input amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            SubPayment.Show()
            PaymentAmount()
        End If
    End Sub
End Class