using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;
using medicalsystem.CustomEntities;

namespace medicalsystem.Models
{
    public class ProductRecieved
    {
        public  tblProductReceivedMaster ModelMaster {get; set;}
        public tblProductReceivedDetail ModelDetail { get; set; }
    }
    public class ProductSale
    {
        public List<tblSaleMaster> SaleMaster { get; set; }
        public tblSaleMaster SaleMastert { get; set; }
        public tblSaleDetail SaleDetail { get; set; }
        public List<ProductSaleEntity> SaleDetails { get; set; }
    }
}