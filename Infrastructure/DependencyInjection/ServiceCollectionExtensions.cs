using Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Saaed360Modern.Infrastructure.ExternalServices;

namespace Saaed360Modern.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IMdtUserWcfService, MdtUserWcfService>();
        return services;
    }
} 