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
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int JewelryId { get; set; }
        public Jewelry Jewelry { get; set; }
        public int ProductCount { get; set; }

        public OrderLine()
        {
            
        }

        public OrderLine(int orderLineId, int orderId, Order order, int jewelryId, Jewelry jewelry, int productCount)
        {
            OrderLineId = orderLineId;
            OrderId = orderId;
            Order = order;
            JewelryId = jewelryId;
            Jewelry = jewelry;
            ProductCount = productCount;
        }
    }
}
