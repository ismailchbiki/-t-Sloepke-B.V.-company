using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class ConnectionString
    {

        public string MyConnection()
        {
            return "Server = studmysql01.fhict.local; Uid = dbi479364; Database = dbi479364; password = 123; SslMode = none";
        }
    }
}
