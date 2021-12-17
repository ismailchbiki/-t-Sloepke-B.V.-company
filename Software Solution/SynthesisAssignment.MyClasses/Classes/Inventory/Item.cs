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
        private ITEMTYPE type;

        //constructors
        public Item()
        {

        }
        public Item(int id) : base(id)
        {
        }
        //to create items
        public Item(ITEMTYPE itemType, double cost, double deposit, int qty, string remark) 
            : base(cost, deposit, qty, remark)
        {
            this.type = itemType;
        }
        //to select * items
        public Item(int id, ITEMTYPE item, double cost, double deposit, int qty, string remark) 
            : base(id, cost, deposit, qty, remark)
        {
            this.type = item;
        }

        //properties
        public string ItemType
        {
            get { return this.type.ToString(); }
            set { type = (ITEMTYPE)Enum.Parse(typeof(ITEMTYPE), value); }
        }
    }
}