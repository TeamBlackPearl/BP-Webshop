using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; }

        public GenericCRUDMethods<Order> DbService { get; set; }

        public OrderService( GenericCRUDMethods<Order> dbService)
        {
            DbService = dbService;
            OrderList = DbService.GetObjectsAsync().Result.ToList();
        }

        public async Task AddOrderAsync(Order order)
        {
            OrderList.Add(order);
            await DbService.AddObjectAsync(order);
        }

    }
}
