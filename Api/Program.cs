using Application.Services.Auth;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using Application.Services.Lookup;
using Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add logging
builder.Services.AddLogging();

// Add CORS configuration
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader()
              .SetIsOriginAllowed(origin => true);
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
        Description = "JWT Authorization header using the Bearer scheme. Just enter your token without the 'Bearer ' prefix",
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
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// Configure DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), o => o.UseCompatibilityLevel(110)));

// Register services
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<ILookupService, LookupService>();
builder.Services.AddScoped<IObjectionService, ObjectionService>();
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

// Configure JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true; // Add this to save the token
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ClockSkew = TimeSpan.Zero
        };

        options.Events = new JwtBearerEvents
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
                Console.WriteLine($"Challenge: {context.Error}");
                Console.WriteLine($"Token: {context.Request.Headers["Authorization"]}");
                return Task.CompletedTask;
            },
            OnMessageReceived = context =>
            {
                // Add this for better debugging - log the exact token being received
                var authHeader = context.Request.Headers["Authorization"].ToString();
                Console.WriteLine($"OnMessageReceived - Authorization header: {authHeader}");
                return Task.CompletedTask;
            }
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    app.UseSwagger(c =>
    {
        c.PreSerializeFilters.Add((swagger, httpReq) =>
        {
            var serverUrl = $"https://{httpReq.Host.Value}/Saaed360TSAPI";
            swagger.Servers = new List<OpenApiServer>
            {
                new OpenApiServer { Url = serverUrl }
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

    // Serve index.html for the root path
    app.MapGet("/", () => Results.File("wwwroot/index.html", "text/html"));

    // Add a route to serve the Swagger JSON from root
    app.MapGet("/Saaed360TSAPI/swagger/v1/swagger.json", async (HttpContext context) =>
    {
        var jsonPath = Path.Combine(AppContext.BaseDirectory, "swagger", "v1", "swagger.json");
        if (File.Exists(jsonPath))
        {
            var json = await File.ReadAllTextAsync(jsonPath);
            context.Response.ContentType = "application/json";
            context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            await context.Response.WriteAsync(json);
        }
        else
        {
            context.Response.StatusCode = 404;
        }
    });
}

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

// Detailed request logging middleware
app.Use(async (context, next) =>
{
    // Don't log OPTIONS requests (CORS preflight)
    if (context.Request.Method != "OPTIONS")
    {
        Console.WriteLine("\n=== Request Details ===");
        Console.WriteLine($"Method: {context.Request.Method}");
        Console.WriteLine($"Path: {context.Request.Path}");
        Console.WriteLine($"QueryString: {context.Request.QueryString}");
        Console.WriteLine($"Headers:");
        foreach (var header in context.Request.Headers)
        {
            Console.WriteLine($"  {header.Key}: {header.Value}");
        }
        Console.WriteLine("====================\n");
    }
    await next();
});

//app.UseHttpsRedirection();

// Use CORS before other middleware
app.UseCors();

// Authentication must come before Authorization
app.UseAuthentication();
app.UseAuthorization();

// Add response logging middleware
app.Use(async (context, next) =>
{
    await next();

    // Don't log OPTIONS responses (CORS preflight)
    if (context.Request.Method != "OPTIONS")
    {
        Console.WriteLine("\n=== Response Details ===");
        Console.WriteLine($"Status Code: {context.Response.StatusCode}");
        Console.WriteLine($"Headers:");
        foreach (var header in context.Response.Headers)
        {
            Console.WriteLine($"  {header.Key}: {header.Value}");
        }
        Console.WriteLine("====================\n");
    }
});

app.MapControllers();

app.Run();