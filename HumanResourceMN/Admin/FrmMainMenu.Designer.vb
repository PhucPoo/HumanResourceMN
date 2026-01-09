<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainMenu
    Inherits Form

    'Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnDepartment = New System.Windows.Forms.Button()
        Me.BtnSalary = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.TxtWelcome = New System.Windows.Forms.TextBox()
        Me.PanelSidebar.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSidebar
        '
        Me.PanelSidebar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelSidebar.Controls.Add(Me.PictureBox4)
        Me.PanelSidebar.Controls.Add(Me.PictureBox3)
        Me.PanelSidebar.Controls.Add(Me.PictureBox2)
        Me.PanelSidebar.Controls.Add(Me.PictureBox1)
        Me.PanelSidebar.Controls.Add(Me.BtnDepartment)
        Me.PanelSidebar.Controls.Add(Me.BtnSalary)
        Me.PanelSidebar.Controls.Add(Me.BtnUser)
        Me.PanelSidebar.Controls.Add(Me.BtnHome)
        Me.PanelSidebar.Controls.Add(Me.LblTitle)
        Me.PanelSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSidebar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New System.Drawing.Size(180, 450)
        Me.PanelSidebar.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.HumanResourceMN.My.Resources.Resources.department_icon
        Me.PictureBox4.Location = New System.Drawing.Point(12, 205)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.HumanResourceMN.My.Resources.Resources.salary_icon
        Me.PictureBox3.Location = New System.Drawing.Point(13, 157)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HumanResourceMN.My.Resources.Resources.user_icon
        Me.PictureBox2.Location = New System.Drawing.Point(13, 115)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HumanResourceMN.My.Resources.Resources.home_icon
        Me.PictureBox1.Location = New System.Drawing.Point(13, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BtnDepartment
        '
        Me.BtnDepartment.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDepartment.Location = New System.Drawing.Point(0, 195)
        Me.BtnDepartment.Name = "BtnDepartment"
        Me.BtnDepartment.Size = New System.Drawing.Size(180, 45)
        Me.BtnDepartment.TabIndex = 0
        Me.BtnDepartment.Text = "Quản lý phòng ban"
        '
        'BtnSalary
        '
        Me.BtnSalary.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalary.Location = New System.Drawing.Point(0, 150)
        Me.BtnSalary.Name = "BtnSalary"
        Me.BtnSalary.Size = New System.Drawing.Size(180, 45)
        Me.BtnSalary.TabIndex = 1
        Me.BtnSalary.Text = "Lương nhân viên"
        '
        'BtnUser
        '
        Me.BtnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnUser.Location = New System.Drawing.Point(0, 105)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(180, 45)
        Me.BtnUser.TabIndex = 2
        Me.BtnUser.Text = "Tài khoản NV"
        '
        'BtnHome
        '
        Me.BtnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHome.Location = New System.Drawing.Point(0, 60)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(180, 45)
        Me.BtnHome.TabIndex = 3
        Me.BtnHome.Text = "Home"
        '
        'LblTitle
        '
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitle.Location = New System.Drawing.Point(0, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(180, 60)
        Me.LblTitle.TabIndex = 4
        Me.LblTitle.Text = "Quản lý nhân viên"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.White
        Me.PanelTop.Controls.Add(Me.Button1)
        Me.PanelTop.Controls.Add(Me.BtnLogout)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.PanelTop.Location = New System.Drawing.Point(180, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(620, 45)
        Me.PanelTop.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.HumanResourceMN.My.Resources.Resources.logout_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(575, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Location = New System.Drawing.Point(529, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(40, 40)
        Me.BtnLogout.TabIndex = 0
        '
        'TxtWelcome
        '
        Me.TxtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtWelcome.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TxtWelcome.Location = New System.Drawing.Point(220, 120)
        Me.TxtWelcome.Name = "TxtWelcome"
        Me.TxtWelcome.Size = New System.Drawing.Size(450, 25)
        Me.TxtWelcome.TabIndex = 0
        Me.TxtWelcome.Text = "Chào mừng đến với quản lý nhân viên"
        '
        'FrmMainMenu
        '
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtWelcome)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelSidebar)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Main"
        Me.PanelSidebar.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ===== Controls =====
    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents PanelTop As FlowLayoutPanel
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnSalary As Button
    Friend WithEvents BtnDepartment As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtWelcome As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
