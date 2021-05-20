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
            Order OrderToDelete = OrderList.Find(order => order.OrderId == id);
            if (OrderToDelete != null)
            { 
                OrderList.Remove(OrderToDelete); 
                await DbService.DeleteObjectAsync(OrderToDelete);
            }
        }

        public decimal AddPriceToTotalPrice(Order order)
        {
            var totalPrice = order.TotalPrice;
            var tax = order.Tax;
            foreach (var jewelry in JewelryService.Jewelries)
            {
                //Type casting er brugt her, da man ikke kan gange en decimal med en double.
                // Så jeg har lavet tax, som er en double, om til en decimal,
                // eftersom decimal er det man bruger under finansielle beregninger    
                totalPrice +=  (jewelry.Price * (1 + ((decimal)tax/100)));
            }

            return totalPrice;
        }
        public decimal RemovePriceFromTotalPrice(Order order)
        {
            var totalPrice = order.TotalPrice;
            var tax = order.Tax;
            foreach (var jewelry in JewelryService.Jewelries)
            {
                totalPrice -= (jewelry.Price * (1 + ((decimal)tax / 100)));
            }
            
            return totalPrice;
        }

        public decimal TotalPriceWithDelivery(Order order)
        {
            var totalPrice = order.TotalPrice;
            var priceWithDelivery = order.DeliveryPrice;

            priceWithDelivery += totalPrice;

            return priceWithDelivery;
        }

    }
}
