using cargomanagementsystem.DAL.DATA;
using System;
using System.Collections.Generic;
using System.Text;
using cargomanagementsystem.Entity.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace cargomanagementsystem.DAL.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
       private  cargomanagementDbcontext _cargomanagementdbcontext;
        public TransactionRepository(cargomanagementDbcontext cargomanagementdbcontext)
        {
            _cargomanagementdbcontext = cargomanagementdbcontext;
        }

        public void AddTransaction(Transaction transaction)
        {
            _cargomanagementdbcontext.transaction.Add(transaction);
            _cargomanagementdbcontext.SaveChanges();
        }

        public void Deletetransactiondetails(int Bill_no)
        {
            var transaction = _cargomanagementdbcontext.transaction.Find(Bill_no);
            _cargomanagementdbcontext.transaction.Remove(transaction);
            _cargomanagementdbcontext.SaveChanges();
        }

       

        public Transaction GetTransactionbyBillno(int Bill_no)
        {
            return _cargomanagementdbcontext.transaction.Find(Bill_no);
        }

        public IEnumerable<Transaction> GetTransactiondetails()
        {
            return _cargomanagementdbcontext.transaction.ToList();
        }

        public void GetTransactiondetails(Transaction transaction)
        {
            _cargomanagementdbcontext.Entry(transaction).State = EntityState.Modified;
            _cargomanagementdbcontext.SaveChanges();
        }

        public void UpdateTransactiondetails(Transaction transaction)
        {
           _cargomanagementdbcontext.Entry(transaction).State = EntityState.Modified;
            _cargomanagementdbcontext.SaveChanges();
        }
    }
}
