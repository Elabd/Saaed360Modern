// Infrastructure dependency‑injection bootstrapper
// --------------------------------------------------
// Call this from Api/Program.cs:
//     builder.Services.AddInfrastructure(builder.Configuration);
// --------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Saaed360Modern.Application.Abstractions;
using Saaed360Modern.Infrastructure.ExternalServices;
using Infrastructure.Persistence.Contexts;
using Application.Abstractions;
using Application.Abstractions.AuthService;
using Infrastructure.Repositories;
using Infrastructure.Services.Auth;
using Infrastructure.Services.Lookup;
using Infrastructure.Services.Objection;
using Microsoft.Extensions.Options;
using Saaed360Modern.Application.Abstractions.AuthService; // Added for IPermissionService

namespace Infrastructure.DependencyInjection;

public static class ServiceRegistration
{

    /// <summary>
    /// dotnet ef dbcontext optimize --output-dir Infrastructure/Persistence/CompiledModels --namespace Infrastructure.Persistence.CompiledModels --context ApplicationDbContext --project Infrastructure --startup-project Api
    /// </summary>
    /// <param name="services"></param>
    /// <param name="cfg"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration cfg)
    {
        // --------------------  Caching (Required for PermissionService) --------------------
        // Use MemoryCache for single-server deployments.
        // For multi-server/cloud deployments, consider replacing with services.AddStackExchangeRedisCache(...)
        // and configuring Redis connection string.
        services.AddMemoryCache();

        // --------------------  Persistence  --------------------
        var connStr = cfg.GetConnectionString("DefaultConnection") ??
                      throw new InvalidOperationException("Connection string 'Default' not found.");

        // Using Compiled Models and DbContext Pooling (Recommended)
        services.AddDbContextPool<ApplicationDbContext>(options => {
            options.UseSqlServer(cfg.GetConnectionString("DefaultConnection"), o => o.UseCompatibilityLevel(110));
            options.UseModel(Infrastructure.Persistence.CompiledModels.ApplicationDbContextModel.Instance);
        });

        // Expose DbContext to upper layers via abstraction
        services.AddScoped<IAppDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());

        // add other repository registrations here

        // --------------------  External Services (WCF)  --------------------
        services.AddSingleton<IReportWcfService, ReportWcfService>();

        // --------------------  Mapping / utilities  --------------------
        // Example: AutoMapper profiles that live in Infrastructure
        // services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);

        // --------------------  APPLICATION-LEVEL SERVICES  --------------------
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ILookupService, LookupService>();
        services.AddScoped<IObjectionService, ObjectionService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IJwtFactory, JwtFactory>();
        services.AddScoped<IRefreshTokenStore, EfRefreshTokenStore>();

        // Register the new Permission Service (for hybrid auth approach)
        services.AddScoped<IPermissionService, PermissionService>();

        return services;
    }
}

