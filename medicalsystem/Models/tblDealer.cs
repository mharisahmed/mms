﻿using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace constrng
{
    public partial class tblDealer
    {
        [ResultColumn]
        public string CompanyName { get; set; }
    }
}
