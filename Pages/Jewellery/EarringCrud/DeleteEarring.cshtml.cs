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
    public class DeleteEarringModel : PageModel
    {
        private EarringService _earringService;
        private List<Models.Earring> earringList;

        //models navigation
        [BindProperty]
        public Models.Earring Earring { get; set; }

        public DeleteEarringModel(EarringService earringService)
        {
            _earringService = earringService;
            //this.earringList = _earringService.GetEarrings().ToList();
        }


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
            Earring = _earringService.GetEarring(id);

            await _earringService.DeleteEarringAsync(Earring.JewelryID);
            return RedirectToPage("AllEarrings");
        }
    }
}
