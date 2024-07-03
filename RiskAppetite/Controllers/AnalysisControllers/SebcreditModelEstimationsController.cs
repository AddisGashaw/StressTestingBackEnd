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
    public class SebcreditModelEstimationsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SebcreditModelEstimationsController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/SebcreditModelEstimations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SebcreditModelEstimation>>> GetSebcreditModelEstimations()
        {
          if (_context.SebcreditModelEstimations == null)
          {
              return NotFound();
          }
            return await _context.SebcreditModelEstimations.ToListAsync();
        }

        // GET: api/SebcreditModelEstimations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SebcreditModelEstimation>> GetSebcreditModelEstimation(int id)
        {
          if (_context.SebcreditModelEstimations == null)
          {
              return NotFound();
          }
            var sebcreditModelEstimation = await _context.SebcreditModelEstimations.FindAsync(id);

            if (sebcreditModelEstimation == null)
            {
                return NotFound();
            }

            return sebcreditModelEstimation;
        }

        // PUT: api/SebcreditModelEstimations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSebcreditModelEstimation(int id, SebcreditModelEstimation sebcreditModelEstimation)
        {
            if (id != sebcreditModelEstimation.Id)
            {
                return BadRequest();
            }

            _context.Entry(sebcreditModelEstimation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SebcreditModelEstimationExists(id))
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
        [HttpGet("SebcreditModelEstimation")]
        public async Task<ActionResult<IEnumerable<SebcreditModelEstimation>>> GetCreditEstimation(string year, string quarter)
        {
            if (_context.SebcreditModelEstimations == null)
            {
                return NotFound();
            }
            int quarterValue = ConvertRomanToArabic(quarter);
            var creditEstimation = new List<SebcreditModelEstimation>();

            for (int i = quarterValue; i >= 1; i--)
            {
                var presentQuarter = ConvertNumberToArabic(i);
                var data = await _context.SebcreditModelEstimations
                    .Where(x => x.Year == year && x.Quarter == presentQuarter)
                    .ToListAsync();

                if (data.Any())
                {
                    creditEstimation.AddRange(data);
                    break;
                }
            }
            

            return Ok(creditEstimation);
        }

        // POST: api/SebcreditModelEstimations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SebcreditModelEstimation>> PostSebcreditModelEstimation(SebcreditModelEstimation sebcreditModelEstimation)
        {
          if (_context.SebcreditModelEstimations == null)
          {
              return Problem("Entity set 'RiskApetiteContext.SebcreditModelEstimations'  is null.");
          }
            _context.SebcreditModelEstimations.Add(sebcreditModelEstimation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSebcreditModelEstimation", new { id = sebcreditModelEstimation.Id }, sebcreditModelEstimation);
        }

        // DELETE: api/SebcreditModelEstimations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSebcreditModelEstimation(int id)
        {
            if (_context.SebcreditModelEstimations == null)
            {
                return NotFound();
            }
            var sebcreditModelEstimation = await _context.SebcreditModelEstimations.FindAsync(id);
            if (sebcreditModelEstimation == null)
            {
                return NotFound();
            }

            _context.SebcreditModelEstimations.Remove(sebcreditModelEstimation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SebcreditModelEstimationExists(int id)
        {
            return (_context.SebcreditModelEstimations?.Any(e => e.Id == id)).GetValueOrDefault();
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
