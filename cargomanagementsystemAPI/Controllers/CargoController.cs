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
    public class CargoController : ControllerBase
    {
        private CargomanagementService _cargomanagementservices;
        public CargoController(CargomanagementService cargomanagementservices)
        {
            _cargomanagementservices = cargomanagementservices;

        }
        [HttpGet("GetCustomerdetails")]
        public IEnumerable<Customerdetails> GetCustomerdetails()
        {
            return _cargomanagementservices.GetCustomerdetails();
        }
        [HttpPost("Addcustdetails")]
        public IActionResult Addcustdetails([FromBody] Customerdetails customerdetails)
        {
            _cargomanagementservices.Addcustdetails(customerdetails);
            return Ok("Successfully added customer details");
        }
        [HttpDelete("Deletecustdetails")]
        public IActionResult Deletecustdetails(int custId)
        {
            _cargomanagementservices.Deletecustdetails(custId);
            return Ok("Successfully deleted customer details");
        }
    }
}
