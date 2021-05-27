using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Jewellery.EarringCrud
{
    public class AllEarringsModel : PageModel
    {
        private EarringService _earringService;
        public List<Models.Earring> earringList;

        //models navigation
        [BindProperty]
        public Models.Earring Earring { get; set; }


            public AllEarringsModel(EarringService earringService)
            {
                _earringService = earringService;
                //earringList = earringService.GetEarrings().ToList();
            }


            public IActionResult OnGet()
            {
                earringList = _earringService.GetEarrings().ToList();
                return Page();
            }


            public async Task<IActionResult> OnGetByETypeAsync(Earring.EarringTypes type)
            {

                earringList = await _earringService.GetEarringbyType(type);
                return Page();
            }

    }
}
