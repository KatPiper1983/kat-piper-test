using EfCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;


namespace EFCoreExample.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public User CreateUser(UserDTO UserDto)
        {
            var user = new User
            {
                Name = UserDto.Name
            };
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }
        private bool ValidateNewUser(UserDTO UserDto)
        {
            if(UserDto.Name.Trim().Length == 0)
            {
                return false;
            }
            else return true;
        }

        public void DeleteUser(int UserId)
        {
             var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();;
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var users = _context.Users
                .Select(u => new UserDTO
                    {
                        UserId = u.UserId,
                        Name = u.Name
                    }).ToList();
                    return users;;
        }

        public UserDTO GetUserBYId(int UserId)
        {
             var user = _context.Users.Find(UserId);
            var userDTO = new UserDTO
            {
                Name = user.Name,
                UserId = user.UserId
            };
            return userDTO;
        }

        public void UpdateUser(int UserId, UserDTO updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            user.Name = updatedUser.Name;

            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public UserDTO GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}