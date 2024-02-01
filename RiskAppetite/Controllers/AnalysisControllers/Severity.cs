using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models.Dto.SeverityDto;
using RiskAppetite.Models.Dto.UserProfileDto;
using RiskAppetite.Services.SeverityService;

namespace RiskAppetite.Controllers.AnalysisControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Severity : ControllerBase
    {
        private readonly ISeverity _severity;

        public Severity(ISeverity severity)
        {
            _severity = severity;
        }

        [HttpPost("RegisterSeverity")]
        public async Task<ActionResult> Register(SeverityCreateDto SeverityCreateDto)
        {
            var result = await _severity.Register(SeverityCreateDto);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<SeverityReadDto>>> GetSeverities()
        {
            var result = await _severity.GetSeverities();
            return Ok(result);
        }
        [HttpGet("GetSeverityById")]
        public async Task<ActionResult<SeverityReadDto>> GetSeverityById(int id)
        {
            var result = await _severity.GetSeverityById(id);

            return Ok(result);

        }
        [HttpPut("UpdateSeverity/{id}")]
        public async Task<ActionResult<SeverityCreateDto>> UpdateSeverity(int id, SeverityCreateDto SeverityCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _severity.UpdateSeverity(id, SeverityCreateDto);
            return Ok(result);

        }
        [HttpDelete("DeleteSeverity/{id}")]
        public async Task<ActionResult> DeleteSeverity(int id)
        {
            await _severity.DeleteSeverity(id);

            return Ok("Deleted Successfully");

        }
    }
}
