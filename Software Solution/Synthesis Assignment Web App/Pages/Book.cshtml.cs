using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.MyClasses.Classes.MyHelpers;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{

    public class BookModel : PageModel
    {
        [BindProperty]
        public Quote Quote { get; set; }
        public List<Inventory> GearList { get; set; }
        public Quote QuoteToUpdate;
        readonly InventoryAdministration manageGear = new InventoryAdministration();
        public string Notification = null;

        public void OnGet()
        {

            GearList = manageGear.GetAllGear();

            if (HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate") != null)
            {
                QuoteToUpdate = new Quote();
                QuoteToUpdate = HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate");
            }
        }

        public IActionResult OnPost()
        {
            if (!Quote.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime))
            {
                Notification = "Please choose valid dates.\nThe desired period must be more than 2 hrs and less than 2 weeks";
                //OnGet doesn't get fired
                GearList = manageGear.GetAllGear();
                return Page();
            }

            //booking reference and time details
            Quote.DateTimeOfMade = DateTime.Now;
            Quote.SetRefNumber(DateTime.Now.ToString("yyyy") + "-" + Calculate.Generate().ToString());

            //prices calculation
            double itemDeposit = 0;
            int itemQuantity = 0;
            double itemPrice = 0;

            //item fields check => items are optional
            if (Quote.Item.ItemType != null)
            {
                itemDeposit = manageGear.GetGearByType(Quote.Item).Deposit;
                itemQuantity = Quote.Item.Quantity;
                itemPrice = manageGear.GetGearByType(Quote.Item).UnitCost
                    * (Quote.Duration / 2) * Quote.Item.Quantity;
                Quote.Item.SetPrice(itemPrice);
            }

            //deposit calculation
            Quote.CalculateDeposit(manageGear.GetGearByType(Quote.Boat).Deposit, Quote.Boat.Quantity,
               itemDeposit, itemQuantity);


            //boat price calculation
            double boatPrice = manageGear.GetGearByType(Quote.Boat).UnitCost
                * (Quote.Duration / 2) * Quote.Boat.Quantity;
            Quote.Boat.SetPrice(boatPrice);            

            //total price calculation
            Quote.CalculateTotalPrice(boatPrice, itemPrice);

            //storing the object in session
            HttpContext.Session.SetObjectAsJson("Quote", Quote);

            return RedirectToPage("CustomerDetails");
        }

        public IActionResult OnPostUpdateQuote()
        {

            if (!Quote.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime))
            {
                Notification = "Please choose valid dates.\nThe desired period must be more than 2 hrs and less than 2 weeks";
                //OnGet doesn't get fired
                GearList = manageGear.GetAllGear();
                return Page();
            }

            //get the time of booking
            Quote.DateTimeOfMade = DateTime.Now;
            Quote.SetRefNumber(HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate").RefNumber);

            //prices calculation
            double itemDeposit = 0;
            int itemQuantity = 0;
            double itemPrice = 0;

            //item fields check => items are optional
            if (Quote.Item.ItemType != null)
            {
                itemDeposit = manageGear.GetGearByType(Quote.Item).Deposit;
                itemQuantity = Quote.Item.Quantity;
                itemPrice = manageGear.GetGearByType(Quote.Item).UnitCost
                    * (Quote.Duration / 2) * Quote.Item.Quantity;
            }

            //deposit calculation
            Quote.CalculateDeposit(manageGear.GetGearByType(Quote.Boat).Deposit, Quote.Boat.Quantity,
               itemDeposit, itemQuantity);


            //boat price calculation
            double boatPrice = manageGear.GetGearByType(Quote.Boat).UnitCost
                * (Quote.Duration / 2) * Quote.Boat.Quantity;

            //total price calculation
            Quote.CalculateTotalPrice(boatPrice, itemPrice);

            //storing the object in session
            HttpContext.Session.SetObjectAsJson("Quote", null);
            HttpContext.Session.SetObjectAsJson("NewQuote", Quote);

            return RedirectToPage("CustomerDetails");
        }
    }
}
