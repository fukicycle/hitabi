using System.Security.Cryptography;
using Hitabi.Backend.Services;
using Hitabi.Backend.Services.Interfaces;
using Hitabi.Shared;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
//CORSの設定
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:7175", "https://hitabi.web.app")
                .WithMethods("GET", "POST", "OPTIONS", "DELETE")
                .WithHeaders("Authorizaion", "Content-Type")
                .AllowCredentials();
    });
});

//JWTの設定
//JWTキーの作成
RandomNumberGenerator.Fill(ApplicationSettings.JWT_KEY);

//JWT認証の設定
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "sato-home.mydns.jp",
        ValidAudience = "fukicycle.github.io",
        IssuerSigningKey = new SymmetricSecurityKey(ApplicationSettings.JWT_KEY),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddControllers();

//作成したサービスの登録
builder.Services.AddScoped<IJWTAuthenticationService, JWTAuthenticationService>();

var app = builder.Build();

//CORS
app.UseCors();

//JWT
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
