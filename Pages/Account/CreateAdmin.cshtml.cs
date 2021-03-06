using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Account
{
    public class CreateAdminModel : PageModel
    {
        private AdminService _adminService;

        private List<AdminUser> _adminUserList;
        //PasswordHasher- kryptering
        private PasswordHasher<string> passwordHasher;

        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        [MinLength(2, ErrorMessage = "2 or more letters")]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Role { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public CreateAdminModel(AdminService adminService)
        {
            this._adminService = adminService;
            _adminUserList = adminService.AdminUserList;
            passwordHasher = new PasswordHasher<string>();
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

            await _adminService.AddAdminUserAsync(new AdminUser(Id, FirstName, LastName, "admin", Email, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/Index");

        }

    }
}
