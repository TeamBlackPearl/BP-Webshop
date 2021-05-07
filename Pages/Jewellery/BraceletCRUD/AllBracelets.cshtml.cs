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
        public List<Bracelet> bracelets { get; set; }

        //Forbindelse til klassen Bracelet (Navigation)
        [BindProperty]
        public Bracelet Bracelet { get; set; }

        public AllBraceletsModel(BraceletService braceService)
        {
            //Dependency (Initialisering)
            braceletService = braceService;
            //bracelets = braceService.GetBracelets().ToList();
        }
        
        //Iaction henter og viser den ved at hente dem til en lokal liste
        public IActionResult OnGet()
        {
            bracelets = braceletService.GetBracelets().ToList();
            return Page();
        }
        

    }
}
