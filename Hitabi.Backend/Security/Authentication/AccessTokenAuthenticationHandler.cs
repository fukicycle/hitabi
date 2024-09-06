using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace Hitabi.Backend;

public sealed class AccessTokenAuthenticationHandler : AuthenticationHandler<AccessTokenAuthenticationOptions>
{
    private readonly ILogger<AccessTokenAuthenticationHandler> _logger;

    public AccessTokenAuthenticationHandler(
        IOptionsMonitor<AccessTokenAuthenticationOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder) : base(options, logger, encoder)
    {
        _logger = logger.CreateLogger<AccessTokenAuthenticationHandler>();
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey(Options.TokenHeaderName))
        {
            return Task.FromResult(AuthenticateResult.Fail($"Missing header: {Options.TokenHeaderName}"));
        }

        string? accessToken = Request.Headers[Options.TokenHeaderName];

        //TODO: get access token from database
        return Task.FromResult(AuthenticateResult.Fail(""));
    }
}
