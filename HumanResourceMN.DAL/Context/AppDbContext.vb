Imports System.Data.Entity
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Text
Imports HumanResourceMN.Domain
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AppDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HumanResource")
    End Sub

    Public Property Users As DbSet(Of Users)
    Public Property Employees As DbSet(Of Employees)
    Public Property Roles As DbSet(Of Roles)

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)

        modelBuilder.Entity(Of Users)() _
        .HasRequired(Function(u) u.Role) _
        .WithMany(Function(r) r.Users) _
        .HasForeignKey(Function(u) u.RoleId) _
        .WillCascadeOnDelete(False)

        MyBase.OnModelCreating(modelBuilder)
    End Sub

End Class

