Public Class Users
    Inherits BaseEntity

    Public Property Username As String
    Public Property PasswordHash As String
    Public Property EmployeeId As Integer

    ' FK to Roles (sử dụng khi không có bảng UserRoles)
    Public Property RoleId As Integer
    Public Overridable Property Role As Roles

    Public Overridable Property Employee As Employees
End Class
