using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{

    //crud ops
    public interface IDALCrud
    {
        //Inventory
        bool AddGear(Inventory gear);
        bool UpdateGear(int id, Inventory gear);
        bool DeleteGear(Inventory gear);
    }

    //lists
    public interface IDALLists
    {
        IEnumerable<Inventory> GetAllBoats();
        IEnumerable<Inventory> GetAllItems();
        IEnumerable<Inventory> GetAllGear();
    }

    public interface IDALInventory : IDALCrud, IDALLists
    {

    }
}
