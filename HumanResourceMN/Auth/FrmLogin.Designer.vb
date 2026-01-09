<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.lblError = New System.Windows.Forms.Label()
        Me.lnkForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(61, 262)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 18
        '
        'lnkForgotPassword
        '
        Me.lnkForgotPassword.AutoSize = True
        Me.lnkForgotPassword.Location = New System.Drawing.Point(207, 236)
        Me.lnkForgotPassword.Name = "lnkForgotPassword"
        Me.lnkForgotPassword.Size = New System.Drawing.Size(91, 13)
        Me.lnkForgotPassword.TabIndex = 17
        Me.lnkForgotPassword.TabStop = True
        Me.lnkForgotPassword.Text = "Forgot password?"
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Location = New System.Drawing.Point(61, 236)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(46, 13)
        Me.lnkRegister.TabIndex = 16
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Register"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(61, 192)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(240, 30)
        Me.btnLogin.TabIndex = 15
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(61, 149)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(241, 20)
        Me.txtPassword.TabIndex = 14
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(61, 106)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(241, 20)
        Me.txtUsername.TabIndex = 13
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(61, 132)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(61, 88)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(130, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(80, 30)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "LOGIN"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 316)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lnkForgotPassword)
        Me.Controls.Add(Me.lnkRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblError As Label
    Friend WithEvents lnkForgotPassword As LinkLabel
    Friend WithEvents lnkRegister As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTitle As Label
End Class
