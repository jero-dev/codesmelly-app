using CodeSmelly.Domain.Entities;

namespace CodeSmelly.Application.Common.Interfaces;

public interface IIngredientRepository
{
    public void Add(Ingredient ingredient);
}
