using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfigurationManager configuration)
    {
        services.AddDbContext<AppDbContext>(option =>
        {
            option.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
}