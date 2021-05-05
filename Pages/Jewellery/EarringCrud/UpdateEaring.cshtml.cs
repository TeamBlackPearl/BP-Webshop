using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Jewellery.EarringCrud
{
    public class UpdateEaringModel : PageModel
    {
        //models navigation
        [BindProperty]
        public Models.Earring Earring { get; set; }

        public void OnGet()
        {
        }
    }
}
