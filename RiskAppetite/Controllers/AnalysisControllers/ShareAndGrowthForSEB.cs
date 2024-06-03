using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;
using RiskAppetite.Services.AnalysisServices.ShareAndGrowth;

namespace RiskAppetite.Controllers.AnalysisControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ShareAndGrowthForSEB : ControllerBase
    {
        private readonly IShareAndGrowth_SEB _shareAndGrowth;

        public ShareAndGrowthForSEB(IShareAndGrowth_SEB shareAndGrowth)
        {
            _shareAndGrowth = shareAndGrowth;
        }
        [HttpGet("GetsebforCredit")]
        public async Task<ActionResult<List<SebcreditRisk>>> GetSebCredit([FromQuery] string[] years)
        {
            var result = await _shareAndGrowth.GetSebCredit(years);
            return Ok(result);
        }
        [HttpGet("GetsebLiquidity")]
        public async Task<ActionResult<List<SebliquidityRisk>>> GetSebLiquidity([FromQuery] string[] years)
        {
            var result = await _shareAndGrowth.GetSebLiquidity(years);
            return Ok(result);
        }
        [HttpGet("GetsebMarket")]
        public async Task<ActionResult<List<SebmarketRisk>>> GetsebMarket([FromQuery] string[] years)
        {
            var result = await _shareAndGrowth.GetSebMarket(years);
            return Ok(result);
        }

        [HttpGet("GetsebMacroeconomics")]
        public async Task<ActionResult<List<Sebmacroeconomic>>> GetsebMacroeconomics([FromQuery] string[] years)
        {
            var result = await _shareAndGrowth.GetSebMacroeconomics(years);
            return Ok(result);
        }

    }
}

