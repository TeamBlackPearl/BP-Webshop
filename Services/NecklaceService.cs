using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class NecklaceService
    {
        private List<Necklace> necklaces;

        public GenericCRUDMethods<Necklace> DbCrudMethods { get; set; }

        public NecklaceService(GenericCRUDMethods<Necklace> dbCrudMethods)
        {
            DbCrudMethods = dbCrudMethods;
            necklaces = dbCrudMethods.GetObjectsAsync().Result.ToList();

        }
        public async Task AddNecklace(Necklace necklace)
        {
            necklaces.Add(necklace);
            await DbCrudMethods.AddObjectAsync(necklace);
        }

        public IEnumerable<Necklace> GetNecklaces()
        {
            return necklaces;
        }

        public Necklace GetNecklace(int id)
        {
            foreach (var necklace in necklaces)
            {
                if (necklace.JewelryID == id)
                {
                    return necklace;
                }
            }

            return null;
        }

        public async Task DeleteNecklaceAsync(int id)
        {
            Necklace necklaceToDelete = necklaces.Find(necklace => necklace.JewelryID == id);
            if (necklaceToDelete != null)
            {
                necklaces.Remove(necklaceToDelete);
                await DbCrudMethods.DeleteObjectAsync(necklaceToDelete);
            }
        }

        public async Task UpdateNecklaceAsync(Necklace Necklace)
        {
            if (Necklace != null)
            {
                foreach (var necklace in necklaces)
                {
                    if (necklace.JewelryID == necklace.JewelryID)
                    {
                        necklace.JewelryTitle = Necklace.JewelryTitle;
                        necklace.Description = Necklace.Description;
                        necklace.Color = Necklace.Color;
                        necklace.Price = Necklace.Price;
                        necklace.AverageRating = Necklace.AverageRating;
                        necklace.ImageLink = Necklace.ImageLink;
                        necklace.NecklaceLength = Necklace.NecklaceLength;
                        necklace.NecklaceWidth = Necklace.NecklaceWidth;
                    }
                }

                await DbCrudMethods.UpdateObjectAsync(Necklace);
            }
        }
    }
}
