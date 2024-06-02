using Microsoft.AspNetCore.Mvc;
using Week_7__ASPNET.Models;

namespace Week_7__ASPNET.Controllers;

[ApiController]
[Route("[controller]")]

public class KatController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Kat is awesome!");
    }
    [HttpPost]
    public IActionResult Post(Message message)
    {
        System.Console.WriteLine(message.note);
        return Created();
    }
    
}