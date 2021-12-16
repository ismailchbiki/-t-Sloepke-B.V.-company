using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models.Administration;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class MyReservationModel : PageModel
    {

        QuoteAdministration test = new QuoteAdministration();

        public void OnGet()
        {
            test.GetAllQuotes();
        }
    }
}
