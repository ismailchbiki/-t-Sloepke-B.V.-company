using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class QuoteAdministration
    {

        //to fetch inventory details from the DB
        InventoryAdministration manageGear = new InventoryAdministration();

        //to insert customers' reservations in the DB
        DALQuote dalQuote = new DALQuote();

        //methods
        public bool AddQuote(Customer rentor, Boat boat, Item item, Quote quote)
        {

            boat.Cost = manageGear.GetGearByType(boat).Cost;
            item.Cost = manageGear.GetGearByType(item).Cost;

            //Convert.ToDouble(this.Cost) * (this.duration / 2) * this.Quantity;


            boat.PriceSemiTotal = boat.Cost * (boat.Duration / 2) * boat.Quantity;
            item.PriceSemiTotal = item.Cost * (item.Duration / 2) * item.Quantity;


            dalQuote.AddQuote(rentor, boat, item, quote);

            return false;
        }
    }
}
