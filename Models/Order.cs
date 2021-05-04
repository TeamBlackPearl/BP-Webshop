using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BP_Webshop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public User UserId { get; set; }
        public decimal DeliveryPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public Order()
        {
            
        }

        public Order(int orderId, DateTime orderDate, User userId, decimal deliveryPrice, decimal totalPrice)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            UserId = userId;
            DeliveryPrice = deliveryPrice;
            TotalPrice = totalPrice;
        }

    }
}
