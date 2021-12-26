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
    public class QuoteManagement : IQuoteManagment
    {
        //to insert customers' reservations in the DB
        IDALQuote _dalQuote;

        //constructor to inject needed service classes
        public QuoteManagement(IDALQuote quoteDA)
        {
            this._dalQuote = quoteDA;
        }

        //methods
        public bool AddQuote(Quote quote)
        {
            bool status = false;
            if (_dalQuote.AddQuote(quote))
            {
                status = true;
            }

            return status;
        }

        public bool UpdateQuote(Quote quote)
        {
            bool status = false;
            if (_dalQuote.UpdateQuote(quote))
            {
                status = true;
            }
            return status;
        }

        public List<Quote> GetAllQuotes()
        {
            return _dalQuote.GetAllQuotes().ToList();
        }

        public Quote GetQuoteByID(Quote quote)
        {
            foreach (var q in GetAllQuotes())
            {
                if (q.RefNumber == quote.RefNumber && q.Customer.LastName == quote.Customer.LastName)
                {
                    quote = q;
                    break;
                }
            }

            return quote;
        }

        public bool DeleteQuote(Quote quote)
        {
            bool status = false;
            if (_dalQuote.DeleteQuote(quote))
            {
                status = true;
            }
            return status;
        }
    }
}
