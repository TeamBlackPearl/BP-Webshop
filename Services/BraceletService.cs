using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using BP_Webshop.Models;
using Microsoft.Extensions.Primitives;

namespace BP_Webshop.Services
{
    public class BraceletService
    {
        public List<Bracelet> Bracelets { get; set; }
        private GenericCRUDMethods<Bracelet> CrudMethods { get; set; }

        public BraceletService(GenericCRUDMethods<Bracelet> crudMethods)
        {
            CrudMethods = crudMethods;

            Bracelets = crudMethods.GetObjectsAsync().Result.ToList();
        }

        public async Task AddBraceletAsync(Bracelet bracelet)
        {
            Bracelets.Add(bracelet);
            await CrudMethods.AddObjectAsync(bracelet);
        }

        public IEnumerable<Bracelet> GetBracelets()
        {
            return Bracelets;
        }

        public Bracelet GetBracelet(int id)
        {
            foreach (var bracelet in Bracelets)
            {
                if (bracelet.JewelryID == id)
                {
                    return bracelet;
                }
            }

            return null;
        }

        public async Task DeleteBraceletAsync(int id)
        {
            Bracelet braceletToDelete = Bracelets.Find(bracelet => bracelet.JewelryID == id);
            if (braceletToDelete != null)
            {
                Bracelets.Remove(braceletToDelete);
                await CrudMethods.DeleteObjectAsync(braceletToDelete);
            }
        }

        public async Task UpdateBraceletAsync(Bracelet bracelet)
        {
            if (bracelet != null)
            {
                foreach (var brace in Bracelets)
                {
                    if (brace.JewelryID == bracelet.JewelryID)
                    {
                        brace.JewelryTitle = bracelet.JewelryTitle;
                        brace.Description = bracelet.Description;
                        brace.Color = bracelet.Color;
                        brace.Price = bracelet.Price;
                        brace.AverageRating = bracelet.AverageRating;
                        brace.ImageLink = bracelet.ImageLink;
                        brace.BraceletLength = bracelet.BraceletLength;
                        brace.BraceletWidth = bracelet.BraceletWidth;
                    }
                }

                await CrudMethods.UpdateObjectAsync(bracelet);
            }
        }

       

        //public List<Bracelet> GetBByCat( string subtype)
        //{
        //    List<Bracelet> SubBracelets = new List<Bracelet>();
        //    foreach (var brc in Bracelets)
        //    {
        //        if (brc.BraceletType == subtype)
        //        {
        //            SubBracelets.Add(brc);
        //        }
        //    }

        //    return SubBracelets;

        //}

        public static List<string> GetTypes()
        {
            return Enum.GetNames(typeof(Bracelet.BraceletTypes)).ToList();
        }
    }
}
