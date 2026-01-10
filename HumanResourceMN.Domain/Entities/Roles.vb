Public Class Roles
    Inherits BaseEntity
    Public Property RoleName As String

    Public Overridable Property Users As ICollection(Of Users)
End Class
