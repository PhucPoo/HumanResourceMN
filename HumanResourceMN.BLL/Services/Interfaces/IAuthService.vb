Public Interface IAuthService
    Function LoginAsync(email As String, password As String) As Task(Of LoginResponseDto)

    Function VerifyAccountAsync(email As String, code As String) As Task

End Interface