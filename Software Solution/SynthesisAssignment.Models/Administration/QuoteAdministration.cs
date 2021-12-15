using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public static class QuoteAdministration
    {

        //to insert customers' reservations in the DB
        static DALQuote dalQuote = new DALQuote();

        //methods
        public static bool AddQuote(Customer rentor, Boat boat, Item item, Quote quote)
        {

            boat.Cost = InventoryAdministration.GetGearByType(boat).Cost;
            item.Cost = InventoryAdministration.GetGearByType(item).Cost;

            boat.PriceSemiTotal = boat.Cost * (boat.Duration / 2) * boat.Quantity;
            item.PriceSemiTotal = item.Cost * (item.Duration / 2) * item.Quantity;
            quote.TotalPrice = boat.PriceSemiTotal + item.PriceSemiTotal;

            if (dalQuote.AddQuote(rentor, boat, item, quote))
            {
                return true;
            }
            
            return false;
        }
    }
}
