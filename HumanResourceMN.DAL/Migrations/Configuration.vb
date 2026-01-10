Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports HumanResourceMN.Domain

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of AppDbContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As AppDbContext)
            Dim adminRole = context.Roles.FirstOrDefault(Function(r) r.RoleName = "Administrator")
            If adminRole Is Nothing Then
                adminRole = New Roles With {
                    .RoleName = "Administrator",
                    .CreatedAt = DateTime.Now,
                    .IsDeleted = False
                }
                context.Roles.Add(adminRole)
                context.SaveChanges()
            End If

            Dim userRole = context.Roles.FirstOrDefault(Function(r) r.RoleName = "User")
            If userRole Is Nothing Then
                userRole = New Roles With {
                    .RoleName = "User",
                    .CreatedAt = DateTime.Now,
                    .IsDeleted = False
                }
                context.Roles.Add(userRole)
                context.SaveChanges()
            End If

            Dim employee = context.Employees.FirstOrDefault(Function(e) e.FullName = "Nguyen Van A")
            If employee Is Nothing Then
                employee = New Employees With {
                    .FullName = "Nguyen Van A",
                    .Gender = "Male",
                    .DateOfBirth = New DateTime(1998, 1, 1),
                    .Phone = "0123456789",
                    .BasicSalary = 10000000,
                    .DepartmentId = 1,
                    .CreatedAt = DateTime.Now,
                    .IsDeleted = False
                }
                context.Employees.Add(employee)
                context.SaveChanges()
            End If

            If Not context.Users.Any(Function(u) u.Username = "admin") Then
                Dim adminUser As New Users With {
                    .Username = "admin",
                    .PasswordHash = HashPassword("Admin@123"),
                    .EmployeeId = employee.Id, ' bắt buộc có
                    .RoleId = adminRole.Id,
                    .CreatedAt = DateTime.Now,
                    .IsDeleted = False
                }
                context.Users.Add(adminUser)
                context.SaveChanges()
            End If

            If Not context.Users.Any(Function(u) u.Username = "user") Then
                Dim normalUser As New Users With {
                    .Username = "user",
                    .PasswordHash = HashPassword("User@123"),
                    .EmployeeId = employee.Id,
                    .RoleId = userRole.Id,
                    .CreatedAt = DateTime.Now,
                    .IsDeleted = False
                }
                context.Users.Add(normalUser)
                context.SaveChanges()
            End If
        End Sub
        Private Function HashPassword(password As String) As String
            Using sha As SHA256 = SHA256.Create()
                Dim bytes = Encoding.UTF8.GetBytes(password)
                Dim hashBytes = sha.ComputeHash(bytes)
                Return Convert.ToBase64String(hashBytes)
            End Using
        End Function

    End Class

End Namespace
