using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cargomanagementsystem.Entity.Model
{
    public  class Admin
    {[Key]
    
        public string AdminEmail { get; set; }
        public string Adminpassword { get; set; }
        public string ConfirmPassword { get; set; }
        public string AdminName { get; set; }
    }
}
