using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public class Customer : Person
    {
        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string address, string zipcode, string city, int phone, string email) : base(firstName, lastName, address, zipcode, city, phone, email)
        {
        }
    }
}
