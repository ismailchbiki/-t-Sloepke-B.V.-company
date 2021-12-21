using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public abstract class Person
    {
        string firstName;
        string lastName;
        string address;
        string zipcode;
        string city;
        int phone;
        string email;

        protected Person()
        {

        }
        protected Person(string firstName, string lastName, string address, string zipcode, string city, int phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }
        
        public string FirstName { get { return this.firstName; } set { firstName = value; } }
        public string LastName { get { return this.lastName; } set { lastName = value; } }
        public string Address { get { return this.address; } set { address = value; } }
        public string Zipcode { get { return this.zipcode; } set { zipcode = value; } }
        public string City { get { return this.city; } set { city = value; } }
        public int Phone { get { return this.phone; } set { phone = value; } }
        public string Email { get { return this.email; } set { email = value; } }
    }
}
