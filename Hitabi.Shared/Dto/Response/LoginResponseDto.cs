namespace Hitabi.Shared.Dto.Response;

public sealed class LoginResponseDto
{
    public LoginResponseDto(string token)
    {
        Token = token;
    }
    public string Token { get; }
}
