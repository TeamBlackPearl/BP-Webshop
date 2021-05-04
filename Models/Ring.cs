using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class Ring : Jewelry
    {
        public enum RingTypes
        {

        }

        public int RingSize { get; set; }
        public double RingWidth { get; set; }

        public Ring()
        {

        }

        public Ring(int jewelryId, string jewelryTitle, string description, string color, decimal price, int ringSize, double ringWidth, double averageRating, string imageLink) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            RingSize = ringSize;
            RingWidth = ringWidth;
        }
    }
}
