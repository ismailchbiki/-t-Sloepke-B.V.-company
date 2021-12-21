using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class Item : Inventory
    {

        //fields
        private string type;

        //constructors
        public Item()
        {

        }
        public Item(string typ)
        {
            this.type = typ;
        }
        public Item(string itemType, double cost, double deposit, int qty, string remark) 
            : base(cost, deposit, qty, remark)
        {
            this.type = itemType;
        }
        public Item(string itemType, double cost, double deposit, int qty, string remark, double price)
            : base(cost, deposit, qty, remark, price)
        {
            this.type = itemType;
        }

        //properties
        public string ItemType
        {
            get { return this.type; }
            set { type = value; }
        }
        public override string GetInventoryType()
        {
            return this.type;
        }
    }
}