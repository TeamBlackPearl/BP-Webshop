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
    public class OrderLineModel : PageModel
    {
        public List<OrderLine> OrderLineList;
        //Vi bruger orderservice
        private OrderLineService _orderLineService;

        //nav prop
        [BindProperty]
        public OrderLine OrderLine { get; set; }

        public OrderLineModel(OrderLineService orderLineService)
        {
            _orderLineService = orderLineService;
        }

        public IActionResult OnGet()
        {
            OrderLineList = _orderLineService.GetOrderLines().ToList();
            return Page();
        }

    }
}
