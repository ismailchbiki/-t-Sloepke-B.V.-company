using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models;
using SynthesisAssignment.Services;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class BookModel : PageModel
    {
        [BindProperty]
        public Boat Boat { get; set; }

        [BindProperty]
        public Item Item { get; set; }

        public void OnGet()
        {
            
        }
    }
}
