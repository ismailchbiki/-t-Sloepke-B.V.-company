using SynthesisAssignment.Models.Interfaces;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models
{

    public class InventoryAdministration
    {

        //DAL
        DALInventory dalGear = new DALInventory();

        //methods
        public bool AddGear(Boat gear)
        {

            List<Boat> boats = AllGear().OfType<Boat>().ToList();

            //if the list is empty
            if (boats.Count == 0)
            {
                dalGear.AddGear(gear);
                return true;
            }

            else
            {

                for (int i = 0; i < boats.Count; i++)
                {
                    Boat b = new Boat();
                    b.BoatType = boats[i].BoatType;

                    if (b.BoatType == gear.BoatType)
                    {
                        return false;
                    }
                }

                dalGear.AddGear(gear);
                return true;
            }
        }

        //all gear
        public List<Inventory> AllGear()
        {
            return dalGear.GetAllGear().ToList();
        }


        public Inventory GetGearByID(int id)
        {
            foreach (Inventory gear in AllGear())
            {
                if (id == gear.ID)
                { return gear; }
            }
            return null;
        }
    }
}
