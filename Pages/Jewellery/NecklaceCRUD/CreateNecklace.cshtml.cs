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
    public class CreateNecklaceModel : PageModel
    {
        private NecklaceService necklaceService;
        private List<Necklace> necklaces;

        [BindProperty]
        public Necklace Necklace { get; set; }

        public CreateNecklaceModel(NecklaceService necklaceService)
        {
            this.necklaceService = necklaceService;
            
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

            await necklaceService.AddNecklace(Necklace);
            return RedirectToPage("AllNecklaces");
        }
    }
}
