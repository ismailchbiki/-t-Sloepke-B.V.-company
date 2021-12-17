using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class CustomerDetailsModel : PageModel
    {
        [BindProperty]
        public Quote Quote { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpContext.Session.SetObjectAsJson("CustomerDetails", Quote.Customer);

            return RedirectToPage("confirmationpage");
        }
    }
}
