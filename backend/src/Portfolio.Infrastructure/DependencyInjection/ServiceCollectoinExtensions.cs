using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Interfaces;
using Portfolio.Application.Services;
using Portfolio.Infrastructure.Repositories;

namespace Portfolio.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IProjectRepository, InMemoryProjectRepository>();
        services.AddSingleton<IProfileRepository, InMemoryProfileRepository>();
        services.AddScoped<IProjectService, ProjectService>();
        services.AddScoped<IProfileService, ProfileService>();

        return services;
    }
}