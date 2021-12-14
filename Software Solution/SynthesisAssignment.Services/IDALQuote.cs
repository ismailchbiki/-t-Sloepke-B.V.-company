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
        public bool AddQuote(Customer customer, Boat boat, Item item, Quote quote);
    }
}
