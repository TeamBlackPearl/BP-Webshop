using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BP_Webshop.Services
{
    public class HeadJewService
    {
        private List<HeadJewelry> _headJewList;

        public GenericCRUDMethods<HeadJewelry> DbServiceMethods { get; set; }

        public HeadJewService(GenericCRUDMethods<HeadJewelry> dbServiceMethods)
        {
            DbServiceMethods = dbServiceMethods;
            _headJewList = dbServiceMethods.GetObjectsAsync().Result.ToList();
        }


        public async Task AddHeadJewAsync(HeadJewelry headJew)
        {
            _headJewList.Add(headJew);
            await DbServiceMethods.AddObjectAsync(headJew);
        }

        //get all
        public IEnumerable<HeadJewelry> GetAllHeadJew()
        {
            return _headJewList;
        }

        public HeadJewelry GetHeadJew(int id)
        {
            foreach (var h in _headJewList)
            {
                if (h.JewelryID == id)
                {
                    return h;
                }
            }

            return null;
        }

        public async Task DeleteHeadJewAsync(int id)
        {
            HeadJewelry headJewToDelete = _headJewList.Find(h => h.JewelryID == id);
            if (headJewToDelete != null)
            {
                _headJewList.Remove(headJewToDelete);
                await DbServiceMethods.DeleteObjectAsync(headJewToDelete);
            }
        }

        public async Task UpdateHeadJewAsync(HeadJewelry headJew)
        {
            if (headJew != null)
            {
                foreach (var h in _headJewList)
                {
                    if (h.JewelryID == headJew.JewelryID)
                    {
                        h.JewelryTitle = headJew.JewelryTitle;
                        h.Description = headJew.Description;
                        h.Color = headJew.Color;
                        h.Price = headJew.Price;
                        h.AverageRating = headJew.AverageRating;
                        h.ImageLink = headJew.ImageLink;
                        h.HeadJewelrySize = headJew.HeadJewelrySize;
                    }
                }

                await DbServiceMethods.UpdateObjectAsync(headJew);
            }
        }

        public async Task<List<HeadJewelry>> GetHeadJbyType(HeadJewelry.HeadJewelryTypes type)
        {
            List<HeadJewelry> hrc = new List<HeadJewelry>();
            using (var context = new BlackPDbContext())
            {
                hrc = await context.HeadJewelries
                    .Where(b => b.HeadJewType == type)
                    .ToListAsync();
            }

            return hrc;
        }


    }


}

