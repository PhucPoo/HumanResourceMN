Imports System.Data.Entity
Imports System.Linq.Expressions
Imports HumanResourceMN.Domain
Imports Microsoft.VisualBasic.ApplicationServices

Public Class UserRepository
    Inherits GenericRepository(Of Users)
    Implements IUserRepository

    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub

    Public Async Function GetByUsernameAsync(userName As String) As Task(Of Users) _
        Implements IUserRepository.GetByUsernameAsync

        Return Await _dbSet.
            FirstOrDefaultAsync(Function(u) u.Username = userName AndAlso u.IsDeleted = False)
    End Function

    Public Function GetAllIncludedDeleted() As IQueryable(Of Users) Implements IUserRepository.GetAllIncludedDeleted
        Return _context.Users
    End Function

    Public Async Function GetRoleNameByUserIdAsync(userId As Integer) As Task(Of String) _
        Implements IUserRepository.GetRoleNameByUserIdAsync

        Debug.WriteLine($"[GetRoleNameByUserIdAsync] userId = {userId}")

        Dim roleName As String = Await _context.Users _
            .Include(Function(u) u.Role) _
            .Where(Function(u) u.Id = userId) _
            .Select(Function(u) u.Role.RoleName) _
            .FirstOrDefaultAsync()

        If String.IsNullOrEmpty(roleName) Then
            Debug.WriteLine("[GetRoleNameByUserIdAsync] ❌ RoleName = NULL")
        Else
            Debug.WriteLine($"[GetRoleNameByUserIdAsync] ✅ RoleName = {roleName}")
        End If

        Return roleName
    End Function
End Class
