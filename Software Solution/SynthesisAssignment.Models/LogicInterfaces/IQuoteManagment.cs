using SynthesisAssignment.MyClasses.Classes;
using System.Collections.Generic;

namespace SynthesisAssignment.Models.Administration
{
    public interface IQuoteManagment
    {
        bool AddQuote(Quote quote);
        bool DeleteQuote(Quote quote);
        List<Quote> GetAllQuotes();
        Quote GetQuoteByID(Quote quote);
        bool UpdateQuote(Quote quote);
    }
}