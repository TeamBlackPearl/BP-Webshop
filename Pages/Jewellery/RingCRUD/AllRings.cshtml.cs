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
    public class AllRingsModel : PageModel
    {
        private RingService ringService;
        public List<Ring> rings { get; set; }

        [BindProperty]
        public Ring Ring { get; set; }

        public AllRingsModel(RingService ringService)
        {
            this.ringService = ringService;
        }

        public IActionResult OnGet()
        {
            rings = ringService.GetRings().ToList();
            return Page();
        }

        public async Task<IActionResult> OnGetByRTypeAsync(Ring.RingTypes type)
        {

            rings = await ringService.GetRingByType(type);
            return Page();
        }
    }
}
