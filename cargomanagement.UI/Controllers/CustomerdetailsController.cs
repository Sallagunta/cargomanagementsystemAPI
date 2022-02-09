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
    public class CustomerdetailsController : Controller
    {
        private IConfiguration _configuration;
        public CustomerdetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
     
        public async Task<IActionResult> Custindex()
        {
            IEnumerable<Customerdetails> custresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Cargo/GetCustomerdetails";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        custresult = JsonConvert.DeserializeObject<IEnumerable<Customerdetails>>(result);
                    }
                }
            }
            return View(custresult);
        }



        public IActionResult Customer()
        {
            return View();
        }
     
       

        [HttpPost]
        public async Task<IActionResult> Customer(Customerdetails  customer)
        {
            ViewBag.status = "";
            if (Request.Form.Files.Count > 0)
            {
                MemoryStream ms = new MemoryStream();
                Request.Form.Files[0].CopyTo(ms);

            }
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Cargo/Addcustdetails";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Transaction details saved successfully!";
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
