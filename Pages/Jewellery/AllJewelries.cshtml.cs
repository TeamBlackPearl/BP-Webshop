using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

        [BindProperty] public Jewelry Jewelry { get; set; }

        //Prop For Sort and filter methods
        //[BindProperty] public string SearchString { get; set; } 
        [BindProperty] public int MaxPri { get; set; }
        [BindProperty] public int MinPri { get; set; }


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

        public IActionResult OnGetSortByPrice()
        {
            Jewelries = jewelryService.SortByPrice().ToList();
            return Page();
        }

        public IActionResult OnGetSortByPriceDesc()
        {
            Jewelries = jewelryService.SortByPriceDesc().ToList();
            return Page();
        }


        public IActionResult OnPostPriceFilter(int maxPri, int minPri = 0)
        {
            Jewelries = jewelryService.PriceFilter(maxPri, minPri).ToList();
            return Page();
        }

    }
}
