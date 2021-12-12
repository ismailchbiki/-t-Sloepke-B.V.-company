using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes
{
    public class ItemDescription
    {
        private int id;

        private int quantity;
        private int duration;

        //get items cost from inventory table
        private Inventory unitPrice;

        //calculate price per item order
        private double price;

        public ItemDescription()
        {

        }

        public ItemDescription(int id, int quantity, int duration, Inventory unitPrice, double price)
        {
            this.id = id;
            this.quantity = quantity;
            this.duration = duration;
            this.unitPrice = unitPrice;
            this.price = price;
        }

        //properties
        public int ID { get { return this.id; } set { this.id = value; } }
        public int Quantity { get { return this.quantity; } set { quantity = value; } }
        public int Duration { get { return this.duration; } set { duration = value; } }
        public Inventory UnitPrice { get { return this.unitPrice; } set { unitPrice = value; } }

        //calculate price per item in order
        public double Price
        {
            get { return this.price; }

            set
            {
                price = Convert.ToDouble(this.unitPrice) * (this.duration / 2) * this.quantity;
            }
        }
    }
}
