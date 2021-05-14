using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class HeadJewelry : Jewelry
    {
        public enum HeadJewelryTypes
        {
            Bindi,
            MathaPatti,
            Jhoomar,
        }


        public string HeadJewelrySize { get; set; }
        public HeadJewelryTypes HeadJewType { get; set; }

        public HeadJewelry()
        {

        }

        public HeadJewelry(int jewelryId, string jewelryTitle, string description, string color, decimal price, string headJewelrySize, double averageRating, string imageLink, HeadJewelryTypes headJewType) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            HeadJewelrySize = headJewelrySize;
            HeadJewType = headJewType;
        }
    }
}
