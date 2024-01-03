using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace RiskAppetite.Services.UserProfileService
{
    public interface IUserProfile
    {
        Task<IEnumerable<userProfileReadOnlyDto>> GetUserProfiles();
        Task<ActionResult<userProfileReadOnlyDto>> GetUserProfilebyId(int id);
        Task<userProfileUpdateDto> UpdateUserProfile(int id, userProfileUpdateDto userProfileUpdateDto);
        Task DeleteUserDetail(int id);
        Task<userProfileUpdateDto> Register(userProfileUpdateDto userProfileUpdateDto);




    }
}
