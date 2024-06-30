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
                .WithHeaders("Content-Type", HttpHeader.ACCESS_TOKEN_HEADER)
                .AllowCredentials();
    });
});

builder.Services.AddControllers();

//作成したサービスの登録

var app = builder.Build();

//CORS
app.UseCors();

//JWT
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
