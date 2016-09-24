using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;

namespace medicalsystem.DataServices.Services
{
    public class RecievedProduct
    {
        private static RecievedProduct _service = null;

        public static RecievedProduct Instance => _service ?? (_service = new RecievedProduct());

        public List<tblProductReceivedMaster> RecievedMasterDetails()
        {

            using (var _context = DataContextHelper.GetContext())
            {
                
                var sql =
                         @" select mr.*,d.DealerName as DealerName,c.CompanyName as CompanyName from tblProductReceivedMaster mr 
                            inner join tblDealer d on mr.DealerId=d.DealId
                            inner join tblCompay c on d.CompanyId=c.CompanyId";
                var result = _context.Fetch<tblProductReceivedMaster>(sql);
                return result;

            }

        }

        public List<tblProduct> listofProduct()
        {
            using (var _context = DataContextHelper.GetContext())
            {
                return _context.Fetch<tblProduct>("select ProductId, ProductName from tblProduct");
            }
        }

        public List<tblProductReceivedDetail> RecievedDetails(int id)
        {

            using (var _context = DataContextHelper.GetContext())
            {

                var sql =
                         @" select *,p.ProductName as ProductName from tblProductReceivedDetails d
                            inner join tblProductReceivedMaster m on d.PRMId = m.PRMId
                            inner join tblProduct p on d.ProductId=p.ProductId 
                            where d.PRMId=@0";
                var result = _context.Fetch<tblProductReceivedDetail>(sql,id);
                return result;

            }

        }


        //Code For Create New Recieved Prodcut Entry

        public List<tblDealer> listofDealers()
        {
            using (var _context = DataContextHelper.GetContext())
            {
                return _context.Fetch<tblDealer>("select DealId, DealerName from tblDealer");
            }
        }



    }
}