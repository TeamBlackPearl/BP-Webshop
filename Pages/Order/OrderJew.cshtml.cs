using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Order
{
    public class OrderJewModel : PageModel
    {
        public OrderService OrderService;
        public UserService UserService;
        public JewelryService JewelryService;

        //To add more than one product:
        //public OrderLineService OrderLineService;

        public Jewelry Jewelry { get; set; }
        public User User { get; set; }
        public Models.Order Order { get; set; } = new Models.Order();
        [BindProperty] public int Count { get; set; }


        public OrderJewModel(OrderService orderService, UserService userService, JewelryService jewelryService)
        {
            OrderService = orderService;
            UserService = userService;
            JewelryService = jewelryService;
        }

        public void OnGet(int id)
        {
            Jewelry = JewelryService.GetJewelry(id);
            User = UserService.GetUserByFirstName(HttpContext.User.Identity.Name);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Jewelry = JewelryService.GetJewelry(id);
            User = UserService.GetUserByFirstName(HttpContext.User.Identity.Name);

            Order.UserId = User.Id ;
            Order.JewelryID = Jewelry.JewelryID;
            //Order.Jewelry = Jewelry;
            Order.OrderDate=DateTime.Now;
            Order.ProductCount = Count;
            OrderService.AddOrder(Order);
            return RedirectToPage("/Jewellery/AllJewelries");

        }
    }
}
