Public Class NewTapTop
    Private Sub CardEnter(sender As Object, e As KeyEventArgs) Handles txtCard.KeyDown
        Try
            Dim intOnly As Integer
            If (e.KeyCode = Keys.Enter) Then
                If Integer.TryParse(txtCard.Text, intOnly) Then
                    ' MessageBox.Show("Please enter your ID!")
                    If VerifyIDTop() Then
                        If VerifyAmount() Then
                            SubLoad.Show()
                            TopDetails()
                            Me.Close()
                        End If
                    End If
                ElseIf (String.IsNullOrEmpty(txtCard.Text)) Then
                        MessageBox.Show("Please enter your ID!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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