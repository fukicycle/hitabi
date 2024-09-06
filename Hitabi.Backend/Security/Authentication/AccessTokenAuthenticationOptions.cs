using Hitabi.Shared;
using Microsoft.AspNetCore.Authentication;

namespace Hitabi.Backend;

public sealed class AccessTokenAuthenticationOptions : AuthenticationSchemeOptions
{
    public const string DefaultScheme = "AcessTokenScheme";
    public string TokenHeaderName { get; } = HttpHeader.ACCESS_TOKEN_HEADER;
}
