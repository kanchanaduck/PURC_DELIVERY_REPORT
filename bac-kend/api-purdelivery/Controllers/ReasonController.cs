using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_purdelivery;
using Microsoft.AspNetCore.Authorization;

namespace api_purdelivery.Controllers
{
    [Authorize] 
    [Route("api/[controller]")]
    [ApiController]
    public class ReasonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReasonController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("PUR12/Domestic/Early")]
        public async Task<ActionResult<IEnumerable<T_Reason_Domestic_Early>>> get_pur12_domestic_early()
        {
            return await _context.T_Reason_Domestic_Early.ToListAsync();
        }
        [HttpPost("PUR12/Domestic/Early")]
        public async Task<ActionResult<IEnumerable<T_Reason_Domestic_Early>>> post_pur12_domestic_early(T_Reason_Domestic_Early reason)
        {
            _context.T_Reason_Domestic_Early.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_early", new { id = reason.id }, reason);
        }
        [HttpPut("PUR12/Domestic/Early/{id}")]
        public async Task<IActionResult> put_pur12_domestic_early(int id, T_Reason_Domestic_Early data)
        {
            var reason = await _context.T_Reason_Domestic_Early.FindAsync(id);
            reason.reason = data.reason;
            reason.upd_by = User.FindFirst("username").Value;
            reason.upd_dt = DateTime.Now;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Domestic_Early_Exists(id))
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
        [HttpDelete("PUR12/Domestic/Early/{id}")]
        public async Task<IActionResult> delete_pur12_domestic_early(int id)
        {
            var reason = await _context.T_Reason_Domestic_Early.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Domestic_Early.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("PUR12/Domestic/Delay")]
        public async Task<ActionResult<IEnumerable<T_Reason_Domestic_Delay>>> get_pur12_domestic_delay()
        {
            return await _context.T_Reason_Domestic_Delay.ToListAsync();
        }
        [HttpPost("PUR12/Domestic/Delay")]
        public async Task<ActionResult<IEnumerable<T_Reason_Domestic_Delay>>> post_pur12_domestic_delay(T_Reason_Domestic_Delay reason)
        {
            _context.T_Reason_Domestic_Delay.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_pur12_domestic_delay", new { id = reason.id }, reason);
        }
        [HttpPut("PUR12/Domestic/Delay/{id}")]
        public async Task<IActionResult> put_pur12_domestic_delay(int id, T_Reason_Domestic_Delay data)
        {
            var reason = await _context.T_Reason_Domestic_Delay.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Domestic_Delay_Exists(id))
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
        [HttpDelete("PUR12/Domestic/Delay/{id}")]
        public async Task<IActionResult> delete_pur12_domestic_delay(int id)
        {
            var reason = await _context.T_Reason_Domestic_Delay.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Domestic_Delay.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("PUR12/Domestic/ShortLT")]
        public async Task<ActionResult<IEnumerable<T_Reason_Domestic_ShortLT>>> get_pur12_domestic_shortlt()
        {
            return await _context.T_Reason_Domestic_ShortLT.ToListAsync();
        }
        [HttpPost("PUR12/Domestic/ShortLT")]
        public async Task<ActionResult<IEnumerable<T_Reason_Domestic_ShortLT>>> post_pur12_domestic_shortlt(T_Reason_Domestic_ShortLT reason)
        {
            _context.T_Reason_Domestic_ShortLT.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_shortlt", new { id = reason.id }, reason);
        }
        [HttpPut("PUR12/Domestic/ShortLT/{id}")]
        public async Task<IActionResult> put_pur12_domestic_shortlt(int id, T_Reason_Domestic_ShortLT data)
        {
            var reason = await _context.T_Reason_Domestic_ShortLT.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Domestic_ShortLT_Exists(id))
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
        [HttpDelete("PUR12/Domestic/ShortLT/{id}")]
        public async Task<IActionResult> delete_pur12_domestic_shortlt(int id)
        {
            var reason = await _context.T_Reason_Domestic_ShortLT.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Domestic_ShortLT.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("PUR12/Oversea/Early")]
        public async Task<ActionResult<IEnumerable<T_Reason_Oversea_Early>>> get_pur12_oversea_early()
        {
            return await _context.T_Reason_Oversea_Early.ToListAsync();
        }
        [HttpPost("PUR12/Oversea/Early")]
        public async Task<ActionResult<IEnumerable<T_Reason_Oversea_Early>>> post_pur12_oversea_early(T_Reason_Oversea_Early reason)
        {
            _context.T_Reason_Oversea_Early.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_early", new { id = reason.id }, reason);
        }
        [HttpPut("PUR12/Oversea/Early/{id}")]
        public async Task<IActionResult> put_pur12_oversea_early(int id, T_Reason_Oversea_Early data)
        {
            var reason = await _context.T_Reason_Oversea_Early.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Oversea_Early_Exists(id))
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
        [HttpDelete("PUR12/Oversea/Early/{id}")]
        public async Task<IActionResult> delete_pur12_oversea_early(int id)
        {
            var reason = await _context.T_Reason_Oversea_Early.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Oversea_Early.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("PUR12/Oversea/Delay")]
        public async Task<ActionResult<IEnumerable<T_Reason_Oversea_Delay>>> get_pur12_oversea_oversea_delay()
        {
            return await _context.T_Reason_Oversea_Delay.ToListAsync();
        }
        [HttpPost("PUR12/Oversea/Delay")]
        public async Task<ActionResult<IEnumerable<T_Reason_Oversea_Delay>>> post_pur12_oversea_delay(T_Reason_Oversea_Delay reason)
        {
            _context.T_Reason_Oversea_Delay.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_delay", new { id = reason.id }, reason);
        }
        [HttpPut("PUR12/Oversea/Delay/{id}")]
        public async Task<IActionResult> put_pur12_oversea_delay(int id, T_Reason_Oversea_Delay data)
        {
            var reason = await _context.T_Reason_Oversea_Delay.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Oversea_Delay_Exists(id))
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
        [HttpDelete("PUR12/Oversea/Delay/{id}")]
        public async Task<IActionResult> delete_pur12_oversea_delay(int id)
        {
            var reason = await _context.T_Reason_Oversea_Delay.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Oversea_Delay.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("PUR12/Oversea/ShortLT")]
        public async Task<ActionResult<IEnumerable<T_Reason_Oversea_ShortLT>>> get_pur12_oversea_shortlt()
        {
            return await _context.T_Reason_Oversea_ShortLT.ToListAsync();
        }
        [HttpPost("PUR12/Oversea/ShortLT")]
        public async Task<ActionResult<IEnumerable<T_Reason_Oversea_ShortLT>>> post_pur12_oversea_shortlt(T_Reason_Oversea_ShortLT reason)
        {
            _context.T_Reason_Oversea_ShortLT.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_shortlt", new { id = reason.id }, reason);
        }
        [HttpPut("PUR12/Oversea/ShortLT/{id}")]
        public async Task<IActionResult> put_pur12_oversea_shortlt(int id, T_Reason_Oversea_ShortLT data)
        {
            var reason = await _context.T_Reason_Oversea_ShortLT.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Oversea_ShortLT_Exists(id))
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
        [HttpDelete("PUR12/Oversea/ShortLT/{id}")]
        public async Task<IActionResult> delete_pur12_oversea_shortlt(int id)
        {
            var reason = await _context.T_Reason_Oversea_ShortLT.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Oversea_ShortLT.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("DelayDomestic")]
        public async Task<ActionResult<IEnumerable<T_Reason_DL_Domestic>>> get_delay_domestic()
        {
            return await _context.T_Reason_DL_Domestic.ToListAsync();
        }
        [HttpPost("DelayDomestic")]
        public async Task<ActionResult<IEnumerable<T_Reason_DL_Domestic>>> post_delay_domestic(T_Reason_DL_Domestic reason)
        {
            _context.T_Reason_DL_Domestic.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_delay_domestic", new { id = reason.id }, reason);
        }
        [HttpPut("DelayDomestic/{id}")]
        public async Task<IActionResult> put_delay_domestic(int id, T_Reason_DL_Domestic data)
        {
            var reason = await _context.T_Reason_DL_Domestic.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_DL_Domestic_Exists(id))
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
        [HttpDelete("DelayDomestic/{id}")]
        public async Task<IActionResult> delete_delay_domestic(int id)
        {
            var reason = await _context.T_Reason_DL_Domestic.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_DL_Domestic.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("DelayOversea")]
        public async Task<ActionResult<IEnumerable<T_Reason_DL_Oversea>>> get_delay_oversea()
        {
            return await _context.T_Reason_DL_Oversea.ToListAsync();
        }
        [HttpPost("DelayOversea")]
        public async Task<ActionResult<IEnumerable<T_Reason_DL_Oversea>>> post_delay_oversea(T_Reason_DL_Oversea reason)
        {
            _context.T_Reason_DL_Oversea.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_delay_oversea", new { id = reason.id }, reason);
        }
        [HttpPut("DelayOversea/{id}")]
        public async Task<IActionResult> put_delay_oversea(int id, T_Reason_DL_Oversea data)
        {
            var reason = await _context.T_Reason_DL_Oversea.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_DL_Oversea_Exists(id))
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
        [HttpDelete("DelayOversea/{id}")]
        public async Task<IActionResult> delete_delay_oversea(int id)
        {
            var reason = await _context.T_Reason_DL_Oversea.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_DL_Oversea.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("ControlEvalio")]
        public async Task<ActionResult<IEnumerable<T_Reason_Evalio>>> get_evalio()
        {
            return await _context.T_Reason_Evalio.ToListAsync();
        }
        [HttpGet("ControlEvalio/{id}")]
        public async Task<ActionResult<T_Reason_Evalio>> get_evalio(int id)
        {
            var reason = await _context.T_Reason_Evalio.FindAsync(id);

            if (reason == null)
            {
                return NotFound();
            }

            return reason;
        }
        [HttpPost("ControlEvalio")]
        public async Task<ActionResult<T_Reason_Evalio>> post_evalio(T_Reason_Evalio reason)
        {
            _context.T_Reason_Evalio.Add(reason);
            await _context.SaveChangesAsync();

            return CreatedAtAction("get_evalio", new { id = reason.id }, reason);
        }
        [HttpPut("ControlEvalio/{id}")]
        public async Task<IActionResult> put_evalio(int id, T_Reason_Evalio data)
        {
            var reason = await _context.T_Reason_Evalio.FindAsync(id);
            reason.reason = data.reason;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Reason_Evalio_Exists(id))
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
        [HttpDelete("ControlEvalio/{id}")]
        public async Task<IActionResult> delete_evalio(int id)
        {
            var reason = await _context.T_Reason_Evalio.FindAsync(id);
            if (reason == null)
            {
                return NotFound();
            }

            _context.T_Reason_Evalio.Remove(reason);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool T_Reason_Domestic_Early_Exists(int id)
        {
            return _context.T_Reason_Domestic_Early.Any(e => e.id == id);
        }
        private bool T_Reason_Domestic_Delay_Exists(int id)
        {
            return _context.T_Reason_Domestic_Delay.Any(e => e.id == id);
        }
        private bool T_Reason_Domestic_ShortLT_Exists(int id)
        {
            return _context.T_Reason_Domestic_ShortLT.Any(e => e.id == id);
        }
        private bool T_Reason_Oversea_Early_Exists(int id)
        {
            return _context.T_Reason_Oversea_Early.Any(e => e.id == id);
        }
        private bool T_Reason_Oversea_Delay_Exists(int id)
        {
            return _context.T_Reason_Oversea_Delay.Any(e => e.id == id);
        }
        private bool T_Reason_Oversea_ShortLT_Exists(int id)
        {
            return _context.T_Reason_Oversea_ShortLT.Any(e => e.id == id);
        }
        private bool T_Reason_DL_Domestic_Exists(int id)
        {
            return _context.T_Reason_DL_Domestic.Any(e => e.id == id);
        }
        private bool T_Reason_DL_Oversea_Exists(int id)
        {
            return _context.T_Reason_DL_Oversea.Any(e => e.id == id);
        }
        private bool T_Reason_Evalio_Exists(int id)
        {
            return _context.T_Reason_Evalio.Any(e => e.id == id);
        }
    }
}
