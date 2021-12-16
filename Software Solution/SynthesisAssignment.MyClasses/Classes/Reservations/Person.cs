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
        int id;
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

        public Person(int id)
        {
            this.id = id;
        }

        public int ID { get { return this.id; } }

        /// <summary>
        /// public get for model binding
        /// </summary>
        
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Text, ErrorMessage = "Invalid input for firstname")]
        public string FirstName { get { return this.firstName; } set { firstName = value; } }

        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Text, ErrorMessage = "Invalid input for lastname")]
        public string LastName { get { return this.lastName; } set { lastName = value; } }

        [Required]
        public string Address { get { return this.address; } set { address = value; } }

        [Required]
        public string Zipcode { get { return this.zipcode; } set { zipcode = value; } }

        [Required]
        public string City { get { return this.city; } set { city = value; } }

        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid input for phone number")]
        public int Phone { get { return this.phone; } set { phone = value; } }
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid input for email")]
        public string Email { get { return this.email; } set { email = value; } }
    }
}
