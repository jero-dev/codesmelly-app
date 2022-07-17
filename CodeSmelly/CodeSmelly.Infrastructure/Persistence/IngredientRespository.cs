using CodeSmelly.Application.Common.Interfaces;
using CodeSmelly.Domain.Entities;

namespace CodeSmelly.Infrastructure.Persistence;

public class IngredientRespository : IIngredientRepository
{
    private static List<Ingredient> _ingredients = new();

    public void Add(Ingredient ing) => _ingredients.Add(ing);
}
