using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BP_Webshop.Models
{
    public class Jewelry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JewelryID { get; set; }
        [Required(ErrorMessage = "Title on jewellery is required")]
        [MinLength(3, ErrorMessage = "min. 3 letters")]
        public string JewelryTitle { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(150, ErrorMessage = "max. 150 letters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }
        [Required(ErrorMessage = "price is required")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "average rating is required")]
        [Range(0,5, ErrorMessage = "has to be between 0-5")]
        public double AverageRating { get; set; }
        [Required(ErrorMessage = "There has to be an image")]
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
