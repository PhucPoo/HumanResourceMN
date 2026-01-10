Imports System.Data.Entity
Imports HumanResourceMN.Domain

Public Class RoleRepository
    Inherits GenericRepository(Of Roles)
    Implements IRoleRepository

    Public Sub New(context As AppDbContext)
        MyBase.New(context)
    End Sub

    Public Async Function GetByNameAsync(roleName As String) As Task(Of Roles) _
                 Implements IRoleRepository.GetByNameAsync

        If String.IsNullOrWhiteSpace(roleName) Then Return Nothing

        Return Await _dbSet.FirstOrDefaultAsync(Function(r) _
            Not r.IsDeleted AndAlso r.RoleName = roleName)
    End Function
End Class
