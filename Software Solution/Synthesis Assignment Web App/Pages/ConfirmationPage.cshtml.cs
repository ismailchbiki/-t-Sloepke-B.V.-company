using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models.Administration;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class ConfirmationPageModel : PageModel
    {

        //Quote quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");

        QuoteAdministration manageQuote = new QuoteAdministration();

        public void OnGet()
        {
        }

        public IActionResult OnPostConfirm()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Boat boat = HttpContext.Session.GetObjectFromJson<Boat>("BoatDescription");
            Item item = HttpContext.Session.GetObjectFromJson<Item>("ItemDescription");
            Customer customer = HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails");
            Quote quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");

            manageQuote.AddQuote(customer,boat, item, quote);

            return Page();
        }
    }
}
