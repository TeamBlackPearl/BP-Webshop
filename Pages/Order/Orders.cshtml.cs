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
    public class OrdersModel : PageModel
    {
        public UserService UserService { get;  }
        
        //IEnumrable
        public IEnumerable<Models.Order> Orders { get; set; }

        public OrdersModel(UserService userService)
        {
            UserService = userService;
        }

        public void OnGet()
        {
        }
    }
}
