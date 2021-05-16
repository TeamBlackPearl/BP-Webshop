using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class RingService
    {
        private List<Ring> rings;

        public GenericCRUDMethods<Ring> DbCrudMethods { get; set; }

        public RingService(GenericCRUDMethods<Ring> dbCrudMethods)
        {
            DbCrudMethods = dbCrudMethods;
            rings = dbCrudMethods.GetObjectsAsync().Result.ToList();

        }
        public async Task AddRingAsync(Ring ring)
        {
            rings.Add(ring);
            await DbCrudMethods.AddObjectAsync(ring);
        }

        public IEnumerable<Ring> GetRings()
        {
            return rings;
        }

        public Ring GetRing(int id)
        {
            foreach (var ring in rings)
            {
                if (ring.JewelryID == id)
                {
                    return ring;
                }
            }

            return null;
        }

        public async Task DeleteRingAsync(int id)
        {
            Ring ringToDelete = rings.Find(ring => ring.JewelryID == id);
            if (ringToDelete != null)
            {
                rings.Remove(ringToDelete);
                await DbCrudMethods.DeleteObjectAsync(ringToDelete);
            }
        }

        public async Task UpdateRingAsync(Ring Ring)
        {
            if (Ring != null)
            {
                foreach (var ring in rings)
                {
                    if (ring.JewelryID == Ring.JewelryID)
                    {
                        ring.JewelryTitle = Ring.JewelryTitle;
                        ring.Description = Ring.Description;
                        ring.Color = Ring.Color;
                        ring.Price = Ring.Price;
                        ring.AverageRating = Ring.AverageRating;
                        ring.ImageLink = Ring.ImageLink;
                        ring.RingSize = Ring.RingSize;
                        ring.RingWidth = Ring.RingWidth;
                    }
                }

                await DbCrudMethods.UpdateObjectAsync(Ring);
            }
        }
    }
}
