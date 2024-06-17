using Microsoft.AspNetCore.Mvc;
using LogInAPI.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using LogInAPI.DTOs;

namespace LogInAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
    {
        var users = await _userService.GetAllUsers();
        return users;

    }
}