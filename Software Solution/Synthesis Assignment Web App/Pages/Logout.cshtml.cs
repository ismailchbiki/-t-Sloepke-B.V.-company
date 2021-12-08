using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dutch_Experience.Pages
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
        }

        // HttpContext.SignOutAsync kills the cookie
        public async Task<IActionResult> OnPostAsync()
        {
            //.SignOutAsync is not in httpcontext it's an extention method 
            await HttpContext.SignOutAsync("MyCookieAuth");

            return RedirectToPage("/Login");
        }
    }
}
