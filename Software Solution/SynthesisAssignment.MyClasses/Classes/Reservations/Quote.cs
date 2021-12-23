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
        /// static fields to not lose data from within a session when redirecting to a new page
        /// </summary>

        //create quote
        static string refNumber;
        Customer customer = new Customer();
        static Boat boat = new Boat();
        static Item item = new Item();
        string location;
        DateTime dateTimeOfMade;
        DateTime startDateTime;
        DateTime endDateTime;
        static int duration;
        static double totalPrice;
        static double deposit;
        static string depositStatus;
        static string paymentStatus;

        //CONSTRUCTORS
        public Quote()
        {

        }

        //PROPERTIES
        public string RefNumber { get { return refNumber; } }
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

        public int Duration { get { return duration; } }
        public double TotalPrice { get { return totalPrice; }}
        public double Deposit { get { return deposit; } }
        public string GetDepositStatus { get { return depositStatus; } }
        public string GetPaymentStatus { get { return paymentStatus; }}

        //SETTERS
        public void SetRefNumber(string refNum)
        {
            refNumber = refNum;
        }
        public void SetDepositStatus(string status)
        {
            depositStatus = status;
        }
        public void SetPaymentStatus(string status)
        {
            paymentStatus = status;
        }
        public void SetDuration(int period)
        {
            duration = period;
        }
        public void SetDeposit(double depo)
        {
            deposit = depo;
        }
        public void SetTotalPrice(double tPrice)
        {
            totalPrice = tPrice;
        }

        //METHODS
        public bool CalculateDuration(DateTime endDate, DateTime startDate)
        {
            bool status = true;
            if (DateTime.Compare(startDate, DateTime.Now) < 0
               || DateTime.Compare(endDate, DateTime.Now) < 0)
            {
                status = false;
            }

            //calculate and round the difference to even number
            duration = Calculate.RoundNumberToEven(Calculate.CalculateDuration(endDate, startDate));

            //duration must be bigger than 2 hrs and less than 2 weeks
            if (!Calculate.ApproveDuration(duration))
            {
                duration = 0;
                status = false;
            }

            return status;
        }
        public void CalculateDeposit(double boatDeposit, int boatQuantity, double itemDeposit, int itemQuantity)
        {
            deposit = (boatDeposit * boatQuantity) + (itemDeposit * itemQuantity);
        }
        public void CalculateTotalPrice(double boatPrice, double itemPrice)
        {
            totalPrice = boatPrice + itemPrice;
        }
    }
}
