using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicalsystem.CustomEntities
{
    public class ProductSaleEntity
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int SDId { get; set; }
        public int SMId { get; set; }
    }
}