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
        public bool AddBoat(Boat gear)
        {

            //if the list is empty
            if (AllBoats().Count == 0)
            {
                dalGear.AddBoat(gear);
                return true;
            }

            else
            {

                for (int i = 0; i < AllBoats().Count; i++)
                {
                    Boat b = new Boat();

                    b.BoatType = AllBoats()[i].BoatType;
                    if (b.BoatType == gear.BoatType)
                    {
                        return false;
                    }
                }

                dalGear.AddBoat(gear);
                return true;
            }
        }



        public Inventory GetInventory(int id)
        {
            foreach (Inventory gear in AllBoats())
            {
                if (id == gear.ID)
                { return gear; }
            }
            return null;
        }

        public List<Boat> AllBoats()
        {

            return dalGear.GetAllBoats().ToList();
        }
    }
}
