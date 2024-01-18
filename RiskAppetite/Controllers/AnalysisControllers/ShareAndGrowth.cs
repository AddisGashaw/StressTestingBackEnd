using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;
using RiskAppetite.Services.AnalysisServices.ShareAndGrowth;

namespace RiskAppetite.Controllers.AnalysisControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ShareAndGrowth : ControllerBase
    {
        private readonly IShareAndGrowth _shareAndGrowth;

        public ShareAndGrowth(IShareAndGrowth shareAndGrowth)
        {
           _shareAndGrowth = shareAndGrowth;
        }
        [HttpGet("GetsdbforShare")]
        public async Task<ActionResult<List<Sdbcredit>>> GetSdbcredit([FromQuery] string[] years, [FromQuery] string[] quarters)
        {
            var result = await _shareAndGrowth.GetSdbcredit(years, quarters);
            return Ok(result);
        }
        [HttpGet("GetsdbLiquidity")]
        public async Task<ActionResult<List<Sdbliquidity>>> GetSdbLiquidity([FromQuery] string[] years, [FromQuery] string[] quarters)
        {
            var result = await _shareAndGrowth.GetSdbLiquidity(years, quarters);
            return Ok(result);
        }
        [HttpGet("GetsdbMarket")]
        public async Task<ActionResult<List<MarketRisk>>> GetsdbMarket([FromQuery] string[] years, [FromQuery] string[] quarters)
        {
            var result = await _shareAndGrowth.GetSdbMarket(years, quarters);
            return Ok(result);
        }

    }
}
