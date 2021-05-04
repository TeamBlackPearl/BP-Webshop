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

        }

        public string HeadJewelrySize { get; set; }

        public HeadJewelry()
        {

        }

        public HeadJewelry(int jewelryId, string jewelryTitle, string description, string color, decimal price, string headJewelrySize, double averageRating, string imageLink) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            HeadJewelrySize = headJewelrySize;
        }
    }
}
