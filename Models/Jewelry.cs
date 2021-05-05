using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class Jewelry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JewelryID { get; set; }
        public string JewelryTitle { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public double AverageRating { get; set; }
        public string ImageLink { get; set; }

        public Jewelry()
        {
                
        }

        public Jewelry(int jewelryId, string jewelryTitle, string description, string color, decimal price, double averageRating, string imageLink)
        {
            JewelryID = jewelryId;
            JewelryTitle = jewelryTitle;
            Description = description;
            Color = color;
            Price = price;
            AverageRating = averageRating;
            ImageLink = imageLink;
        }
    }
}
