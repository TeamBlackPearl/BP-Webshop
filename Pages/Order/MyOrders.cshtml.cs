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
    public class MyOrdersModel : PageModel
    {
        public UserService UserService;
        public IEnumerable<Models.Order> MyOrders { get; set; }

        public MyOrdersModel(UserService userService)
        {
            UserService = userService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            User currentUser = UserService.GetUserByFirstName(HttpContext.User.Identity.Name);
            MyOrders = UserService.GetOrdersByUser(currentUser).Result.Orders;
            return Page();
        }
    }
}
