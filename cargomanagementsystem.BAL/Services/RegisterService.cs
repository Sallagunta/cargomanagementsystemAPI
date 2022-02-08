using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.BAL.Services
{
    public  class RegisterService
    {
        private IRegisterrepository _registerrepository;
        public RegisterService(IRegisterrepository registerrepository)
        {
            _registerrepository = registerrepository;
        }
      public   void Register(cargomanagementRegister cargomanagementregister)
        {
            _registerrepository.Register(cargomanagementregister);
        }
        public cargomanagementRegister Login(cargomanagementRegister cargomanagementlogin)
        {
            return  _registerrepository.Login(cargomanagementlogin);
        }
    }
}
