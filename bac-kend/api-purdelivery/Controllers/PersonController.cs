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

namespace api_purdelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        private readonly IRepository _repository;

        public PersonController(ApplicationDbContext context, IRepository repository, IConfiguration config)
        {
            _config = config;
            _context = context;
            _repository = repository;
        }
        [HttpGet("Buyer")]
        public async Task<ActionResult> get_buyers()
        {
            List<String> domestic_buyer = await _context.T_Domestic.Select(e=>e.cd_procur_person).Distinct().ToListAsync();
            List<String> oversea_buyer = await _context.T_Oversea.Select(m => m.cd_estim_person).Distinct().ToListAsync();
            List<String> buyer = new List<String>();
            buyer.AddRange(domestic_buyer);
            buyer.AddRange(oversea_buyer);
            buyer = buyer.Distinct().OrderBy(x=>x).ToList();
            return Ok(buyer);
        }
        [HttpGet("Supplier")]
        public async Task<ActionResult> get_suppliers()
        {
            List<String> domestic_suppliers = await _context.T_Domestic.Select(e=>e.cd_sply).Distinct().ToListAsync();
            List<String> oversea_suppliers = await _context.T_Oversea.Select(m => m.cd_sply).Distinct().ToListAsync();
            List<String> suppliers = new List<String>();
            suppliers.AddRange(domestic_suppliers);
            suppliers.AddRange(oversea_suppliers);
            suppliers = suppliers.Distinct().OrderBy(x=>x).ToList();
            return Ok(suppliers);
        }
    }
}
