Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Init
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Employees",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .FullName = c.String(),
                        .Gender = c.String(),
                        .DateOfBirth = c.DateTime(nullable := False),
                        .Phone = c.String(),
                        .BasicSalary = c.Int(nullable := False),
                        .DepartmentId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False),
                        .UpdatedAt = c.DateTime(),
                        .IsDeleted = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Roles",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .RoleName = c.String(),
                        .CreatedAt = c.DateTime(nullable := False),
                        .UpdatedAt = c.DateTime(),
                        .IsDeleted = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Username = c.String(),
                        .PasswordHash = c.String(),
                        .EmployeeId = c.Int(nullable := False),
                        .RoleId = c.Int(nullable := False),
                        .CreatedAt = c.DateTime(nullable := False),
                        .UpdatedAt = c.DateTime(),
                        .IsDeleted = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Employees", Function(t) t.EmployeeId, cascadeDelete := True) _
                .ForeignKey("dbo.Roles", Function(t) t.RoleId) _
                .Index(Function(t) t.EmployeeId) _
                .Index(Function(t) t.RoleId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles")
            DropForeignKey("dbo.Users", "EmployeeId", "dbo.Employees")
            DropIndex("dbo.Users", New String() { "RoleId" })
            DropIndex("dbo.Users", New String() { "EmployeeId" })
            DropTable("dbo.Users")
            DropTable("dbo.Roles")
            DropTable("dbo.Employees")
        End Sub
    End Class
End Namespace
