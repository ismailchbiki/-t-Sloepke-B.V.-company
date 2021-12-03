using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class Boat : Inventory
    {

        //fields
        private BOATTYPE type;

        //constructors
        public Boat()
        {

        }
        public Boat(int id, BOATTYPE boat, double cost, double deposit, int qnty, string remamrk)
            : base(id, cost, deposit, qnty, remamrk)
        {
            this.type = boat;
        }

        //properties
        public BOATTYPE BoatType
        {
            get { return this.type; }
            set { type = value; }
        }

        //public string BoatType
        //{
        //    get { return this.type.ToString(); }
        //    set { type = (BOATTYPE)Enum.Parse(typeof(BOATTYPE), value); }
        //}
    }
}
