Public Class SubTapPay
    Private Sub CardEnter(sender As Object, e As KeyEventArgs) Handles txtCard.KeyDown
        Try
            Dim intOnly As Integer
            If (e.KeyCode = Keys.Enter) Then
                If Integer.TryParse(txtCard.Text, intOnly) Then
                    If (VerifyIDPay() = True) Then
                        Pay()
                        SubSuccessPay.Show()
                        Me.Close()
                    End If
                ElseIf (String.IsNullOrEmpty(txtCard.Text)) Then
                    MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCard.Text = ""
                    Me.Close()
                    Me.Show()
                Else
                    MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCard.Text = ""
                    Me.Close()
                    Me.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCard.Text = ""
        End Try
    End Sub

End Class