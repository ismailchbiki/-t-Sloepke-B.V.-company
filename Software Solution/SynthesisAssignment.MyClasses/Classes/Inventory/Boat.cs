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
        public Boat(int id) : base(id)
        {
        }        
        //to create boats
        public Boat(BOATTYPE bType, CAPACITY capacity, double cost, double deposit, int qty, string remark) : base(cost, deposit, qty, remark)
        {
            this.type = bType;
            this.capacity = capacity;
        }
        //to select * boats
        public Boat(int id, BOATTYPE boat, CAPACITY capacity, double cost, double deposit, int qty, string remark)
            : base(id, cost, deposit, qty, remark)
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
