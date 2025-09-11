<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelForm = New Panel()
        lblTitle = New Label()
        Label1 = New Label()
        txtAccNum = New TextBox()
        Label2 = New Label()
        txtPIN = New TextBox()
        btnLogin = New Button()
        PanelKeypad = New Panel()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl3 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl6 = New Label()
        lbl7 = New Label()
        lbl8 = New Label()
        lbl9 = New Label()
        lbl0 = New Label()
        lblEnter = New Label()
        lblCancel = New Label()
        lblClear = New Label()
        btnDel = New Label()
        PanelForm.SuspendLayout()
        PanelKeypad.SuspendLayout()
        SuspendLayout()
        '
        ' PanelForm
        '
        PanelForm.BackColor = Color.White
        PanelForm.BorderStyle = BorderStyle.FixedSingle
        PanelForm.Controls.Add(lblTitle)
        PanelForm.Controls.Add(Label1)
        PanelForm.Controls.Add(txtAccNum)
        PanelForm.Controls.Add(Label2)
        PanelForm.Controls.Add(txtPIN)
        PanelForm.Controls.Add(btnLogin)
        PanelForm.Location = New Point(40, 40)
        PanelForm.Name = "PanelForm"
        PanelForm.Padding = New Padding(20)
        PanelForm.Size = New Size(320, 400)
        PanelForm.TabIndex = 0
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(0, 123, 255)
        lblTitle.Location = New Point(70, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(180, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "ATM LOGIN"
        '
        ' Label1
        '
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(60, 60, 60)
        Label1.Location = New Point(20, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 1
        Label1.Text = "Account Number"
        '
        ' txtAccNum
        '
        txtAccNum.BackColor = Color.White
        txtAccNum.BorderStyle = BorderStyle.FixedSingle
        txtAccNum.Font = New Font("Segoe UI", 11.0F)
        txtAccNum.Location = New Point(20, 95)
        txtAccNum.Name = "txtAccNum"
        txtAccNum.Size = New Size(270, 27)
        txtAccNum.TabIndex = 2
        '
        ' Label2
        '
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(60, 60, 60)
        Label2.Location = New Point(20, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 20)
        Label2.TabIndex = 3
        Label2.Text = "PIN"
        '
        ' txtPIN
        '
        txtPIN.BackColor = Color.White
        txtPIN.BorderStyle = BorderStyle.FixedSingle
        txtPIN.Font = New Font("Segoe UI", 11.0F)
        txtPIN.Location = New Point(20, 175)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(270, 27)
        txtPIN.TabIndex = 4
        '
        ' btnLogin
        '
        btnLogin.BackColor = Color.FromArgb(0, 123, 255)
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(20, 240)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(270, 45)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        '
        ' PanelKeypad
        '
        PanelKeypad.BackColor = Color.FromArgb(245, 245, 245)
        PanelKeypad.BorderStyle = BorderStyle.FixedSingle
        PanelKeypad.Controls.Add(lbl1)
        PanelKeypad.Controls.Add(lbl2)
        PanelKeypad.Controls.Add(lbl3)
        PanelKeypad.Controls.Add(lbl4)
        PanelKeypad.Controls.Add(lbl5)
        PanelKeypad.Controls.Add(lbl6)
        PanelKeypad.Controls.Add(lbl7)
        PanelKeypad.Controls.Add(lbl8)
        PanelKeypad.Controls.Add(lbl9)
        PanelKeypad.Controls.Add(lbl0)
        PanelKeypad.Controls.Add(lblEnter)
        PanelKeypad.Controls.Add(lblCancel)
        PanelKeypad.Controls.Add(lblClear)
        PanelKeypad.Controls.Add(btnDel)
        PanelKeypad.Location = New Point(390, 40)
        PanelKeypad.Name = "PanelKeypad"
        PanelKeypad.Size = New Size(330, 400)
        PanelKeypad.TabIndex = 1
        '
        ' Keypad Buttons (Shared Styling)
        '
        Dim keypadFont As New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Dim keypadBack As Color = Color.FromArgb(70, 70, 70)
        Dim keypadFore As Color = Color.White

        lbl1.BackColor = keypadBack : lbl1.Font = keypadFont : lbl1.ForeColor = keypadFore : lbl1.Location = New Point(20, 20) : lbl1.Size = New Size(70, 60) : lbl1.Text = "1" : lbl1.TextAlign = ContentAlignment.MiddleCenter
        lbl2.BackColor = keypadBack : lbl2.Font = keypadFont : lbl2.ForeColor = keypadFore : lbl2.Location = New Point(120, 20) : lbl2.Size = New Size(70, 60) : lbl2.Text = "2" : lbl2.TextAlign = ContentAlignment.MiddleCenter
        lbl3.BackColor = keypadBack : lbl3.Font = keypadFont : lbl3.ForeColor = keypadFore : lbl3.Location = New Point(220, 20) : lbl3.Size = New Size(70, 60) : lbl3.Text = "3" : lbl3.TextAlign = ContentAlignment.MiddleCenter

        lbl4.BackColor = keypadBack : lbl4.Font = keypadFont : lbl4.ForeColor = keypadFore : lbl4.Location = New Point(20, 100) : lbl4.Size = New Size(70, 60) : lbl4.Text = "4" : lbl4.TextAlign = ContentAlignment.MiddleCenter
        lbl5.BackColor = keypadBack : lbl5.Font = keypadFont : lbl5.ForeColor = keypadFore : lbl5.Location = New Point(120, 100) : lbl5.Size = New Size(70, 60) : lbl5.Text = "5" : lbl5.TextAlign = ContentAlignment.MiddleCenter
        lbl6.BackColor = keypadBack : lbl6.Font = keypadFont : lbl6.ForeColor = keypadFore : lbl6.Location = New Point(220, 100) : lbl6.Size = New Size(70, 60) : lbl6.Text = "6" : lbl6.TextAlign = ContentAlignment.MiddleCenter

        lbl7.BackColor = keypadBack : lbl7.Font = keypadFont : lbl7.ForeColor = keypadFore : lbl7.Location = New Point(20, 180) : lbl7.Size = New Size(70, 60) : lbl7.Text = "7" : lbl7.TextAlign = ContentAlignment.MiddleCenter
        lbl8.BackColor = keypadBack : lbl8.Font = keypadFont : lbl8.ForeColor = keypadFore : lbl8.Location = New Point(120, 180) : lbl8.Size = New Size(70, 60) : lbl8.Text = "8" : lbl8.TextAlign = ContentAlignment.MiddleCenter
        lbl9.BackColor = keypadBack : lbl9.Font = keypadFont : lbl9.ForeColor = keypadFore : lbl9.Location = New Point(220, 180) : lbl9.Size = New Size(70, 60) : lbl9.Text = "9" : lbl9.TextAlign = ContentAlignment.MiddleCenter

        lbl0.BackColor = keypadBack : lbl0.Font = keypadFont : lbl0.ForeColor = keypadFore : lbl0.Location = New Point(120, 260) : lbl0.Size = New Size(70, 60) : lbl0.Text = "0" : lbl0.TextAlign = ContentAlignment.MiddleCenter

        lblEnter.BackColor = Color.FromArgb(40, 167, 69) : lblEnter.Font = keypadFont : lblEnter.ForeColor = Color.White : lblEnter.Location = New Point(220, 260) : lblEnter.Size = New Size(70, 60) : lblEnter.Text = "Enter" : lblEnter.TextAlign = ContentAlignment.MiddleCenter
        lblCancel.BackColor = Color.FromArgb(220, 53, 69) : lblCancel.Font = keypadFont : lblCancel.ForeColor = Color.White : lblCancel.Location = New Point(20, 260) : lblCancel.Size = New Size(70, 60) : lblCancel.Text = "Cancel" : lblCancel.TextAlign = ContentAlignment.MiddleCenter
        lblClear.BackColor = Color.FromArgb(255, 193, 7) : lblClear.Font = keypadFont : lblClear.ForeColor = Color.Black : lblClear.Location = New Point(20, 330) : lblClear.Size = New Size(70, 50) : lblClear.Text = "Clear" : lblClear.TextAlign = ContentAlignment.MiddleCenter
        btnDel.BackColor = Color.FromArgb(108, 117, 125) : btnDel.Font = keypadFont : btnDel.ForeColor = Color.White : btnDel.Location = New Point(220, 330) : btnDel.Size = New Size(70, 50) : btnDel.Text = "Del" : btnDel.TextAlign = ContentAlignment.MiddleCenter
        '
        ' frmLogin
        '
        BackColor = Color.FromArgb(230, 230, 230)
        ClientSize = New Size(760, 500)
        Controls.Add(PanelForm)
        Controls.Add(PanelKeypad)
        Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ATM Login"
        PanelForm.ResumeLayout(False)
        PanelForm.PerformLayout()
        PanelKeypad.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelForm As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents PanelKeypad As Panel
    Friend WithEvents lblEnter As Label
    Friend WithEvents lblCancel As Label
    Friend WithEvents lblClear As Label
    Friend WithEvents btnDel As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
End Class
