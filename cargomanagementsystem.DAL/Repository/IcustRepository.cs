using System;
using System.Collections.Generic;
using System.Text;
using cargomanagementsystem.Entity.Model;


namespace cargomanagementsystem.DAL.Repository
{
    public  interface IcustRepository
    {
        void Addcustdetails(Customerdetails custdetails);
        void Updatecustdetails(Customerdetails custdetails);
        void Deletecustdetails(int custId);
        Customerdetails Getcustdetailsbyid(int custId);
        IEnumerable<Customerdetails> GetCustomerdetails();

    }
}
