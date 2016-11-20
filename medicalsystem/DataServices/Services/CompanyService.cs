using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;
using medicalsystem.Entities;

namespace medicalsystem.DataServices.Services
{
    public class CompanyService
    {
        //#region Define as Singleton
        //private static CompanyService _Instance;

        //public static CompanyService Instance
        //{
        //    get
        //    {
        //        if (_Instance == null)
        //        {
        //            _Instance = new CompanyService();
        //        }

        //        return (_Instance);
        //    }
        //}

        //private CompanyService()
        //{
        //}
        //#endregion
        private static CompanyService _service = null;

        public static CompanyService Instance => _service ?? (_service = new CompanyService());

        public List<CompanyEntity> Companies()
        {

            using (var _context = DataContextHelper.GetContext())
            {
                var result = _context.Fetch<CompanyEntity>("select * from tblCompay").ToList();

                return result;

            }

        }

        //string compname, string compaddress, string compnemail
        public void AddCompany(tblCompay compobject)
        {
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
                var Company = _context.Single<tblCompay>("Select * From tblCompay where CompanyId=@0", id);
                return Company;
            }
        }

        // Update Record.
        public void UpdateCompany(tblCompay comp, int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Update(comp,id);
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