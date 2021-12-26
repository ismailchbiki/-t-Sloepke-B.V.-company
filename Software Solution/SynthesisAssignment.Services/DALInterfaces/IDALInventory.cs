using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    //Service class
    public interface IDALInventory
    {
        //Inventory Crud
        bool AddGear(Inventory gear);
        bool UpdateGear(Inventory gear);
        bool DeleteGear(Inventory gear);
    }

    //Boats service class
    public interface IDALBoat : IDALInventory
    {
        IEnumerable<Inventory> GetAllBoats();
    }

    //items service class
    public interface IDALItem : IDALInventory
    {
        IEnumerable<Inventory> GetAllItems();
    }
}
