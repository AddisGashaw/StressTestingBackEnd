using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace RiskAppetite.Services.AnalysisServices.Assumption
{
    public class Assumption : IAssumption
    {
        private readonly RiskApetiteContext _context;

        public Assumption(RiskApetiteContext context)
        {
            _context = context;
        }

        private int GetQuarterNumber(string quarter)
        {
            return quarter switch
            {
                "QI" => 1,
                "QII" => 2,
                "QIII" => 3,
                "QIV" => 4,
                _ => throw new ArgumentException("Invalid quarter value."),
            };
        }

        private string GetQuarterName(int quarterNumber)
        {
            return quarterNumber switch
            {
                1 => "QI",
                2 => "QII",
                3 => "QIII",
                4 => "QIV",
                _ => throw new ArgumentException("Invalid quarter number."),
            };
        }
        public async Task<ActionResult<List<Sdbcredit>>> GetSdbcredit(string year, string quarter)
        {
            var sdbCreditList = new List<Sdbcredit>();
            var currentYear = int.Parse(year.Split('/')[0]);
            var currentQuarter = GetQuarterNumber(quarter);
            var quartersCount = 0;

            while (quartersCount < 21 && currentYear >= 1950)
            {
                var sdbCreditData = await _context.Sdbcredits
                    .Where(x => x.Year == year && x.Quarter == quarter)
                    .ToListAsync();

                if (sdbCreditData.Count > 0)
                {
                    sdbCreditList.InsertRange(0, sdbCreditData); // Insert at the beginning to maintain descending order
                    quartersCount += sdbCreditData.Count;
                }

                currentQuarter--;
                if (currentQuarter == 0)
                {
                    currentYear--;
                    currentQuarter = 4;
                }

                year = $"{currentYear}/{currentYear % 100 + 1:00}";
                quarter = GetQuarterName(currentQuarter);
            }

            if (sdbCreditList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected year and quarter in the Sensitivity Credit table.");
            }

            return sdbCreditList.Take(21).ToList();
        }


        public async Task<ActionResult<List<Sdbliquidity>>> GetSdbLiquidity(string year, string quarter)
        {
            var sdbLiquidityList = new List<Sdbliquidity>();
            var currentYear = int.Parse(year.Split('/')[0]);
            var currentQuarter = GetQuarterNumber(quarter);
            var quartersCount = 0;

            while (quartersCount < 21 && currentYear >= 1950)
            {
                var sdbLiquidityData = await _context.Sdbliquidities
                    .Where(x => x.Year == year && x.Quarter == quarter)
                    .ToListAsync();

                if (sdbLiquidityData.Count > 0)
                {
                    sdbLiquidityList.InsertRange(0, sdbLiquidityData); // Insert at the beginning to maintain descending order
                    quartersCount += sdbLiquidityData.Count;
                }

                currentQuarter--;
                if (currentQuarter == 0)
                {
                    currentYear--;
                    currentQuarter = 4;
                }

                year = $"{currentYear}/{currentYear % 100 + 1:00}";
                quarter = GetQuarterName(currentQuarter);
            }

            if (sdbLiquidityList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected year and quarter in the Sensitivity Liquidity table.");
            }

            return sdbLiquidityList.Take(21).ToList();
        }


        public async Task<ActionResult<List<MarketRisk>>> GetSdbMarket(string year, string quarter)
        {
            var sdbMarketList = new List<MarketRisk>();
            var currentYear = int.Parse(year.Split('/')[0]);
            var currentQuarter = GetQuarterNumber(quarter);
            var quartersCount = 0;

            while (quartersCount < 21 && currentYear >= 1950)
            {
                var sdbMarketData = await _context.MarketRisks
                    .Where(x => x.Year == year && x.Quarter == quarter)
                    .ToListAsync();

                if (sdbMarketData.Count > 0)
                {
                    sdbMarketList.InsertRange(0, sdbMarketData); // Insert at the beginning to maintain descending order
                    quartersCount += sdbMarketData.Count;
                }

                currentQuarter--;
                if (currentQuarter == 0)
                {
                    currentYear--;
                    currentQuarter = 4;
                }

                year = $"{currentYear}/{currentYear % 100 + 1:00}";
                quarter = GetQuarterName(currentQuarter);
            }

            if (sdbMarketList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected year and quarter in the Sensitivity Market table.");
            }

            return sdbMarketList.Take(21).ToList();
        }

        public async Task<ActionResult<List<OprationalRisk>>> GetSdbOperational(string year, string quarter)
        {
            var sdbOperationalList = new List<OprationalRisk>();
            var currentYear = int.Parse(year.Split('/')[0]);
            var currentQuarter = GetQuarterNumber(quarter);
            var quartersCount = 0;

            while (quartersCount < 21 && currentYear >= 1950)
            {
                var sdbOprationalData = await _context.OprationalRisks
                    .Where(x => x.Year == year && x.Quarter == quarter)
                    .ToListAsync();

                if (sdbOprationalData.Count > 0)
                {
                    sdbOperationalList.InsertRange(0, sdbOprationalData); // Insert at the beginning to maintain descending order
                    quartersCount += sdbOprationalData.Count;
                }

                currentQuarter--;
                if (currentQuarter == 0)
                {
                    currentYear--;
                    currentQuarter = 4;
                }

                year = $"{currentYear}/{currentYear % 100 + 1:00}";
                quarter = GetQuarterName(currentQuarter);
            }

            if (sdbOperationalList.Count == 0)
            {
                throw new DataNotFoundException($"No data found for the selected year and quarter in the Sensitivity Operational table.");
            }

            return sdbOperationalList.Take(21).ToList();
        }
    }
}
