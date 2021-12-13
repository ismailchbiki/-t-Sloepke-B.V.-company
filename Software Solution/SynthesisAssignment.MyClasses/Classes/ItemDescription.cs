using SynthesisAssignment.Models;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public class ItemDescription : Item
    {
        private int duration;
        private double priceSemiTotal;

        //constructors
        public ItemDescription()
        {

        }
        public ItemDescription(int duration, double priceSemi, ITEMTYPE item, double cost, double deposit, int qnty, string remamrk) 
            : base(item, cost, deposit, qnty, remamrk)
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
                //calculate price per item in order
                priceSemiTotal = Convert.ToDouble(this.Cost) * (this.duration / 2) * this.Quantity;
            }
        }
    }
}
