using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Administration;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.MyClasses.Classes.MyHelpers;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class ConfirmationPageModel : PageModel
    {

        public Quote Quote = new Quote();
        QuoteAdministration manageQuote = new QuoteAdministration();
        InventoryAdministration manageGear = new InventoryAdministration();

        //message to show
        public string Notification;

        //gear price
        public double BoatCost;
        public double ItemCost;

        //check rental time
        public bool RentalInMoreThanWeek = false;

        public IActionResult OnGet()
        {

            //MADE QUOTES ACCESS
            if (HttpContext.Session.GetObjectFromJson<Quote>("MyReservation") != null &&
                HttpContext.Session.GetObjectFromJson<Quote>("Quote") == null &&
                HttpContext.Session.GetObjectFromJson<Quote>("NewQuote") == null)
            {
                //made reservations from DB
                Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");

                //update/cancel a reservation allowed for longer period than a week
                if (Quote.Duration > 168)
                {
                    RentalInMoreThanWeek = true;
                }

                //gear cost
                BoatCost = manageGear.GetGearByType(Quote.Boat).UnitCost;
                ItemCost = manageGear.GetGearByType(Quote.Item).UnitCost;
            }

            //MAKING NEW QUOTES
            else if (HttpContext.Session.GetObjectFromJson<Quote>("Quote") != null &&
                HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails") != null)
            {

                Quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");
                Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails");

                //gear cost
                BoatCost = manageGear.GetGearByType(Quote.Boat).UnitCost;
                ItemCost = manageGear.GetGearByType(Quote.Item).UnitCost;
            }

            //UPDATE EXISTING QUOTES
            else if (HttpContext.Session.GetObjectFromJson<Quote>("NewQuote") != null &&
                HttpContext.Session.GetObjectFromJson<Customer>("NewCustomerDetails") != null)
            {
                Quote = HttpContext.Session.GetObjectFromJson<Quote>("NewQuote");
                Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("NewCustomerDetails");

                //update/cancel a reservation allowed for longer period than a week
                if (Quote.Duration > 168)
                {
                    RentalInMoreThanWeek = true;
                }

                //gear cost
                BoatCost = manageGear.GetGearByType(Quote.Boat).UnitCost;
                ItemCost = manageGear.GetGearByType(Quote.Item).UnitCost;
            }

            //QUOTE IS EMPTY
            else if (HttpContext.Session.GetObjectFromJson<Quote>("Quote") == null)
            {
                return RedirectToPage("Book");
            }

            return null;
        }

        //create new quote
        public IActionResult OnPostConfirm()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //get all the objects from sessions
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");
            Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails");

            //if reservation is successful
            if (manageQuote.AddQuote(Quote))
            {
                return RedirectToPage("MyReservation");
            }
            
            return Page();
        }

        //go to the update page
        public IActionResult OnPostUpdate()
        {
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");
            HttpContext.Session.SetObjectAsJson("QuoteToUpdate", Quote);
            return RedirectToPage("Book");
        }

        //delete quote
        public IActionResult OnPostCancel()
        {
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");
            manageQuote.DeleteQuote(Quote);

            return RedirectToPage("Book");
        }

        //save new updates
        public IActionResult OnPostSaveUpdate()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //get all the objects from sessions
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("NewQuote");
            Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("NewCustomerDetails");

            //if reservation is successful
            if (manageQuote.UpdateQuote(Quote))
            {
                HttpContext.Session.SetObjectAsJson("NewQuote", null);
                HttpContext.Session.SetObjectAsJson("NewCustomerDetails", null);
                return RedirectToPage("MyReservation");
            }

            return Page();
        }
    }
}
