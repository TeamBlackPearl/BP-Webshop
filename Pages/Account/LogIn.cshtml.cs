using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Threading.Tasks;
using BP_Webshop.Models;
using BP_Webshop.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
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

       //Task
       //async - dele der arbejder asynkront
        public async Task<IActionResult> OnPost()
        {
            //midlertidig list vi sætte = list i userservice
            List<User> userList = _userService.UsersList;

            foreach (User user in userList)
            {
                if (Email == user.Email)
                {
                    var passwordHasher = new PasswordHasher<string>();

                    if (passwordHasher.VerifyHashedPassword(null,user.Password, Password) == PasswordVerificationResult.Success)
                    {
                        //loggedInUser = user;
                        //claims
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, Email)
                        };

                        //admin role
                        //if (Email == "Admin") claims.Add(new Claim(ClaimTypes.Role, "Admin"));

                        //cookie authentifikation
                        var claimsIdentity =
                            new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        
                        //await
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                         new ClaimsPrincipal(claimsIdentity));
                        return RedirectToPage("/Index");
                    }
                }
            }

            return Page();


            //bool validateLogin = _userService.ValidateLogin(Email, Password);
            //if ( ! validateLogin)
            //{
            //    return Page();
            //}
            ////??
            //TempData["LoginSuccess"] = "Login Succesful";
            ////Scheme
            //var cookie = CookieAuthenticationDefaults.AuthenticationScheme;

            //var user = new ClaimsPrincipal
            //(
            //    new ClaimsIdentity
            //    (
            //        new[] 
            //            {new Claim(ClaimTypes.Name, Email),},
            //        cookie
            //    )
            //);
            //return SignIn(user, cookie);

        }
    }
}
