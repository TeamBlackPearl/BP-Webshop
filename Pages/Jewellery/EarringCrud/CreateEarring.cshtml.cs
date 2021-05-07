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
    public class CreateEarringModel : PageModel
    {
        private EarringService _earringService;
        private List<Models.Earring> earringList;

        //models navigation
        [BindProperty] 
        public Models.Earring Earring { get; set; }

        public CreateEarringModel(EarringService earringService)
        {
            _earringService = earringService;
            //this.earringList = _earringService.GetEarrings().ToList();
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
            await _earringService.AddEarringAsync(Earring);
            return RedirectToPage("AllEarrings");
        }
    }
}
