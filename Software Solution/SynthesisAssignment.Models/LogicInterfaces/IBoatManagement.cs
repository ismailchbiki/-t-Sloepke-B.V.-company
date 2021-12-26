using SynthesisAssignment.Services;
using System.Collections.Generic;

namespace SynthesisAssignment.Models
{
    public interface IBoatManagement
    {
        bool AddBoat(Boat boat);
        bool DeleteBoat(Boat boat);
        List<Boat> GetAllBoats();
        Boat GetBoatByType(Boat boat);
        bool UpdateBoat(Boat boat);
    }
}