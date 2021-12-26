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
    [BindProperties]
    public class BookModel : PageModel
    {

        public Quote Quote { get; set; }
        public List<Inventory> GearList { get; set; }
        public Quote QuoteToUpdate;
        readonly BoatManagement manageBoats = new BoatManagement(new DALBoat());
        readonly ItemManagement manageItems = new ItemManagement(new DALItem());
        public string Notification = null;

        ILocationManagement manageLoc = new LocationManagement(new DALLocation());
        public List<string> Locations { get; set; }
        public void OnGet()
        {
            Quote = new Quote();

            //load available gear
            GearList.AddRange(manageBoats.GetAllBoats());
            GearList.AddRange(manageItems.GetAllItems());
            Locations = manageLoc.Locations();

            if (HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate") != null)
            {
                QuoteToUpdate = new Quote();
                QuoteToUpdate = HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate");
            }
        }

        public IActionResult OnPost()
        {

            Quote.Duration = Calculate.RoundNumberToEven(Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime));
            
            if (Calculate.DateIsInPast(Quote.EndDateTime, Quote.StartDateTime)
                || !Calculate.ApproveDuration(Quote.Duration))
            {
                Notification = "Please choose valid dates.\nThe desired period must be more than 2 hrs and less than 2 weeks";
                //OnGet doesn't get fired
                GearList.AddRange(manageBoats.GetAllBoats());
                GearList.AddRange(manageItems.GetAllItems());
                Locations = manageLoc.Locations();
                return Page();
            }

            Quote.DateTimeOfMade = DateTime.Now;
            Quote.RefNumber = DateTime.Now.ToString("yyyy") + "-" + Calculate.Generate().ToString();

            double itemDeposit = 0;
            int itemQuantity = 0;
            double itemPrice = 0;

            //item fields check => items are optional
            if (Quote.Item.ItemType != null)
            {
                itemDeposit = manageItems.GetItemByType(Quote.Item).Deposit;
                itemQuantity = Quote.Item.Quantity;
                itemPrice = manageItems.GetItemByType(Quote.Item).UnitCost
                    * (Quote.Duration / 2) * Quote.Item.Quantity;
                
                Quote.Item.Price = (itemPrice);
            }
            else
            {
                Quote.Item.ItemType = "None";
            }

            Quote.Deposit = Calculate.CalculateDeposit(manageBoats.GetBoatByType(Quote.Boat).Deposit, Quote.Boat.Quantity,
               itemDeposit, itemQuantity);

            //boat price calculation
            double boatPrice = manageBoats.GetBoatByType(Quote.Boat).UnitCost
                * (Quote.Duration / 2) * Quote.Boat.Quantity;
            Quote.Boat.Price = (boatPrice);

            Quote.TotalPrice = Calculate.CalculateTotalPrice(boatPrice, itemPrice);

            //storing the object in session
            HttpContext.Session.SetObjectAsJson("Quote", Quote);

            return RedirectToPage("CustomerDetails");
        }

        public IActionResult OnPostUpdateQuote()
        {

            Quote.Duration = Calculate.RoundNumberToEven(Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime));

            if (Calculate.DateIsInPast(Quote.EndDateTime, Quote.StartDateTime)
                || !Calculate.ApproveDuration(Quote.Duration))
            {
                Notification = "Please choose valid dates.\nThe desired period must be more than 2 hrs and less than 2 weeks";
                //OnGet doesn't get fired
                GearList.AddRange(manageBoats.GetAllBoats());
                GearList.AddRange(manageItems.GetAllItems());
                Locations = manageLoc.Locations();
                return Page();
            }

            Quote.DateTimeOfMade = DateTime.Now;
            Quote.RefNumber = HttpContext.Session.GetObjectFromJson<Quote>("QuoteToUpdate").RefNumber;


            double itemDeposit = 0;
            int itemQuantity = 0;
            double itemPrice = 0;

            //item fields check => items are optional
            if (Quote.Item.ItemType != null)
            {
                itemDeposit = manageItems.GetItemByType(Quote.Item).Deposit;
                itemQuantity = Quote.Item.Quantity;
                itemPrice = manageItems.GetItemByType(Quote.Item).UnitCost
                    * (Quote.Duration / 2) * Quote.Item.Quantity;

                Quote.Item.Price = (itemPrice);
            }
            else
            {
                Quote.Item.ItemType = "None";
            }

            Quote.Deposit = Calculate.CalculateDeposit(manageBoats.GetBoatByType(Quote.Boat).Deposit, Quote.Boat.Quantity,
               itemDeposit, itemQuantity);

            //boat price calculation
            double boatPrice = manageBoats.GetBoatByType(Quote.Boat).UnitCost
                * (Quote.Duration / 2) * Quote.Boat.Quantity;
            Quote.Boat.Price = (boatPrice);

            Quote.TotalPrice = Calculate.CalculateTotalPrice(boatPrice, itemPrice);

            //storing the object in session
            HttpContext.Session.SetObjectAsJson("Quote", null);
            HttpContext.Session.SetObjectAsJson("NewQuote", Quote);

            return RedirectToPage("CustomerDetails");
        }
    }
}
