using EfCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace EFCoreExample.Services
{
    public class ProfileService : IProfileService
    {
        private readonly AppDbContext _context;
        public ProfileService(AppDbContext context)
        {
            _context = context;
        }

        public Profile CreateProfile(ProfileDTO profileDto)
        {
            var user = _context.Users.FirstOrDefault(u=>u.UserId == profileDto.UserId);
            var profile = new Profile
            {
                Bio = profileDto.Bio,
                UserId = user.UserId,
                User = user
            };
            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return profile;
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