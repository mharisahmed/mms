using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PetaPoco;

namespace constrng
{
    public partial class tblProduct
    {
        [ResultColumn]
        public string TypeName { get; set; }
    }

}