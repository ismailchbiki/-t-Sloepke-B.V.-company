using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Enums;
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
        //quote ID
        private int refNumber;

        //location and duration
        private LOCATION location;
        private int duration;

        //total price of all rented items
        private double totalPrice;

        //date of made of quote
        private DateTime date;

        //start and end date for the renting
        private DateTime startDate;
        private DateTime endDate;
        private DateTime startTime;
        private DateTime endTime;

        public Quote()
        {

        }

        public Quote(int refNumber, LOCATION location, int duration, double totalPrice, DateTime date, DateTime startDate,
            DateTime endDate, DateTime startTime, DateTime endTime)
        {
            this.refNumber = refNumber;
            this.location = location;
            this.date = date;
            this.startDate = startDate;
            this.endDate = endDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.duration = duration;
            this.totalPrice = totalPrice;
        }

        public int RefNumber { get { return this.refNumber; } set { this.refNumber = value; } }
        public string Location
        {
            get { return this.location.ToString(); }
            set { location = (LOCATION)Enum.Parse(typeof(LOCATION), value); }
        }
        public int Duration { get { return this.duration; } set { duration = value; } }
        public double TotalPrice { get { return this.totalPrice; } set { totalPrice = value; } }
        public DateTime Date { get { return this.date; } set { date = value; } }
        
        [Required(ErrorMessage = "Please provide a date")]
        public DateTime StartDate { get { return this.startDate; } set { startDate = value; } }
        
        [Required(ErrorMessage = "Please provide a date")]
        public DateTime EndDate { get { return this.endDate; } set { endDate = value; } }
        public DateTime StartTime { get { return this.startTime; } set { startTime = value; } }
        public DateTime EndTime { get { return this.endTime; } set { endTime = value; } }
    }
}
