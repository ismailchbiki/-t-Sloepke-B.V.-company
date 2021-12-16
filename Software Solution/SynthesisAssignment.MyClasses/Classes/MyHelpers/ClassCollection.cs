using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.MyClasses.Classes.MyHelpers
{
    public class ClassCollection
    {
        Boat boat = new Boat();
        Item item = new Item();
        Quote quote = new Quote();
        Customer customer = new Customer();

        public ClassCollection()
        {

        }

        public ClassCollection(Boat boat, Item item, Quote quote, Customer customer)
        {
            this.boat = boat;
            this.item = item;
            this.quote = quote;
            this.customer = customer;
        }

        public Boat Boat
        {
            get { return this.boat; }
            set { this.boat = value; }
        }

        public Item Item
        {
            get { return this.item; }
            set { this.item = value; }
        }

        public Quote Quote
        {
            get { return this.quote; }
            set { this.quote = value; }
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
    }
}
