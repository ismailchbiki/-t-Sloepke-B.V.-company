using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public interface IDALLocation
    {
        public IEnumerable<string> GelAllLocations();
    }
}
