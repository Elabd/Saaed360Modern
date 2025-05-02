// Infrastructure dependency‑injection bootstrapper
// --------------------------------------------------
// Call this from Api/Program.cs:
//     builder.Services.AddInfrastructure(builder.Configuration, builder.Environment);
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
using Saaed360Modern.Application.Abstractions.AuthService;
using Infrastructure.Services; // Added for IPermissionService
using RazorLight.Extensions; // Added for AddRazorLight
using Microsoft.AspNetCore.Hosting; // Added for IWebHostEnvironment

namespace Infrastructure.DependencyInjection;

public static class ServiceRegistration
{

    /// <summary>
    /// dotnet ef dbcontext optimize --output-dir Infrastructure/Persistence/CompiledModels --namespace Infrastructure.Persistence.CompiledModels --context ApplicationDbContext --project Infrastructure --startup-project Api
    /// </summary>
    /// <param name="services"></param>
    /// <param name="cfg"></param>
    /// <param name="env">The hosting environment, needed for resolving template paths.</param> /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration cfg,
        IWebHostEnvironment env) // Add IWebHostEnvironment parameter
    {
        // --------------------  Caching (Required for PermissionService) --------------------
        services.AddMemoryCache();

        // --------------------  Persistence  --------------------
        var connStr = cfg.GetConnectionString("DefaultConnection") ??
                      throw new InvalidOperationException("Connection string 'Default' not found.");

        services.AddDbContextPool<ApplicationDbContext>(options => {
            options.UseSqlServer(cfg.GetConnectionString("DefaultConnection"), o => o.UseCompatibilityLevel(110));
            options.UseModel(Infrastructure.Persistence.CompiledModels.ApplicationDbContextModel.Instance);
        });

        services.AddScoped<IAppDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());

        // --------------------  External Services (WCF)  --------------------
        services.AddSingleton<IReportWcfService, ReportWcfService>();

        // --------------------  Mapping / utilities  --------------------
        // services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);

        // --------------------  APPLICATION-LEVEL SERVICES  --------------------
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ILookupService, LookupService>();
        services.AddScoped<IObjectionService, ObjectionService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IJwtFactory, JwtFactory>();
        services.AddScoped<IRefreshTokenStore, EfRefreshTokenStore>();
        services.AddScoped<IRequestService, RequestService>();

        // Register RazorLight Engine with proper project setup
        var templateRoot = Path.Combine(env.ContentRootPath, "Templates");
        services.AddRazorLight()
            .UseFileSystemProject(templateRoot) // Configure template source
            .UseMemoryCachingProvider(); // Configure caching

        // Register our custom service that USES RazorLight engine
        services.AddScoped<IReportTemplateService, RazorReportTemplateService>();

        // Register the new Permission Service (for hybrid auth approach)
        services.AddScoped<IPermissionService, PermissionService>();

        return services;
    }
}

