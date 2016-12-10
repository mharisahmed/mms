using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;

namespace medicalsystem.DataServices.Services
{
    public class DealersService
    {
        private static DealersService _service = null;

        public static DealersService Instance => _service ?? (_service = new DealersService());

        public List<tblDealer> getdealers()
        {
            using (var _context = DataContextHelper.GetContext())
            {
                var sql =
                    " select d.*,c.CompanyName as CompanyName from tblDealer d " +
                          "inner join tblCompay c on d.CompanyId = c.CompanyId";

                var abc = _context.Fetch<tblDealer>(sql);
                return abc;
            }
        }

        public List<tblCompay> listofCompanies()
        {
            using (var _context = DataContextHelper.GetContext())
            {
                return _context.Fetch < tblCompay>("Select * from tblCompay");
            }
        }


        //Add New product
        public void AddDealer(tblDealer dealer)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Insert(dealer);

            }
        }

        //Get Recode for Update
        public tblDealer EditDealer(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                var dealer = _context.Single<tblDealer>("Select * From tblDealer where DealerId=@0", id);
                return dealer;
            }
        }

        // Update Record.
        public void UpdateDealer(tblDealer dealer,int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Update(dealer,id);
            }

        }

        // Delete Record.
        public void DeleteDealer(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Delete<tblDealer>(id);
            }

        }

    }
}