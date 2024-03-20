using System.Security.Claims;

namespace Hitabi.Backend.Services.Interfaces;

public interface IJWTAuthenticationService
{
    bool Authentication(string email);

    string GenerateAccessToken(Guid userGuid, string email);

    string GetEmailFromClaims(IEnumerable<Claim> claims);
}
