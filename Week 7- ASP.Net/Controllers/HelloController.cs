using Microsoft.AspNetCore.Mvc;

namespace Week_7__ASPNET.Controllers;



[ApiController]
[Route("[Controller]")]

public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello");
    }

}