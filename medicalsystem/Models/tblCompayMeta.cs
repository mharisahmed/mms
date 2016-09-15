using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PetaPoco;

namespace constrng
{
    public class tbl_compayMeta
    {
        [Required]
        public string CompanyName { get; set; }

    }
    [MetadataTypeAttribute(typeof(tbl_compayMeta))]
    public partial class tblCompay
    {
    }
}