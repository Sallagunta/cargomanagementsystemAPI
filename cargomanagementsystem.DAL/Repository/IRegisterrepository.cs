using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
  public   interface IRegisterrepository
    {
        void Register(cargomanagementRegister cargomanagementregister);
        cargomanagementRegister Login(cargomanagementRegister cargomanagementlogin);
    }
}
