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
        private HeadJewService headJewService;
        private RingService ringService;

        public JewelryService(BraceletService braceletService, NecklaceService necklaceService, EarringService earringService, HeadJewService headJewService, RingService ringService)
        {
            this.braceletService = braceletService;
            this.necklaceService = necklaceService;
            this.earringService = earringService;
            this.headJewService = headJewService;
            this.ringService = ringService;
        }

        public List<Jewelry> GetAllJewelries()
        {
            Jewelries = new List<Jewelry>(necklaceService.GetNecklaces().Count() +
                                          braceletService.GetBracelets().Count() +
                                          earringService.GetEarrings().Count() +
                                          ringService.GetRings().Count() +
                                          headJewService.GetAllHeadJew().Count());
            Jewelries.AddRange(necklaceService.GetNecklaces());
            Jewelries.AddRange(braceletService.GetBracelets());
            Jewelries.AddRange(earringService.GetEarrings());
            Jewelries.AddRange(ringService.GetRings());
            Jewelries.AddRange(headJewService.GetAllHeadJew());
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
