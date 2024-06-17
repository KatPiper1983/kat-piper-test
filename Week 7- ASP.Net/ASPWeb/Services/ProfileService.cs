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

        public void DeleteProfile(int ProfileId)
        {
             var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);
            _context.Profiles.Remove(profile);
            _context.SaveChanges();;
        }

        public IEnumerable<ProfileDTO> GetAllProfiles()
        {
            var profiles = _context.Profiles
                .Select(p => new ProfileDTO
                    {
                        UserId = p.UserId,
                        Bio = p.Bio
                    }).ToList();
                    return profiles;;
        }

        public ProfileDTO GetProfileById(int ProfileId)
        {
             var profile = _context.Profiles.Find(ProfileId);
            var profileDTO = new ProfileDTO
            {
                Bio = profile.Bio,
                UserId = profile.UserId
            };
            return profileDTO;
        }

        public void UpdateProfile(int ProfileId, ProfileDTO updatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);
            profile.Bio = updatedProfile.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();
        }

       
    }
}