using System.ComponentModel.DataAnnotations;

namespace constrng
{ 
    public class tbl_TypeMeta
    {
        [Required]
        public string TypeName { get; set; }
    }

    [MetadataTypeAttribute(typeof(tbl_TypeMeta))]
    public partial class tblType
    {

    }
}