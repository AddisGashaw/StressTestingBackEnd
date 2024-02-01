using AutoMapper;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.SeverityDto;
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
            CreateMap<SeverityForAnalysis, SeverityCreateDto>().ReverseMap();
            CreateMap<SeverityForAnalysis, SeverityReadDto>().ForMember(Q => Q.SeverityType, d => d.MapFrom(map => $"{map.SeverityCat.Name}")).ReverseMap();
        }

    }
}
