using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public class Quote
    {
        //quote ID
        private int refNumber;

        //rentor
        private Customer rentorID;

        //rented gear
        private ItemDescription itemID;

        //quote details
        private string Location;
        private DateTime date;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime startTime;
        private DateTime endTime;

    }
}
