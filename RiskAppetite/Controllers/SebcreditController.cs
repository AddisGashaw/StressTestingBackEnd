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
    public class SebcreditController : Controller
    {
        private readonly RiskApetiteContext _context;

        public SebcreditController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebcreditRisks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebcreditRisk>>> GetSebcredits()
        {
            if (_context.SebcreditRisks == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebcreditRisks.OrderBy(risk => risk.Year).ToListAsync();
            return sortedData;
        }

        // GET: api/SebcreditRisks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebcreditRisk>> GetSebcredits(int id)
        {
            if (_context.SebcreditRisks == null)
            {
                return NotFound();
            }
            var sebcredit = await _context.SebcreditRisks.FindAsync(id);

            if (sebcredit == null)
            {
                return NotFound();
            }

            return sebcredit;
        }
        [HttpGet("GetSebCredittByyear")]
        public async Task<ActionResult<IEnumerable<SebcreditRisk>>> GetSebCredittByyear([FromQuery] string year)
        {
            if (_context.SebcreditRisks == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var CreditRisk = await _context.SebcreditRisks.Where(x => x.Year == year).ToListAsync();

            if (CreditRisk == null)
            {
                return NotFound();
            }

            return CreditRisk;
        }

        // Fetching Data of 40 years
        [HttpGet("GetSebCreditofFourtyYears")]
        public async Task<ActionResult<IEnumerable<SebcreditRisk>>> GetSebCreditofFourtyYears()
        {
            if (_context.SebcreditRisks == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebcreditRisks.OrderByDescending(risk => risk.Year).Take(40).ToListAsync();
            return sortedData;
        }
        // PUT: api/SebcreditRisks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebcredit(int id, SebcreditRisk sebcredit)
        {
            if (id != sebcredit.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebcredit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebcreditExists(id))
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

        // POST: api/SebcreditRisks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebcreditRisk>> PostSebcredit(SebcreditRisk sebcredit)
        {
            if (_context.SebcreditRisks == null)
            {
                return Problem("Entity set 'RiskApetiteContext.Sebcredits'  is null.");
            }
            _context.SebcreditRisks.Add(sebcredit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebcredit", new { id = sebcredit.Id }, sebcredit);
        }

        // DELETE: api/SebcreditRisks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebcredit(int id)
        {
            if (_context.SebcreditRisks == null)
            {
                return NotFound();
            }
            var sebcredit = await _context.SebcreditRisks.FindAsync(id);
            if (sebcredit == null)
            {
                return NotFound();
            }

            _context.SebcreditRisks.Remove(sebcredit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebcreditExists(int id)
        {
            return (_context.SebcreditRisks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
