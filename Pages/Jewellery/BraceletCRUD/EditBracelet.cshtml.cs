using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.CRUD.BraceletCRUD
{
    public class EditBraceletModel : PageModel
    {
        private BraceletService braceletService;

        [BindProperty]
        public Bracelet Bracelet { get; set; }

        public EditBraceletModel(BraceletService braceService)
        {
            braceletService = braceService;
        }

        public IActionResult OnGet(int id)
        {
            Bracelet = braceletService.GetBracelet(id);
            if (Bracelet == null)
            {
                RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            //Bracelet = braceletService.GetBracelet(id);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await braceletService.UpdateBraceletAsync(Bracelet);
            return RedirectToPage("AllBracelets");
        }


    }
}
