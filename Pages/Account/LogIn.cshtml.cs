using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
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
    /// <summary>
    /// 
    /// </summary>
    
    [BindProperties]
    public class LogInModel : PageModel
    {
        private UserService _userService;

        private List<AUser> allUserTypes;

        public LogInModel(UserService userService)
        {
            _userService = userService;
        }

        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Message { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            List<AUser> allUserTypes = _userService.GetAllUserTypes();

            foreach (var u in allUserTypes)
            {

                if (Email == u.Email)
                {
                    var passwordHasher = new PasswordHasher<string>();
                    if (passwordHasher.VerifyHashedPassword(null, u.Password, Password) ==
                        PasswordVerificationResult.Success)
                    {
                        //LoggedInUser = u;
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, u.FirstName)

                        };

                        if (u.Role == "admin") claims.Add(new Claim(ClaimTypes.Role, u.Role));

                        var claimsIdentity =
                            new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity));
                        return RedirectToPage("/Index");
                    }
                }
            }

            Message = "Invalid attempt!";
            return Page();
        }
    }
}

    

