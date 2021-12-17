using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Enums;
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
        //quote ID
        string refNumber;

        Customer customer = new Customer();
        Boat boat = new Boat();
        Item item = new Item();
        LOCATION location;
        DateTime dateTimeOfMade;
        DateTime startDateTime;
        DateTime endDateTime;

        //CONSTRUCTORS
        public Quote()
        {

        }

        // --------- PROPERTIES(public setters to bound the properties to the view template)
        //quote ID
        public string RefNumber { get { return this.refNumber; } set { refNumber = value; } }

        public Customer Customer { get { return this.customer; } set { customer = value; } }
        public Boat Boat { get { return this.boat; } set { boat = value; } }
        public Item Item { get { return this.item; } set { item = value; } }

        //location
        public string Location
        {
            get { return this.location.ToString(); }
            set { location = (LOCATION)Enum.Parse(typeof(LOCATION), value); }
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
        
    }
}
