using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models.Dto.SeverityDto;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace RiskAppetite.Services.SeverityService
{
    public interface ISeverity
    {
        Task<IEnumerable<SeverityReadDto>> GetSeverities();
        Task<ActionResult<SeverityReadDto>> GetSeverityById(int id);
        Task<IEnumerable<SeverityReadDto>> GetSeverityByYearAndQuarter(string year, string quarter, int id);
        Task<SeverityCreateDto> UpdateSeverity(int id, SeverityCreateDto SeverityCreateDto);
        Task DeleteSeverity(int id);
        Task<SeverityCreateDto> Register(SeverityCreateDto SeverityCreateDto);

    }
}
