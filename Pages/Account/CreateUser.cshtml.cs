using System;
using System.Collections.Generic;
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
        /// <summary>
        /// [DataType(DataType.Password)]
        /// What is the role of [DataType(DataType.Password)] ?
        /// DataType as password, means that we will see the password field in non readable format.
        /// </summary>
        private UserService _userService;
        //PasswordHasher
        private PasswordHasher<string> passwordHasher;

        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        //UserName
        public string Email { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        public CreateUserModel(UserService userService)
        {
            _userService = userService;
            passwordHasher = new PasswordHasher<string>();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _userService.AddUser(new User(Id, FirstName, LastName, Address, PhoneNumber, Email, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/Index");
        }
    }
}
