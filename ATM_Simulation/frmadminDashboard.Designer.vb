<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' Panels
    Private WithEvents PanelSidebar As Panel
    Private WithEvents PanelHeader As Panel
    Private WithEvents PanelMain As Panel

    ' Sidebar Buttons
    Private WithEvents btnUsers As Button
    Private WithEvents btnTransactions As Button
    Private WithEvents btnReports As Button
    Private WithEvents btnSettings As Button

    ' Header Label
    Private WithEvents lblHeader As Label
    Private WithEvents btnLogout As Button

    ' Main Panel Cards
    Private WithEvents pnlTotalUsers As Panel
    Private WithEvents pnlTotalTransactions As Panel
    Private WithEvents pnlSystemStatus As Panel
    Private WithEvents lblTotalUsers As Label
    Private WithEvents lblTotalTransactions As Label
    Private WithEvents lblSystemStatus As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelSidebar = New Panel()
        btnUsers = New Button()
        btnTransactions = New Button()
        btnReports = New Button()
        btnSettings = New Button()
        PanelHeader = New Panel()
        lblHeader = New Label()
        btnLogout = New Button()
        PanelMain = New Panel()
        pnlTotalUsers = New Panel()
        lblTotalUsers = New Label()
        pnlTotalTransactions = New Panel()
        lblTotalTransactions = New Label()
        pnlSystemStatus = New Panel()
        lblSystemStatus = New Label()

        ' -------------------------------
        ' PanelSidebar
        ' -------------------------------
        PanelSidebar.BackColor = Color.FromArgb(34, 49, 63)
        PanelSidebar.Controls.Add(btnUsers)
        PanelSidebar.Controls.Add(btnTransactions)
        PanelSidebar.Controls.Add(btnReports)
        PanelSidebar.Controls.Add(btnSettings)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(220, 650)

        ' Sidebar Buttons
        btnSettings.Dock = DockStyle.Top
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnSettings.ForeColor = Color.White
        btnSettings.Padding = New Padding(25, 0, 0, 0)
        btnSettings.Size = New Size(220, 60)
        btnSettings.Text = "Settings"
        btnSettings.TextAlign = ContentAlignment.MiddleLeft

        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnReports.ForeColor = Color.White
        btnReports.Padding = New Padding(25, 0, 0, 0)
        btnReports.Size = New Size(220, 60)
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft

        btnTransactions.Dock = DockStyle.Top
        btnTransactions.FlatAppearance.BorderSize = 0
        btnTransactions.FlatStyle = FlatStyle.Flat
        btnTransactions.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnTransactions.ForeColor = Color.White
        btnTransactions.Padding = New Padding(25, 0, 0, 0)
        btnTransactions.Size = New Size(220, 60)
        btnTransactions.Text = "Transaction Records"
        btnTransactions.TextAlign = ContentAlignment.MiddleLeft

        btnUsers.Dock = DockStyle.Top
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnUsers.ForeColor = Color.White
        btnUsers.Padding = New Padding(25, 0, 0, 0)
        btnUsers.Size = New Size(220, 60)
        btnUsers.Text = "User Management"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft

        ' -------------------------------
        ' PanelHeader
        ' -------------------------------
        PanelHeader.BackColor = Color.FromArgb(41, 128, 185)
        PanelHeader.Controls.Add(lblHeader)
        PanelHeader.Controls.Add(btnLogout)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(220, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(880, 70)

        ' Header Label
        lblHeader.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(20, 20)
        lblHeader.Size = New Size(300, 40)
        lblHeader.Text = "Admin Dashboard"

        ' Logout Button
        btnLogout.Text = "Logout"
        btnLogout.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.BackColor = Color.FromArgb(231, 76, 60)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.Size = New Size(90, 35)
        btnLogout.Location = New Point(PanelHeader.Width - 110, 20)
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        AddHandler btnLogout.Click, AddressOf btnLogout_Click

        ' -------------------------------
        ' PanelMain
        ' -------------------------------
        PanelMain.BackColor = Color.FromArgb(245, 247, 250)
        PanelMain.Controls.Add(pnlTotalUsers)
        PanelMain.Controls.Add(pnlTotalTransactions)
        PanelMain.Controls.Add(pnlSystemStatus)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(220, 70)
        PanelMain.Padding = New Padding(30)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(880, 580)

        ' -------------------------------
        ' pnlTotalUsers
        ' -------------------------------
        pnlTotalUsers.BackColor = Color.White
        pnlTotalUsers.BorderStyle = BorderStyle.FixedSingle
        pnlTotalUsers.Controls.Add(lblTotalUsers)
        pnlTotalUsers.Location = New Point(30, 30)
        pnlTotalUsers.Size = New Size(250, 130)

        lblTotalUsers.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTotalUsers.ForeColor = Color.FromArgb(52, 152, 219)
        lblTotalUsers.Location = New Point(20, 20)
        lblTotalUsers.Size = New Size(200, 23)
        lblTotalUsers.Text = "Total Users: 0"

        ' -------------------------------
        ' pnlTotalTransactions
        ' -------------------------------
        pnlTotalTransactions.BackColor = Color.White
        pnlTotalTransactions.BorderStyle = BorderStyle.FixedSingle
        pnlTotalTransactions.Controls.Add(lblTotalTransactions)
        pnlTotalTransactions.Location = New Point(310, 30)
        pnlTotalTransactions.Size = New Size(250, 130)

        lblTotalTransactions.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTotalTransactions.ForeColor = Color.FromArgb(46, 204, 113)
        lblTotalTransactions.Location = New Point(20, 20)
        lblTotalTransactions.Size = New Size(200, 23)
        lblTotalTransactions.Text = "Total Transactions: 0"

        ' -------------------------------
        ' pnlSystemStatus
        ' -------------------------------
        pnlSystemStatus.BackColor = Color.White
        pnlSystemStatus.BorderStyle = BorderStyle.FixedSingle
        pnlSystemStatus.Controls.Add(lblSystemStatus)
        pnlSystemStatus.Location = New Point(590, 30)
        pnlSystemStatus.Size = New Size(250, 130)

        lblSystemStatus.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblSystemStatus.ForeColor = Color.FromArgb(231, 76, 60)
        lblSystemStatus.Location = New Point(20, 20)
        lblSystemStatus.Size = New Size(200, 23)
        lblSystemStatus.Text = "System Status: OK"

        ' -------------------------------
        ' frmAdminDashboard
        ' -------------------------------
        ClientSize = New Size(1100, 650)
        Controls.Add(PanelMain)
        Controls.Add(PanelHeader)
        Controls.Add(PanelSidebar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmAdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"

        PanelSidebar.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        PanelMain.ResumeLayout(False)
        pnlTotalUsers.ResumeLayout(False)
        pnlTotalTransactions.ResumeLayout(False)
        pnlSystemStatus.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
End Class