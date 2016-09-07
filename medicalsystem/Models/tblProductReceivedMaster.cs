using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;
using PetaPoco;

namespace constrng
{
    public partial class tblProductReceivedMaster
    {
        [ResultColumn]
        public string DealerName { get; set; }

        [ResultColumn]
        public string CompanyName { get; set; }
        
    }
}