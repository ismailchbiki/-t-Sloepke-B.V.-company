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
        public Item(int id, ITEMTYPE item, double cost, double deposit, int qnty, string remamrk)
            : base(id, cost, deposit, qnty, remamrk)
        {
            this.type = item;
        }

        //properties
        public ITEMTYPE ItemType
        {
            get { return this.type; }
            set { type = value; }
        }


        //public string ItemType
        //{
        //    get { return this.type.ToString(); }
        //    set { type = (ITEMTYPE)Enum.Parse(typeof(ITEMTYPE), value); }
        //}
    }
}