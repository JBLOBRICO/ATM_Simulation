<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBalanceInquiry = New System.Windows.Forms.Button()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.btnMiniStatement = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnFundTransfer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccountNumberDisplay = New System.Windows.Forms.Label()
        Me.lblUserAccountNumber = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        ' PictureBox1
        ' (Initialized to avoid errors — Image property is left Nothing to prevent missing-resource compile issues)
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(820, 520)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.Image = Nothing ' <-- If you have a resource, replace Nothing with: My.Resources.YourImageName
        '
        ' btnBalanceInquiry
        '
        Me.btnBalanceInquiry.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnBalanceInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalanceInquiry.FlatAppearance.BorderSize = 0
        Me.btnBalanceInquiry.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBalanceInquiry.ForeColor = System.Drawing.Color.White
        Me.btnBalanceInquiry.Location = New System.Drawing.Point(30, 30)
        Me.btnBalanceInquiry.Name = "btnBalanceInquiry"
        Me.btnBalanceInquiry.Size = New System.Drawing.Size(250, 55)
        Me.btnBalanceInquiry.TabIndex = 0
        Me.btnBalanceInquiry.Text = "Balance Inquiry"
        Me.btnBalanceInquiry.UseVisualStyleBackColor = False
        '
        ' btnWithdrawal
        '
        Me.btnWithdrawal.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWithdrawal.FlatAppearance.BorderSize = 0
        Me.btnWithdrawal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnWithdrawal.ForeColor = System.Drawing.Color.White
        Me.btnWithdrawal.Location = New System.Drawing.Point(30, 110)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(250, 55)
        Me.btnWithdrawal.TabIndex = 1
        Me.btnWithdrawal.Text = "Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = False
        '
        ' btnMiniStatement
        '
        Me.btnMiniStatement.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnMiniStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiniStatement.FlatAppearance.BorderSize = 0
        Me.btnMiniStatement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMiniStatement.ForeColor = System.Drawing.Color.White
        Me.btnMiniStatement.Location = New System.Drawing.Point(30, 190)
        Me.btnMiniStatement.Name = "btnMiniStatement"
        Me.btnMiniStatement.Size = New System.Drawing.Size(250, 55)
        Me.btnMiniStatement.TabIndex = 2
        Me.btnMiniStatement.Text = "Mini Statement"
        Me.btnMiniStatement.UseVisualStyleBackColor = False
        '
        ' btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposit.FlatAppearance.BorderSize = 0
        Me.btnDeposit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeposit.ForeColor = System.Drawing.Color.White
        Me.btnDeposit.Location = New System.Drawing.Point(320, 30)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(250, 55)
        Me.btnDeposit.TabIndex = 3
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        ' btnFundTransfer
        '
        Me.btnFundTransfer.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnFundTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFundTransfer.FlatAppearance.BorderSize = 0
        Me.btnFundTransfer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFundTransfer.ForeColor = System.Drawing.Color.White
        Me.btnFundTransfer.Location = New System.Drawing.Point(320, 110)
        Me.btnFundTransfer.Name = "btnFundTransfer"
        Me.btnFundTransfer.Size = New System.Drawing.Size(250, 55)
        Me.btnFundTransfer.TabIndex = 4
        Me.btnFundTransfer.Text = "Fund Transfer"
        Me.btnFundTransfer.UseVisualStyleBackColor = False
        '
        ' btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(320, 190)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(250, 55)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        ' Panel1 (container)
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblAccountNumberDisplay)
        Me.Panel1.Controls.Add(Me.lblUserAccountNumber)
        Me.Panel1.Controls.Add(Me.lbl)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblGreetings)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(50, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 420)
        Me.Panel1.TabIndex = 7
        '
        ' lblAccountNumberDisplay
        '
        Me.lblAccountNumberDisplay.AutoSize = True
        Me.lblAccountNumberDisplay.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular)
        Me.lblAccountNumberDisplay.Location = New System.Drawing.Point(200, 80)
        Me.lblAccountNumberDisplay.Name = "lblAccountNumberDisplay"
        Me.lblAccountNumberDisplay.Size = New System.Drawing.Size(65, 20)
        Me.lblAccountNumberDisplay.TabIndex = 16
        Me.lblAccountNumberDisplay.Text = "0000000"
        '
        ' lblUserAccountNumber
        '
        Me.lblUserAccountNumber.AutoSize = True
        Me.lblUserAccountNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserAccountNumber.Location = New System.Drawing.Point(200, 55)
        Me.lblUserAccountNumber.Name = "lblUserAccountNumber"
        Me.lblUserAccountNumber.Size = New System.Drawing.Size(65, 20)
        Me.lblUserAccountNumber.TabIndex = 15
        Me.lblUserAccountNumber.Text = "0000000"
        '
        ' lbl (label text)
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl.Location = New System.Drawing.Point(30, 55)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(145, 20)
        Me.lbl.TabIndex = 14
        Me.lbl.Text = "Account Number:"
        '
        ' lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.Location = New System.Drawing.Point(120, 25)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(85, 21)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "UserName"
        '
        ' lblGreetings
        '
        Me.lblGreetings.AutoSize = True
        Me.lblGreetings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGreetings.Location = New System.Drawing.Point(30, 25)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(67, 21)
        Me.lblGreetings.TabIndex = 12
        Me.lblGreetings.Text = "Hello,"
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.lblTitle.Location = New System.Drawing.Point(250, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(210, 30)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Banking Operations"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' Panel2 (buttons card)
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(233, 236, 239)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnBalanceInquiry)
        Me.Panel2.Controls.Add(Me.btnDeposit)
        Me.Panel2.Controls.Add(Me.btnWithdrawal)
        Me.Panel2.Controls.Add(Me.btnMiniStatement)
        Me.Panel2.Controls.Add(Me.btnFundTransfer)
        Me.Panel2.Location = New System.Drawing.Point(60, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 260)
        Me.Panel2.TabIndex = 8
        '
        ' TextBox1 (hidden helper; kept for compatibility)
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(14, -17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 18)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Visible = False
        '
        ' TextBox2 (hidden helper; kept for compatibility)
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(69, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 18)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = "Transaction"
        Me.TextBox2.Visible = False
        '
        ' frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 520)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATM Simulation - Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBalanceInquiry As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnFundTransfer As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblGreetings As Label
    Friend WithEvents lblUserAccountNumber As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblAccountNumberDisplay As Label
    Friend WithEvents lblTitle As Label
End Class
