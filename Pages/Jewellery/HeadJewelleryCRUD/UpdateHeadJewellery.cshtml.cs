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
    public class UpdateHeadJewelleryModel : PageModel
    {
        private HeadJewelleryService _headJewelleryService;
        public List<Models.HeadJewelry> headJewelleryList;
        //models navigation
        [BindProperty]
        public Models.HeadJewelry HeadJewelry { get; set; }


        public UpdateHeadJewelleryModel(HeadJewelleryService headJewelleryService)
        {
            _headJewelleryService = headJewelleryService;
        }

        public IActionResult OnGet(int id)
        {
            HeadJewelry = _headJewelleryService.GetHeadJewelry(id);
            if (HeadJewelry == null)
            {
                RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            //HeadJewelry = _headJewelleryService.GetHeadJewelries(id);
            await _headJewelleryService.UpdateHeadJewelryAsync(HeadJewelry);
            return RedirectToPage("/AllHeadJewellery");
        }

    }
}
