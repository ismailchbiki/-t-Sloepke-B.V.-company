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
        private int id;
        private double cost;
        private double deposit;
        private int qty;
        private string remark;

        //for renting purposes
        private int duration;

        //constructors
        protected Inventory()
        {

        }

        //for inventory management
        protected Inventory(double cost, double deposit, int qty, string remark)
        {
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
        }

        //for customers' reservations
        protected Inventory(double cost, double deposit, int qty, string remark, int duration)
        {
            this.cost = cost;
            this.deposit = deposit;
            this.qty = qty;
            this.remark = remark;
            this.duration = duration;
        }

        //Properties
        public int ID { get { return this.id; } set { this.id = value;  } }
        public double Cost { get { return this.cost; } set { cost = value; } }
        [Required]
        public double Deposit { get { return this.deposit; } set { deposit = value; } }
        [Required(ErrorMessage = "Please provide a number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please provide a valid number")]
        public int Quantity { get { return this.qty; } set { qty = value; } }
        public string Remark { get { return this.remark; } set { remark = value; } }

        //Property for renting purposes
        public int Duration { get { return this.duration; } set { duration = value; } }
        public double PriceSemiTotal { get; set; }

    }
}
