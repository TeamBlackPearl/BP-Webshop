using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Jewellery.RingCRUD
{
    public class EditRingModel : PageModel
    {
        private RingService ringService;

        [BindProperty]
        public Ring Ring { get; set; }

        public EditRingModel(RingService ringService)
        {
            this.ringService = ringService;
        }
        public IActionResult OnGet(int id)
        {
            Ring = ringService.GetRing(id);
            if (Ring == null)
            {
                RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            
            await ringService.UpdateRingAsync(Ring);
            return RedirectToPage("AllRings");
        }
    }
}
