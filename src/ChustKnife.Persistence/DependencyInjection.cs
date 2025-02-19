using ChustKnife.Domain.Entities;
using ChustKnife.Persistence.DataContexts;
using ChustKnife.Persistence.Interceptors;
using ChustKnife.Persistence.Repositories;
using ChustKnife.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChustKnife.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultDbConnection"));
            options.AddInterceptors(new AuditableInterceptor());
        });

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IRepository<User>, Repository<User>>();

        return services;
    }
}