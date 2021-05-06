using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class JewelryService
    {
        public List<Jewelry> Jewelries { get; set; }
        private BraceletService braceletService;
        private NecklaceService necklaceService;
        private EarringService earringService;

        public JewelryService(BraceletService braceletService, NecklaceService necklaceService, EarringService earringService)
        {
            this.braceletService = braceletService;
            this.necklaceService = necklaceService;
            this.earringService = earringService;
        }

        public List<Jewelry> GetAllJewelries()
        {
            Jewelries = new List<Jewelry>(necklaceService.GetNecklaces().Count() +
                                          braceletService.GetBracelets().Count() +
                                          earringService.GetEarrings().Count());
            Jewelries.AddRange(necklaceService.GetNecklaces());
            Jewelries.AddRange(braceletService.GetBracelets());
            Jewelries.AddRange(earringService.GetEarrings());
            return Jewelries;
        }

        public IEnumerable<Jewelry> SearchInJewelries(string criteria)
        {
            List<Jewelry> searchResults = new List<Jewelry>();
            if (criteria != null)
            {
                foreach (var jewelry in Jewelries)
                {
                    if (jewelry.JewelryTitle.ToLower().Contains(criteria.ToLower()))
                    {
                        searchResults.Add(jewelry);
                    }
                }   
            }

            return searchResults;
        }



    }
}
