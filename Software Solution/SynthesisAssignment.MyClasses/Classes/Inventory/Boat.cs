using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class Boat : Inventory
    {

        //fields
        private BOATTYPE type;
        private CAPACITY capacity;

        //constructors
        public Boat()
        {

        }

        //for inventory management
        public Boat(BOATTYPE boat, CAPACITY capacity, double cost, double deposit, int qty, string remark)
            : base(cost, deposit, qty, remark)
        {
            this.type = boat;
            this.capacity = capacity;
        }

        //for customers' reservations
        public Boat(BOATTYPE boat, CAPACITY capacity, double cost, double deposit, int qty, string remark, int duration) 
            : base(cost, deposit, qty, remark, duration)
        {
            this.type = boat;
            this.capacity = capacity;
        }

        //properties
        public string BoatType
        {
            get { return this.type.ToString(); }
            set { type = (BOATTYPE)Enum.Parse(typeof(BOATTYPE), value); }
        }
        public string Capacity
        {
            get { return this.capacity.ToString(); }
            set { capacity = (CAPACITY)Enum.Parse(typeof(CAPACITY), value); }
        }

    }
}
