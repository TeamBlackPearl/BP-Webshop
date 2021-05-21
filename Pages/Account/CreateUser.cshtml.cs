using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Account
{
    public class CreateUserModel : PageModel
    {
        private UserService _userService;

        private List<User> users;

        //PasswordHasher- kryptering
        private PasswordHasher<string> passwordHasher;

        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        [MinLength(2, ErrorMessage = "Min. 2 letters is needed")]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "has to be 8 digits")]
        public string PhoneNumber { get; set; }
        [BindProperty] 
        public string Role { get; set; }
        //UserName
        [BindProperty]
        [EmailAddress(ErrorMessage = "@ is needed")]
        public string Email { get; set; }

        [BindProperty] 
        [PasswordPropertyText]
        public string Password { get; set; }


        public CreateUserModel(UserService userService)
        {
            this._userService = userService;
            users = userService.UsersList;
            passwordHasher = new PasswordHasher<string>();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            await _userService.AddUserAsync(new User(Id, FirstName, LastName, Address, PhoneNumber, "user", Email, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/Index");
        }

    }
}
