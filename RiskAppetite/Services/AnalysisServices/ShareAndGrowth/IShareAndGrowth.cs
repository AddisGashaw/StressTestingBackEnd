using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;

namespace RiskAppetite.Services.AnalysisServices.ShareAndGrowth
{
    public interface IShareAndGrowth
    {
        Task<ActionResult<List<Sdbcredit>>> GetSdbcredit(string[] years, string[] quarters);
        Task<ActionResult<List<Sdbliquidity>>> GetSdbLiquidity(string[] years, string[] quarters);
        Task<ActionResult<List<MarketRisk>>> GetSdbMarket(string[] years, string[] quarters);
    }
}
