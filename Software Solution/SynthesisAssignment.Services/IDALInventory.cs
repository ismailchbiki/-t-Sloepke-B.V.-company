using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public interface IDALInventory
    {

        //Inventory
        bool AddBoat(Boat gear);
        bool AddItem(Item gear);
        bool UpdateBoat(int id, Boat gear);
        bool UpdateItem(int id, Item gear);
        bool DeleteGear(Inventory gear);
        IEnumerable<Inventory> GetAllBoats();
        IEnumerable<Inventory> GetAllItems();
        IEnumerable<Inventory> GetAllGear();

    }
}
