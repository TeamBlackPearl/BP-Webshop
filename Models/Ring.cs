using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class Ring : Jewelry
    {
        public enum RingTypes
        {
            Panjangla,
            DoubleRings,
            SilverRings,
        }

        [Required(ErrorMessage = "Size is required")]
        public int RingSize { get; set; }
        //optional
        public double RingWidth { get; set; }
        public RingTypes RingType { get; set; }

        public Ring()
        {

        }

        public Ring(int jewelryId, string jewelryTitle, string description, string color, decimal price, int ringSize, double ringWidth, double averageRating, string imageLink, RingTypes ringType) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            RingSize = ringSize;
            RingWidth = ringWidth;
            RingType = ringType;
        }
    }
}
