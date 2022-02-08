using cargomanagementsystem.DAL.DATA;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
  public   class AdminRepository:IAdminRepository
    {

        private cargomanagementDbcontext _cargomanagementdbcontext;
        public AdminRepository(cargomanagementDbcontext cargomanagementdbcontext)
        {
            _cargomanagementdbcontext = cargomanagementdbcontext;
        }
       

        public Admin Login(Admin Adminlogin)
        {
            Admin AdminRegister = null;
            var result = _cargomanagementdbcontext.admin.Where(obj => obj.AdminEmail==Adminlogin.AdminEmail  && obj.Adminpassword == Adminlogin.Adminpassword).ToList();
            if (result.Count > 0)
            {
                AdminRegister = result[0];


            }
            return AdminRegister;
        }

       

        public void Register(Admin AdminRegister)
        {
            _cargomanagementdbcontext.admin.Add(AdminRegister);
            _cargomanagementdbcontext.SaveChanges();
        }
    }
}