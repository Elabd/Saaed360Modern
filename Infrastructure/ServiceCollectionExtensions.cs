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
using Application.Interfaces.ExternalServices;
using Infrastructure.Persistence.Contexts;

namespace Saaed360Modern.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration cfg)
    {
        // --------------------  Persistence  --------------------
        var connStr = cfg.GetConnectionString("DefaultConnection") ??
                      throw new InvalidOperationException("Connection string 'Default' not found.");

        services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseSqlServer(connStr, sql => sql.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        // Expose DbContext to upper layers via abstraction
        services.AddScoped<IAppDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());

        // add other repository registrations here

        // --------------------  External Services (WCF)  --------------------
        services.AddSingleton<IReportWcfService, ReportWcfService>();

        // --------------------  Mapping / utilities  --------------------
        // Example: AutoMapper profiles that live in Infrastructure
        // services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);

        return services;
    }
}
