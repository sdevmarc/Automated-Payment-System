Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim intOnly As Integer
        If (String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtID.Text)) Then
            MessageBox.Show("Please fill the empty fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (Integer.TryParse(txtID.Text, intOnly)) Then
            SubRegister.Show()
            RegisterDetails()
        Else
            MessageBox.Show("Please enter a valid ID Number!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Main.Show()
        Me.Close()
    End Sub
End Class