using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models
{
    public abstract class Inventory
    {
        //fields
        private int id;
        private double cost;
        private double deposit;
        private int qty;
        private string remark;

        //constructors
        public Inventory()
        {

        }

        public Inventory(double cost, double deposit, int qty, string remark)
        {
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
        }

        //Properties
        public int ID { get { return this.id; } set { this.id = value;  } }
        public double Cost { get { return this.cost; } set { cost = value; } }
        public double Deposit { get { return this.deposit; } set { deposit = value; } }
        public int Quantity { get { return this.qty; } set { qty = value; } }
        public string Remark { get { return this.remark; } set { remark = value; } }
    }
}
