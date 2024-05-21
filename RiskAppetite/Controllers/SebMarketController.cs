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
    public class SebMarketController : Controller
    {
        private readonly RiskApetiteContext _context;

        public SebMarketController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebmarketRisks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebmarketRisk>>> GetSebmarkets()
        {
            if (_context.SebmarketRisks == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebmarketRisks.OrderBy(risk => risk.Year).ToListAsync();
            return sortedData;
        }

        // GET: api/SebmarketRisks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebmarketRisk>> GetSebmarkets(int id)
        {
            if (_context.SebmarketRisks == null)
            {
                return NotFound();
            }
            var sebmarket = await _context.SebmarketRisks.FindAsync(id);

            if (sebmarket == null)
            {
                return NotFound();
            }

            return sebmarket;
        }
        [HttpGet("GetSebMarkettByyear")]
        public async Task<ActionResult<IEnumerable<SebmarketRisk>>> GetSebMarkettByyear([FromQuery] string year)
        {
            if (_context.SebmarketRisks == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var MarketRisk = await _context.SebmarketRisks.Where(x => x.Year == year).ToListAsync();

            if (MarketRisk == null)
            {
                return NotFound();
            }

            return MarketRisk;
        }

        // Fetching Data of 40 years
        [HttpGet("GetSebMarketofFourtyYears")]
        public async Task<ActionResult<IEnumerable<SebmarketRisk>>> GetSebMarketofFourtyYears()
        {
            if (_context.SebmarketRisks == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebmarketRisks.OrderByDescending(risk => risk.Year).Take(40).ToListAsync();
            return sortedData;
        }
        // PUT: api/SebmarketRisks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebmarket(int id, SebmarketRisk sebmarket)
        {
            if (id != sebmarket.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebmarket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebmarketExists(id))
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

        // POST: api/SebmarketRisks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebmarketRisk>> PostSebmarket(SebmarketRisk sebmarket)
        {
            if (_context.SebmarketRisks == null)
            {
                return Problem("Entity set 'RiskApetiteContext.Sebmarkets'  is null.");
            }
            _context.SebmarketRisks.Add(sebmarket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebmarket", new { id = sebmarket.Id }, sebmarket);
        }

        // DELETE: api/SebmarketRisks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebmarket(int id)
        {
            if (_context.SebmarketRisks == null)
            {
                return NotFound();
            }
            var sebmarket = await _context.SebmarketRisks.FindAsync(id);
            if (sebmarket == null)
            {
                return NotFound();
            }

            _context.SebmarketRisks.Remove(sebmarket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebmarketExists(int id)
        {
            return (_context.SebmarketRisks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
