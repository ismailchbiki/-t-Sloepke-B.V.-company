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
        //Inventory Crud
        bool AddGear(Inventory gear);
        bool UpdateGear(int id, Inventory gear);
        bool DeleteGear(Inventory gear);

        //lists
        IEnumerable<Inventory> GetAllBoats();
        IEnumerable<Inventory> GetAllItems();
        IEnumerable<Inventory> GetAllGear();
    }
}
