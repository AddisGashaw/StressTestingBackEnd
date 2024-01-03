using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models.Dto.UserProfileDto;
using RiskAppetite.Services.UserProfileService;
using System.Text;

namespace RiskAppetite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfile : ControllerBase
    {
        private readonly IUserProfile _userProfile;

        public UserProfile(IUserProfile userProfile)
        {
           _userProfile = userProfile;
        }
        [HttpPost("RegisterUser")]
        public async Task<ActionResult> RoleAssignment(userProfileUpdateDto userProfileUpdateDto)
        {
            var result = await _userProfile.Register(userProfileUpdateDto);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userProfileReadOnlyDto>>> GetUserDetails()
        {
            var result = await _userProfile.GetUserProfiles();
            return Ok(result);
        }
        [HttpGet("GetUserDetailById")]
        public async Task<ActionResult<userProfileReadOnlyDto>> GetUserDetailById(int id)
        {
            var result = await _userProfile.GetUserProfilebyId(id);

            return Ok(result);

        }
        [HttpPut("UpdateUserProfile/{id}")]
        public async Task<ActionResult<userProfileUpdateDto>> UpdateUserProfile(int id, userProfileUpdateDto userProfileUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userProfile.UpdateUserProfile(id, userProfileUpdateDto);
            return Ok(result);

        }
        [HttpDelete("DeleteUserDetail/{id}")]
        public async Task<ActionResult> DeleteUserDetail(int id)
        {
            await _userProfile.DeleteUserDetail(id);

            return Ok("Deleted Successfully");

        }
    }
}
