using System;
using System.Collections.Generic;
using System.Text;
using cargomanagementsystem.Entity.Model;
using cargomanagementsystem.DAL.DATA;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace cargomanagementsystem.DAL.Repository
{
    public class custrepository : IcustRepository
    {
      private  cargomanagementDbcontext _cargomanagementdbcontext;
        public custrepository(cargomanagementDbcontext cargomanagementdbcontext)
        {
            _cargomanagementdbcontext = cargomanagementdbcontext;
        }
        public void Addcustdetails(Customerdetails customerdetails)
        {
            _cargomanagementdbcontext.customer_details.Add(customerdetails);
            _cargomanagementdbcontext.SaveChanges();
        }

        public void Deletecustdetails(int custId)
        {
            var customer = _cargomanagementdbcontext.customer_details.Find(custId);
            _cargomanagementdbcontext.customer_details.Remove(customer);
            _cargomanagementdbcontext.SaveChanges();
        }
        public Customerdetails Getcustdetailsbyid(int custId)
        {
            return _cargomanagementdbcontext.customer_details.Find(custId);


        }

        public void Updatecustdetails(Customerdetails custdetails)
        {
            _cargomanagementdbcontext.Entry(custdetails).State = EntityState.Modified;
            _cargomanagementdbcontext.SaveChanges();
        }
            public IEnumerable<Customerdetails> GetCustomerdetails()
        {
            return _cargomanagementdbcontext.customer_details.ToList();
        }


    }

}