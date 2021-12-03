using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public interface IInventoryRepository
    {
        IEnumerable<Inventory> GetBoats();
    }
}
