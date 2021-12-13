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

        Customer rentor;
        Boat boat;
        Item item;
        Quote quote;

        public QuoteAdministration()
        {

        }

        public QuoteAdministration(Customer rentor, Boat boat, Item item, Quote quote)
        {
            this.rentor = rentor;
            this.boat = boat;
            this.item = item;
            this.quote = quote;
        }
    }
}
