using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Jewellery.NecklaceCRUD
{
    public class EditNecklaceModel : PageModel
    {
        private NecklaceService necklaceService;

        [BindProperty]
        public Necklace Necklace { get; set; }

        public EditNecklaceModel(NecklaceService necklaceService)
        {
            necklaceService = necklaceService;
        }
        public IActionResult OnGet(int id)
        {
            Necklace = necklaceService.GetNecklace(id);
            if (Necklace == null)
            {
                RedirectToPage("/NotFound");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Necklace= necklaceService.GetNecklace(id);
            await necklaceService.UpdateNecklaceAsync(Necklace);
            return RedirectToPage("AllNecklaces");
        }
    }
}