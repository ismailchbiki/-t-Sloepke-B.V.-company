using SynthesisAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Models.Administration
{
    public class LocationManagement
    {
        DALLocation dalLoc = new DALLocation();

        public List<string> Locations()
        {
            return dalLoc.GelAllLocations().ToList();
        }
    }
}
