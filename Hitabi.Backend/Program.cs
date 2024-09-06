using System.Security.Cryptography;
using Hitabi.Backend.DBContext;
using Hitabi.Backend.Services;
using Hitabi.Backend.Services.Interfaces;
using Hitabi.Shared;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
//CORSの設定
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:7175", "https://hitabi.web.app")
                .WithMethods("GET", "POST", "OPTIONS", "DELETE")
                .WithHeaders("Content-Type", HttpHeader.ACCESS_TOKEN_HEADER)
                .AllowCredentials();
    });
});

builder.Services.AddControllers();

builder.Services.AddDbContext<HitabiDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB")));

//作成したサービスの登録

var app = builder.Build();

//CORS
app.UseCors();

//JWT
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
