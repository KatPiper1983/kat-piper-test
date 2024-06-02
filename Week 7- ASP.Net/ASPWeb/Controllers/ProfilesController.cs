using EfCoreExample.Data;
using EFCoreExample.DTOs;
using Microsoft.AspNetCore.Mvc;
using EfCoreExample.Models;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfilesController : ControllerBase
    {
        //appdbcontext is used to interact with our db
        //constructor is used by our dependency manager to inject it into our class
        //we don't have to instantiate the controller or provide the app db context into the constructor
        private readonly AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
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
        [HttpGet("{UserId}")]
        public ActionResult<ProfileDTO> GetProfileById(int UserId)
        {
            var profile = _context.Profiles.Find(UserId);
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
            var profile = new Profile
            {
                Bio = profileDTO.Bio
            };
            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfileById), new { UserId = profile.UserId }, profileDTO);
        }

        [HttpPut("{UserId}")]
        public ActionResult<ProfileDTO> UpdateProfile(int UserId, ProfileDTO UpdatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == UserId);
            profile.Bio = UpdatedProfile.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();

            return Ok(UpdatedProfile);
        }

        [HttpDelete("{UserId}")]
         public IActionResult DeleteProfile(int UserId)
         {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == UserId);
            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            return Ok();
         }
    }
}