using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using Microsoft.EntityFrameworkCore;

namespace BP_Webshop.Services
{
    public class UserDBService : GenericCRUDMethods<User>
    {
        //public async Task<User> GetOrdersByIdAsync(int id)
        //{
        //    User user;

        //    using (var context = new BlackPDbContext())
        //    {
        //        user = context.Users
        //            .Include(u => u.Orders)
        //            .ThenInclude(j => j.Jewelry)
        //            .AsNoTracking()
        //            .FirstOrDefault(u => u.Id == id);
        //    }

        //    return user;
        //}
    }
}
