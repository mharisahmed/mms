using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;

namespace medicalsystem.DataServices.Services
{
    public class ExpiryPorduct
    {
        private static ExpiryPorduct _service = null;

        public static ExpiryPorduct Instance => _service ?? (_service = new ExpiryPorduct());

        public List<tblProductReceivedDetail> RecievedMasterDetail()
        {

            using (var _context = DataContextHelper.GetContext())
            {

                var sql =
                         @"SELECT dbo.tblProduct.ProductName, dbo.tblDealer.DealerId ,dbo.tblProductReceivedDetails.Quantity, dbo.tblProductReceivedDetails.MfgDate, dbo.tblProductReceivedDetails.ExpDate FROM            
                         dbo.tblProduct INNER JOIN
                         dbo.tblProductReceivedDetails ON dbo.tblProduct.ProductId = dbo.tblProductReceivedDetails.ProductId INNER JOIN
                         dbo.tblProductReceivedMaster ON dbo.tblProductReceivedDetails.PRMId = dbo.tblProductReceivedMaster.PRMId INNER JOIN
                         dbo.tblDealer ON dbo.tblProductReceivedMaster.DealerId = dbo.tblDealer.DealerId";
                var result = _context.Fetch<tblProductReceivedDetail>(sql);
                return result;

            }

        }
    }
}