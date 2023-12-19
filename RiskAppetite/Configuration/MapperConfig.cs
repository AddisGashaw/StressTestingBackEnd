using AutoMapper;
using RiskAppetite.Models;

namespace CBE_ERMS.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<UserProfile, UserRoleAssignationDto>().ReverseMap();
            CreateMap<Role, userRoleListDto>().ReverseMap();
          
        }

    }
}
