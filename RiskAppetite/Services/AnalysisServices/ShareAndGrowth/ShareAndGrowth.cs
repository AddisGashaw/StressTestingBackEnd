using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace RiskAppetite.Services.AnalysisServices.ShareAndGrowth
{
    public class ShareAndGrowth : IShareAndGrowth
    {
        private readonly RiskApetiteContext _context;

        public ShareAndGrowth(RiskApetiteContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<Sdbcredit>>> GetSdbcredit(string[] years, string[] quarters)
        {
            var sdbCreditList = await _context.Sdbcredits
                .Where(x => years.Contains(x.Year) && (quarters.Length ==0 || quarters.Contains(x.Quarter)))
                .ToListAsync();
            if (sdbCreditList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years and quarter in the Sensativity Credit table.");
            }

            return sdbCreditList;
        }
        public async Task<ActionResult<List<Sdbliquidity>>> GetSdbLiquidity(string[] years, string[] quarters)
        {
            var sdbLiquidityList = await _context.Sdbliquidities
                .Where(x => years.Contains(x.Year) && (quarters.Length ==0 || quarters.Contains(x.Quarter)))
                .ToListAsync();
            if (sdbLiquidityList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years and quarter in the Sensativity Liquidity table.");
            }

            return sdbLiquidityList;
        } 
        public async Task<ActionResult<List<MarketRisk>>> GetSdbMarket(string[] years, string[] quarters)
        {
            var sdbMarketList = await _context.MarketRisks
                .Where(x => years.Contains(x.Year) && (quarters.Length ==0 || quarters.Contains(x.Quarter)))
                .ToListAsync();
            if (sdbMarketList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected years and quarter in the Sensativity Market Risk table.");
            }

            return sdbMarketList;
        }
    }
}
