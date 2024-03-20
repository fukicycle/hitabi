using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Hitabi.Backend.Services.Interfaces;
using Hitabi.Shared;
using Microsoft.IdentityModel.Tokens;

namespace Hitabi.Backend.Services;

public sealed class JWTAuthenticationService : IJWTAuthenticationService
{
    private readonly ILogger<JWTAuthenticationService> _logger;
    public JWTAuthenticationService(ILogger<JWTAuthenticationService> logger)
    {
        _logger = logger;
    }
    public bool Authentication(Guid userGuid, string email)
    {
        //TODO(未実装)
        return true;
    }

    public string GenerateAccessToken(Guid userGuid, string email)
    {
        SymmetricSecurityKey key = new SymmetricSecurityKey(ApplicationSettings.JWT_KEY);
        SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        IEnumerable<Claim> claims = new List<Claim> { new Claim("EMAIL", email), new Claim("USER_GUID", userGuid.ToString()) };
        JwtSecurityToken token = new JwtSecurityToken(
            issuer: "sato-home.mydns.jp",
            audience: "fukicycle.github.io",
            notBefore: DateTime.Now,
            expires: DateTime.Now.AddMonths(2),
            signingCredentials: creds,
            claims: claims);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public string GetEmailFromClaims(IEnumerable<Claim> claims)
    {
        //TODO(未実装)
        return "example@sample.com";
    }
}
