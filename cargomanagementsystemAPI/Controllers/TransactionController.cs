using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cargomanagementsystem.BAL.Services;
using cargomanagementsystem.Entity.Model;

namespace cargomanagementsystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private TransactionServices _transactionServices;
        public TransactionController(TransactionServices transactionServices)
        {
            _transactionServices = transactionServices;
        }
        [HttpGet("GetTransactiondetails")]

        public IEnumerable<Transaction> GetTransactiondetails()
        {
            return _transactionServices.GetTransactiondetails();
        }
        [HttpPost("AddTransaction")]
        public IActionResult AddTransaction([FromBody] Transaction transaction)
        {
            _transactionServices.AddTransaction(transaction);
            return Ok("Successfully added transaction details");
        }
        [HttpDelete("Deletetransactiondetails")]
        public IActionResult Deletetransactiondetails(int Bill_no)
        {
            _transactionServices.Deletetransactiondetails(Bill_no);
            return Ok("Successfully deleted customer details");
        }
    
    [HttpPut("UpdateTransactiondetails")]
    public IActionResult UpdateTransactiondetails(Transaction transaction)
    {
            _transactionServices.UpdateTransactiondetails(transaction);
        return Ok("Transaction details updated successfully!!");
    }
    [HttpGet("GetTranscation_detailsbyno")]
    public IActionResult GetTransactionbyBillno(int Bill_no)
    {
           _transactionServices.GetTransactionbyBillno(Bill_no);

            return Ok("Get details by id");
            

    }
}
}
    

