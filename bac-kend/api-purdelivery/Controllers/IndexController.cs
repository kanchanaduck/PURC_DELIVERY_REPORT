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
    public class IndexController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        private readonly IRepository _repository;

        public IndexController(ApplicationDbContext context, IRepository repository, IConfiguration config)
        {
            _config = config;
            _context = context;
            _repository = repository;
        }
        [HttpGet("Monthly")]
        public async Task<ActionResult> get_monthly()
        {
            var weekly =  await _context.T_Domestic
                .FromSqlRaw(@$"
                                select dt_acptc from (
                                select substring(dt_acptc,1,4)+substring(dt_acptc,5,2) dt_acptc
                                from T_Domestic
                                group by substring(dt_acptc,1,4), substring(dt_acptc,5,2)
                                union all
                                select substring(dt_rec,1,4)+substring(dt_rec,5,2) dt_rec
                                from T_Oversea
                                group by substring(dt_rec,1,4), substring(dt_rec,5,2)
                                ) a
                                group by dt_acptc
                              "
                )
                .OrderByDescending(e=>e.dt_acptc)
                .Select(e=>e.dt_acptc)
                .ToArrayAsync();
            return Ok(weekly);
        }
    }
}
