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
    public class AdminController : ControllerBase
    {
       private AdminService  _adminService;
        public AdminController(AdminService adminService)
        {
            _adminService = adminService;

        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] Admin AdminRegister)
        {
            _adminService.Register(AdminRegister);
            return Ok("registerd succesfully");
        }
        [HttpPost("login")]
        public IActionResult login([FromBody] Admin Adminlogin)
        {
            Admin user = _adminService.Login(Adminlogin);
            if (user != null)

                return Ok("Login sucessfully!!!");
            else
                return NotFound();
        }

    }
}
