using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Enums;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public class BoatDescription : Boat
    {
        private int duration;
        private double priceSemiTotal;

        //constructors
        public BoatDescription()
        {

        }
        public BoatDescription(int duration, double priceSemi, BOATTYPE boat, CAPACITY capacity, double cost, double deposit, int qnty, string remamrk) : base(boat, capacity, cost, deposit, qnty, remamrk)
        {
            this.duration = duration;
            this.priceSemiTotal = priceSemi;
        }

        //properties
        public int Duration { get { return this.duration; } set { duration = value; } }
        public double PriceSemiTotal
        {
            get { return this.priceSemiTotal; }

            set
            {
                //calculate price per boat in order
                priceSemiTotal = Convert.ToDouble(this.Cost) * (this.duration / 2) * this.Quantity;
            }
        }
    }
}
