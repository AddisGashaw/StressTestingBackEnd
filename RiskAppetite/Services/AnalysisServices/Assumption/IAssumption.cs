using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;

namespace RiskAppetite.Services.AnalysisServices.Assumption
{
    public interface IAssumption
    {
        Task<ActionResult<List<Sdbcredit>>> GetSdbcredit(string year, string quarter);
        Task<ActionResult<List<Sdbliquidity>>> GetSdbLiquidity(string year, string quarter);
        Task<ActionResult<List<MarketRisk>>> GetSdbMarket(string year, string quarter);
        Task<ActionResult<List<OprationalRisk>>> GetSdbOperational(string year, string quarter);
        
    }
}
