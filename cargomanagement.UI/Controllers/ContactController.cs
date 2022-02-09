using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cargomanagement.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
           
        }
        [HttpPost]
        public IActionResult Contact()
        {
            return Ok("succesfylly send");

        }


    }
}
