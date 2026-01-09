Imports MyLibrary.Domain

Public Interface IUnitOfWork
    Inherits IDisposable

    ReadOnly Property Context As AppDbContext

    ReadOnly Property Users As IUserRepository

    Function SaveAsync() As Task
End Interface
