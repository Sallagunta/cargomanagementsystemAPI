using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.BAL.Services
{
   public  class AdminService
    {
        private IAdminRepository _adminRepository;
        public AdminService(IAdminRepository  adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public Admin Login(Admin Adminlogin)
        {
            return _adminRepository.Login(Adminlogin);
        }
        public void Register(Admin AdminRegister)
        {
            _adminRepository.Register(AdminRegister);
        }
    }
}
