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
    public class SebmarketModelEstimationsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SebmarketModelEstimationsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebmarketModelEstimations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebmarketModelEstimation>>> GetSebmarketModelEstimations()
        {
          if (_context.SebmarketModelEstimations == null)
          {
              return NotFound();
          }
            return await _context.SebmarketModelEstimations.ToListAsync();
        }

        // GET: api/SebmarketModelEstimations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebmarketModelEstimation>> GetSebmarketModelEstimation(int id)
        {
          if (_context.SebmarketModelEstimations == null)
          {
              return NotFound();
          }
            var sebmarketModelEstimation = await _context.SebmarketModelEstimations.FindAsync(id);

            if (sebmarketModelEstimation == null)
            {
                return NotFound();
            }

            return sebmarketModelEstimation;
        }

        // PUT: api/SebmarketModelEstimations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebmarketModelEstimation(int id, SebmarketModelEstimation sebmarketModelEstimation)
        {
            if (id != sebmarketModelEstimation.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebmarketModelEstimation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebmarketModelEstimationExists(id))
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
        [HttpGet("SebmarketModelEstimation")]
        public async Task<ActionResult<IEnumerable<SebmarketModelEstimation>>> GetMarketEstimation(string year, string quarter)
        {
            if (_context.SebmarketModelEstimations == null)
            {
                return NotFound();
            }
            int quarterValue = ConvertRomanToArabic(quarter);
            var marketEstimation = new List<SebmarketModelEstimation>();

            for (int i = quarterValue; i >= 1; i--)
            {
                var presentQuarter = ConvertNumberToArabic(i);
                var data = await _context.SebmarketModelEstimations
                    .Where(x => x.Year == year && x.Quarter == presentQuarter)
                    .ToListAsync();

                if (data.Any())
                {
                    marketEstimation.AddRange(data);
                    break;
                }
            }


            return Ok(marketEstimation);
        }
        // POST: api/SebmarketModelEstimations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebmarketModelEstimation>> PostSebmarketModelEstimation(SebmarketModelEstimation sebmarketModelEstimation)
        {
          if (_context.SebmarketModelEstimations == null)
          {
              return Problem("Entity set 'RiskApetiteContext.SebmarketModelEstimations'  is null.");
          }
            _context.SebmarketModelEstimations.Add(sebmarketModelEstimation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebmarketModelEstimation", new { id = sebmarketModelEstimation.Id }, sebmarketModelEstimation);
        }

        // DELETE: api/SebmarketModelEstimations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebmarketModelEstimation(int id)
        {
            if (_context.SebmarketModelEstimations == null)
            {
                return NotFound();
            }
            var sebmarketModelEstimation = await _context.SebmarketModelEstimations.FindAsync(id);
            if (sebmarketModelEstimation == null)
            {
                return NotFound();
            }

            _context.SebmarketModelEstimations.Remove(sebmarketModelEstimation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebmarketModelEstimationExists(int id)
        {
            return (_context.SebmarketModelEstimations?.Any(e => e.Id == id)).GetValueOrDefault();
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
