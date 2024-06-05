using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAllUsers();

        UserDTO GetUserById(int UserId);

        User CreateUser(UserDTO UserDto);

        void UpdateUser(int UserId, UserDTO UpdatedUser);
        void DeleteUser(int UserId);
    }


}