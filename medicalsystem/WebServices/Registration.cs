using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicalsystem
{
    public class Registration
    {
        public string UserName { get; set; }
        public bool UserNameInUse { get; set; }

        public string TypeName { get; set; }
        public bool TypeNameInUse { get; set; }
        public string ProductName { get; set; }
        public bool ProductNameInUse { get; set; }
        public string DealerName { get; set; }
        public bool DealerNameInUse { get; set; }
    }
}