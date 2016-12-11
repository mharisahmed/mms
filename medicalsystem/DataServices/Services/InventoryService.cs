using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;
using medicalsystem.CustomEntities;

namespace medicalsystem.DataServices.Services
{
    public class InventoryService
    {
        private static InventoryService _service = null;

        public static InventoryService Instance => _service ?? (_service = new InventoryService());

        public List<InventoryDetailEntity> GetInventoryDetails()
        {

            using (var _context = DataContextHelper.GetContext())
            {
                var sql = @" select ProductName,Quantity from tblStockInHand inner join tblProduct
  on tblStockInHand.ProductId = tblProduct.ProductId";
                var result = _context.Fetch<InventoryDetailEntity>(sql);

                return result;

            }

        }
    }
}