using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public static class ConnectionString
    {

        //constant variables are considered to be static as well
        public const string MyConnection = "Server = studmysql01.fhict.local; Uid = dbi479364; Database = dbi479364; password = 123; SslMode = none";

        /// <summary>
        /// The difference between const and readonly:
        /// const: the value becomes constant after the program is compiled (baked and stored in the dll files)
        /// readonly: becomes constant at the runtime (can be intialized, but can't be changed afterwards during the runtime)
        /// </summary>
    }
}
