using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.BAL.Services
{
   public  class TransactionServices
    {
         public ITransactionRepository _transactionrepository;
        public TransactionServices(ITransactionRepository transactionrepository)
        {
            _transactionrepository = transactionrepository;
        }
        public void AddTransaction(Transaction transaction)
        {
            _transactionrepository.AddTransaction(transaction);

        }
        public void UpdateTransactiondetails(Transaction transaction)
        {
            _transactionrepository.UpdateTransactiondetails(transaction);
        }
        public void Deletetransactiondetails(int Bill_no)
        {
            _transactionrepository.Deletetransactiondetails(Bill_no);
        }
        public Transaction GetTransactionbyBillno(int Bill_no)
        {
            return _transactionrepository.GetTransactionbyBillno(Bill_no);
        }
        public IEnumerable<Transaction> GetTransactiondetails()
        {
            return _transactionrepository.GetTransactiondetails();
        }
    }
}

 
