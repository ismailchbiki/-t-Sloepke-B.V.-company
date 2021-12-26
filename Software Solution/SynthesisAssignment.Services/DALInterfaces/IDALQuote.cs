using SynthesisAssignment.MyClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public interface IDALQuote
    {
        //crud
        public bool AddQuote(Quote quote);
        public bool UpdateQuote(Quote quote);
        public bool DeleteQuote(Quote quote);
        public IEnumerable<Quote> GetAllQuotes();
    }
}
