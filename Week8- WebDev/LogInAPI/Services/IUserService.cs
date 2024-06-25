using LogInAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LogInAPI.Services;

public interface IUserService
{
    Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers();
}