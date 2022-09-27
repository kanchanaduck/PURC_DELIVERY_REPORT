using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using api_purdelivery;
using api_purdelivery.Repository;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

namespace api_purdelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PUR3Controller : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        private readonly IRepository _repository;

        public PUR3Controller(ApplicationDbContext context, IRepository repository, IConfiguration config)
        {
            _config = config;
            _context = context;
            _repository = repository;
        }
        [HttpGet("ControlDomestic")]
        public async Task<ActionResult<IEnumerable<T_Control_Domestic>>> get_control_domestic(string subject)
        {
            var data = await _context.T_Control_Domestic.Where(e=>e.subject==subject)
                .ToListAsync();
            
            if(data==null){
                return NotFound();
            }

            return data;
        }
        [HttpGet("ControlDomestic/Subject")]
        public async Task<ActionResult> get_control_domestic_subject()
        {
            return Ok(await _context.T_Control_Domestic
                    .Select(e => e.subject).Distinct()
                    .OrderByDescending(e => e)
                    .ToArrayAsync());
        }
        [HttpGet("ControlOversea")]
        public async Task<ActionResult<IEnumerable<T_Control_Oversea>>> get_control_oversea(string subject)
        {
            var data = await _context.T_Control_Oversea.Where(e=>e.subject==subject)
                .ToListAsync();
            
            if(data==null){
                return NotFound();
            }

            return data;
        }
        [HttpGet("ControlOversea/Subject")]
        public async Task<ActionResult> get_control_oversea_subject()
        {
            return Ok(await _context.T_Control_Oversea
                    .Select(e => e.subject).Distinct()
                    .OrderByDescending(e => e)
                    .ToArrayAsync());
        }
        [HttpGet("POIssue")]
        public async Task<ActionResult<IEnumerable<T_PO_Issue>>> get_po_issue(string subject)
        {
            var data = await _context.T_PO_Issue.Where(e=>e.subject==subject)
                .ToListAsync();
            
            if(data==null){
                return NotFound();
            }

            return data;
        }
        [HttpGet("POIssue/Subject")]
        public async Task<ActionResult> get_po_issue_subject()
        {
            return Ok(await _context.T_PO_Issue
                    .Select(e => e.subject).Distinct()
                    .OrderByDescending(e => e)
                    .ToArrayAsync());
        }
        [HttpGet("DelayDomestic")]
        public async Task<ActionResult<IEnumerable<T_Delay_Domestic>>> get_delay_domestic(string subject)
        {
            var data = await _context.T_Delay_Domestic.Where(e=>e.subject==subject)
                .ToListAsync();
            
            if(data==null){
                return NotFound();
            }

            return data;
        }
        [HttpPut("DelayDomestic/{id}")]
        public async Task<ActionResult<IEnumerable<T_Delay_Domestic>>> put_delay_domestic(int id, T_Delay_Domestic data)
        {
            var reason = await _context.T_Delay_Domestic.FindAsync(id);
            reason.resp_suppliercpt = String.IsNullOrWhiteSpace(data.resp_suppliercpt) ? reason.resp_suppliercpt:data.resp_suppliercpt;
            reason.remark_and_reason = String.IsNullOrWhiteSpace(data.remark_and_reason) ? reason.remark_and_reason:data.remark_and_reason;
            reason.byer_pic = String.IsNullOrWhiteSpace(data.byer_pic) ? reason.byer_pic:data.byer_pic;
            reason.upd_by = User.FindFirst("username").Value;
            reason.upd_dt = DateTime.Now;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Delay_Domestic_Exists(id))
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
        [HttpGet("DelayDomestic/Subject")]
        public async Task<ActionResult> get_delay_domestic_subject()
        {
            return Ok(await _context.T_Delay_Domestic
                    .Select(e => e.subject).Distinct()
                    .OrderByDescending(e => e)
                    .ToArrayAsync());
        }
        [HttpGet("DelayOversea")]
        public async Task<ActionResult<IEnumerable<T_Delay_Oversea>>> get_delay_oversea(string subject)
        {
            Console.WriteLine(subject);
            var data = await _context.T_Delay_Oversea.Where(e=>e.subject==subject)
                .ToListAsync();
            
            if(data==null){
                return NotFound();
            }

            return data;
        }
        [HttpPut("DelayOversea/{id}")]
        public async Task<ActionResult<IEnumerable<T_Delay_Oversea>>> put_delay_oversea(int id, T_Delay_Oversea data)
        {
            var reason = await _context.T_Delay_Oversea.FindAsync(id);
            reason.resp_suppliercpt = String.IsNullOrWhiteSpace(data.resp_suppliercpt) ? reason.resp_suppliercpt:data.resp_suppliercpt;
            reason.remark_and_reason = String.IsNullOrWhiteSpace(data.remark_and_reason) ? reason.remark_and_reason:data.remark_and_reason;
            reason.upd_by = User.FindFirst("username").Value;
            reason.upd_dt = DateTime.Now;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Delay_Oversea_Exists(id))
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
        [HttpGet("DelayOversea/Subject")]
        public async Task<ActionResult> get_delay_oversea_subject()
        {
            return Ok(await _context.T_Control_Oversea
                    .Select(e => e.subject).Distinct()
                    .OrderByDescending(e => e)
                    .ToArrayAsync());
        }
        [HttpGet("ControlEvalio")]
        public async Task<ActionResult<IEnumerable<T_Control_Evalio>>> get_evalio(string subject)
        {
            var data = await _context.T_Control_Evalio.Where(e=>e.subject==subject)
                .ToListAsync();
            
            if(data==null){
                return NotFound();
            }

            return data;
        }
        [HttpPut("ControlEvalio/{id}")]
        public async Task<ActionResult<IEnumerable<T_Control_Evalio>>> put_evalio(int id, T_Control_Evalio data)
        {
            var reason = await _context.T_Control_Evalio.FindAsync(id);
            reason.resp_suppliercpt = String.IsNullOrWhiteSpace(data.resp_suppliercpt) ? reason.resp_suppliercpt:data.resp_suppliercpt;
            reason.remark_and_reason = String.IsNullOrWhiteSpace(data.remark_and_reason) ? reason.remark_and_reason:data.remark_and_reason;
            // reason.byer_pic = String.IsNullOrWhiteSpace(data.byer_pic) ? reason.byer_pic:data.byer_pic;
            reason.upd_by = User.FindFirst("username").Value;
            reason.upd_dt = DateTime.Now;
            _context.Entry(reason).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!T_Control_Evalio_Exists(id))
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
        [HttpGet("ControlEvalio/Subject")]
        public async Task<ActionResult> get_evalio_subject()
        {
            return Ok(await _context.T_Control_Evalio
                    .Select(e => e.subject).Distinct()
                    .OrderByDescending(e => e)
                    .ToArrayAsync());
        }
        private bool T_Control_Domestic_Exists(int id)
        {
            return _context.T_Control_Domestic.Any(e => e.ID == id);
        }
        private bool T_Control_Oversea_Exists(int id)
        {
            return _context.T_Control_Oversea.Any(e => e.ID == id);
        }
        private bool T_Delay_Domestic_Exists(int id)
        {
            return _context.T_Delay_Domestic.Any(e => e.ID == id);
        }
        private bool T_Delay_Oversea_Exists(int id)
        {
            return _context.T_Delay_Oversea.Any(e => e.ID == id);
        }
        private bool T_Control_Evalio_Exists(int id)
        {
            return _context.T_Control_Evalio.Any(e => e.ID == id);
        }
    }
}
