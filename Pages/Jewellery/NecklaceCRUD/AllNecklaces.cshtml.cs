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
    public class AllNecklacesModel : PageModel
    {
        private NecklaceService necklaceService;
        public List<Necklace> necklaces { get; set; }

        [BindProperty]
        public Necklace Necklace { get; set; }

        public AllNecklacesModel(NecklaceService necklaceService)
        {
            this.necklaceService = necklaceService;
            
        }

        public IActionResult OnGet()
        {
            necklaces = necklaceService.GetNecklaces().ToList();
            return Page();
        }

        public async Task<IActionResult> OnGetByNTypeAsync(Necklace.NecklaceTypes type)
        {

            necklaces = await necklaceService.GetNecklaceByType(type);
            return Page();
        }
    }
}
