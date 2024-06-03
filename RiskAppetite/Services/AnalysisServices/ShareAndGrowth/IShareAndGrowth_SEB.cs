using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;


namespace RiskAppetite.Services.AnalysisServices.ShareAndGrowth
{
    public interface IShareAndGrowth_SEB
    {
        Task<ActionResult<List<SebcreditRisk>>> GetSebCredit(string[] years);
        Task<ActionResult<List<SebliquidityRisk>>> GetSebLiquidity(string[] years);
        Task<ActionResult<List<SebmarketRisk>>> GetSebMarket(string[] years);
        Task<ActionResult<List<Sebmacroeconomic>>> GetSebMacroeconomics(string[] years);
    }
}


