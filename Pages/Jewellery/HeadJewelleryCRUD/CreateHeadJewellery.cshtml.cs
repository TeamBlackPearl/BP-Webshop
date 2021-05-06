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
    public class CreateHeadJewelleryModel : PageModel
    {
        private HeadJewelleryService _headJewelleryService;
        public List<Models.HeadJewelry> headJewelleryList;
        //models navigation
        [BindProperty]
        public Models.HeadJewelry HeadJewelry { get; set; }

        public CreateHeadJewelleryModel(HeadJewelleryService headJewelleryService)
        {
            _headJewelleryService = headJewelleryService;
            this.headJewelleryList = _headJewelleryService.GetHeadJewelries().ToList();
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

            await _headJewelleryService.AddHeadJewelryAsync(HeadJewelry);
            return RedirectToPage("/Index");
        }
       
    }
}
