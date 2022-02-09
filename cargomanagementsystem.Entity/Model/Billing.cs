using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cargomanagementsystem.Entity.Model
{
    public  class Billing
    {
        [Required]
        [ForeignKey("Bill_no")]
        public int  TranID { get; set; }
        public virtual Transaction Bill_no { get; set; }
         [Required]
        [ForeignKey("custId")]
        public int CustId { get; set; }
        public virtual Transaction custId { get; set; }




    }
}
