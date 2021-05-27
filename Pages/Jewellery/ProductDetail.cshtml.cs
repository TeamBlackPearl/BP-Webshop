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
    public class ProductDetailModel : PageModel
    {
        private JewelryService jewelryService;
         public List<Jewelry> jewelries { get; set; } 

         [BindProperty]
        public Jewelry Jewelry { get; set; }

        public ProductDetailModel(JewelryService jewelryService)
        {
            this.jewelryService = jewelryService;
        }

        public void OnGet(int id)
        {

            jewelries = jewelryService.GetAllJewelries();
            Jewelry = jewelryService.GetJewelry(id);

        }
    }
}
