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
        int refNumber;

        //location
        LOCATION location;

        //date of made of quote
        DateTime dateTimeOfMade;

        //start and end date for the renting
        DateTime startDateTime;
        DateTime endDateTime;

        //CONSTRUCTORS
        public Quote()
        {

        }
        public Quote(int id)
        {
            this.refNumber = id;
        }

        // --------- PROPERTIES

        //quote ID
        public int RefNumber { get { return this.refNumber; }}
        
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
