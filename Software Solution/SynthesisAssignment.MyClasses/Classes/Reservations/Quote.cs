using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Classes.MyHelpers;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public class Quote
    {
        /// <summary>
        /// public set to bound the fields to the view
        /// </summary>

        //create quote
        string refNumber;
        string location;
        int duration;
        double totalPrice;
        double deposit;
        string depositStatus;
        string paymentStatus;
        Customer customer = new Customer();
        Boat boat = new Boat();
        Item item = new Item();
        DateTime dateTimeOfMade;
        DateTime startDateTime;
        DateTime endDateTime;

        //CONSTRUCTORS
        public Quote()
        {

        }

        //PROPERTIES
        public string RefNumber { get { return refNumber; } set { refNumber = value; } }
        public Customer Customer { get { return this.customer; } set { customer = value; } }
        public Boat Boat { get { return boat; } set { boat = value; } }
        public Item Item { get { return item; } set { item = value; } }

        //location
        public string Location
        {
            get { return this.location; }
            set { location =  value; }
        }

        //date of made
        public DateTime DateTimeOfMade { get { return this.dateTimeOfMade; } set { dateTimeOfMade = value; } }

        //start DateTime
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH-mm")]
        [Required(ErrorMessage = "Please provide a date")]
        public DateTime StartDateTime { get { return this.startDateTime; } set { startDateTime = value; } }        

        //end Datetime
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH-mm")]
        [Required(ErrorMessage = "Please provide a date")]
        public DateTime EndDateTime { get { return this.endDateTime; } set { endDateTime = value; } }

        public int Duration { get { return duration; } set { duration = value; } }
        public double TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
        public double Deposit { get { return deposit; } set { deposit = value; } }
        public string DepositStatus { get { return depositStatus; } set { depositStatus = value; } }
        public string PaymentStatus { get { return paymentStatus; } set { paymentStatus = value; } }


    }
}
