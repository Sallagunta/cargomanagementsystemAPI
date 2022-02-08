using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using cargomanagementsystem.Entity.Model;

namespace cargomanagementsystem.DAL.DATA
{
     public class cargomanagementDbcontext:DbContext
    { 
        public cargomanagementDbcontext(DbContextOptions<cargomanagementDbcontext>options):base(options)
        {

        }
          public DbSet<cargomanagementRegister> Register { get; set; }
        public DbSet<Customerdetails> customer_details { get; set; }
        public DbSet<Transaction> transaction { get; set; }
        public DbSet<Admin> admin { get; set; }
        
      }
}
