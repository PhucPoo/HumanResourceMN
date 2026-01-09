Public Class UnitOfWork
    Implements IUnitOfWork

    Private ReadOnly _context As AppDbContext

    Public Sub New()
        _context = New AppDbContext()
    End Sub

    Public ReadOnly Property Context As AppDbContext _
        Implements IUnitOfWork.Context
        Get
            Return _context
        End Get
    End Property
    Private _users As IUserRepository
    Public ReadOnly Property Users As IUserRepository _
        Implements IUnitOfWork.Users
        Get
            If _users Is Nothing Then
                _users = New UserRepository(_context)
            End If
            Return _users
        End Get
    End Property
    Public Async Function SaveAsync() As Task Implements IUnitOfWork.SaveAsync
        Await _context.SaveChangesAsync()
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub

End Class

