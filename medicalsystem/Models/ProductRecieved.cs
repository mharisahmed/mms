using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;

namespace medicalsystem.Models
{
    public class ProductRecieved
    {
        public  tblProductReceivedMaster ModelMaster {get; set;}
        public tblProductReceivedDetail ModelDetail { get; set; }
    }
}