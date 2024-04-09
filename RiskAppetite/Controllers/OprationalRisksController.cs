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
    public class OprationalRisksController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public OprationalRisksController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/OprationalRisks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OprationalRisk>>> GetOprationalRisks()
        {
          if (_context.OprationalRisks == null)
          {
              return NotFound();
          }
            return await _context.OprationalRisks.ToListAsync();
        }

        // GET: api/OprationalRisks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OprationalRisk>> GetOprationalRisk(int id)
        {
          if (_context.OprationalRisks == null)
          {
              return NotFound();
          }
            var oprationalRisk = await _context.OprationalRisks.FindAsync(id);

            if (oprationalRisk == null)
            {
                return NotFound();
            }

            return oprationalRisk;
        }
        [HttpGet("GetSdbOperationalByyearandQuarter")]
        public async Task<ActionResult<IEnumerable<OprationalRisk>>> GetSdbOperationalByyearandQuarter([FromQuery] string year, [FromQuery] string quarter)
        {
            if (_context.OprationalRisks == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var oprationalRisk = await _context.OprationalRisks.Where(x=>x.Year== year && x.Quarter== quarter).ToListAsync();

            if (oprationalRisk == null)
            {
                return NotFound();
            }

            return oprationalRisk;
        }


        // PUT: api/OprationalRisks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOprationalRisk(int id, OprationalRisk oprationalRisk)
        {
            if (id != oprationalRisk.Id)
            {
                return BadRequest();
            }

            _context.Entry(oprationalRisk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OprationalRiskExists(id))
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

        // POST: api/OprationalRisks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OprationalRisk>> PostOprationalRisk(OprationalRisk oprationalRisk)
        {
          if (_context.OprationalRisks == null)
          {
              return Problem("Entity set 'RiskApetiteContext.OprationalRisks'  is null.");
          }
            _context.OprationalRisks.Add(oprationalRisk);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOprationalRisk", new { id = oprationalRisk.Id }, oprationalRisk);
        }

        // DELETE: api/OprationalRisks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOprationalRisk(int id)
        {
            if (_context.OprationalRisks == null)
            {
                return NotFound();
            }
            var oprationalRisk = await _context.OprationalRisks.FindAsync(id);
            if (oprationalRisk == null)
            {
                return NotFound();
            }

            _context.OprationalRisks.Remove(oprationalRisk);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OprationalRiskExists(int id)
        {
            return (_context.OprationalRisks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
       
    }
}
