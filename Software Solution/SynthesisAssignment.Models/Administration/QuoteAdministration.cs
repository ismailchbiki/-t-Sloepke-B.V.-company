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
        DALQuote dalQuote = new DALQuote();

        //methods
        public bool AddQuote(Quote quote)
        {

            //calculate time difference between 2 dates
            int duration = Calculate.CalculateDuration(quote.EndDateTime, quote.StartDateTime);

            //duration must be bigger than 2hrs and less than two weeks
            if (!Calculate.ApproveDuration(duration))
            {
                return false;
            }

            if (dalQuote.AddQuote(quote))
            {
                return true;
            }
            
            return false;
        }

        public List<Quote> GetAllQuotes()
        {
            return dalQuote.GetAllQuotes().ToList();
        }

        public Quote GetQuoteByID(Quote quote)
        {

            foreach (var q in GetAllQuotes())
            {
                if (q.RefNumber == quote.RefNumber && q.Customer.LastName == quote.Customer.LastName)
                {
                    return q;
                }
            }

            return null;
        }
    }
}
