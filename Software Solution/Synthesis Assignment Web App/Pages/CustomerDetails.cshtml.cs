using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Administration;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class CustomerDetailsModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        QuoteAdministration manageQuote = new QuoteAdministration();

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                Page();
            }

            Boat boat = HttpContext.Session.GetObjectFromJson<Boat>("BoatDescription");
            Item item = HttpContext.Session.GetObjectFromJson<Item>("ItemDescription");
            Quote quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");

            //manageQuote.AddQuote(Customer, boat, item, quote);
        }
    }
}
