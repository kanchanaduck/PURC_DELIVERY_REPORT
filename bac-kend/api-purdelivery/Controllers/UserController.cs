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
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        private readonly IRepository _repository;

        public UserController(ApplicationDbContext context, IRepository repository, IConfiguration config)
        {
            _config = config;
            _context = context;
            _repository = repository;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_User>>> get_users()
        {
            var users =  await _context.T_User
                .Select(
                    user => new { 
                        username = user.username,
                        name = user.name,
                        dept = user.dept,
                        roles = user.roles.Select(x => x.role) 
                    })
                .ToListAsync();
            return Ok(users);
        }
        // GET: api/014496/Roles
        [HttpGet]
        [Route("/api/{username}/Roles")]
        public async Task<ActionResult<IEnumerable<T_User>>> get_username_roles(string username)
        {
            var user =  await _context.T_User.Where(e=>e.username==username).Include(e=>e.roles).FirstOrDefaultAsync();
            if(user==null){
                return NotFound("ไม่พบ username นี้");
            }
            var roles =  user.roles.Select(e=>e.role).ToArray();
            return Ok(roles);
        }
        // GET: api/Roles
        [HttpGet]
        [Route("/api/Roles")]
        public async Task<ActionResult<IEnumerable<T_User>>> get_roles()
        {
            var roles =  await _context.T_Role
                .Select(
                    role => role.role )
                .ToListAsync();
            return Ok(roles);
        }

        // POST: api/Login
        [AllowAnonymous]
        [HttpPost]
        [Route("/api/Login")]
        public async Task<ActionResult<T_User>> Login(Login Input)
        {
            var username = _context.T_User.FirstOrDefault(u => u.username == Input.username);

            if(username!=null){

                var user = _repository.VerifyPassword(Input.password, username.storedsalt, username.passwordhash);

                if (user)
                {
                    //Login Successfull
                    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Secret"]));
                    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_config["Jwt:ValidIssuer"],
                    _config["Jwt:ValidIssuer"],
                    null,
                    expires: DateTime.Now.AddHours(8),
                    signingCredentials: credentials);

                    var query = await _context.T_User
                                        .Where(e=>e.username==Input.username)
                                        .Select(
                                            user => new { 
                                                username = user.username,
                                                name = user.name,
                                                dept = user.dept,
                                                roles = user.roles.Select(x => x.role) 
                                        })
                                        .FirstOrDefaultAsync();
                    token.Payload["user"] = query;

                    return Ok(new
                    {
                        name = username.name,
                        username = Input.username,
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo,
                    });
                }
            }

            return Unauthorized("Authentication failed.");
        }
        // POST: api/Users
        // [AllowAnonymous]
        [HttpPost]
        [Route("/api/Register")]
        public async Task<ActionResult<T_User>> Register(Register register)
        {
            var username = _context.T_User.FirstOrDefault(u => u.username == register.username);
            if(username==null){
                try	
                {
                    var content = new {
                        command = $"SELECT * FROM cpt_employees where emp_no='{register.username}'"
                    };

                    var json = JsonConvert.SerializeObject(content);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.PostAsync("http://cptsvs531:1000/middleware/oracle/hrms", data);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    dynamic res = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody.ToString());

                    if(res.data.Count>0){  

                        var roles =  new List<T_Role_Claim>();
                        if(register.roles!=null){
                            foreach (var item in register.roles)
                            {
                                roles.Add(new T_Role_Claim{
                                    username = register.username,
                                    role = item
                                });
                            }
                        } 

                        T_User tb = new T_User();
                        tb.username = register.username;
                        tb.name = res.data[0].FIRSTNAME_EN+" "+res.data[0].LASTNAME_EN;
                        tb.dept = res.data[0].DEPT_ABB;
                        tb.active = true;
                        var hashsalt = _repository.EncryptPassword(register.username);
                        tb.passwordhash = hashsalt.Hash;
                        tb.storedsalt = hashsalt.Salt;
                        tb.created_at = DateTime.Now;
                        tb.created_by = register.username;
                        if(roles.Count>0) {
                            tb.roles = roles;
                        }

                        _context.T_User.Add(tb);
                        await _context.SaveChangesAsync();

                        var users =  await _context.T_User
                        .Select(
                            user => new { 
                                username = user.username,
                                name = user.name,
                                dept = user.dept,
                                roles = user.roles.Select(x => x.role) 
                            })
                        .Where(user => user.username==register.username)
                        .FirstOrDefaultAsync();

                        try
                        {   
                            return CreatedAtAction("get_users", new { username = register.username }, users);
                        }
                        catch (DbUpdateException)
                        {
                            if (user_exists(tb.username))
                            {
                                return Conflict();
                            }
                            else
                            {
                                throw;
                            }
                        }
                    }
                    else{
                        return NotFound("Not found this employee.");
                    }
                }
                catch(HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");	
                    Console.WriteLine("Message :{0} ",e.Message);
                    return BadRequest(e);
                }
            }
            else{
                return Conflict("This account is already exist.");
            }
        }
        [AllowAnonymous]
        [HttpPut("{username}")]
        public async Task<ActionResult<T_User>> EditRole(string username, Register register)
        {
            var user = await _context.T_User.Where(e=>e.username==username).Include(e=>e.roles).FirstOrDefaultAsync();
            user.roles.Clear();
            foreach (var item in register.roles)
            {
                var roles = new T_Role_Claim{
                    username = user.username,
                    role = item
                };
                user.roles.Add(roles);
            }
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpDelete("{username}")]
        public async Task<IActionResult> DeleteT_Reason_Delay(string username)
        {
            var last_admin = _context.T_User
            .Include(c => c.roles)
            .Where(c => c.roles.Any(i => i.role=="Admin")).Count();

            Console.WriteLine(last_admin);

            if(last_admin==1){
                return BadRequest("Cannot delete the last admin account.");
            }

            Console.WriteLine(last_admin);
            // return Ok(customer);

            var user = await _context.T_User.FindAsync(username);
            if (user == null)
            {
                return NotFound();
            }

            _context.T_User.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [Authorize]
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> change_password(ChangePassword c){
            var user = await _context.T_User.FirstOrDefaultAsync(e=>e.username==User.FindFirst("username").Value);

            if(user==null){
                return NotFound("Not found this user in the system.");
            }

            var password_correct = _repository.VerifyPassword(c.current_password, user.storedsalt, user.passwordhash);

            if (password_correct){
                var hashsalt = _repository.EncryptPassword(c.new_password);
                user.passwordhash = hashsalt.Hash;
                user.storedsalt = hashsalt.Salt;
                user.reset_password_at = DateTime.Now;
                user.reset_password_by = User.FindFirst("username").Value;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            else{
                return BadRequest("Password is incorrect.");
            }

        }
        [Authorize]
        [HttpPut("ResetPassword/{username}")]
        public async Task<IActionResult> reset_password(string username){
            var user = await _context.T_User.FirstOrDefaultAsync(e=>e.username==username);

            if(user==null){
                return NotFound("Not found this user in the system.");
            }

            var hashsalt = _repository.EncryptPassword(username);
            user.passwordhash = hashsalt.Hash;
            user.storedsalt = hashsalt.Salt;
            user.reset_password_at = DateTime.Now;
            user.reset_password_by = User.FindFirst("username").Value;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool user_exists(string username)
        {
            return _context.T_User.Any(e => e.username == username);
        }
    }
}
