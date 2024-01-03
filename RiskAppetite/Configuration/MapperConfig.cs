using AutoMapper;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace CBE_ERMS.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {

            CreateMap<UserProfile, UserRoleAssignationDto>().ReverseMap();
            CreateMap<UserProfile, userProfileUpdateDto>().ReverseMap();
            CreateMap<UserProfile, userProfileReadOnlyDto>().ForMember(Q => Q.UserRoleName, d => d.MapFrom(map => $"{map.UserRole.RoleName}")).ReverseMap();
            CreateMap<Role, userRoleListDto>().ReverseMap();
          
        }

    }
}
