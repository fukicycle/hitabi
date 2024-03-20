﻿using Hitabi.Backend.Services.Interfaces;
using Hitabi.Shared.Dto.Request;
using Hitabi.Shared.Dto.Response;
using Microsoft.AspNetCore.Mvc;

namespace Hitabi.Backend.Controllers;

[Route("/api/v1/authentication")]
public sealed class JWTAuthenticationController : ControllerBase
{
    private readonly IJWTAuthenticationService _jwtAuthenticationService;
    public JWTAuthenticationController(IJWTAuthenticationService jwtAuthenticationService)
    {
        _jwtAuthenticationService = jwtAuthenticationService;
    }
    [HttpPost]
    public IActionResult Login([FromBody] LoginRequestDto loginRequestDto)
    {
        if (_jwtAuthenticationService.Authentication(loginRequestDto.UserGuid, loginRequestDto.Email))
        {
            string token = _jwtAuthenticationService.GenerateAccessToken(loginRequestDto.UserGuid, loginRequestDto.Email);
            return Ok(new LoginResponseDto(token));
        }
        return Forbid();
    }
}
