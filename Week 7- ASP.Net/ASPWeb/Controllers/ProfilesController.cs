using EfCoreExample.Data;
using EFCoreExample.DTOs;
using Microsoft.AspNetCore.Mvc;
using EFCoreExample.Models;
using EFCoreExample.Services;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfilesController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
        private readonly IProfileService _profileService;
        public ProfilesController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProfileDTO>> GetProfiles()
        {
            var profiles = _context.Profiles
                            .Select(p => new ProfileDTO
                            {
                                UserId = p.UserId,
                                Bio = p.Bio
                            }).ToList();
                        return profiles;
        }
        [HttpGet("{ProfileId}")]
        public ActionResult<ProfileDTO> GetProfileById(int ProfileId)
        {
            var profile = _context.Profiles.Find(ProfileId);
            var profileDTO = new ProfileDTO
            {
                Bio = profile.Bio,
                UserId = profile.UserId
            };
            return profileDTO;
        }

        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDTO)
        {
            var user = _context.Users.FirstOrDefault(u=>u.UserId == profileDTO.UserId);
            var profile = new Profile
            {
                Bio = profileDTO.Bio,
                UserId = user.UserId,
                User = user

            };
            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfileById), new { ProfileId = profile.ProfileId }, profileDTO);
        }

        [HttpPut("{ProfileId}")]
        public ActionResult<ProfileDTO> UpdateProfile(int ProfileId, ProfileDTO UpdatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.ProfileId == ProfileId);
            profile.Bio = UpdatedProfile.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();

            return Ok(UpdatedProfile);
        }

        [HttpDelete("{ProfileId}")]
         public IActionResult DeleteProfile(int ProfileId)
         {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == ProfileId);
            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            return Ok();
         }
    }
}