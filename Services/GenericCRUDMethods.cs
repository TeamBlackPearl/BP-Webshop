using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using Microsoft.EntityFrameworkCore;

namespace BP_Webshop.Services
{
    public class GenericCRUDMethods<T> where T : class
    {
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new BlackPDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task AddObjectAsync(T obj)
        {
            using (var context = new BlackPDbContext())
            {
                context.Set<T>().Add(obj);
                await context.SaveChangesAsync();
            }

        }

        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new BlackPDbContext())
            {
                context.Set<T>().Remove(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new BlackPDbContext())
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }
        }

        //tilføjet:
        public async Task<T> GetObjectByIdAsync(int id)
        {
            using (var context = new BlackPDbContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }
        //tilføjet:
        public async Task<User> GetOrdersByIdAsync(int id)
        {
            User user;

            using (var context = new BlackPDbContext())
            {
                user = context.Users
                    .Include(u => u.Orders)
                    .ThenInclude(j => j.Jewelry)
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Id == id);
            }

            return user;
        }
    }
}
