using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BP_Webshop.Pages.Account
{
    public class LogInModel : PageModel
    {
        /// <summary>
        /// When an identity is created it may be assigned one or more claims
        /// issued by a trusted party. A claim is a name value pair that represents
        /// what the subject is, not what the subject can do.
        /// </summary>
        
        private UserService _userService;
        //ref user
        public User Users { get; set; }

        [Required, EmailAddress, BindProperty]
        public string Email { get; set; }

        [Required, BindProperty]
        public string Password { get; set; }

        //public string Message { get; set; }

        public LogInModel(UserService userService)
        {
            _userService = userService;
        }   

        public void OnGet()
        {
        }

       
        public IActionResult OnPost()
        {
            bool validateLogin = _userService.ValidateLogin(Email, Password);

            if ( ! validateLogin)
            {
                return Page();
            }
            //??
            TempData["LoginSuccess"] = "Login Succesful";
            //Scheme
            var cookie = CookieAuthenticationDefaults.AuthenticationScheme;

            var user = new ClaimsPrincipal
            (
                new ClaimsIdentity
                (
                    new[] 
                        {new Claim(ClaimTypes.Name, Email),},
                    cookie
                )
            );
            return SignIn(user, cookie);
        }
    }
}
