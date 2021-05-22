using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class AllTypes
    {
        public int TyId { get; set; }
        public string TypeName { get; set; }
        public int JeweleryId { get; set; }
        public Jewelry Jewelry { get; set; }

        public AllTypes(int tyId, string typeName, int jeweleryId)
        {
            TyId = tyId;
            TypeName = typeName;
            JeweleryId = jeweleryId;
        }
        
    }
}
