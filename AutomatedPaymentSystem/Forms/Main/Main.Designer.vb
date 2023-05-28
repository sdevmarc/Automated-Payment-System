<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.White
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPayment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Location = New System.Drawing.Point(21, 12)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(260, 140)
        Me.btnPayment.TabIndex = 0
        Me.btnPayment.Text = "PAYMENT"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnPop
        '
        Me.btnPop.BackColor = System.Drawing.Color.White
        Me.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPop.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPop.Location = New System.Drawing.Point(297, 12)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(260, 140)
        Me.btnPop.TabIndex = 1
        Me.btnPop.Text = "TOP - UP"
        Me.btnPop.UseVisualStyleBackColor = False
        '
        'btnTrans
        '
        Me.btnTrans.BackColor = System.Drawing.Color.White
        Me.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTrans.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrans.Location = New System.Drawing.Point(297, 167)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(260, 140)
        Me.btnTrans.TabIndex = 3
        Me.btnTrans.Text = "TRANSACTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HISTORY"
        Me.btnTrans.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(21, 167)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(260, 140)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "REGISTER NEW USER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBalance
        '
        Me.btnBalance.BackColor = System.Drawing.Color.White
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBalance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBalance.Location = New System.Drawing.Point(21, 325)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(536, 47)
        Me.btnBalance.TabIndex = 5
        Me.btnBalance.Text = "BALANCE"
        Me.btnBalance.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(585, 384)
        Me.Controls.Add(Me.btnBalance)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPayment)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Payment System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPayment As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnTrans As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBalance As Button
End Class
