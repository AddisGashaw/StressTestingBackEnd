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
    public class Sebforcasted_financial_statmentController : Controller
    {
        private readonly RiskApetiteContext _context;

        public Sebforcasted_financial_statmentController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebforcastedFinancialStatements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebforcastedFinancialStatement>>> GetSebforcastedFinancialStatements()
        {
            if (_context.SebforcastedFinancialStatements == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebforcastedFinancialStatements.OrderBy(risk => risk.ForcastedYear).ToListAsync();
            return sortedData;
        }

        // GET: api/SebforcastedFinancialStatements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebforcastedFinancialStatement>> GetSebforcastedFinancialStatements(int id)
        {
            if (_context.SebforcastedFinancialStatements == null)
            {
                return NotFound();
            }
            var sebforcastedFinancialStatement = await _context.SebforcastedFinancialStatements.FindAsync(id);

            if (sebforcastedFinancialStatement == null)
            {
                return NotFound();
            }

            return sebforcastedFinancialStatement;
        }
        [HttpGet("GetSebForcastedFinancialStatementtByyear")]
        public async Task<ActionResult<IEnumerable<SebforcastedFinancialStatement>>> GetSebForcastedFinancialStatementtByyear([FromQuery] string year)
        {
            if (_context.SebforcastedFinancialStatements == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var CreditRisk = await _context.SebforcastedFinancialStatements.Where(x => x.ForcastedYear == year).ToListAsync();

            if (CreditRisk == null)
            {
                return NotFound();
            }

            return CreditRisk;
        }

        // Fetching Data of 40 years
        [HttpGet("GetSebForcasted_financial_statmentOfFourtyYears")]
        public async Task<ActionResult<IEnumerable<SebforcastedFinancialStatement>>> GetSebForcasted_financial_statmentOfFourtyYears()
        {
            if (_context.SebforcastedFinancialStatements == null)
            {
                return NotFound();
            }

            var sortedData = await _context.SebforcastedFinancialStatements.OrderByDescending(risk => risk.ForcastedYear).Take(40).ToListAsync();
            return sortedData;
        }
        // PUT: api/SebforcastedFinancialStatements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebforcastedFinancialStatement(int id, SebforcastedFinancialStatement sebforcastedFinancialStatement)
        {
            if (id != sebforcastedFinancialStatement.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebforcastedFinancialStatement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebforcastedFinancialStatementExists(id))
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

        // POST: api/SebforcastedFinancialStatements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebforcastedFinancialStatement>> PostSebforcastedFinancialStatement(SebforcastedFinancialStatement sebforcastedFinancialStatement)
        {
            if (_context.SebforcastedFinancialStatements == null)
            {
                return Problem("Entity set 'RiskApetiteContext.SebforcastedFinancialStatements'  is null.");
            }
            _context.SebforcastedFinancialStatements.Add(sebforcastedFinancialStatement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebforcastedFinancialStatement", new { id = sebforcastedFinancialStatement.Id }, sebforcastedFinancialStatement);
        }

        // DELETE: api/SebforcastedFinancialStatements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebforcastedFinancialStatement(int id)
        {
            if (_context.SebforcastedFinancialStatements == null)
            {
                return NotFound();
            }
            var sebforcastedFinancialStatement = await _context.SebforcastedFinancialStatements.FindAsync(id);
            if (sebforcastedFinancialStatement == null)
            {
                return NotFound();
            }

            _context.SebforcastedFinancialStatements.Remove(sebforcastedFinancialStatement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebforcastedFinancialStatementExists(int id)
        {
            return (_context.SebforcastedFinancialStatements?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
