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

        private BOATTYPE type;

        public Boat()
        {

        }

        public Boat(BOATTYPE boat, double cost, double deposit, int qnty, string remamrk)
            : base(cost, deposit, qnty, remamrk)
        {
            this.type = boat;
        }

        public string BoatType
        {
            get { return this.type.ToString(); }
            set { type = (BOATTYPE)Enum.Parse(typeof(BOATTYPE), value); }
        }
    }
}
