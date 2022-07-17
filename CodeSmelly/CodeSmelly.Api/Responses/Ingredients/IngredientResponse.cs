namespace CodeSmelly.Api.Responses.Ingredients;

public record IngredientResponse
(
    string Name,
    string MeasureUnit,
    double Quantity
);