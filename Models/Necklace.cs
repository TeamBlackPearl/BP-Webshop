using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class Necklace : Jewelry
    {
        public enum NecklaceTypes
        {
            Mala,
            Choker,
            Multilayered,
        }

        public double NecklaceLength { get; set; }
        public double NecklaceWidth { get; set; }

        public Necklace()
        {

        }

        public Necklace(int jewelryId, string jewelryTitle, string description, string color, decimal price, double necklaceLength, double necklaceWidth, double averageRating, string imageLink) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            NecklaceLength = necklaceLength;
            NecklaceWidth = necklaceWidth;
        }

    }
}
