using GISA.Model;
using GISA.Repository;
using GISA.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

TimeZoneInfo brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
builder.Services.AddSingleton(brazilTimeZone);


// Add services to the container.
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("pt-BR", "pt-BR");
    options.SupportedCultures = new List<CultureInfo> { new CultureInfo("pt-BR") };
    options.SupportedUICultures = new List<CultureInfo> { new CultureInfo("pt-BR") };
    options.FallBackToParentCultures = true;
    options.FallBackToParentUICultures = true;
});

builder.Services.AddScoped<IWhatsappRepository, WhatsappRepository>();

builder.Services.AddDbContext<EsusContext>(options =>
   options.LogTo(message => Debug.WriteLine(message)).
   EnableSensitiveDataLogging().
   UseNpgsql(builder.Configuration["ConnectionStrings:GisaPostgre"]));



builder.Services.AddControllers();
builder.Services.AddMvc();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Davy: Projetos Back-end", Version = "v2.2.7" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. Ex: Bearer 12345...",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement{{new OpenApiSecurityScheme {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
});

var app = builder.Build();

app.UseRequestLocalization();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseCors(x => x.AllowAnyHeader().
AllowAnyMethod().
SetIsOriginAllowed(origin => true).
AllowCredentials().
SetPreflightMaxAge(TimeSpan.FromSeconds(600)));

app.UseSwagger();
app.UseSwaggerUI();
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
