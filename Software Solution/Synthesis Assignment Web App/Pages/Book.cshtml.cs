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

        //ask about how to cast Gear in the view page (with asp-for)
        Inventory Gear { get; set; }

        public Boat Boat { get; set; }
        public Item Item { get; set; }
        public Quote Quote { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpContext.Session.SetObjectAsJson("BookedBoats", Boat);
            HttpContext.Session.SetObjectAsJson("BookedItems", Item);
            HttpContext.Session.SetObjectAsJson("Quote", Quote);

            return RedirectToPage("./CustomerDetails");
        }
    }
}
