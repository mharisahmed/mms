using System.ComponentModel.DataAnnotations;

namespace constrng
{
    public class tbl_DealerMeta
    {
        [Required]
        public string DealerName { get; set; }
        [Required]
        public string DealerAddress { get; set; }
        [Required]
        public string DealerEmail { get; set; }
       

    }

    [MetadataType(typeof(tbl_DealerMeta))]
    public partial class tblDealer
    {

    }
}