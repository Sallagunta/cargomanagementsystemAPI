using cargomanagementsystem.DAL.DATA;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cargomanagementsystem.DAL.Repository
{
    public class Registerrepository : IRegisterrepository
    {
       private cargomanagementDbcontext _cargomanagementdbcontext;
        public Registerrepository(cargomanagementDbcontext cargomanagementdbcontext)
        {
            _cargomanagementdbcontext = cargomanagementdbcontext;
        }
        public cargomanagementRegister Login(cargomanagementRegister cargomanagementlogin)
        {
            cargomanagementRegister  cargomangementregister = null;
            var result = _cargomanagementdbcontext.Register.Where(obj => obj.CustEmailid== cargomanagementlogin.CustEmailid && obj.Custpassword == cargomanagementlogin.Custpassword).ToList();
          if(result.Count>0)
            {
                cargomangementregister = result[0];


            }
            return cargomangementregister;
        }

        public void Register(cargomanagementRegister cargomanagementregister)
        {
            _cargomanagementdbcontext.Register.Add(cargomanagementregister);
            _cargomanagementdbcontext.SaveChanges();
        }
    }
}
