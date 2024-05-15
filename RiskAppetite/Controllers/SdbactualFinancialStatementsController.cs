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
    public class SdbactualFinancialStatementsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SdbactualFinancialStatementsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SdbactualFinancialStatements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SdbactualFinancialStatement>>> GetSdbactualFinancialStatements()
        {
          if (_context.SdbactualFinancialStatements == null)
          {
              return NotFound();
          }
            return await _context.SdbactualFinancialStatements.ToListAsync();
        }

        // GET: api/SdbactualFinancialStatements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SdbactualFinancialStatement>> GetSdbactualFinancialStatement(int id)
        {
          if (_context.SdbactualFinancialStatements == null)
          {
              return NotFound();
          }
            var sdbactualFinancialStatement = await _context.SdbactualFinancialStatements.FindAsync(id);

            if (sdbactualFinancialStatement == null)
            {
                return NotFound();
            }

            return sdbactualFinancialStatement;
        }

        // PUT: api/SdbactualFinancialStatements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSdbactualFinancialStatement(int id, SdbactualFinancialStatement sdbactualFinancialStatement)
        {
            if (id != sdbactualFinancialStatement.Id)
            {
                return BadRequest();
            }

            _context.Entry(sdbactualFinancialStatement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SdbactualFinancialStatementExists(id))
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

        // POST: api/SdbactualFinancialStatements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SdbactualFinancialStatement>> PostSdbactualFinancialStatement(SdbactualFinancialStatement sdbactualFinancialStatement)
        {
          if (_context.SdbactualFinancialStatements == null)
          {
              return Problem("Entity set 'RiskApetiteContext.SdbactualFinancialStatements'  is null.");
          }
            _context.SdbactualFinancialStatements.Add(sdbactualFinancialStatement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSdbactualFinancialStatement", new { id = sdbactualFinancialStatement.Id }, sdbactualFinancialStatement);
        }

        // DELETE: api/SdbactualFinancialStatements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSdbactualFinancialStatement(int id)
        {
            if (_context.SdbactualFinancialStatements == null)
            {
                return NotFound();
            }
            var sdbactualFinancialStatement = await _context.SdbactualFinancialStatements.FindAsync(id);
            if (sdbactualFinancialStatement == null)
            {
                return NotFound();
            }

            _context.SdbactualFinancialStatements.Remove(sdbactualFinancialStatement);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("GetSdbActualFinancialStatmentByYearandQuarter")]
        public async Task<ActionResult<IEnumerable<SdbactualFinancialStatement>>> GetSdbActualFinancialByyearandQuarter([FromQuery] string year, [FromQuery] string quarter)
        {
            if (_context.SdbactualFinancialStatements == null)
            {
                return NotFound();
            }
            var SdbactualFinancial = await _context.SdbactualFinancialStatements.Where(x => x.Year == year && x.Quarter == quarter).ToListAsync();

            if (SdbactualFinancial == null)
            {
                return NotFound();
            }

            return SdbactualFinancial;
        }

        private bool SdbactualFinancialStatementExists(int id)
        {
            return (_context.SdbactualFinancialStatements?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
