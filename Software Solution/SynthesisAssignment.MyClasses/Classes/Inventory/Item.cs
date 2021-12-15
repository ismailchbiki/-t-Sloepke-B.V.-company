﻿using SynthesisAssignment.Models;
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

        //inventory management
        public Item(ITEMTYPE item, double cost, double deposit, int qty, string remark) 
            : base(cost, deposit, qty, remark)
        {
            this.type = item;
        }

        //for customers' reservations
        public Item(ITEMTYPE item, double cost, double deposit, int qty, string remark, int duration) 
            : base(cost, deposit, qty, remark, duration)
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