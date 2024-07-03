using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;

namespace RiskAppetite.Controllers.AnalysisControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SebliquidityModelEstimationsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SebliquidityModelEstimationsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebliquidityModelEstimations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebliquidityModelEstimation>>> GetSebliquidityModelEstimations()
        {
          if (_context.SebliquidityModelEstimations == null)
          {
              return NotFound();
          }
            return await _context.SebliquidityModelEstimations.ToListAsync();
        }

        // GET: api/SebliquidityModelEstimations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebliquidityModelEstimation>> GetSebliquidityModelEstimation(int id)
        {
          if (_context.SebliquidityModelEstimations == null)
          {
              return NotFound();
          }
            var sebliquidityModelEstimation = await _context.SebliquidityModelEstimations.FindAsync(id);

            if (sebliquidityModelEstimation == null)
            {
                return NotFound();
            }

            return sebliquidityModelEstimation;
        }

        // PUT: api/SebliquidityModelEstimations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebliquidityModelEstimation(int id, SebliquidityModelEstimation sebliquidityModelEstimation)
        {
            if (id != sebliquidityModelEstimation.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebliquidityModelEstimation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebliquidityModelEstimationExists(id))
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

        // POST: api/SebliquidityModelEstimations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebliquidityModelEstimation>> PostSebliquidityModelEstimation(SebliquidityModelEstimation sebliquidityModelEstimation)
        {
          if (_context.SebliquidityModelEstimations == null)
          {
              return Problem("Entity set 'RiskApetiteContext.SebliquidityModelEstimations'  is null.");
          }
            _context.SebliquidityModelEstimations.Add(sebliquidityModelEstimation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebliquidityModelEstimation", new { id = sebliquidityModelEstimation.Id }, sebliquidityModelEstimation);
        }
        [HttpGet("SebliquidityModelEstimation")]
        public async Task<ActionResult<IEnumerable<SebliquidityModelEstimation>>> GetLiquidityEstimation(string year, string quarter)
        {
            if (_context.SebliquidityModelEstimations == null)
            {
                return NotFound();
            }
            int quarterValue = ConvertRomanToArabic(quarter);
            var liquidityEstimation = new List<SebliquidityModelEstimation>();

            for (int i = quarterValue; i >= 1; i--)
            {
                var presentQuarter = ConvertNumberToArabic(i);
                var data = await _context.SebliquidityModelEstimations
                    .Where(x => x.Year == year && x.Quarter == presentQuarter)
                    .ToListAsync();

                if (data.Any())
                {
                    liquidityEstimation.AddRange(data);
                    break;
                }
            }


            return Ok(liquidityEstimation);
        }
        // DELETE: api/SebliquidityModelEstimations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebliquidityModelEstimation(int id)
        {
            if (_context.SebliquidityModelEstimations == null)
            {
                return NotFound();
            }
            var sebliquidityModelEstimation = await _context.SebliquidityModelEstimations.FindAsync(id);
            if (sebliquidityModelEstimation == null)
            {
                return NotFound();
            }

            _context.SebliquidityModelEstimations.Remove(sebliquidityModelEstimation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebliquidityModelEstimationExists(int id)
        {
            return (_context.SebliquidityModelEstimations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public static int ConvertRomanToArabic(string Quarter)
        {
            switch (Quarter)
            {
                case "QI":
                    return 1;
                case "QII":
                    return 2;
                case "QIII":
                    return 3;
                case "QIV":
                    return 4;
                default:
                    return -1;
            }
        }
        public static string ConvertNumberToArabic(int Quarter)
        {
            switch (Quarter)
            {
                case 1:
                    return "QI";
                case 2:
                    return "QII";
                case 3:
                    return "QIII";
                case 4:
                    return "QIV";
                default:
                    return null;
            }
        }
    }
}
