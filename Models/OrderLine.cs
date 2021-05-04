using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class OrderLine
    {
        public Order OrderId { get; set; }
        public Jewelry JewelryId { get; set; }
        public int ProductCount { get; set; }

        public OrderLine()
        {
            
        }
        public OrderLine(Order orderId, Jewelry jewelryId, int productCount)
        {
            OrderId = orderId;
            JewelryId = jewelryId;
            ProductCount = productCount;
        }
    }
}
