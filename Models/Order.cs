using System;
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
        [ForeignKey("JewelryId")]
        public int Id { get; set; }
        public decimal DeliveryPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public Order()
        {
            
        }

        public Order(User user, Jewelry product)
        {
            Date = DateTime.Now;
            User = user;
            Product = product;
        }
    }
}
