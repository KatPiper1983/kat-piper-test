using EfCoreExample.Data;
using EFCoreExample.Models;
using EFCoreExample.DTOs;
using EFCoreExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
       // private readonly AppDbContext _context;

       /* public UsersController(AppDbContext context)
        {
            _context = context;
        }*/
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _userService.GetUserById(UserId);
            return user;
        }

        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = _userService.CreateUser(userDto);
        

            return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, userDto);
        }

        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            _userService.UpdateUser(UserId, UpdatedUser);

            return Ok(UpdatedUser);
        }

        [HttpDelete("{UserId}")]
         public IActionResult DeleteUser(int UserId)
         {
            _userService.DeleteUser(UserId);

            return Ok();
         }
    }
   
}
