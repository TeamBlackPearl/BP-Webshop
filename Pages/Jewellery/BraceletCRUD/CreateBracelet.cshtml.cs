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
    public class CreateBraceletModel : PageModel
    {
        private BraceletService braceletService;
        private List<Bracelet> bracelets;

        [BindProperty]
        public Bracelet Bracelet { get; set; }

        public CreateBraceletModel(BraceletService braceletService)
        {
            this.braceletService = braceletService;
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
            await braceletService.AddBraceletAsync(Bracelet);
            return RedirectToPage("AllBracelets");
        }


    }
}
