
Imports HumanResourceMN.Domain
Imports Microsoft.VisualBasic.ApplicationServices

Public Interface IUserRepository
    Inherits IGenericRepository(Of Users)

    Function GetByUsernameAsync(userName As String) As Task(Of Users)
    Function GetAllIncludedDeleted() As IQueryable(Of Users)
    Function GetRoleNameByUserIdAsync(userId As Integer) As Task(Of String)
End Interface