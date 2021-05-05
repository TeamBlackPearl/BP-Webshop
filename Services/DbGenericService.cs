using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class DbGenericService<T>
    {
        public async Task AddObjectAsync(T obj)
        {
            using (var context = new BlackPDbContext())
            {
                context.Add(obj);
                await context.SaveChangesAsync();
            }
        }
    }
}
