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


        public GenericCRUDMethods<Order> DbService;
        public JewelryService JewelryService;
        public OrderLine OrderLine;
        public Order Order;


        public OrderService(GenericCRUDMethods<Order> dbService, JewelryService jewelryService)
        {
            DbService = dbService;
            OrderList = DbService.GetObjectsAsync().Result.ToList();

            JewelryService = jewelryService;
        }

        public async Task AddOrderAsync(Order order)
        {
            OrderList.Add(order);
            await DbService.AddObjectAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            Order orderToDelete = OrderList.Find(order => order.OrderId == id);
            if (orderToDelete != null)
            { 
                OrderList.Remove(orderToDelete); 
                await DbService.DeleteObjectAsync(orderToDelete);
            }
        }

        //public decimal TotalPriceWithDelivery(Order order)
        //{
        //    var totalPrice = order.TotalPrice;
        //    var priceWithDelivery = order.DeliveryPrice;

        //    priceWithDelivery += totalPrice;

        //    return priceWithDelivery;
        //}


        public decimal TotalPriceWithoutTax()
        {
            decimal totalPrice = 0;
            foreach (var jewelry in JewelryService.Jewelries)
            {
                totalPrice += jewelry.Price;
            }

            return totalPrice;
        }

    }
}
