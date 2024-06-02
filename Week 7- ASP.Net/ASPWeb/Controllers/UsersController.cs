using EfCoreExample.Data;
using EfCoreExample.Models;
using EFCoreExample.DTOs;
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
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _context.Users
                            .Select(u => new UserDTO
                            {
                                UserId = u.UserId,
                                Name = u.Name
                            }).ToList();
                        return users;
        }
        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _context.Users.Find(UserId);
            var userDTO = new UserDTO
            {
                Name = user.Name,
                UserId = user.UserId
            };
            return userDTO;
        }

        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDTO)
        {
            var user = new User
            {
                Name = userDTO.Name
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, userDTO);
        }

        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            user.Name = UpdatedUser.Name;

            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(UpdatedUser);
        }

        [HttpDelete("{UserId}")]
         public IActionResult DeleteUser(int UserId)
         {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok();
         }
    }
   
}
