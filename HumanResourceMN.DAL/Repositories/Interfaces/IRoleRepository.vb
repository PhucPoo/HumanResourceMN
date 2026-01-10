Imports HumanResourceMN.Domain

Public Interface IRoleRepository
    Inherits IGenericRepository(Of Roles)

    Function GetByNameAsync(roleName As String) As Task(Of Roles)
End Interface
