using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace BP_Webshop.Models
{
    public class Earring : Jewelry
    {
        public enum EarringTypes
        {
            Jhumkay,
            Tops,
        }

        public double EarringLength { get; set; }
        public EarringTypes EarringType { get; set; }

        public Earring()
        {
            
        }

        public Earring(int jewelryId, string jewelryTitle, string description, string color, decimal price, double earringLength, double averageRating, string imageLink, EarringTypes earringType) : base(jewelryId, jewelryTitle, description, color, price, averageRating, imageLink)
        {
            EarringLength = earringLength;
            EarringType = earringType;
        }

    }
}
