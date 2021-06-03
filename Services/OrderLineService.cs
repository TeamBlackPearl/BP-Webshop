using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class OrderLineService
    {
        public List<OrderLine> OrderLineList { get; set; }

        public GenericCRUDMethods<OrderLine> DbService { get; set; }

        public OrderLineService(GenericCRUDMethods<OrderLine> dbService)
        {
            DbService = dbService;
            OrderLineList = DbService.GetObjectsAsync().Result.ToList();

        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return OrderLineList;
        }

        public async Task AddToCart(OrderLine orderLine)
        {
            //OrderLine orderLine = new OrderLine(id);
            //if (OrderLineList.Contains(orderLine))
            //{
            //    foreach (var line in OrderLineList)
            //    {
            //        if (line.Equals(orderLine))
            //        {
            //            line.ProductCount++;
            //            return;
            //        }
            //    }

            //    //await DbService.UpdateObjectAsync(orderLine);
            //}
            //else
            //{
            //    orderLine.ProductCount = 1;
            //    OrderLineList.Add(orderLine);
            //}
            await DbService.AddObjectAsync(orderLine);
        }

        public async Task DeleteOrderLine(int id)
        {
            OrderLine orderLineToDelete = new OrderLine(id);
            OrderLineList.Remove(orderLineToDelete);
            await DbService.DeleteObjectAsync(orderLineToDelete);
        }

        public async Task ChangeProductCount(int jewelryId, int productCount)
        {
            if (productCount == 0)
            {
                await DeleteOrderLine(jewelryId);
                return;
            }

            OrderLine updateOrderLine = new OrderLine(jewelryId);
            foreach (var orderLine in OrderLineList)
            {
                if (orderLine.Equals(updateOrderLine))
                {
                    orderLine.ProductCount = productCount;
                    return;
                }
            }

            await DbService.UpdateObjectAsync(updateOrderLine);
        }

        
    }
}

