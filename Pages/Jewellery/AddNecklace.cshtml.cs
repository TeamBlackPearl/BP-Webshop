using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.CRUD
{
    public class AddNecklaceModel : PageModel
    {
        private NecklaceService necklaceService;
        private List<Necklace> necklaces;

        [BindProperty]
        public Necklace Necklace { get; set; }

        public AddNecklaceModel(NecklaceService ns)
        {
            necklaceService = ns;
            necklaces = necklaceService.GetNecklaces().ToList();
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
            return RedirectToPage("/Index");
        }
    }
}
