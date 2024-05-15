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
    public class SdbliquiditiesController : ControllerBase
    {
        private readonly RiskApetiteContext _context;

        public SdbliquiditiesController(RiskApetiteContext context)
        {
            _context = context;
        }

        // GET: api/Sdbliquidities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sdbliquidity>>> GetSdbliquidities()
        {
          if (_context.Sdbliquidities == null)
          {
              return NotFound();
          }
            return await _context.Sdbliquidities.ToListAsync();
        }

        // GET: api/Sdbliquidities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sdbliquidity>> GetSdbliquidity(int id)
        {
          if (_context.Sdbliquidities == null)
          {
              return NotFound();
          }
            var sdbliquidity = await _context.Sdbliquidities.FindAsync(id);

            if (sdbliquidity == null)
            {
                return NotFound();
            }

            return sdbliquidity;
        }

        // PUT: api/Sdbliquidities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSdbliquidity(int id, Sdbliquidity sdbliquidity)
        {
            if (id != sdbliquidity.IdNo)
            {
                return BadRequest();
            }

            _context.Entry(sdbliquidity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SdbliquidityExists(id))
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

        // POST: api/Sdbliquidities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sdbliquidity>> PostSdbliquidity(Sdbliquidity sdbliquidity)
        {
          if (_context.Sdbliquidities == null)
          {
              return Problem("Entity set 'RiskApetiteContext.Sdbliquidities'  is null.");
          }
            _context.Sdbliquidities.Add(sdbliquidity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSdbliquidity", new { id = sdbliquidity.IdNo }, sdbliquidity);
        }

        // DELETE: api/Sdbliquidities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSdbliquidity(int id)
        {
            if (_context.Sdbliquidities == null)
            {
                return NotFound();
            }
            var sdbliquidity = await _context.Sdbliquidities.FindAsync(id);
            if (sdbliquidity == null)
            {
                return NotFound();
            }

            _context.Sdbliquidities.Remove(sdbliquidity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("GetSdbLiquidityByyearandQuarter")]
        public async Task<ActionResult<IEnumerable<Sdbliquidity>>> GetSdbLiquidityByyearandQuarter([FromQuery] string year, [FromQuery] string quarter)
        {
            if (_context.Sdbliquidities == null)
            {
                return NotFound();
            }
            //List<OprationalRisk> OperationalRisk = new List<OprationalRisk>();

            var LiquidityRisk = await _context.Sdbliquidities.Where(x => x.Year == year && x.Quarter == quarter).ToListAsync();

            if (LiquidityRisk == null)
            {
                return NotFound();
            }

            return LiquidityRisk;
        }


        private bool SdbliquidityExists(int id)
        {
            return (_context.Sdbliquidities?.Any(e => e.IdNo == id)).GetValueOrDefault();
        }
    }
}
