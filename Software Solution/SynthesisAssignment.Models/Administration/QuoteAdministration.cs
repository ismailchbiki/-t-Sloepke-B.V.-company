using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.MyClasses.Classes.MyHelpers;
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

        //to insert customers' reservations in the DB
        static DALQuote dalQuote = new DALQuote();

        //methods
        public bool AddQuote(Customer customer, Boat boat, Item item, Quote quote)
        {

            //duration calculation per hours between 2 dates
            double diff = (quote.EndDateTime - quote.StartDateTime).TotalHours;
            int durationPerHours = Convert.ToInt32(Math.Ceiling(diff));

            //only multiple of 2 hrs is accepted
            double reminder = durationPerHours % 2;

            //minimum 2 hrs / max 2 weeks
            if (durationPerHours < 2 || durationPerHours > 336 || reminder != 0)
            {
                return false;
            }

            if (dalQuote.AddQuote(customer, boat, item, quote))
            {
                return true;
            }
            
            return false;
        }

        public List<ClassCollection> GetAllQuotes()
        {
            return dalQuote.GetAllQuotes().ToList();
        }
    }
}
