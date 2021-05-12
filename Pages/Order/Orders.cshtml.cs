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
        private BraceletService braceletService;
        private EarringService earringService;
        private HeadJewService headJewService;
        private NecklaceService necklaceService;
        private RingService ringService;
        private UserService userService;
        private OrderService orderService;
        public Models.Bracelet Bracelet { get; set; }
        public Models.Earring Earring { get; set; }
        public Models.HeadJewelry HeadJewelry { get; set; }
        public Models.Necklace Necklace { get; set; }

    }
}
