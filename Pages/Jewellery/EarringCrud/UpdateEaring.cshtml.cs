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
    public class UpdateEaringModel : PageModel
    {
        private EarringService _earringService;
        private List<Models.Earring> earringList;

        //models navigation
        [BindProperty]
        public Models.Earring Earring { get; set; }

        public UpdateEaringModel(EarringService earringService)
        {
            _earringService = earringService;
            this.earringList = _earringService.GetEarrings().ToList();
        }
        private BraceletService braceletService;


        public IActionResult OnGet(int id)
        {
            Earring = _earringService.GetEarring(id);
            if (Earring == null)
            {
                RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            //Earring = _earringService.GetEarring(id);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _earringService.UpdateEarringAsync(Earring);
            return RedirectToPage("AllEarrings");
        }
    }
}
