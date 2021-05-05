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
    public class AllBraceletsModel : PageModel
    {
        private BraceletService braceletService;
        public List<Bracelet> bracelets;

        [BindProperty]
        public Bracelet Bracelet { get; set; }

        public AllBraceletsModel(BraceletService braceService)
        {
            braceletService = braceService;
            //bracelets = braceService.GetBracelets().ToList();
        }
        

        public IActionResult OnGet()
        {
            bracelets = braceletService.GetBracelets().ToList();
            return Page();
        }


    }
}
