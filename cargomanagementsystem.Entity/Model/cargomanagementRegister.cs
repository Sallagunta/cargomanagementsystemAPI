using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace cargomanagementsystem.Entity.Model
{
    public  class cargomanagementRegister
    {
       
       
        public string CustName { get; set; }
        [Key]
        public string CustEmailid { get; set; }
        public string Custpassword { get; set; }
        public string Confirmpassword { get; set; }
        public int mobile { get; set; }

    }
}
