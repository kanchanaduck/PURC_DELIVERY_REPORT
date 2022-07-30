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
        private readonly DataBaseContext _context;
        private readonly IRepository _repository;

        public PersonController(DataBaseContext context, IRepository repository, IConfiguration config)
        {
            _config = config;
            _context = context;
            _repository = repository;
        }
        [HttpGet("Buyer")]
        public async Task<ActionResult> get_buyer()
        {
            List<String> domestic_buyer = await _context.T_Domestic.Select(e=>e.cd_procur_person).Distinct().ToListAsync();
            List<String> oversea_buyer = await _context.T_Oversea.Select(m => m.cd_estim_person).Distinct().ToListAsync();
            List<String> buyer = new List<String>();
            buyer.AddRange(domestic_buyer);
            buyer.AddRange(oversea_buyer);
            buyer = buyer.Distinct().OrderBy(x=>x).ToList();
            return Ok(buyer);
        }
        [HttpGet("Vendor")]
        public async Task<ActionResult> get_vendor()
        {
            List<String> domestic_vendor = await _context.T_Domestic.Select(e=>e.cd_sply).Distinct().ToListAsync();
            List<String> oversea_vendor = await _context.T_Oversea.Select(m => m.cd_sply).Distinct().ToListAsync();
            List<String> vendor = new List<String>();
            vendor.AddRange(domestic_vendor);
            vendor.AddRange(oversea_vendor);
            vendor = vendor.Distinct().OrderBy(x=>x).ToList();
            return Ok(vendor);
        }
        [HttpGet("PartNo")]
        public async Task<ActionResult> get_part_no()
        {
            List<String> domestic_part_no = await _context.T_Domestic.Select(e=>e.no_parts).Distinct().ToListAsync();
            List<String> oversea_part_no = await _context.T_Oversea.Select(m => m.no_parts).Distinct().ToListAsync();
            List<String> part_no = new List<String>();
            part_no.AddRange(domestic_part_no);
            part_no.AddRange(oversea_part_no);
            part_no = part_no.Distinct().OrderBy(x=>x).ToList();
            return Ok(part_no);
        }
    }
}
