using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Jewellery
{
    public class AllJewelriesModel : PageModel
    {
        private JewelryService jewelryService;
        public List<Jewelry> Jewelries { get; set; }

        [BindProperty]
        public Jewelry Jewelry { get; set; }


        public AllJewelriesModel(JewelryService jewelryService)
        {
            this.jewelryService = jewelryService;
        }


        public IActionResult OnGet()
        {
            Jewelries = jewelryService.GetAllJewelries().ToList();
            return Page();


        }

        public IActionResult OnPost(string searchCriteria)
        {
            searchCriteria ??= "";

            if (jewelryService != null)
            {
                Jewelries = jewelryService.GetAllJewelries()
                    .FindAll(x => x.JewelryTitle.ToUpper().Contains(searchCriteria.ToUpper()));
                 //return RedirectToPage("/Jewellery/AllJewelries");
            }

            return Page();
        }
    }
}
