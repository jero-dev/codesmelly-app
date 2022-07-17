using CodeSmelly.Api.Requests.Ingredients;
using CodeSmelly.Api.Responses.Ingredients;
using CodeSmelly.Application.Services.Ingredients;
using CodeSmelly.Domain.ValueObject;
using Microsoft.AspNetCore.Mvc;

namespace CodeSmelly.Api.Controllers.Ingredients;

[ApiController]
public class CreateIngredientController : ControllerBase
{
    private IIngredientService _ingredientService;

    public CreateIngredientController(IIngredientService ingredientService)
    {
        _ingredientService = ingredientService;
    }

    [HttpPost("api/ingredient")]
    public async Task<IActionResult> CreateIngredient(CreateIngredientRequest request)
    {
        var result = _ingredientService.CreateIngredient(request.Name, request.MeasureUnit);

        if (result == null)
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);

        return Ok(MapToResponse(result));
    }

    private IngredientResponse MapToResponse(IngredientResult result)
    {
        var measure = result.MeasureUnit == MeasureUnit.GRAMS ? "g" : "l";

        return new IngredientResponse(result.Name, measure, result.Quantity);
    }
}
