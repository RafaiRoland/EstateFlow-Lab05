using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using EstateFlow.Infrastructure.Data;
using EstateFlow.Application;

namespace EstateFlow.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EstateFlowDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("EstateFlowDbConnection")));

        services.AddScoped<IApplicationDbContext, EstateFlowDbContext>();

        return services;
    }
}