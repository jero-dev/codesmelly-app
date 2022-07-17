using CodeSmelly.Application.Common.Interfaces;
using CodeSmelly.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace CodeSmelly.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IIngredientRepository, IngredientRespository>();

        return services;
    }
}