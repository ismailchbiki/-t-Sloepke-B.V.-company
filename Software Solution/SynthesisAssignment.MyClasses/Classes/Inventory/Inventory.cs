using System;
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
        double cost;
        double deposit;
        int qty;
        string remark;
        double price;

        //CONSTRUCTORS
        protected Inventory()
        {

        }
        protected Inventory(double cost, double deposit, int qty, string remark)
        {
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
        }
        protected Inventory(double cost, double deposit, int qty, string remark, double price)
        {
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
            this.price = price;
        }

        //Properties
        public double Cost { get { return this.cost; } }
        public double Deposit { get { return this.deposit; }}
        public int Quantity { get { return this.qty; } set { qty = value; } }
        public string Remark { get { return this.remark; } }
        public abstract string GetInventoryType();

        //booking price
        public double Price { get { return this.price; } }
    }
}
