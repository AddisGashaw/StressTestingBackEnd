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
    public class SdbforcastFinancialStatmentsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SdbforcastFinancialStatmentsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SdbforcastFinancialStatments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SdbforcastFinancialStatment>>> GetSdbforcastFinancialStatments()
        {
          if (_context.SdbforcastFinancialStatments == null)
          {
              return NotFound();
          }
            return await _context.SdbforcastFinancialStatments.ToListAsync();
        }

        // GET: api/SdbforcastFinancialStatments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SdbforcastFinancialStatment>> GetSdbforcastFinancialStatment(int id)
        {
          if (_context.SdbforcastFinancialStatments == null)
          {
              return NotFound();
          }
            var sdbforcastFinancialStatment = await _context.SdbforcastFinancialStatments.FindAsync(id);

            if (sdbforcastFinancialStatment == null)
            {
                return NotFound();
            }

            return sdbforcastFinancialStatment;
        }

        // PUT: api/SdbforcastFinancialStatments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSdbforcastFinancialStatment(int id, SdbforcastFinancialStatment sdbforcastFinancialStatment)
        {
            if (id != sdbforcastFinancialStatment.Id)
            {
                return BadRequest();
            }

            _context.Entry(sdbforcastFinancialStatment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SdbforcastFinancialStatmentExists(id))
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

        // POST: api/SdbforcastFinancialStatments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SdbforcastFinancialStatment>> PostSdbforcastFinancialStatment(SdbforcastFinancialStatment sdbforcastFinancialStatment)
        {
          if (_context.SdbforcastFinancialStatments == null)
          {
              return Problem("Entity set 'RiskApetiteContext.SdbforcastFinancialStatments'  is null.");
          }
            _context.SdbforcastFinancialStatments.Add(sdbforcastFinancialStatment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSdbforcastFinancialStatment", new { id = sdbforcastFinancialStatment.Id }, sdbforcastFinancialStatment);
        }

        // DELETE: api/SdbforcastFinancialStatments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSdbforcastFinancialStatment(int id)
        {
            if (_context.SdbforcastFinancialStatments == null)
            {
                return NotFound();
            }
            var sdbforcastFinancialStatment = await _context.SdbforcastFinancialStatments.FindAsync(id);
            if (sdbforcastFinancialStatment == null)
            {
                return NotFound();
            }

            _context.SdbforcastFinancialStatments.Remove(sdbforcastFinancialStatment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("GetSdbforcastByyearandQuarter")]
        public async Task<ActionResult<IEnumerable<SdbforcastFinancialStatment>>> GetSdbforcastByyearandQuarter ([FromQuery] string year, [FromQuery] string quarter)
        {
            if (_context.SdbforcastFinancialStatments == null)
            {
                return NotFound();
            }
            List<SdbforcastFinancialStatment> sdbforcastFinancialStatment = new List<SdbforcastFinancialStatment>();
            
            var yearseparated=year.Split('/');
            int selectedYear = Convert.ToInt32(yearseparated[0]); 
            int startYear = selectedYear;
            int endYear = selectedYear + 1;

            string fiscalYear ="";
            if (quarter== "QIV")
            {
                fiscalYear = $"{(startYear+1)}/{(endYear+1).ToString().Substring(2)}";
                sdbforcastFinancialStatment = await _context.SdbforcastFinancialStatments
               .Where(x => x.Year == fiscalYear && x.Quarter == "QI")
               .ToListAsync();
            }
            else if (quarter=="QII") 
            {
              sdbforcastFinancialStatment = await _context.SdbforcastFinancialStatments
              .Where(x => x.Year == year && x.Quarter == "QIII")
              .ToListAsync();
            }
            else if (quarter == "QIII")
            {
               sdbforcastFinancialStatment = await _context.SdbforcastFinancialStatments
              .Where(x => x.Year == year && x.Quarter == "QIV")
              .ToListAsync();
            }
            else
            {
                sdbforcastFinancialStatment = await _context.SdbforcastFinancialStatments
                   .Where(x => x.Year == year && x.Quarter == "QII")
                   .ToListAsync();
            }
            if (sdbforcastFinancialStatment == null)
            {
                return NotFound();
            }

            return sdbforcastFinancialStatment;
        }
        private bool SdbforcastFinancialStatmentExists(int id)
        {
            return (_context.SdbforcastFinancialStatments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
