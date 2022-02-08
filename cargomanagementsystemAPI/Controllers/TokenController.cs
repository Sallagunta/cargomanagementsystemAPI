using cargomanagementsystem.DAL.DATA;
using cargomanagementsystem.Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace cargomanagementsystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly cargomanagementDbcontext _context;

        public TokenController(IConfiguration config, cargomanagementDbcontext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult>  Post(cargomanagementRegister _login)
        {

            if (_login != null && _login.CustEmailid != null && _login.Custpassword != null)
            {
                var user = await Register(_login.CustEmailid, _login.Custpassword);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("CustEmailid", user.CustEmailid),
                    new Claim("CustName", user.CustName),
                    new Claim("mobile", user.mobile.ToString()),
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<cargomanagementRegister> Register(string email, string password)
        {
            cargomanagementRegister register = null;
            var result = _context.Register.Where(u => u.CustEmailid == email && u.Custpassword== password);
            foreach (var item in result)
            {
                register = new cargomanagementRegister();
                register.CustName = item.CustName;
                register.CustEmailid = item.CustEmailid;
                register.mobile = item.mobile;
                register.Custpassword = item.Custpassword;
                register.Confirmpassword = item.Confirmpassword;

            }
            return register;

        }
    }
}

