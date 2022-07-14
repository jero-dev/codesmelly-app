using Microsoft.AspNetCore.Mvc;

namespace CodeSmelly.API.Controllers;

[ApiController]
public class HealthCheck : ControllerBase
{
    [HttpGet("api/health")]
    public IActionResult IsAlive()
    {
        return Ok("I'm alive!");
    }
}
