Module OBJModule
    Sub MdiForm(inp As Object)
        If (inp = "Pay") Then
            inp = New TransPay
            inp.MdiParent = Transaction
            inp.Show()
        ElseIf (inp = "CashIn") Then
            inp = New TransCashin
            inp.MdiParent = Transaction
            inp.Show()
        End If
    End Sub

    'PAY FORMS
    Sub PaymentAmount()
        SubPayment.lblAmount.Text = "PHP " + Payment.txtAmount.Text + ".00"
    End Sub


    'TOP FORMS
    Sub TopDetails()
        SubLoad.lblAmount.Text = "PHP " + TopLoading.txtAmount.Text
        SubTopBal.lblAmount.Text = SubLoad.lblAmount.Text

    End Sub

    'REGISTER FORMS
    Sub RetrieveFailed()
        SubLinkFailed.lblExist.Text = SubRegCard.txtCard.Text + " already exist in the System!".ToUpper
    End Sub

    Sub RegisterDetails()
        SubRegister.lblName.Text = Register.txtName.Text.ToUpper()
        SubRegister.lblID.Text = Register.txtID.Text.ToUpper()
        SubRegister.lblBirth.Text = Register.dtpBirth.Text.ToUpper()
    End Sub
End Module
