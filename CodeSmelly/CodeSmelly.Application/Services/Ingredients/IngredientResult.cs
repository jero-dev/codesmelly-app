using CodeSmelly.Domain.ValueObject;

namespace CodeSmelly.Application.Services.Ingredients;

public record IngredientResult
(
    string Name,
    MeasureUnit MeasureUnit,
    double Quantity
);