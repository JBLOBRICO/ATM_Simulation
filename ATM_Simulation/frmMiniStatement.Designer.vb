<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMiniStatement
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeader = New Label()
        lstMiniStatement = New ListBox()
        Panel1 = New Panel()
        btnCancel = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI Semibold", 22.0F, FontStyle.Bold)
        lblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        lblHeader.Location = New Point(280, 20)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(229, 41)
        lblHeader.TabIndex = 0
        lblHeader.Text = "Mini Statement"
        ' 
        ' lstMiniStatement
        ' 
        lstMiniStatement.BackColor = Color.White
        lstMiniStatement.BorderStyle = BorderStyle.FixedSingle
        lstMiniStatement.Font = New Font("Consolas", 12.0F)
        lstMiniStatement.ForeColor = Color.Black
        lstMiniStatement.FormattingEnabled = True
        lstMiniStatement.ItemHeight = 19
        lstMiniStatement.Location = New Point(20, 20)
        lstMiniStatement.Name = "lstMiniStatement"
        lstMiniStatement.Size = New Size(580, 268)
        lstMiniStatement.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lstMiniStatement)
        Panel1.Controls.Add(btnCancel)
        Panel1.Location = New Point(80, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(620, 340)
        Panel1.TabIndex = 2
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(450, 300)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(150, 35)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Close"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmMiniStatement
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(800, 450)
        Controls.Add(lblHeader)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmMiniStatement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mini Statement"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lstMiniStatement As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
End Class
