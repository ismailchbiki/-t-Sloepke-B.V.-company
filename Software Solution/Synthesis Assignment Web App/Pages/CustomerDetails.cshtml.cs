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

        public Quote QuoteToUpdate;

        public void OnGet()
        {
            if (HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate") != null)
            {
                QuoteToUpdate = new Quote();
                QuoteToUpdate = HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate");
            }
        }

        //add new customer
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpContext.Session.SetObjectAsJson("CustomerDetails", Quote.Customer);

            return RedirectToPage("confirmationpage");
        }

        //update customer
        public IActionResult OnPostUpdateContactDetails()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpContext.Session.SetObjectAsJson("CustomerDetails", null);
            HttpContext.Session.SetObjectAsJson("NewCustomerDetails", Quote.Customer);

            return RedirectToPage("confirmationpage");
        }

        //keep same contact details
        public IActionResult OnPostDontChangeContactDetails()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpContext.Session.SetObjectAsJson("CustomerDetails", null);
            HttpContext.Session.SetObjectAsJson("NewCustomerDetails", HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate").Customer);

            return RedirectToPage("confirmationpage");
        }
    }
}
