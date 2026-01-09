Imports System.Data.Entity
Imports HumanResourceMN.Domain

Public Class AppDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HumanResourceMN")
    End Sub

    Public Property Users As DbSet(Of Users)
    Public Property Employees As DbSet(Of Employees)
    Public Property Roles As DbSet(Of Roles)

End Class
