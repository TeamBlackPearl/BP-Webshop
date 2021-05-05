using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BP_Webshop.Models
{
    public class OrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderLineId { get; set; }
        //[Key, Column(Order = 0)]
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        //[Key, Column(Order = 1)]
        [ForeignKey("JewelryId")]
        public int JewelryId { get; set; }
        public int ProductCount { get; set; }

        public OrderLine()
        {
            
        }
        public OrderLine(int orderId, int jewelryId, int productCount)
        {
            OrderId = orderId;
            JewelryId = jewelryId;
            ProductCount = productCount;
        }
    }
}
