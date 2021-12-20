using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models.Administration;
using SynthesisAssignment.MyClasses.Classes;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class MyReservationModel : PageModel
    {
        [BindProperty]
        public Quote Reservation { get; set; }
        public Quote Quote = new Quote();

        public static string QuoteIsNotFound;

        //to get all the quotes
        QuoteAdministration manageQuotes = new QuoteAdministration();

        public void OnGet()
        {
            //communicate the quote to the page (reference number)
            if (HttpContext.Session.GetObjectFromJson<Quote>("Quote") != null)
            {
                Quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");
            }
        }

        public IActionResult OnPostFindQuote()
        {
            //clear the session
            HttpContext.Session.SetObjectAsJson("Quote", null);

            //fetch quote by id
            if (manageQuotes.GetQuoteByID(Reservation) != null)
            {
                HttpContext.Session.SetObjectAsJson("MyReservation", manageQuotes.GetQuoteByID(Reservation));

                QuoteIsNotFound = null;
                return RedirectToPage("ConfirmationPage");
            }

            QuoteIsNotFound = "Quote was not found";
            return RedirectToPage("MyReservation");
        }

        public void OnPostClear()
        {
            if (HttpContext.Session.GetObjectFromJson<Quote>("Quote") != null)
            {
                HttpContext.Session.SetObjectAsJson("Quote", null);

                RedirectToPage("MyReservation");
            }
        }
    }
}
