using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Jewellery.HeadJewelleryCRUD
{
    public class AllHeadJewelleryModel : PageModel
    {
        private HeadJewelleryService _headJewelleryService;
        public List<Models.HeadJewelry> headJewelleryList;

        //models navigation
        [BindProperty]
        public Models.HeadJewelry HeadJewelry { get; set; }


        public AllHeadJewelleryModel(HeadJewelleryService headJewelleryService)
        {
            _headJewelleryService = headJewelleryService;
            //earringList = earringService.GetEarrings().ToList();
        }


        public IActionResult OnGet()
        {
            headJewelleryList = _headJewelleryService.GetHeadJewelries().ToList();
            return Page();
        }


    }
}