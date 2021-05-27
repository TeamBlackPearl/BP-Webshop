﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BP_Webshop.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public decimal DeliveryPrice { get; set; }
        public double Tax { get; set; }
        public decimal TotalPrice { get; set; }

        public Order()
        {
            
        }

        public Order(int orderId, int userId)
        {
            OrderId = orderId;
            OrderDate = DateTime.Now;
            UserId = userId;
            Tax = 25;
            DeliveryPrice = 45;
            TotalPrice = 0;
        }
    }
}
