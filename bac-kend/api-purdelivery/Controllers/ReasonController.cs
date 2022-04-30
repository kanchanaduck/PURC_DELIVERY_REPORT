using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_purdelivery;

namespace api_purdelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReasonController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public ReasonController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: api/Reason
       [HttpGet("get_reason_delay")]
        public async Task<ActionResult<IEnumerable<T_Reason_Delay>>> GetT_Reason_Delay()
        {
            return await _context.T_Reason_Delay.ToListAsync();
        }

        [HttpGet("get_reason_dl_domestic")]
        public async Task<ActionResult<IEnumerable<T_Reason_DL_Domestic>>> GetT_Reason_dl_domestic()
        {
            return await _context.T_Reason_DL_Domestic.ToListAsync();
        }

        [HttpGet("get_reason_dl_oversea")]
        public async Task<ActionResult<IEnumerable<T_Reason_DL_Oversea>>> GetT_Reason_dl_Oversea()
        {
            return await _context.T_Reason_DL_Oversea.ToListAsync();
        }

       [HttpGet("get_reason_early")]
        public async Task<ActionResult<IEnumerable<T_Reason_Early>>> GetT_Reason_Early()
        {
            return await _context.T_Reason_Early.ToListAsync();
        }

        [HttpGet("get_reason_dl_evalio")]
        public async Task<ActionResult<IEnumerable<T_Reason_Evalio>>> GetT_Reason_Evalio()
        {
            return await _context.T_Reason_Evalio.ToListAsync();
        }

         [HttpGet("get_reason_dl_shortLT")]
        public async Task<ActionResult<IEnumerable<T_Reason_ShortLT>>> GetT_Reason_ShortLT()
        {
            return await _context.T_Reason_ShortLT.ToListAsync();
        }
        // GET: api/Reason/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T_Reason_Delay>> GetT_Reason_Delay(int id)
        {
            var t_Reason_Delay = await _context.T_Reason_Delay.FindAsync(id);

            if (t_Reason_Delay == null)
            {
                return NotFound();
            }

            return t_Reason_Delay;
        }

        // PUT: api/Reason/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutT_Reason_Delay(int id, T_Reason_Delay t_Reason_Delay)
        {
            if (id != t_Reason_Delay.id)
            {
                return BadRequest();
            }

            _context.Entry(t_Reason_Delay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_DelayExists(id))
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

        // POST: api/Reason
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<T_Reason_Delay>> PostT_Reason_Delay(T_Reason_Delay t_Reason_Delay)
        {
            _context.T_Reason_Delay.Add(t_Reason_Delay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetT_Reason_Delay", new { id = t_Reason_Delay.id }, t_Reason_Delay);
        }

        // DELETE: api/Reason/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteT_Reason_Delay(int id)
        {
            var t_Reason_Delay = await _context.T_Reason_Delay.FindAsync(id);
            if (t_Reason_Delay == null)
            {
                return NotFound();
            }

            _context.T_Reason_Delay.Remove(t_Reason_Delay);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool T_Reason_DelayExists(int id)
        {
            return _context.T_Reason_Delay.Any(e => e.id == id);
        }
    }
}
