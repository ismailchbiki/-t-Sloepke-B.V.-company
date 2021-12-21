using SynthesisAssignment.Models;
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
        private string type;
        private string capacity;
        
        //constructors
        public Boat()
        {

        }
        public Boat(string typ)
        {
            this.type = typ;
        }
        public Boat(string boat, string capacity, double cost, double deposit, int qty, string remark)
            : base(cost, deposit, qty, remark)
        {
            this.type = boat;
            this.capacity = capacity;
        }
        public Boat(string boat, double cost, double deposit, int qty, string remark, double price)
            : base(cost, deposit, qty, remark, price)
        {
            this.type = boat;
        }

        //properties
        public string BoatType
        {
            get { return this.type; }
            set { type = value; }
        }
        public string Capacity
        {
            get { return this.capacity; }
        }
        public override string GetInventoryType()
        {
            return this.type;
        }
    }
}
