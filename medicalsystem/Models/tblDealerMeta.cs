using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace constrng
{
    public class tblDealerMeta
    {
        [Required]
        public string DealerName { get; set; }
        [Required]
        public string DealerAddress { get; set; }
        [Required]
        public string DealerEmail { get; set; }
       

    }

    [MetadataTypeAttribute(typeof(tblDealerMeta))]
    public partial class tblDealer
    {

    }
}