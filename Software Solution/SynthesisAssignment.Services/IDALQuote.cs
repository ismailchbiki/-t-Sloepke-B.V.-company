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
        public bool AddQuote(Quote quote);

        public IEnumerable<Quote> GetAllQuotes();

        public bool DeleteQuote(Quote quote);
    }
}
