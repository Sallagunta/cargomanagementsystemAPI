using System;
using System.Collections.Generic;
using System.Text;
using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;

namespace cargomanagementsystem.BAL.Services
{
   public   class CargomanagementService
    {
       private  IcustRepository _custRepository;
        public CargomanagementService(IcustRepository  icustRepository)
        {
            _custRepository = icustRepository;
        }
        public void Addcustdetails(Customerdetails custdetails)
        {
            _custRepository.Addcustdetails(custdetails );

        }
        public void Updatecustdetails(Customerdetails custdetails)
        {
            _custRepository.Updatecustdetails(custdetails);
        }
        public void Deletecustdetails(int custId)
        {
            _custRepository.Deletecustdetails(custId);
        }
        public void Getcustdetailsbyid(int custId)
        {
            _custRepository.Getcustdetailsbyid(custId);
        }
        public IEnumerable<Customerdetails>  GetCustomerdetails()
        {
           return _custRepository.GetCustomerdetails();
        }
    }
}
