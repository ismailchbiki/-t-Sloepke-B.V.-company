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

        //create quote
        string refNumber;
        Customer customer = new Customer();
        Boat boat = new Boat();
        Item item = new Item();
        string location;
        DateTime dateTimeOfMade;
        DateTime startDateTime;
        DateTime endDateTime;
        int duration;
        double totalPrice;
        double deposit;
        string depositStatus;
        string paymentStatus;

        //CONSTRUCTORS
        public Quote()
        {

        }

        //PROPERTIES
        public string RefNumber { get { return this.refNumber; } set { refNumber = value; } }
        public Customer Customer { get { return this.customer; } set { customer = value; } }
        public Boat Boat { get { return this.boat; } set { boat = value; } }
        public Item Item { get { return this.item; } set { item = value; } }

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

        public int Duration { get { return this.duration; } }
        public double TotalPrice { get { return this.totalPrice; }}
        public double Deposit { get { return this.deposit; } }

        public string GetDepositStatus { get { return this.depositStatus; } }
        public string GetPaymentStatus { get { return this.paymentStatus; }}

        public string SetRefNumber(string refNum)
        {
            this.refNumber = refNum;
            return this.refNumber;
        }
        public double CalculateDeposit(double boatDeposit, int boatQuantity, double itemDeposit, int itemQuantity)
        {
            
            this.deposit = (boatDeposit * boatQuantity) + (itemDeposit * itemQuantity);
            return this.deposit;
        }
        public double CalculateTotalPrice(double boatPrice, double itemPrice)
        {

            this.totalPrice = boatPrice + itemPrice;
            return this.totalPrice;
        }
        public double GetTotalPrice(double total)
        {
            this.totalPrice = total;
            return this.totalPrice;
        }
        public double GetDeposit(double deposit)
        {
            this.deposit = deposit;
            return this.deposit;
        }
        public string SetDepositStatus(string status)
        {
            this.depositStatus = status;
            return this.depositStatus;
        }
        public string SetPaymentStatus(string status)
        {
            this.paymentStatus = status;
            return this.paymentStatus;
        }
        public int SetDuration(int duration)
        {
            this.duration = duration;
            return this.duration;
        }

    }
}
