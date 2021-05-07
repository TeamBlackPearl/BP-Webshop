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
    public class CreateRingModel : PageModel
    {
        private RingService ringService;
        private List<Ring> rings;

        [BindProperty]
        public Ring Ring { get; set; }

        public CreateRingModel(RingService ringService)
        {
            this.ringService = ringService;
            
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

            await ringService.AddRing(Ring);
            return RedirectToPage("AllRings");
        }
    }
}
