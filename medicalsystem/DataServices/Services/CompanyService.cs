using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;

namespace medicalsystem.DataServices.Services
{
    public class CompanyService
    {
        private static CompanyService _service = null;

        public static CompanyService Instance => _service ?? (_service = new CompanyService());

        public List<tblCompay> Companies()
        {

            using (var _context = DataContextHelper.GetContext())
            {
                var result = _context.Fetch<tblCompay>("select * from tblCompay");

                return result;

            }

        }

        //string compname, string compaddress, string compnemail
        public void AddCompany(tblCompay compobject) {
            using (var _context = DataContextHelper.GetContext())
            {
              _context.Insert(compobject);
    
            }
        }

        //Get Recode for Update
        public tblCompay EditCompany(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                var Company =_context.Single<tblCompay>("Select * From tblCompay where CompanyId=@0", id);
                return Company;
            }
        }

        // Update Record.
        public void UpdateCompany(tblCompay comp)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Update(comp);
            }

        }

        // Delete Record.
        public void DeleteCompany(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Delete<tblCompay>(id);
            }

        }

    }
}