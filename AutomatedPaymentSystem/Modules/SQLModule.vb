Imports MySql.Data.MySqlClient
Module SQLModule
    Dim constring As String = "server = localhost; user = root; password=1234; database = db_aps"
    Dim con As New MySqlConnection(constring)
    Dim cmd As MySqlCommand

    Sub ConnecDB(inp As Object)
        If (inp = "con") Then
            con.Open()
        ElseIf (inp = "dis") Then
            con.Close()
        End If
    End Sub

    'BALANCE DETAILS
    Function ViewBal() As Boolean
        con.Open()
        cmd = New MySqlCommand("select * from card where card_no = @CN", con)
        cmd.Parameters.AddWithValue("@CN", Balance.txtCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            Dim bal As Integer = read.GetInt32(read.GetOrdinal("balance"))
            MessageBox.Show("Your current balance is PHP " + bal.ToString + ".00", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            read.Close()
            con.Close()
            Return True
        Else
            read.Close()
            con.Close()
            Return False
        End If
    End Function

    'TOP DETAILS
    Function VerifyAmount() As Boolean
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM account left join card on account.account_id = card_id where card_no = @cn", con)
        cmd.Parameters.AddWithValue("@cn", SubTopBal.lblCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader()

        If read.Read() Then
            Dim balance As Integer = read.GetInt32("balance")
            If balance <= 5000 Then
                read.Close()
                con.Close()
                Return True
            Else
                read.Close()
                con.Close()
                MessageBox.Show("Balance limit exceeded! Maximum balance allowed is PHP 5000.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NewTapTop.Close()
                Return False
            End If
        Else
            Return False
        End If
        read.Close()
        con.Close()
    End Function

    Function VerifyIDTop()
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM account left join card on account.account_id = card_id where card_no = @cn", con)
        cmd.Parameters.AddWithValue("@cn", NewTapTop.txtCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader()

        If read.Read() Then
            SubTopBal.lblName.Text = read.GetString("name")
            SubTopBal.lblCard.Text = read.GetString("card_no")
            SubTopBal.lblBal.Text = read.GetString("balance")
            read.Close()
            con.Close()
            Return True
        Else
            read.Close()
            con.Close()
            MessageBox.Show("Unrecognized Card! Please register first!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TopLoading.Show()
            NewTapTop.Close()
            Return False
        End If
        read.Close()
        con.Close()
    End Function

    Sub TopUp()
        con.Open()
        Dim topAmount As Integer = TopLoading.txtAmount.Text
        cmd = New MySqlCommand("UPDATE card SET balance = balance + @topAmount WHERE card_no = @cardNo", con)
        cmd.Parameters.AddWithValue("@topAmount", topAmount)
        cmd.Parameters.AddWithValue("@cardNo", SubTopBal.lblCard.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub RetrieveCash()
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM account left join card on account.account_id = card_id where card_no = @cn", con)
        cmd.Parameters.AddWithValue("@cn", SubTopBal.lblCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            SubSuccessTop.lblCard.Text = read.GetString("card_no")
            SubSuccessTop.lblBal.Text = read.GetString("balance")
        End If
        con.Close()
    End Sub

    'PAYMENT DETAILS
    Sub Pay()
        con.Open()
        Dim payAmount As Integer = Payment.txtAmount.Text
        cmd = New MySqlCommand("UPDATE card SET balance = balance - @topAmount WHERE card_no = @cardNo", con)
        cmd.Parameters.AddWithValue("@topAmount", payAmount)
        cmd.Parameters.AddWithValue("@cardNo", SubTapPay.txtCard.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub RetrievePay()
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM account left join card on account.account_id = card_id where card_no = @cn", con)
        cmd.Parameters.AddWithValue("@cn", SubTapPay.txtCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        If read.Read() Then
            SubSuccessPay.lblCard.Text = read.GetString("card_no")
            SubSuccessPay.lblBal.Text = read.GetString("balance")
            SubSuccessPay.lblName.Text = read.GetString("name")
        End If
        con.Close()
    End Sub

    Sub InsertFailed()
        con.Open()
        cmd = New MySqlCommand("insert into transaction_pay (pay_card, amount, datetimepay, pay_name) values (@pc, @am, @dt, @name)", con)
        cmd.Parameters.AddWithValue("@pc", SubFailedPay.lblCard.Text)
        cmd.Parameters.AddWithValue("@am", 0)
        cmd.Parameters.AddWithValue("@dt", DateTime.Now)
        cmd.Parameters.AddWithValue("@name", SubFailedPay.lblName.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub RetrieveCard()
        con.Open()
        cmd = New MySqlCommand("Select * from account left join card on account.account_id = card.card_id where card_no = @card", con)
        cmd.Parameters.AddWithValue("@card", SubTapPay.txtCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader

        If read.Read() Then
            SubFailedPay.lblCard.Text = read.GetInt32("card_no")
            SubFailedPay.lblName.Text = read.GetString("name")
        End If
        read.Close()
        con.Close()
    End Sub

    Function VerifyIDPay() As Boolean
        con.Open()
        cmd = New MySqlCommand("SELECT * FROM card where card_no = @cn", con)
        cmd.Parameters.AddWithValue("@cn", SubTapPay.txtCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader()

        If read.Read() Then
            Dim amount As Integer = read.GetInt32(read.GetOrdinal("balance"))
            If (Payment.txtAmount.Text > amount) Or (Payment.txtAmount.Text = 0) Then
                con.Close()
                read.Close()
                SubFailedPay.Show()
                SubTapPay.Close()
                Return False
            Else
                con.Close()
                read.Close()
                Return True
            End If
        Else
            con.Close()
            read.Close()
            MessageBox.Show("Unrecognized Card! Please register first!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Payment.Show()
            SubTapPay.Close()
            Return False
        End If
        read.Close()
        con.Close()
    End Function

    'REGISTER DETAILS
    Function VerifyRegisterCard() As Boolean
        con.Open()
        cmd = New MySqlCommand("Select * from card where card_no = @cn", con)
        cmd.Parameters.AddWithValue("@cn", SubRegCard.txtCard.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader

        If read.Read() Then
            read.Close()
            con.Close()
            Register.Show()
            SubRegCard.Hide()
            SubLinkFailed.Show()
            Return False
        Else
            read.Close()
            con.Close()
            Return True
        End If
        read.Close()
        con.Close()
    End Function

    Sub RegisterCardDB()
        con.Open()
        cmd = New MySqlCommand("insert into card (card_no, balance) values (@cn, @bal)", con)
        cmd.Parameters.AddWithValue("@cn", SubRegCard.txtCard.Text)
        cmd.Parameters.AddWithValue("@bal", 0)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Function VerifyRegister() As Boolean
        con.Open()
        cmd = New MySqlCommand("Select * from account where school_id = @si", con)
        cmd.Parameters.AddWithValue("@si", Register.txtID.Text)
        Dim read As MySqlDataReader = cmd.ExecuteReader

        If read.Read() Then
            read.Close()
            con.Close()
            MessageBox.Show("School ID already Registered!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            read.Close()
            con.Close()
            Return True
        End If
        read.Close()
        con.Close()
    End Function

    Sub RegisterAccDB()
        con.Open()
        cmd = New MySqlCommand("insert into account (school_id, name, birthday) values (@id, @nm, @bd)", con)
        cmd.Parameters.AddWithValue("@id", Register.txtID.Text)
        cmd.Parameters.AddWithValue("@nm", Register.txtName.Text)
        cmd.Parameters.AddWithValue("@bd", Register.dtpBirth.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    'TRANSACTION
    'CASHIN
    Sub TransTop()
        con.Open()
        cmd = New MySqlCommand("insert into transaction_cashin (card_cash, amount, datetimecashin, cash_name) values (@cn, @am, @dt, @name)", con)
        cmd.Parameters.AddWithValue("@cn", SubTopBal.lblCard.Text)
        cmd.Parameters.AddWithValue("@am", TopLoading.txtAmount.Text)
        cmd.Parameters.AddWithValue("@dt", DateTime.Now)
        cmd.Parameters.AddWithValue("@name", SubTopBal.lblName.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub ShowTop(grid As Object)
        con.Open()
        cmd = New MySqlCommand("select * from transaction_cashin left join account on transaction_cashin.transactioncashin_id = account.account_id", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.rows.add(read("transactioncashin_id"), read("card_cash"), read("datetimecashin"), read("amount"), read("cash_name"))
        End While
        read.Close()
        con.Close()
    End Sub

    Sub SearchTop(num As Object, grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from transaction_cashin left join card on transaction_cashin.transactioncashin_id = card.card_id left join account on transaction_cashin.transactioncashin_id = card.card_id where card_cash like '%" & num & "%'", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.rows.add(read("transactioncashin_id"), read("card_cash"), read("datetimecashin"), read("amount"), read("cash_name"))
        End While
        con.Close()
        read.Close()
    End Sub


    'PAYMENT
    Sub TransaPay()
        con.Open()
        cmd = New MySqlCommand("insert into transaction_pay (pay_card, amount, datetimepay, pay_name) values (@pc, @am, @dt, @pn)", con)
        cmd.Parameters.AddWithValue("@pc", SubSuccessPay.lblCard.Text)
        cmd.Parameters.AddWithValue("@am", Payment.txtAmount.Text)
        cmd.Parameters.AddWithValue("@dt", DateTime.Now)
        cmd.Parameters.AddWithValue("@pn", SubSuccessPay.lblName.Text)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub ShowPay(grid As Object)
        con.Open()
        grid.Rows.clear()
        cmd = New MySqlCommand("select * from transaction_pay left join card on transaction_pay.transactionpay_id = card.card_id left join account on transaction_pay.transactionpay_id = card.card_id", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.rows.add(read("transactionpay_id"), read("pay_card"), read("datetimepay"), read("amount"), read("pay_name"))
        End While
        con.Close()
        read.Close()
    End Sub

    Sub SearchPay(num As Object, grid As Object)
        con.Open()
        grid.Rows.Clear()
        cmd = New MySqlCommand("select * from transaction_pay left join card on transaction_pay.transactionpay_id = card.card_id left join account on transaction_pay.transactionpay_id = card.card_id where card_no like '%" & num & "%'", con)
        Dim read As MySqlDataReader = cmd.ExecuteReader
        While read.Read
            grid.rows.add(read("transactionpay_id"), read("pay_card"), read("datetimepay"), read("amount"), read("pay_name"))
        End While
        con.Close()
        read.Close()
    End Sub

End Module
