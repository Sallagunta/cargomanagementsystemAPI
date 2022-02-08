using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
namespace cargomanagementsystem.Entity.Model
{

    public class Transaction
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bill_no { get; set; }
        [Required]
        [ForeignKey("cust_id")]
        public int Sender_id { get; set; }
        public virtual Customerdetails  cust_id { get; set; }
        [Required]
        public string Type_of_goods { get; set; }
        [Required]
        public int Goods_Qty { get; set; }
        [Required]
        public int Trans_amount { get; set; }
        [Required]
        public string Sending_date { get; set; }
        [Required]
        public string Receiver_date { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }

    }

}

