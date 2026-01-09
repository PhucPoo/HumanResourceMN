
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
            Include("UserRoles.Role").
            FirstOrDefaultAsync(Function(u) u.Username = userName AndAlso u.IsDeleted = False)
    End Function


    Public Function GetAllIncludedDeleted() As IQueryable(Of Users) Implements IUserRepository.GetAllIncludedDeleted
        Return _context.Users
    End Function

End Class
