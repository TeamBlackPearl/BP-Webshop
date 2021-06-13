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
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
       // public decimal DeliveryPrice { get; set; }

        //tilføjet: Jew ID
        [Required]
        public int JewelryID { get; set; }
        //tilføjet: Jew
        //Navigation Property
        public Jewelry Jewelry { get; set; }
        //tilføjet: ProductCount
        public int ProductCount { get; set; }

        //public double Tax { get; set; }
        //public decimal TotalPrice { get; set; }

        public Order()
        {
            
        }

        public Order(User user, Jewelry jewelry)
        {
            OrderDate = DateTime.Now;
            User = user;
            Jewelry = jewelry;
        }
    }
}
