using SynthesisAssignment.Models.Interfaces;
using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models
{
    public class Management : IBoatManagement, IItemManagement
    {
        public void AddBoat(Boat boat)
        {
            throw new NotImplementedException();
        }

        public void AddItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
