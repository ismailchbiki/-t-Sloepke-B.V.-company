using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class LocationManagement : ILocationManagement
    {
        IDALLocation _dalLoc;

        public LocationManagement(IDALLocation locDA)
        {
            this._dalLoc = locDA;
        }

        public List<string> Locations()
        {
            return _dalLoc.GelAllLocations().ToList();
        }
    }
}
