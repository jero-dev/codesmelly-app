namespace CodeSmelly.Application.Services.Ingredients;

public interface IIngredientService
{
    public IngredientResult CreateIngredient(string name, string measureUnit);
}
