using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class EarringService
    {
        private List<Earring> _earringsList;

        public GenericCRUDMethods<Earring> DbServiceMethods { get; set; }

        public EarringService(GenericCRUDMethods<Earring> dbServiceMethods)
        {
            DbServiceMethods = dbServiceMethods;
            _earringsList = dbServiceMethods.GetObjectsAsync().Result.ToList();
        }


        public async Task AddEarringAsync(Earring earring)
        {
            _earringsList.Add(earring);
            await DbServiceMethods.AddObjectAsync(earring);
        }

        public IEnumerable<Earring> GetEarrings()
        {
            return _earringsList;
        }

        public Earring GetEarring(int id)
        {
            foreach (Earring earring in _earringsList)
            {
                if (earring.JewelryID == id) return earring;
            }

            return null;
        }

        public async Task DeleteEarringAsync(int EarringId)
        {
            Earring EarringToBeDeleted = _earringsList.Find(earring => earring.JewelryID == EarringId);

            // foreach (Earring e in _earringsList)
            // {
            //     if (e.JewelryID == EarringId.JewelryID)
            //     {
            //         EarringToBeDeleted = e;
            //         break;
            //     }
            // }

            if (EarringToBeDeleted != null)
            {
                _earringsList.Remove(EarringToBeDeleted);
                //JsonFileService.SaveJsonObjects(items);
                await DbServiceMethods.DeleteObjectAsync(EarringToBeDeleted);
            }

        }


        public async Task UpdateEarringAsync(Earring earring)
        {
            if (earring != null)
            {
                foreach (Earring e in _earringsList)
                {
                    if (e.JewelryID == earring.JewelryID)
                    {
                        e.JewelryTitle = earring.JewelryTitle;
                        e.Price = earring.Price;
                    }
                }
                //JsonFileService.SaveJsonObjects(items);
                await DbServiceMethods.UpdateObjectAsync(earring);
            }
        }

    }
}
