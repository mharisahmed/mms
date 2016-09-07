using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;
using PetaPoco;

namespace constrng
{

     public partial class tblProductReceivedDetail
    {

        [ResultColumn]
        public string ProductName { get; set; }

    }
}