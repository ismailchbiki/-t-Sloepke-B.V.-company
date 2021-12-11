using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SynthesisAssignment.Models;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class BookModel : PageModel
    {
        private InventoryAdministration manageGear = new InventoryAdministration();
        public List<Inventory> Gear;

        public void OnGet()
        {
            Gear = manageGear.AllGear();
        }
    }
}
