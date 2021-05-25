using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Orders
{
    public class AddToCartModel : PageModel
    {
        public JewelryService JewelryService;
        public OrderService OrderService;
        public OrderLineService OrderLineService;
        [BindProperty]
        public Jewelry Jewelry { get; set; }
        [BindProperty]
        public OrderLine OrderLine { get; set; }
        [BindProperty]
        public Models.Order Order { get; set; }
        [BindProperty] public int Count { get; set; }
        [BindProperty] public double Tax { get; set; }

        public AddToCartModel(JewelryService jewelryService, OrderService orderService, OrderLineService orderLineService)
        {
            JewelryService = jewelryService;
            OrderService = orderService;
            OrderLineService = orderLineService;
        }

        public IActionResult OnGet(int id)
        {
            JewelryService.GetJewelry(id);
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Jewelry = JewelryService.GetJewelry(id);
            OrderLine.JewelryId = Jewelry.JewelryID;
            OrderLine.OrderId = Order.OrderId;
            OrderLine.ProductCount = Convert.ToInt32(OrderLineService.ChangeProductCount(id, Count));
            Order.Tax = Tax;
            Order.TotalPrice = OrderService.TotalPriceWithoutTax() * (1 + ((decimal)Tax / 100));
            await OrderLineService.AddToCart(id);
            return Page();

        }
    }
}
