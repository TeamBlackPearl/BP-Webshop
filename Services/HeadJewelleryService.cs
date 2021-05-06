using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BP_Webshop.Services
{
    public class HeadJewelleryService
    {
        private List<HeadJewelry> _headJewelryList;

        public GenericCRUDMethods<HeadJewelry> DbServiceMethods { get; set; }

        public HeadJewelleryService(GenericCRUDMethods<HeadJewelry> dbServiceMethods)
        {
            DbServiceMethods = dbServiceMethods;
            _headJewelryList = dbServiceMethods.GetObjectsAsync().Result.ToList();
        }


        public async Task AddHeadJewelryAsync(HeadJewelry headJewelry)
        {
            _headJewelryList.Add(headJewelry);
            await DbServiceMethods.AddObjectAsync(headJewelry);
        }

        public IEnumerable<HeadJewelry> GetHeadJewelries()
        {
            return _headJewelryList;
        }

        public HeadJewelry GetHeadJewelry(int id)
        {
            foreach (var h in _headJewelryList)
            {
                if (h.JewelryID == id)
                {
                    return h;
                }
            }

            return null;
        }

        public async Task DeleteHeadJewelryAsync(int id)
        {
            HeadJewelry headJewelryToDelete = _headJewelryList.Find(h => h.JewelryID == id);
            if (headJewelryToDelete != null)
            {
                _headJewelryList.Remove(headJewelryToDelete);
                await DbServiceMethods.DeleteObjectAsync(headJewelryToDelete);
            }
        }

        public async Task UpdateHeadJewelryAsync(HeadJewelry headJewelry)
        {
            if (headJewelry != null)
            {
                foreach (var h in _headJewelryList)
                {
                    if (h.JewelryID == headJewelry.JewelryID)
                    {
                        h.JewelryTitle = headJewelry.JewelryTitle;
                        h.Description = headJewelry.Description;
                        h.Color = headJewelry.Color;
                        h.Price = headJewelry.Price;
                        h.AverageRating = headJewelry.AverageRating;
                        h.ImageLink = headJewelry.ImageLink;
                        h.HeadJewelrySize = headJewelry.HeadJewelrySize;
                    }
                }

                await DbServiceMethods.UpdateObjectAsync(headJewelry);
            }
        }


    }


}

