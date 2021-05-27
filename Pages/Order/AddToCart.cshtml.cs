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
        public UserService UserService;

        [BindProperty]
        public Jewelry Jewelry { get; set; }
        [BindProperty]
        public OrderLine OrderLine { get; set; }
        [BindProperty]
        public Models.Order Order { get; set; }
        [BindProperty] public User User { get; set; }
        [BindProperty] public int Count { get; set; }
        [BindProperty] public double Tax { get; set; }

        public AddToCartModel(JewelryService jewelryService, OrderService orderService, OrderLineService orderLineService, UserService userService)
        {
            JewelryService = jewelryService;
            OrderService = orderService;
            OrderLineService = orderLineService;
            UserService = userService;
        }

        public IActionResult OnGet(int id)
        {
            Jewelry = JewelryService.GetJewelry(id);
            Order = OrderService.GetOrder(id);
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Jewelry = JewelryService.GetJewelry(id);
            Order.UserId = User.Id;
            OrderLine.JewelryId = Jewelry.JewelryID;
            OrderLine.OrderId = Order.OrderId;
            OrderLine.ProductCount = Count;
            Order.Tax = Tax;
            //Order.T= OrderService.TotalPriceWithoutTax() * (1 + ((decimal)Tax / 100));
            await OrderLineService.AddToCart(id);
            return RedirectToPage("/Jewellery/AllJewelries");
        }


    }
}
