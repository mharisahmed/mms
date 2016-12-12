using constrng;
using medicalsystem.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicalsystem.DataServices.Services
{
    public class SaleProduct
    {
        private static SaleProduct _service = null;

        public static SaleProduct Instance => _service ?? (_service = new SaleProduct());

        public List<tblSaleMaster> SaleMasterDetails()
        {

            using (var _context = DataContextHelper.GetContext())
            {

                var sql =
                         @" select * from tblSaleMaster  ";
                          
                var result = _context.Fetch<tblSaleMaster>(sql);
                return result;

            }

        }
        public List<ProductSaleEntity> SaleDetailDetails(int id)
        {

            using (var _context = DataContextHelper.GetContext())
            {

                var sql =
                         @" select *,p.ProductName as ProductName from tblSaleDetails d
                            inner join tblSaleMaster m on d.SMId = m.SMId
                            inner join tblProduct p on d.ProductId=p.ProductId 
                            where d.SMId=@0";
                var result = _context.Fetch<ProductSaleEntity>(sql, id);
                return result;

            }

        }
        public int InsertMasterRecieved(tblSaleMaster master)
        {
            //int currid = 0;
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Insert(master);
            }
            return master.SMId;
        }
        public void InsertDetailRecieved(tblSaleDetail detail)
        {
            //int currid = 0;
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Insert(detail);
            }
            //return pro.PRMId;
        }
    }
}