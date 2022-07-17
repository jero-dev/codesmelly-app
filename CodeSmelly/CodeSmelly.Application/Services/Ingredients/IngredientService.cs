using CodeSmelly.Application.Common.Interfaces;
using CodeSmelly.Domain.Entities;
using CodeSmelly.Domain.ValueObject;

namespace CodeSmelly.Application.Services.Ingredients;

public class IngredientService : IIngredientService
{
    private IIngredientRepository _repository;

    public IngredientService(IIngredientRepository repository)
    {
        _repository = repository;
    }

    public IngredientResult CreateIngredient(string n, string mU)
    {
        var measure = mU == "g" ? MeasureUnit.GRAMS : MeasureUnit.LITERS;

        var ingredient = new Ingredient(n, measure, 0);

        _repository.Add(ingredient);

        return new IngredientResult(ingredient.Name.Value, ingredient.MeasureUnit, ingredient.Quantity);
    }
}
