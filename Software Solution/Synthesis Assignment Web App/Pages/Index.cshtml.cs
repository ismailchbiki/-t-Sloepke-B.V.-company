using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Administration;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Synthesis_Assignment_Web_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Inventory> Gear;
        BoatManagement manageBoats = new BoatManagement(new DALBoat());
        ItemManagement manageItems = new ItemManagement(new DALItem());

        public void OnGet()
        {
            Gear.AddRange(manageBoats.GetAllBoats());
            Gear.AddRange(manageItems.GetAllItems());
        }
    }
}
