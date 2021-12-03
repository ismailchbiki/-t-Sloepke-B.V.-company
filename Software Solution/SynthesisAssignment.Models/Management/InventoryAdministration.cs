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

        //fields
        private List<Inventory> inventory = new List<Inventory>();

        //constructors
        public InventoryAdministration()
        {

        }

        //methods
        public void AddGear(Inventory gear)
        {
            if (this.GetInventory(gear.ID) == null)
            {
                this.inventory.Add(gear);
            }
        }

        public Inventory GetInventory(int id)
        {
            foreach (Inventory gear in this.inventory)
            {
                if (id == gear.ID)
                { return gear; }
            }
            return null;
        }

        public List<Inventory> GearList()
        {            

            return this.inventory;
        }
    }
}
