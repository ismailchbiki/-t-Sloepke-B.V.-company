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

        //Boats
        bool AddBoat(Boat gear);
        bool UpdateBoat(Boat gear);
        bool DeleteBoat(int id);
        Boat GetBoatByID(int id);
        //Boat GetBoatByType(string t);
        IEnumerable<Boat> GetAllBoats();
    }
}
