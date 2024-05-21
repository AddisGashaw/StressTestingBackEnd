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
    public class SebMacroEconomicsController : Controller
    {
        private readonly RiskApetiteContext _context;

        public SebMacroEconomicsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/Sebmacroeconomics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sebmacroeconomic>>> GetSebmacroeconomics()
        {
            if (_context.Sebmacroeconomics == null)
            {
                return NotFound();
            }

            var sortedData = await _context.Sebmacroeconomics.OrderBy(risk => risk.Year).ToListAsync();
            return sortedData;
        }

        // GET: api/Sebmacroeconomics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sebmacroeconomic>> GetSebmacroeconomics(int id)
        {
            if (_context.Sebmacroeconomics == null)
            {
                return NotFound();
            }
            var sebmacroeconomic = await _context.Sebmacroeconomics.FindAsync(id);

            if (sebmacroeconomic == null)
            {
                return NotFound();
            }

            return sebmacroeconomic;
        }
        [HttpGet("GetSebMacroeconomictByyear")]
        public async Task<ActionResult<IEnumerable<Sebmacroeconomic>>> GetSebMacroeconomictByyear([FromQuery] string year)
        {
            if (_context.Sebmacroeconomics == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var CreditRisk = await _context.Sebmacroeconomics.Where(x => x.Year == year).ToListAsync();

            if (CreditRisk == null)
            {
                return NotFound();
            }

            return CreditRisk;
        }

        // Fetching Data of 40 years
        [HttpGet("GetSebMacroeconomicofFourtyYears")]
        public async Task<ActionResult<IEnumerable<Sebmacroeconomic>>> GetSebMacroeconomicofFourtyYears()
        {
            if (_context.Sebmacroeconomics == null)
            {
                return NotFound();
            }

            var sortedData = await _context.Sebmacroeconomics.OrderByDescending(risk => risk.Year).Take(40).ToListAsync();
            return sortedData;
        }
        // PUT: api/Sebmacroeconomics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebmacroeconomic(int id, Sebmacroeconomic sebmacroeconomic)
        {
            if (id != sebmacroeconomic.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebmacroeconomic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebmacroeconomicExists(id))
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

        // POST: api/Sebmacroeconomics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sebmacroeconomic>> PostSebmacroeconomic(Sebmacroeconomic sebmacroeconomic)
        {
            if (_context.Sebmacroeconomics == null)
            {
                return Problem("Entity set 'RiskApetiteContext.Sebmacroeconomics'  is null.");
            }
            _context.Sebmacroeconomics.Add(sebmacroeconomic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebmacroeconomic", new { id = sebmacroeconomic.Id }, sebmacroeconomic);
        }

        // DELETE: api/Sebmacroeconomics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebmacroeconomic(int id)
        {
            if (_context.Sebmacroeconomics == null)
            {
                return NotFound();
            }
            var sebmacroeconomic = await _context.Sebmacroeconomics.FindAsync(id);
            if (sebmacroeconomic == null)
            {
                return NotFound();
            }

            _context.Sebmacroeconomics.Remove(sebmacroeconomic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebmacroeconomicExists(int id)
        {
            return (_context.Sebmacroeconomics?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
