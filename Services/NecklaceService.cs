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
    }
}
