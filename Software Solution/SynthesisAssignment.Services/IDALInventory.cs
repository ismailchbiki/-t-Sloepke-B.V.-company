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
        //bool UpdateBoat(Boat gear);
        //bool DeleteBoat(int id);
        //Boat GetBoatByID(int id);
        IEnumerable<Inventory> GetAllBoats();
        IEnumerable<Inventory> GetAllItems();
        IEnumerable<Inventory> GetAllGear();

    }
}
