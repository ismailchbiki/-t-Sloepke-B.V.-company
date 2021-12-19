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
    [BindProperties]
    public class BookModel : PageModel
    {

        public string Notification = null;
        public Quote Quote { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //Booked period check
            int duration = Calculate.CalculateDuration(Quote.EndDateTime, Quote.StartDateTime);
            int evenDuration = Calculate.DurationMultipleOfTwo(duration);

            

            if (!Calculate.ApproveDuration(evenDuration)
                 || DateTime.Compare(Quote.StartDateTime, DateTime.Now) < 0
                 || DateTime.Compare(Quote.EndDateTime, DateTime.Now) < 0)
            {
                Notification = "Please choose valid dates.\nThe desired period must be more than 2 hrs and less than 2 weeks";
                return Page();
            }

            //code to restrict booked quantity per reservation here
            //Code to check quantity availability during some period here

            //get the time of booking
            Quote.DateTimeOfMade = DateTime.Now;
            Quote.RefNumber = DateTime.Now.ToString("yyyy") + "-" + Calculate.Generate().ToString();
            
            //storing the object in session
            HttpContext.Session.SetObjectAsJson("Quote", Quote);

            return RedirectToPage("CustomerDetails");
        }
    }
}
