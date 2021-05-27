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
    public class AllHeadJewModel : PageModel
    {
            private HeadJewService _headJewService;
            public List<Models.HeadJewelry> headJewList;

            //models navigation
            [BindProperty]
            public Models.HeadJewelry HeadJewelry { get; set; }


            public AllHeadJewModel(HeadJewService headJewService)
            {
                _headJewService = headJewService;
            }

            public IActionResult OnGet()
            {
                headJewList = _headJewService.GetAllHeadJew().ToList();
                return Page();
            }


            public async Task<IActionResult> OnGetByHTypeAsync(HeadJewelry.HeadJewelryTypes type)
            {

                headJewList = await _headJewService.GetHeadJbyType(type);
                return Page();
            }
    }
}
