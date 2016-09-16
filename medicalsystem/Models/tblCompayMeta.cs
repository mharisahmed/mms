using System.ComponentModel.DataAnnotations;

namespace constrng
{
    public class tbl_compayMeta
    {
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string CompanyAddress { get; set; }
        [Required]
        public string CompanyEmail { get; set; }

    }
    [MetadataTypeAttribute(typeof(tbl_compayMeta))]
    public partial class tblCompay
    {
    }
}