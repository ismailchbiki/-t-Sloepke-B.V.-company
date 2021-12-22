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
        
        //data access layer
        DALInventory dalGear = new DALInventory();

        //CRUD
        public bool AddGear(Inventory gear)
        {
            bool status = false;
            //to prevent creating duplicate gear
            if ((GetGearByType(gear)) == null)
            {
                //if insertion is successful
                if (dalGear.AddGear(gear))
                {
                    status = true;
                }
            }
            
            //if there is an error
            return status;
        }
        public bool UpdateGear(Inventory gear)
        {
            bool status = false;
            if (dalGear.UpdateGear(gear))
            {
                status = true;
            }

            return status;
        }
        public Inventory GetGearByType(Inventory gear)
        {
            Inventory g = null;

            foreach (var item in GetAllGear().ToList())
            {
                if (item.GetInventoryType() == gear.GetInventoryType())
                {
                    g = item;
                    break;
                }
            }

            return g;
        }
        public bool  DeleteGear(Inventory gear)
        {
            bool status = false;
            if (dalGear.DeleteGear(gear))
            {
                status = true;
            }
            
            return status;
        }
        public List<Inventory> GetAllGear()
        {
            return dalGear.GetAllGear().ToList();
        }
    }
}
