using System.ComponentModel.DataAnnotations;

namespace constrng
{
    public class tblProductMeta
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int TypeId { get; set; }
    }
    [MetadataTypeAttribute(typeof(tblProductMeta))]
    public partial class tblProduct
    {

    }
}