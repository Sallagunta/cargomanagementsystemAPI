using System;
using System.Collections.Generic;
using System.Text;
using cargomanagementsystem.Entity.Model;


namespace cargomanagementsystem.DAL.Repository
{
   public   interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        void UpdateTransactiondetails(Transaction transaction);
        void Deletetransactiondetails(int Bill_no);
        Transaction GetTransactionbyBillno(int Bill_no);
        IEnumerable<Transaction> GetTransactiondetails();
    }
}
