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
    }
}
