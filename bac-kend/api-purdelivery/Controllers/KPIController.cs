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
using Microsoft.AspNet.OData;

namespace api_purdelivery.Controllers
{
    [Authorize]  
    [Route("api/[controller]")]
    [ApiController]
    public class KPIController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        private readonly IRepository _repository;

        public KPIController(ApplicationDbContext context, IRepository repository, IConfiguration config)
        {
            _config = config;
            _context = context;
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult> kpi(string year, string dept=null)
        {
            if(String.IsNullOrEmpty(year)){
                year = DateTime.Now.Year.ToString();
            }
            return Ok(await _context.T_KPI.Where(e=>Convert.ToString(e.year)==year && (e.dept==dept || dept==null)).ToListAsync());
        }
        [HttpGet("Years")]
        public async Task<ActionResult> kpi_year()
        {
            return Ok(await _context.T_KPI.Select(e=>e.year).Distinct().OrderByDescending(e => e).ToArrayAsync());
        }
        [HttpGet("Create/{year}")]
        public async Task<ActionResult> create_kpi(int year=2022)
        {
            if(_context.T_KPI.Any(e=>e.year==year)){
                return Conflict(@$"KPI of {year} is already exist.");
            }

            List<string> depts = new List<string> {"PUR1","PUR2","PUR3"};
            foreach (var dept in depts)
            {
                DateTime target = new DateTime(year, 1, 1);
                while (target < new DateTime(year+1, 1, 1)) {
                    _context.T_KPI.Add(
                        new T_KPI{
                            year=year,
                            monthly=target.ToString("yyyy-MM-dd"),
                            dept=dept,
                            // kpi=RandomNumber(),
                            created_by=User.FindFirst("username").Value,
                            created_dt=DateTime.Now
                        }
                    );
                    target = target.AddMonths(1);
                }  
            }

            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> update_kpi(string monthly, string dept, T_KPI data){
            var kpi = await _context.T_KPI.Where(e=>e.monthly==monthly && e.dept==dept).FirstOrDefaultAsync();
            kpi.kpi = data.kpi;
            kpi.updated_dt = DateTime.Now;
            kpi.updated_by = User.FindFirst("username").Value;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        static decimal RandomNumber()
        {
            Random random = new Random(); return random.Next(0, 100);
        }
    }
}
