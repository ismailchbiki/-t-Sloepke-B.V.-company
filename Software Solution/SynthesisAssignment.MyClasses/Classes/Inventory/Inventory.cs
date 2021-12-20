﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models
{
    public abstract class Inventory
    {
        //fields
        int id;
        double cost;
        double deposit;
        int qty;
        string remark;

        //CONSTRUCTORS
        protected Inventory()
        {

        }
        protected Inventory(int id)
        {
            this.id = id;
        }
        //to create gear
        public Inventory(double cost, double deposit, int qty, string remark)
        {
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
        }
        //to select * gear
        protected Inventory(int id, double cost, double deposit, int qty, string remark)
        {
            this.id = id;
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
        }

        //Properties
        public int ID { get { return this.id; } }
        public double Cost { get { return this.cost; } }
        public double Deposit { get { return this.deposit; }}

        // public set to bound quantity to the view
        //[Required(ErrorMessage = "Please provide a number")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "Please provide a valid number")]
        public int Quantity { get { return this.qty; } set { qty = value; } }
        public string Remark { get { return this.remark; } }

    }
}
