using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using medicalsystem.CustomEntities;

namespace medicalsystem.Models
{
    public class InventoryModel
    {
        public List<InventoryDetailEntity> InventoryEntity { get; set; }
    }
}