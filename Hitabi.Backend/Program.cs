using System.Security.Cryptography;
using Hitabi.Shared;

var builder = WebApplication.CreateBuilder(args);
//CORSの設定
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:7175", "https://fukicycle.github.io")
                .WithMethods("GET", "POST", "OPTIONS", "DELETE")
                .WithHeaders("Authorizaion", "Content-Type")
                .AllowCredentials();
    });
});

//JWTの設定
//JWTキーの作成
RandomNumberGenerator.Fill(ApplicationSettings.JWT_KEY);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
