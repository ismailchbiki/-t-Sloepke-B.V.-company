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

        public bool RentalInMoreThanWeek = false;

        public string Notification;

        public double BoatUnitPrice;
        public int BoatValidDuration;
        public double BoatPrice;

        public double ItemUnitPrice;
        public int ItemValidDuration;
        public double ItemPrice;

        public double TotalPrice;
        public double TotalDeposit;

        public IActionResult OnGet()
        {
            int duration;

            //MADE QUOTES ACCESS
            if (HttpContext.Session.GetObjectFromJson<Quote>("MyReservation") != null &&
                HttpContext.Session.GetObjectFromJson<Quote>("Quote") == null &&
                HttpContext.Session.GetObjectFromJson<Quote>("NewQuote") == null)
            {

                //made reservations from DB
                Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");

                //update/cancel a reservation allowed for longer period than a week
                duration = Calculate.CalculateDuration(Quote.StartDateTime, DateTime.Now);
                if (duration > 168)
                {
                    RentalInMoreThanWeek = true;
                }

                //boat
                BoatUnitPrice = manageGear.GetGearByType(Quote.Boat).Cost;
                //calculate duration
                duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
                //make duration an even number
                BoatValidDuration = Calculate.DurationMultipleOfTwo(duration);
                //caluclate boat price
                BoatPrice = BoatUnitPrice * (BoatValidDuration / 2) * Quote.Boat.Quantity;

                //item
                ItemUnitPrice = manageGear.GetGearByType(Quote.Item).Cost;
                //calculate duration
                duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
                //make duration an even number
                ItemValidDuration = Calculate.DurationMultipleOfTwo(duration);
                //calculate item price
                ItemPrice = ItemUnitPrice * (ItemValidDuration / 2) * Quote.Item.Quantity;

                //total price per quote
                TotalPrice = BoatPrice + ItemPrice;

                //deposit calculation
                double boatDeposit = manageGear.GetGearByType(Quote.Boat).Deposit;
                double itemDeposit = manageGear.GetGearByType(Quote.Item).Deposit;
                TotalDeposit = (boatDeposit * Quote.Boat.Quantity) + (itemDeposit * Quote.Item.Quantity);
            }

            //MAKING NEW QUOTES
            else if (HttpContext.Session.GetObjectFromJson<Quote>("Quote") != null &&
                HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails") != null)
            {

                Quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");
                Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails");

                //boat
                BoatUnitPrice = manageGear.GetGearByType(Quote.Boat).Cost;
                //calculate duration
                duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
                //make duration an even number
                BoatValidDuration = Calculate.DurationMultipleOfTwo(duration);
                //calculate boat price
                BoatPrice = BoatUnitPrice * (BoatValidDuration / 2) * Quote.Boat.Quantity;

                //item
                ItemUnitPrice = manageGear.GetGearByType(Quote.Item).Cost;
                //calculate duration
                duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
                //make duration an even number
                ItemValidDuration = Calculate.DurationMultipleOfTwo(duration);
                //calculate item price
                ItemPrice = ItemUnitPrice * (ItemValidDuration / 2) * Quote.Item.Quantity;

                //total price per quote
                TotalPrice = BoatPrice + ItemPrice;

                //deposit calculation
                double boatDeposit = manageGear.GetGearByType(Quote.Boat).Deposit;
                double itemDeposit = manageGear.GetGearByType(Quote.Item).Deposit;
                TotalDeposit = (boatDeposit * Quote.Boat.Quantity) + (itemDeposit * Quote.Item.Quantity);
            }

            //UPDATE EXISTING QUOTES
            else if (HttpContext.Session.GetObjectFromJson<Quote>("NewQuote") != null &&
                HttpContext.Session.GetObjectFromJson<Customer>("NewCustomerDetails") != null)
            {
                Quote = HttpContext.Session.GetObjectFromJson<Quote>("NewQuote");
                Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("NewCustomerDetails");

                //boat
                BoatUnitPrice = manageGear.GetGearByType(Quote.Boat).Cost;
                //calculate duration
                duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
                //make duration an even number
                BoatValidDuration = Calculate.DurationMultipleOfTwo(duration);
                //calculate boat price
                BoatPrice = BoatUnitPrice * (BoatValidDuration / 2) * Quote.Boat.Quantity;

                //item
                ItemUnitPrice = manageGear.GetGearByType(Quote.Item).Cost;
                //calculate duration
                duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
                //make duration an even number
                ItemValidDuration = Calculate.DurationMultipleOfTwo(duration);
                //calculate item price
                ItemPrice = ItemUnitPrice * (ItemValidDuration / 2) * Quote.Item.Quantity;

                //total price per quote
                TotalPrice = BoatPrice + ItemPrice;

                //deposit calculation
                double boatDeposit = manageGear.GetGearByType(Quote.Boat).Deposit;
                double itemDeposit = manageGear.GetGearByType(Quote.Item).Deposit;
                TotalDeposit = (boatDeposit * Quote.Boat.Quantity) + (itemDeposit * Quote.Item.Quantity);
            }

            //QUOTE IS EMPTY
            else if (HttpContext.Session.GetObjectFromJson<Quote>("Quote") == null)
            {
                return RedirectToPage("Book");
            }

            return null;
        }

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

        public IActionResult OnPostUpdate()
        {
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");
            HttpContext.Session.SetObjectAsJson("QuoteToUpdate", Quote);
            return RedirectToPage("Book");
        }

        public IActionResult OnPostCancel()
        {
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("MyReservation");
            manageQuote.DeleteQuote(Quote);

            return RedirectToPage("Book");
        }

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
                return RedirectToPage("MyReservation");
            }

            return Page();
        }
    }
}
