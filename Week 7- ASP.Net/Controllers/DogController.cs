using Microsoft.AspNetCore.Mvc;

namespace Week_7__ASPNET;

[ApiController]
[Route("[controller]")]

public class DogController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Woof Woof!");
    }
}