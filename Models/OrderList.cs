using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class OrderList
    {
        /// <summary>
        /// Alle ordre bliver gemt i en liste, kun synlig for admin.
        /// </summary>
        public Order OrderId { get; set; }
        public List<Order> OrdersList { get; set; }

        public OrderList()
        {
            
        }
        public OrderList(Order orderId, List<Order> ordersList)
        {
            OrderId = orderId;
            OrdersList = ordersList;
        }
    }
}
