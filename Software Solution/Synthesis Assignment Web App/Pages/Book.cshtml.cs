using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{
    [BindProperties]
    public class BookModel : PageModel
    {
        //duration hours
        public List<int> GenerateHours()
        {

            List<int> duration = new List<int>();
            int hours;

            for (int i = 2; i < 338; i = i + 2)
            {
                hours = i;
                duration.Add(hours);
            }

            return duration;
        }

        public Boat Boat { get; set; }
        public Item Item { get; set; }
        public Quote Quote { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

            if (!ModelState.IsValid)
            {
                Page();
            }

            HttpContext.Session.SetObjectAsJson("BoatDescription", Boat);
            HttpContext.Session.SetObjectAsJson("ItemDescription", Item);
            HttpContext.Session.SetObjectAsJson("Quote", Quote);

            RedirectToPage("./CustomerDetails");
        }
    }
}
