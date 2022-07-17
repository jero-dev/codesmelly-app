using CodeSmelly.Application.Services.Ingredients;
using Microsoft.Extensions.DependencyInjection;

namespace CodeSmelly.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IIngredientService, IngredientService>();

        return services;
    }
}