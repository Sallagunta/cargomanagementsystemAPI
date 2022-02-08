using cargomanagementsystem.BAL.Services;
using cargomanagementsystem.Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cargomanagementsystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RegisterController : ControllerBase
    {
        private RegisterService _registerservice;
        public RegisterController(RegisterService registerservice)
        {
            _registerservice = registerservice;

        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] cargomanagementRegister cargomanagementregister)
        {
            _registerservice.Register(cargomanagementregister);
            return Ok("registerd succesfully");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] cargomanagementRegister cargomanagementlogin)
        {
            cargomanagementRegister user = _registerservice.Login(cargomanagementlogin);
            if (user != null)

                return Ok("Login sucessfully!!!");
            else
                return NotFound();
        }

    }
}