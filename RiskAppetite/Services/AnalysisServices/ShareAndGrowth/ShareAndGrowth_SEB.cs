
using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.UserProfileDto;




namespace RiskAppetite.Services.AnalysisServices.ShareAndGrowth
{
    public class ShareAndGrowth_SEB : IShareAndGrowth_SEB
    {
        private readonly RiskApetiteContext _context;

        public ShareAndGrowth_SEB(RiskApetiteContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<SebcreditRisk>>> GetSebCredit(string[] years)
        {
            var sebCreditList = await _context.SebcreditRisks
                .Where(x => years.Contains(x.Year) )
                .ToListAsync();
            if (sebCreditList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years in the Sensativity Credit table.");
            }

            return sebCreditList;
        }
        public async Task<ActionResult<List<SebliquidityRisk>>> GetSebLiquidity(string[] years)
        {
            var sebLiquidityList = await _context.SebliquidityRisks
                .Where(x => years.Contains(x.Year))
                .ToListAsync();
            if (sebLiquidityList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years in the Sensativity Liquidity table.");
            }

            return sebLiquidityList;
        }
        public async Task<ActionResult<List<SebmarketRisk>>> GetSebMarket(string[] years)
        {
            var sebMarketList = await _context.SebmarketRisks
                .Where(x => years.Contains(x.Year))
                .ToListAsync();
            if (sebMarketList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years in the Sensetivity Market Risk table.");
            }

            return sebMarketList;
        }

        public async Task<ActionResult<List<Sebmacroeconomic>>> GetSebMacroeconomics(string[] years)
        {
            var sebMacroList = await _context.Sebmacroeconomics
                .Where(x => years.Contains(x.Year))
                .ToListAsync();
            if (sebMacroList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years in the Sensetivity Macroeconomics Risk table.");
            }

            return sebMacroList;
        }
    }
}

