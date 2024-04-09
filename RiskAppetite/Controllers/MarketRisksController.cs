using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;

namespace RiskAppetite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketRisksController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public MarketRisksController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/MarketRisks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketRisk>>> GetMarketRisks()
        {
          if (_context.MarketRisks == null)
          {
              return NotFound();
          }
            return await _context.MarketRisks.ToListAsync();
        }

        // GET: api/MarketRisks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MarketRisk>> GetMarketRisk(int id)
        {
          if (_context.MarketRisks == null)
          {
              return NotFound();
          }
            var marketRisk = await _context.MarketRisks.FindAsync(id);

            if (marketRisk == null)
            {
                return NotFound();
            }

            return marketRisk;
        }

        // PUT: api/MarketRisks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarketRisk(int id, MarketRisk marketRisk)
        {
            if (id != marketRisk.Id)
            {
                return BadRequest();
            }

            _context.Entry(marketRisk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarketRiskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [HttpGet("GetSdbMarkrtByyearandQuarter")]
        public async Task<ActionResult<IEnumerable<MarketRisk>>> GetSdbMarkrtByyearandQuarter([FromQuery] string year, [FromQuery] string quarter)
        {
            if (_context.MarketRisks == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var marketRisk = await _context.MarketRisks.Where(x => x.Year == year && x.Quarter== quarter).ToListAsync();

            if (marketRisk == null)
            {
                return NotFound();
            }

            return marketRisk;
        }
        // POST: api/MarketRisks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MarketRisk>> PostMarketRisk(MarketRisk marketRisk)
        {
          if (_context.MarketRisks == null)
          {
              return Problem("Entity set 'RiskApetiteContext.MarketRisks'  is null.");
          }
            _context.MarketRisks.Add(marketRisk);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarketRisk", new { id = marketRisk.Id }, marketRisk);
        }

        // DELETE: api/MarketRisks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMarketRisk(int id)
        {
            if (_context.MarketRisks == null)
            {
                return NotFound();
            }
            var marketRisk = await _context.MarketRisks.FindAsync(id);
            if (marketRisk == null)
            {
                return NotFound();
            }

            _context.MarketRisks.Remove(marketRisk);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MarketRiskExists(int id)
        {
            return (_context.MarketRisks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
