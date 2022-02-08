using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cargomanagementsystem.Entity.Model
{
     public class Customerdetails
    {
        public  string custname { get; set; }
      
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int custId { get; set; }
        public string custAddress { get; set; }
        public string custCity { get; set; }
        public int custPhone { get; set; }
        public int custpincode { get; set; }
        public string recNmae { get; set; }
      
        public int recID { get; set; }
        public string recAddress { get; set; }
        public string rectCity { get; set; }
        public int recPhone { get; set; }
        public int recpincode { get; set; }

    }
}
