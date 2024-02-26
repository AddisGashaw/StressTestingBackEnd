using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;
using RiskAppetite.Services.AnalysisServices.Assumption;



namespace RiskAppetite.Controllers.AnalysisControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AssumptionController : ControllerBase
    {
        private readonly IAssumption _Assumption;

        public AssumptionController(IAssumption assumption)
        {
            _Assumption = assumption;
        }
        [HttpGet("GetsdbforCredit")]
        public async Task<ActionResult<List<Sdbcredit>>> GetSdbcredit([FromQuery] string year, [FromQuery] string quarter)
        {
            var result = await _Assumption.GetSdbcredit(year, quarter);
            return Ok(result);
        }
        [HttpGet("GetsdbLiquidity")]
        public async Task<ActionResult<List<Sdbliquidity>>> GetSdbLiquidity([FromQuery] string year, [FromQuery] string quarter)
        {
            var result = await _Assumption.GetSdbLiquidity(year, quarter);
            return Ok(result);
        }
        [HttpGet("GetsdbMarket")]
        public async Task<ActionResult<List<MarketRisk>>> GetsdbMarket([FromQuery] string year, [FromQuery] string quarter)
        {
            var result = await _Assumption.GetSdbMarket(year, quarter);
            return Ok(result);
        }
        [HttpGet("GetsdbOperational")]
        public async Task<ActionResult<List<OprationalRisk>>> GetsdbOperational([FromQuery] string year, [FromQuery] string quarter)
        {
            var result = await _Assumption.GetSdbOperational(year, quarter);
            return Ok(result);
        }

    }
}

