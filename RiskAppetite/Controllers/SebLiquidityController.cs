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
    public class SebLiquidityController : Controller
    {
        private readonly RiskApetiteContext _context;

        public SebLiquidityController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebliquidityRisks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebliquidityRisk>>> GetSebliquidities()
        {
            if (_context.SebliquidityRisks == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebliquidityRisks.OrderBy(risk => risk.Year).ToListAsync();
            return sortedData;
        }

        // GET: api/SebliquidityRisks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebliquidityRisk>> GetSebliquidities(int id)
        {
            if (_context.SebliquidityRisks == null)
            {
                return NotFound();
            }
            var sebliquidity = await _context.SebliquidityRisks.FindAsync(id);

            if (sebliquidity == null)
            {
                return NotFound();
            }

            return sebliquidity;
        }
        [HttpGet("GetSebLiquiditytByyear")]
        public async Task<ActionResult<IEnumerable<SebliquidityRisk>>> GetSebLiquiditytByyear([FromQuery] string year)
        {
            if (_context.SebliquidityRisks == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var CreditRisk = await _context.SebliquidityRisks.Where(x => x.Year == year).ToListAsync();

            if (CreditRisk == null)
            {
                return NotFound();
            }

            return CreditRisk;
        }

        // Fetching Data of 40 years
        [HttpGet("GetSebLiquidityofFourtyYears")]
        public async Task<ActionResult<IEnumerable<SebliquidityRisk>>> GetSebLiquidityofFourtyYears([FromQuery] string year)
        {
            if (_context.SebliquidityRisks == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebliquidityRisks.OrderByDescending(risk => risk.Year).Where(x => String.Compare(x.Year, year) <= 0).Take(40).ToListAsync();
            return sortedData;
        }
        // PUT: api/SebliquidityRisks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebliquidity(int id, SebliquidityRisk sebliquidity)
        {
            if (id != sebliquidity.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebliquidity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebliquidityExists(id))
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

        // POST: api/SebliquidityRisks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebliquidityRisk>> PostSebliquidity(SebliquidityRisk sebliquidity)
        {
            if (_context.SebliquidityRisks == null)
            {
                return Problem("Entity set 'RiskApetiteContext.Sebliquiditys'  is null.");
            }
            _context.SebliquidityRisks.Add(sebliquidity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebliquidity", new { id = sebliquidity.Id }, sebliquidity);
        }

        // DELETE: api/SebliquidityRisks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebliquidity(int id)
        {
            if (_context.SebliquidityRisks == null)
            {
                return NotFound();
            }
            var sebliquidity = await _context.SebliquidityRisks.FindAsync(id);
            if (sebliquidity == null)
            {
                return NotFound();
            }

            _context.SebliquidityRisks.Remove(sebliquidity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebliquidityExists(int id)
        {
            return (_context.SebliquidityRisks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
