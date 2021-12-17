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

        public Quote Quote { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            //get the time of booking
            Quote.DateTimeOfMade = DateTime.Now;
            Quote.RefNumber = DateTime.Now.ToString("yyyy") + "-" + Calculate.Generate().ToString();
            
            //storing the object in session
            HttpContext.Session.SetObjectAsJson("Quote", Quote);

            return RedirectToPage("CustomerDetails");
        }
    }
}
