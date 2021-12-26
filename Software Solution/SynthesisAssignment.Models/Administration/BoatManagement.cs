using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class BoatManagement : IBoatManagement
    {
        //data access layer
        IDALBoat _dalBoat;

        //constructor to inject needed service classes
        public BoatManagement(IDALBoat boatDA)
        {
            this._dalBoat = boatDA;
        }

        //CRUD
        public bool AddBoat(Boat boat)
        {
            bool status = false;
            //to prevent creating duplicate gear
            if ((GetBoatByType(boat)) == null)
            {
                //if insertion is successful
                if (_dalBoat.AddGear(boat))
                {
                    status = true;
                }
            }

            //if there is an error
            return status;
        }
        public bool UpdateBoat(Boat boat)
        {
            bool status = false;
            if (_dalBoat.UpdateGear(boat))
            {
                status = true;
            }

            return status;
        }
        public bool DeleteBoat(Boat boat)
        {
            bool status = false;
            if (_dalBoat.DeleteGear(boat))
            {
                status = true;
            }

            return status;
        }
        //Get By Type using Linq Query
        public Boat GetBoatByType(Boat boat)
        {
            Boat b = null;
            b = GetAllBoats().FirstOrDefault
                (b => b.GetInventoryType().Equals(boat.GetInventoryType(), StringComparison.OrdinalIgnoreCase));

            return b;
        }
        public List<Boat> GetAllBoats()
        {
            return _dalBoat.GetAllBoats().OfType<Boat>().ToList();
        }
    }
}
