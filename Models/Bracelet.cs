using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP_Webshop.Models
{
    public class Bracelet : Jewelry
    {
        public enum BraceletTypes
        {
            Kangan,
            Bangle

        }

        public double BraceletLength { get; set; }
        public double BraceletWidth { get; set; }
        public BraceletTypes BraceletType { get; set; }

        

        public Bracelet()
        {

        }

        
        public Bracelet(int jewelryId, string jewelryTitle, string description, string color, decimal price, double braceletLength, double braceletWidth, double averageRating, string imageLink, BraceletTypes braceletType) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            BraceletLength = braceletLength;
            BraceletWidth = braceletWidth;
            BraceletType = braceletType;
        }
    }
}
