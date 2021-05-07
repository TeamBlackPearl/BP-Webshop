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
    public class CreateHeadJewModel : PageModel
    {
            private HeadJewService _headJewService;
            public List<Models.HeadJewelry> headJewList;
            //models navigation
            [BindProperty]
            public Models.HeadJewelry HeadJew { get; set; }

            public CreateHeadJewModel(HeadJewService headJewService)
            {
                _headJewService = headJewService;
                this.headJewList = _headJewService.GetAllHeadJew().ToList();
            }

            public IActionResult OnGet()
            {
                return Page();

            }

            public async Task<IActionResult> OnPostAsync()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                await _headJewService.AddHeadJewAsync(HeadJew);
                return RedirectToPage("AllHeadJew");
            }

        
    }
}
