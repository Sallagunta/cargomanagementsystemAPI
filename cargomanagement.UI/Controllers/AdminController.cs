using cargomanagementsystem.Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cargomanagement.UI.Controllers
{
    public class AdminController : Controller
    {
        private IConfiguration _configuration;
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Adminlogin()
        {
            return View();
        }
        public IActionResult AdminRegister()
        {
            return View();
        }
       


        [HttpPost]
        public async Task<IActionResult> Adminlogin(Admin login)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Admin/login";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        TempData["Admin"] = "Admin";
                        return RedirectToAction("Transactiondetails", "Transaction");

                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong credentials!";
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Admin Adminlogin)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(Adminlogin), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + " Admin/AdminRegister";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        TempData["Admin"] = "Admin";
                        ViewBag.status = "Ok";
                        ViewBag.message = "Register successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }

    }
}
       

