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
        public OrderService OrderService;
        public OrderLineService OrderLineService;

        public List<OrderLine> OrderLines { get; set; }

        public OrdersModel(OrderService orderService, OrderLineService orderLineService)
        {
            OrderService = orderService;
            OrderLineService = orderLineService;
        }


        public void OnGet()
        {

        }
    }
}
