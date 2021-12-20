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

            if (dalQuote.AddQuote(quote))
            {
                return true;
            }
            
            return false;
        }

        public bool UpdateQuote(Quote quote)
        {
            if (dalQuote.UpdateQuote(quote))
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
            Quote reservation = new Quote();
            reservation = null;
            foreach (var q in GetAllQuotes())
            {
                if (q.RefNumber == quote.RefNumber && q.Customer.LastName == quote.Customer.LastName)
                {
                    reservation = q;
                }
            }

            return reservation;
        }

        public bool DeleteQuote(Quote quote)
        {

            if (dalQuote.DeleteQuote(quote))
            {
                return true;
            }

            return false;
        }
    }
}
