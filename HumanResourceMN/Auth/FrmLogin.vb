Imports HumanResourceMN.BLL
Imports HumanResourceMN.DAL
Imports MyLibrary.DAL
Public Class FrmLogin
    Private ReadOnly _authService As IAuthService
    Public Sub New()
        InitializeComponent()
        Dim uow As New UnitOfWork()
        _authService = New AuthService()
    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            lblError.Text = ""

            Dim userName = txtUsername.Text.Trim()
            Dim password = txtPassword.Text

            Dim result = Await _authService.LoginAsync(userName, password)

            SessionManager.CurrentUser = result

            Dim f As New FrmMainMenu()
            f.Show()


            Me.Hide()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class
