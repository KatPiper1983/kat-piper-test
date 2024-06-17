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
            var profiles = _profileService.GetAllProfiles();
            return Ok(profiles);
        }
        [HttpGet("{ProfileId}")]
        public ActionResult<ProfileDTO> GetProfileById(int ProfileId)
        {
            var profile = _profileService.GetProfileById(ProfileId);
            return profile;
        }

        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDTO)
        {
            var profile = _profileService.CreateProfile(profileDTO);
        

            return CreatedAtAction(nameof(GetProfileById), new { ProfileId = profile.ProfileId }, profileDTO);
        }

        [HttpPut("{ProfileId}")]
        public ActionResult<ProfileDTO> UpdateProfile(int ProfileId, ProfileDTO UpdatedProfile)
        {
            _profileService.UpdateProfile(ProfileId, UpdatedProfile);

            return Ok(UpdatedProfile);
        }

        [HttpDelete("{ProfileId}")]
         public IActionResult DeleteProfile(int ProfileId)
         {
           _profileService.DeleteProfile(ProfileId);

            return Ok();
         }
    }
}