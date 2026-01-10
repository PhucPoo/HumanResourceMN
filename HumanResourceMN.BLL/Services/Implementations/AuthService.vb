Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports HumanResourceMN.DAL
Imports Microsoft.Build.Utilities
Imports NLog
Imports System.Data.Entity
Imports Task = System.Threading.Tasks.Task

Public Class AuthService
    Implements IAuthService

    Private ReadOnly _uow As New UnitOfWork
    Private Shared logger As NLog.Logger = LogManager.GetCurrentClassLogger()

    Public Async Function LoginAsync(userName As String, password As String) As Task(Of LoginResponseDto) _
        Implements IAuthService.LoginAsync

        If String.IsNullOrWhiteSpace(userName) OrElse String.IsNullOrWhiteSpace(password) Then
            Throw New Exception(AuthMessages.UsernameOrPasswordEmpty)
        End If

        Dim user = Await _uow.Users.GetByUsernameAsync(userName)

        If user Is Nothing Then
            logger.Warn("Sai userName hoặc mật khẩu")
            Throw New Exception(AuthMessages.UserNameOrPasswordErorr)
        End If

        If user.IsDeleted Then
            logger.Warn($"Login thất bại: userName {userName} đã bị xóa.")
            Throw New Exception(AuthMessages.UserNameOrPasswordErorr)
        End If

        Dim hash = HashPassword(password)
        If user.PasswordHash <> hash Then
            logger.Warn("Sai userName hoặc mật khẩu")
            Throw New Exception(AuthMessages.UserNameOrPasswordErorr)
        End If

        ' Lấy tên role từ Users.Role (trường hợp bạn đã xoá bảng UserRoles)
        Dim roleName As String = Nothing
        Try
            roleName = Await _uow.Context.Users _
                .Include(Function(u) u.Role) _
                .Where(Function(u) u.Id = user.Id) _
                .Select(Function(u) u.Role.RoleName) _
                .FirstOrDefaultAsync()
        Catch ex As Exception
            logger.Error(ex, "Lỗi khi lấy role cho userId=" & user.Id)
            Throw
        End Try

        If String.IsNullOrEmpty(roleName) Then
            logger.Warn("Tài khoản chưa được phân quyền.")
            Throw New Exception(AuthMessages.AccountNotRole)
        End If

        logger.Info("Login thành công")

        Return New LoginResponseDto With {
            .UserId = user.Id,
            .UserName = user.Username,
            .RoleName = roleName
        }
    End Function

    Public Async Function VerifyAccountAsync(userName As String, code As String) As Task _
        Implements IAuthService.VerifyAccountAsync

        Dim user = Await _uow.Users.GetByUsernameAsync(userName.Trim().ToLower())

        If user Is Nothing Then
            logger.Warn("User không tồn tại")
            Throw New Exception(AuthMessages.AccountNotExist)
        End If

        logger.Info("Kích hoạt thành công")

        _uow.Users.Update(user)
        Await _uow.SaveAsync()
    End Function

    Private Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hashBytes = sha.ComputeHash(bytes)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Private Sub ValidatePassword(password As String)
        If String.IsNullOrWhiteSpace(password) Then
            Throw New Exception("Mật khẩu không được để trống")
        End If

        If password.Length < 6 Then
            Throw New Exception("Mật khẩu phải có ít nhất 6 ký tự")
        End If

        If Not Regex.IsMatch(password, "[A-Za-z]") Then
            Throw New Exception("Mật khẩu phải chứa ít nhất 1 chữ cái")
        End If

        If Not Regex.IsMatch(password, "\d") Then
            Throw New Exception("Mật khẩu phải chứa ít nhất 1 chữ số")
        End If

        If password.Contains(" ") Then
            Throw New Exception("Mật khẩu không được chứa khoảng trắng")
        End If

        If Not Regex.IsMatch(password, "[^a-zA-Z0-9]") Then
            Throw New Exception("Mật khẩu phải chứa ít nhất 1 ký tự đặc biệt")
        End If
    End Sub
End Class