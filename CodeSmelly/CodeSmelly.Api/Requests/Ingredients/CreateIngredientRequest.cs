namespace CodeSmelly.Api.Requests.Ingredients;

public record CreateIngredientRequest(
    string Name,
    string MeasureUnit
);
