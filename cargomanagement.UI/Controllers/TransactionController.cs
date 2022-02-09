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
    public class TransactionController : Controller
    {
        private IConfiguration _configuration;
        public TransactionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Transaction> transresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Transaction/GetTransactiondetails";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        transresult = JsonConvert.DeserializeObject<IEnumerable<Transaction>>(result);
                    }
                }
            }
            return View(transresult);
        }
        public IActionResult Transactiondetails()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Transactiondetails(Transaction transaction)
        {
            ViewBag.status = "";
            if (Request.Form.Files.Count > 0)
            {
                MemoryStream ms = new MemoryStream();
                Request.Form.Files[0].CopyTo(ms);

            }
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Transaction/AddTransaction";
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

        [HttpGet]
        public async Task<IActionResult> GetTransactionbyBillno()
        {
            IEnumerable<Transaction> transresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Transaction/GetTransactionbyBillno";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        transresult = JsonConvert.DeserializeObject<IEnumerable<Transaction>>(result);
                    }
                }

            }
            return View(transresult);
        }

    }
}
