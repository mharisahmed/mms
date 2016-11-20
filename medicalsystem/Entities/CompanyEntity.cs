using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medicalsystem.Entities
{
    public class CompanyEntity
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
    }
}