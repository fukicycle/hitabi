namespace Hitabi.Shared.Dto.Request;

public sealed class LoginRequestDto
{
    public LoginRequestDto(string email, Guid userGuid)
    {
        Email = email;
        UserGuid = userGuid;
    }
    public string Email { get; }
    public Guid UserGuid { get; }
}
