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
    public class UpdateHeadJewModel : PageModel
    {
        private HeadJewService _headJewService;

        //models navigation
        [BindProperty] 
        public Models.HeadJewelry HeadJew { get; set; }


        public UpdateHeadJewModel(HeadJewService headJewService)
        {
            _headJewService = headJewService;
        }

        public IActionResult OnGet(int id)
        {
            HeadJew = _headJewService.GetHeadJew(id);
            if (HeadJew == null)
            {
                RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _headJewService.UpdateHeadJewAsync(HeadJew);
            return RedirectToPage("AllHeadJew");
        }
    }
}
