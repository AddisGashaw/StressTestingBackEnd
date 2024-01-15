using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;

namespace RiskAppetite.Services.AnalysisServices.ShareAndGrowth
{
    public interface IShareAndGrowth
    {
        Task<ActionResult<List<Sdbcredit>>> GetSdbcredit(string[] years, string[] quarters);
    }
}
