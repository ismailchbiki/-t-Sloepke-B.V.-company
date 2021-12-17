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

        public double BoatUnitPrice;
        public int BoatDuration;
        public double BoatPrice;

        public double ItemUnitPrice;
        public int ItemDuration;
        public double ItemPrice;

        public double TotalPrice;

        public void OnGet()
        {
            //to fill in the fields
            Quote = HttpContext.Session.GetObjectFromJson<Quote>("Quote");
            Quote.Customer = HttpContext.Session.GetObjectFromJson<Customer>("CustomerDetails");

            //boat
            BoatUnitPrice = manageGear.GetGearByType(Quote.Boat).Cost;
            BoatDuration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
            BoatPrice = BoatUnitPrice * (BoatDuration / 2) * Quote.Boat.Quantity;

            //item
            ItemUnitPrice = manageGear.GetGearByType(Quote.Item).Cost;
            ItemDuration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
            ItemPrice = ItemUnitPrice * (ItemDuration / 2) * Quote.Item.Quantity;

            TotalPrice = BoatPrice + ItemPrice;
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
    }
}
