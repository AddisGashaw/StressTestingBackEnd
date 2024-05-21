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

        // GET: api/Sdbcredits
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

        // GET: api/Sdbcredits/5
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
        // PUT: api/Sdbcredits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebcredit(int id, Sdbcredit sebcredit)
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

        // POST: api/Sdbcredits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sdbcredit>> PostSebcredit(SebcreditRisk sebcredit)
        {
            if (_context.SebcreditRisks == null)
            {
                return Problem("Entity set 'RiskApetiteContext.Sebcredits'  is null.");
            }
            _context.SebcreditRisks.Add(sebcredit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebcredit", new { id = sebcredit.Id }, sebcredit);
        }

        // DELETE: api/Sdbcredits/5
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
