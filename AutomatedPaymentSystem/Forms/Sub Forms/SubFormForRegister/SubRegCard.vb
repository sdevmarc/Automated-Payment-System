Public Class SubRegCard
    Private Sub CardEnter(sender As Object, e As KeyEventArgs) Handles txtCard.KeyDown
        Try
            Dim intOnly As Integer
            If (e.KeyCode = Keys.Enter) Then
                If Integer.TryParse(txtCard.Text, intOnly) Then
                    If VerifyRegisterCard() = True Then
                        RegisterAccDB()
                        RegisterCardDB()
                        SubRegister.Close()
                        SubProcess.Show()
                        Me.Close()
                    End If
                ElseIf (String.IsNullOrEmpty(txtCard.Text)) Then
                    If (MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK) Then
                        txtCard.Text = ""
                    End If
                Else
                    MessageBox.Show("Please enter a valid id number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCard.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class