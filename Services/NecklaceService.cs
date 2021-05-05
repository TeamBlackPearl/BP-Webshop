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
        
        public DbGenericService<Necklace> DbService { get; set; }

        public NecklaceService(DbGenericService<Necklace> dbService)
        {
            DbService = dbService;

            //necklaces = dbService.GetObjectsAsync().Result.ToList();

        }
        public void AddNecklace(Necklace necklace)
        {
            necklaces.Add(necklace);
            DbService.AddObjectAsync(necklace);
        }
    }
}
