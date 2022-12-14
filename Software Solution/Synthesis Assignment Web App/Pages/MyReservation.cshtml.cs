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
    public class MyReservationModel : PageModel
    {
        [BindProperty]
        public Quote Reservation { get; set; }
        public Quote Quote = new Quote();

        public static string QuoteIsNotFound;

        //to get all the quotes
        //QuoteManagement manageQuotes = new QuoteAdministration();
        IQuoteManagment manageQuotes = new QuoteManagement(new DALQuote());

        public void OnGet()
        {

            //communicate the new made quote to the page (reference number)
            if (HttpContext.Session.GetObjectFromJson<Quote>("MyReservation") != null)
            {
                Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");
            }
        }

        public IActionResult OnPostFindQuote()
        {
            //clear the session
            HttpContext.Session.SetObjectAsJson("Quote", null);

            //fetch quote by id
            if (manageQuotes.GetQuoteByID(Reservation).PaymentStatus != null)
            {
                HttpContext.Session.SetObjectAsJson("MyReservation", manageQuotes.GetQuoteByID(Reservation));

                //in case quote is found
                QuoteIsNotFound = null;
                return RedirectToPage("ConfirmationPage");
            }

            QuoteIsNotFound = "Quote was not found";
            return RedirectToPage("MyReservation");
        }

        public IActionResult OnPostClear()
        {

            HttpContext.Session.SetObjectAsJson("Quote", null);
            HttpContext.Session.SetObjectAsJson("MyReservation", null);

            return RedirectToPage("MyReservation");
        }
    }
}
