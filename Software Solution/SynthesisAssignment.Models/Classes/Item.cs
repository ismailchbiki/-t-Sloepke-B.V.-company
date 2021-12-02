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
        private ITEMTYPE type;

        public Item()
        {

        }

        public string ItemType
        {
            get { return this.type.ToString(); }
            set { type = (ITEMTYPE)Enum.Parse(typeof(ITEMTYPE), value); }
        }

        public Item(ITEMTYPE item, double cost, double deposit, int qnty, string remamrk)
            : base(cost, deposit, qnty, remamrk)
        {
            this.type = item;
        }
    }
}
