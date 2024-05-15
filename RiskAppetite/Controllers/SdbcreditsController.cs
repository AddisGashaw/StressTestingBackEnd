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
    public class SdbcreditsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SdbcreditsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/Sdbcredits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sdbcredit>>> GetSdbcredits()
        {
          if (_context.Sdbcredits == null)
          {
              return NotFound();
          }
            return await _context.Sdbcredits.ToListAsync();
        }

        // GET: api/Sdbcredits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sdbcredit>> GetSdbcredit(int id)
        {
          if (_context.Sdbcredits == null)
          {
              return NotFound();
          }
            var sdbcredit = await _context.Sdbcredits.FindAsync(id);

            if (sdbcredit == null)
            {
                return NotFound();
            }

            return sdbcredit;
        }
        [HttpGet("GetSdbCredittByyearandQuarter")]
        public async Task<ActionResult<IEnumerable<Sdbcredit>>> GetSdbCredittByyearandQuarter([FromQuery] string year, [FromQuery] string quarter)
        {
            if (_context.Sdbcredits == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var CreditRisk = await _context.Sdbcredits.Where(x => x.Year == year && x.Quarter == quarter).ToListAsync();

            if (CreditRisk == null)
            {
                return NotFound();
            }

            return CreditRisk;
        }
        // PUT: api/Sdbcredits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSdbcredit(int id, Sdbcredit sdbcredit)
        {
            if (id != sdbcredit.Id)
            {
                return BadRequest();
            }

            _context.Entry(sdbcredit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SdbcreditExists(id))
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
        public async Task<ActionResult<Sdbcredit>> PostSdbcredit(Sdbcredit sdbcredit)
        {
          if (_context.Sdbcredits == null)
          {
              return Problem("Entity set 'RiskApetiteContext.Sdbcredits'  is null.");
          }
            _context.Sdbcredits.Add(sdbcredit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSdbcredit", new { id = sdbcredit.Id }, sdbcredit);
        }

        // DELETE: api/Sdbcredits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSdbcredit(int id)
        {
            if (_context.Sdbcredits == null)
            {
                return NotFound();
            }
            var sdbcredit = await _context.Sdbcredits.FindAsync(id);
            if (sdbcredit == null)
            {
                return NotFound();
            }

            _context.Sdbcredits.Remove(sdbcredit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SdbcreditExists(int id)
        {
            return (_context.Sdbcredits?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
