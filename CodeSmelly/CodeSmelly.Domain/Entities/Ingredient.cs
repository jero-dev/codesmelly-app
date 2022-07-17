using CodeSmelly.Domain.ValueObject;

namespace CodeSmelly.Domain.Entities;

public class Ingredient
{
    public NonEmptyString Name { get; set; }
    public MeasureUnit MeasureUnit { get; set; }
    public double Quantity { get; set; }

    public Ingredient(string name, MeasureUnit measureUnit, double quantity)
    {
        Name = new NonEmptyString(name);
        MeasureUnit = measureUnit;
        Quantity = quantity;
    }
}
