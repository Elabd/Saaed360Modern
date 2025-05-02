using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Infrastructure.DependencyInjection;
using Saaed360Modern.Application.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // CORE FRAMEWORK SERVICES
        builder.Services.AddControllers();
        builder.Services.AddLogging();
        builder.Services.AddHttpContextAccessor();

        // CORS
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(p => p.AllowAnyOrigin()
                                       .AllowAnyMethod()
                                       .AllowAnyHeader());
        });

        // SWAGGER
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Saaed360 API",
                Version = "v1",
                Description = "Saaed360 API Documentation"
            });

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description =
                    "JWT Authorization header using the Bearer scheme. " +
                    "Just enter your token without the 'Bearer ' prefix",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme, Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });

        // INFRASTRUCTURE  (DbContext, WCF wrapper, repositories)
        builder.Services.AddInfrastructure(builder.Configuration, builder.Environment);

        // JWT AUTHENTICATION
        var jwt = builder.Configuration.GetSection("Jwt");
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(opts =>
            {
                opts.SaveToken = true;
                opts.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwt["Issuer"],
                    ValidAudience = jwt["Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                                                Encoding.UTF8.GetBytes(jwt["Key"]!)),
                    ClockSkew = TimeSpan.Zero
                };
                opts.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        Console.WriteLine($"Authentication failed: {context.Exception.Message}");
                        Console.WriteLine($"Token: {context.Request.Headers["Authorization"]}");
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        Console.WriteLine("Token validated successfully");
                        Console.WriteLine($"Token: {context.Request.Headers["Authorization"]}");
                        return Task.CompletedTask;
                    },
                    OnChallenge = context =>
                    {
                        Console.WriteLine("Challenge issued");
                        return Task.CompletedTask;
                    }
                };
            });


        // BUILD PIPELINE
        var app = builder.Build();
        app.Lifetime.ApplicationStarted.Register(async () =>
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<IAppDbContext>();

            // Warm up by forcing EF to build the model and cache connections
            await db.AspnetUsers.FirstOrDefaultAsync();
        });
        // Swagger UI
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Saaed360 API V1");
                c.RoutePrefix = string.Empty;
                c.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
                c.ConfigObject.AdditionalItems.Add("syntaxHighlight.theme", "monokai");
            });
        }
        else
        {
            // Production Swagger � adjusts server URL, serves under /Saaed360TSAPI
            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((doc, req) =>
                {
                    doc.Servers = new List<OpenApiServer>
            {
                new() { Url = $"https://{req.Host.Value}/Saaed360TSAPI" }
            };
                });
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/Saaed360TSAPI/swagger/v1/swagger.json", "Saaed360 API V1");
                c.RoutePrefix = "swagger";
                c.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
                c.ConfigObject.AdditionalItems.Add("syntaxHighlight.theme", "monokai");
            });
        }

        // Middleware order
        // Custom middleware to automatically add Bearer prefix if missing
        app.Use(async (context, next) =>
        {
            var authHeader = context.Request.Headers["Authorization"].ToString();
            if (!string.IsNullOrEmpty(authHeader) && !authHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
            {
                // If token doesn't start with Bearer, add it
                context.Request.Headers["Authorization"] = $"Bearer {authHeader}";
                Console.WriteLine($"Added Bearer prefix to token: {context.Request.Headers["Authorization"]}");
            }

            await next();
        });
        app.UseCors();
        app.UseAuthentication();
        app.UseAuthorization();

        // Optional: add your custom token-prefix or logging middleware here

        app.MapControllers();
        app.Run();
    }
}