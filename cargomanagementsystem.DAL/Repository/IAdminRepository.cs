using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
  public   interface IAdminRepository
    {
           Admin Login(Admin  Adminlogin);
       void Register(Admin AdminRegister);
    }
}
