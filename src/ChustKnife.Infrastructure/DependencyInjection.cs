using ChustKnife.Application.Common.Identity;
using ChustKnife.Application.Services;
using ChustKnife.Infrastructure.Common.Identity;
using ChustKnife.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChustKnife.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddIdentity()
            .AddNotification()
            .AddServices();

        return services;
    }

    private static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        services.AddScoped<ITokenGeneratorService, TokenGeneratorService>();

        return services;
    }

    private static IServiceCollection AddNotification(this IServiceCollection services)
    {
        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}